using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

using System.Threading;
using System.Runtime.InteropServices;

namespace QianDao
{
    public partial class StudentSignInForm : Form
    { 
        [DllImport("dcrf32.dll")]
        public static extern int dc_init(Int16 port, long baud);  //初试化
        [DllImport("dcrf32.dll")]
        public static extern int dc_exit(int icdev);
        [DllImport("dcrf32.dll")]
        public static extern int dc_reset(int icdev, uint sec);
        [DllImport("dcrf32.dll")]
        public static extern int dc_request(int icdev, char _Mode, ref uint TagType);
        [DllImport("dcrf32.dll")]
        public static extern int dc_card(int icdev, char _Mode, ref ulong Snr);
        [DllImport("dcrf32.dll")]
        public static extern int dc_halt(int icdev);
        [DllImport("dcrf32.dll")]
        public static extern int dc_anticoll(int icdev, char _Bcnt, ref ulong IcCardNo);
        [DllImport("dcrf32.dll")]
        public static extern int dc_beep(int icdev, uint _Msec);
        [DllImport("dcrf32.dll")]
        public static extern int dc_authentication(int icdev, int _Mode, int _SecNr);

        [DllImport("dcrf32.dll")]
        public static extern int dc_load_key(int icdev, int mode, int secnr, [In] byte[] nkey);  //密码装载到读写模块中
        [DllImport("dcrf32.dll")]
        public static extern int dc_load_key_hex(int icdev, int mode, int secnr, string nkey);  //密码装载到读写模块中

        [DllImport("dcrf32.dll")]
        public static extern int dc_write(int icdev, int adr, [In] byte[] sdata);  //向卡中写入数据
        [DllImport("dcrf32.dll")]
        public static extern int dc_write_hex(int icdev, int adr, [In] byte[] sdata);  //向卡中写入数据(转换为16进制)

        [DllImport("dcrf32.dll")]
        public static extern int dc_read(int icdev, int adr, [Out] byte[] sdata);  //从卡中读数据
        [DllImport("dcrf32.dll")]
        public static extern int dc_read_hex(int icdev, int adr, [Out] byte[] sdata);  //从卡中读数据(转换为16进制)
        [DllImport("dcrf32.dll")]
        public static extern int a_hex(string oldValue, ref string newValue, Int16 len);  //普通字符转换成十六进制字符
        [DllImport("dcrf32.dll")]
        public static extern void hex_a(ref string oldValue, ref string newValue, int len);  //十六进制字符转换成普通字符

        private Thread threadReadCardno = null;
        private Thread threadGetCardNo = null;
        private int _icdev = -1;

        private int _currentDayOfWeek;

        public StudentSignInForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            // 获取今天的星期
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    _currentDayOfWeek = 1;
                    break;
                case DayOfWeek.Tuesday:
                    _currentDayOfWeek = 2;
                    break;
                case DayOfWeek.Wednesday:
                    _currentDayOfWeek = 3;
                    break;
                case DayOfWeek.Thursday:
                    _currentDayOfWeek = 4;
                    break;
                case DayOfWeek.Friday:
                    _currentDayOfWeek = 5;
                    break;
                case DayOfWeek.Saturday:
                    _currentDayOfWeek = 6;
                    break;
                case DayOfWeek.Sunday:
                    _currentDayOfWeek = 7;
                    break;
            }
        }

        Queue<ulong> cardNoQueue = new Queue<ulong>();
        private void ReadCard()
        {
            while (true)
            {
                if (!_isActive)
                {
                    Thread.Sleep(1000);
                    continue;
                }

                char tt = (char)0;
                uint ss = 0;

                ulong icCardNo = 0;
                dc_reset(_icdev, ss);
                dc_card(_icdev, tt, ref icCardNo);
                if (icCardNo != 0)
                {
                    // 蜂鸣
                    dc_beep(_icdev, 10);

                    // 保存新的卡号
                    Monitor.Enter(this);//锁定，保持同步
                    cardNoQueue.Enqueue(icCardNo);
                    Monitor.Exit(this);//取消锁定
                    Thread.Sleep(2000);
                }

                Thread.Sleep(1000);
            }
        }

        private void GetCardNo()
        {
            while (true)
            {
                Monitor.Enter(this);//锁定，保持同步
                if (cardNoQueue.Count > 0)
                {
                    txtCardNo.Text = cardNoQueue.Dequeue().ToString();

                    // 获取当前的学生记录
                    string cardNo = txtCardNo.Text;
                    DataRow[] rows = signInDataSet.Students.Select("CardNo = '" + cardNo + "'");
                    if (rows.Length <= 0)
                    {
                        // 卡号不存在
                        ShowSignInFailedInfo("卡号不存在");
                        ClearStudentInfo();
                        Monitor.Exit(this);//取消锁定
                        Thread.Sleep(100);
                        continue;
                    }

                    // 显示学生信息
                    DataRow row = rows[0];
                    ShowStudentsInfo(row);

                    // 查看当前学生已经过期
                    if (row.Field<DateTime>("ExpireTime") < DateTime.Now)
                    {
                        // 欠费
                        ShowSignInFailedInfo("您已欠费，请及时缴费");
                        Monitor.Exit(this);//取消锁定
                        Thread.Sleep(100);
                        continue;
                    }
                    else 
                    {
                        // 查询当前学生当天可以上的所有课程
                        this.studentCourseTableAdapter.Fill(this.signInDataSet.StudentCourse, row.Field<int>("ID"), _currentDayOfWeek);
                        if (this.signInDataSet.StudentCourse.Rows.Count == 0)
                        {
                            // 当天没有课程，提示时间不一致，但允许刷卡
                            ShowTimeNotMatchInfo("请核对上课时间");
                            studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                            Monitor.Exit(this);//取消锁定
                            Thread.Sleep(100);
                            continue;
                        }
                        else
                        {
                            // 当天只有一门课
                            if (this.signInDataSet.StudentCourse.Rows.Count == 1)
                            {
                                DataRow scRow = this.signInDataSet.StudentCourse.Rows[0];
                                // 1.判断该课程是否过期
                                if (scRow.Field<DateTime>("ExpireTime") < DateTime.Now)
                                {
                                    ShowSignInFailedInfo("您已欠费，请及时缴费");
                                    Monitor.Exit(this);//取消锁定
                                    Thread.Sleep(100);
                                    continue;
                                }

                                // 2.判断上课时间是否已过
                                string courseEndTime = DateTime.Now.ToShortDateString() + " " + scRow.Field<DateTime>("EndTime").ToLongTimeString();
                                // 上课时间已过
                                if (DateTime.Now.CompareTo(DateTime.Parse(courseEndTime)) != -1)
                                {
                                    ShowTimeNotMatchInfo("请核对上课时间");
                                    studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                                    Monitor.Exit(this);//取消锁定
                                    Thread.Sleep(100);
                                    continue;
                                }

                                // 3.根据收费类型进行判断 收费类型(0:季度|1:月份|2:课次)
                                int chargeType = scRow.Field<int>("ChargeType");
                                if (chargeType == 0 || chargeType == 1)
                                {
                                    // 提前2周提醒
                                    if (DateDiff(scRow.Field<DateTime>("ExpireTime"), DateTime.Now) <= 14)
                                    {
                                        ShowSignInSuccessInfo(true);
                                    }
                                    else
                                    {
                                        ShowSignInSuccessInfo(false);
                                    }
                                }
                                else
                                {
                                    // 最后2次提醒
                                    int actualCost = scRow.Field<int>("ChargeAmount");
                                    int courseNum = scRow.Field<int>("CourseNum");
                                    int balance = scRow.Field<int>("Balance");
                                    if (courseNum <= 2)
                                    {
                                        if (actualCost > balance)
                                        {
                                            ShowSignInFailedInfo("余额不足，请及时缴费");
                                            Monitor.Exit(this);//取消锁定
                                            Thread.Sleep(100);
                                            continue;
                                        }
                                        else
                                        {
                                            ShowSignInSuccessInfo(true);
                                        }
                                    }
                                    else
                                    {
                                        ShowSignInSuccessInfo(false);
                                    }
                                    ChargeByCourse(balance, actualCost, row, scRow, scRow.Field<int>("CourseTimeID"));
                                }
                                studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                            }
                            else
                            {
                                // 当前有多门课，弹框供用户选择后刷卡
                                StudentCourseForm studentCourseForm = new StudentCourseForm();
                                studentCourseForm.StartPosition = FormStartPosition.CenterScreen;
                                studentCourseForm.studentId = row.Field<int>("ID");
                                studentCourseForm.studentName = row.Field<string>("Name");
                                studentCourseForm.currentDayOfWeek = _currentDayOfWeek;
                                if (studentCourseForm.ShowDialog() != DialogResult.OK)
                                {
                                    ClearStudentInfo();
                                    Monitor.Exit(this);//取消锁定
                                    Thread.Sleep(100);
                                    continue;
                                }
                                else
                                {
                                    int retCourseId = studentCourseForm.courseId;
                                    DataRow[] scRow = this.signInDataSet.StudentCourse.Select("CourseID = " + retCourseId);
                                    // 1.判断该课程是否过期
                                    if (scRow[0].Field<DateTime>("ExpireTime") < DateTime.Now)
                                    {
                                        ShowSignInFailedInfo("您已欠费，请及时缴费");
                                        Monitor.Exit(this);//取消锁定
                                        Thread.Sleep(100);
                                        continue;
                                    }
                                    // 2.判断上课时间是否已过
                                    string courseEndTime = DateTime.Now.ToShortDateString() + " " + studentCourseForm.endTime;
                                    // 上课时间已过
                                    if (DateTime.Now.CompareTo(DateTime.Parse(courseEndTime)) != -1)
                                    {
                                        ShowTimeNotMatchInfo("请核对上课时间");
                                        studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                                        Monitor.Exit(this);//取消锁定
                                        Thread.Sleep(100);
                                        continue;
                                    }

                                    // 3.根据收费类型进行判断 收费类型(0:季度|1:月份|2:课次)
                                    int chargeType = scRow[0].Field<int>("ChargeType");
                                    if (chargeType == 0 || chargeType == 1)
                                    {
                                        // 提前2周提醒
                                        if (DateDiff(scRow[0].Field<DateTime>("ExpireTime"), DateTime.Now) <= 14)
                                        {
                                            ShowSignInSuccessInfo(true);
                                        }
                                        else
                                        {
                                            ShowSignInSuccessInfo(false);
                                        }
                                    }
                                    else
                                    {
                                        // 最后2次提醒
                                        int actualCost = scRow[0].Field<int>("ChargeAmount");
                                        int courseNum = scRow[0].Field<int>("CourseNum");
                                        int balance = scRow[0].Field<int>("Balance");
                                        if (courseNum <= 2)
                                        {
                                            if (actualCost > balance)
                                            {
                                                // 余额不足以支付
                                                ShowSignInFailedInfo("余额不足，请及时缴费");
                                                Monitor.Exit(this);//取消锁定
                                                Thread.Sleep(100);
                                                continue;
                                            }
                                            else
                                            {
                                                ShowSignInSuccessInfo(true);
                                            }
                                        }
                                        else
                                        {
                                            ShowSignInSuccessInfo(false);
                                        }
                                        ChargeByCourse(balance, actualCost, row, scRow[0], studentCourseForm.courseTimeId);
                                    }
                                    studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                                }
                            }
                        }
                    }
                    Thread.Sleep(2000);
                }
                Monitor.Exit(this);//取消锁定
                Thread.Sleep(100);
            }
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClearStudentInfo();
            if (e.KeyChar != (char)13)
                return;

            // 获取当前的学生记录
            string cardNo = txtCardNo.Text;
            DataRow[] rows = signInDataSet.Students.Select("CardNo = '" + cardNo + "'");
            if (rows.Length <= 0)
            {
                // 卡号不存在
                ShowSignInFailedInfo("卡号不存在");
                return;
            }

            // 显示学生信息
            DataRow row = rows[0];
            ShowStudentsInfo(row);

            // 查看当前学生是否已经过期
            if (row.Field<DateTime>("ExpireTime") < DateTime.Now)
            {
                // 欠费
                ShowSignInFailedInfo("您已欠费，请及时缴费");
                return;
            }
            else
            {
                // 查询当前学生当天可以上的所有课程
                this.studentCourseTableAdapter.Fill(this.signInDataSet.StudentCourse, row.Field<int>("ID"), _currentDayOfWeek);
                if (this.signInDataSet.StudentCourse.Rows.Count == 0)
                {
                    // 当天没有课程，提示时间不一致，但允许刷卡
                    ShowTimeNotMatchInfo("请核对上课时间");
                    studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                    return;
                }
                else
                {
                    // 当天只有一门课
                    if (this.signInDataSet.StudentCourse.Rows.Count == 1)
                    {
                        DataRow scRow = this.signInDataSet.StudentCourse.Rows[0];
                        // 1.判断该课程是否过期
                        if (scRow.Field<DateTime>("ExpireTime") < DateTime.Now)
                        {
                            ShowSignInFailedInfo("您已欠费，请及时缴费");
                            return;
                        }

                        // 2.判断上课时间是否已过
                        string courseEndTime = DateTime.Now.ToShortDateString() + " " + scRow.Field<DateTime>("EndTime").ToLongTimeString();
                        // 上课时间已过
                        if (DateTime.Now.CompareTo(DateTime.Parse(courseEndTime)) != -1)
                        {
                            ShowTimeNotMatchInfo("请核对上课时间");
                            studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                            return;
                        }

                        // 3.根据收费类型进行判断 收费类型(0:季度|1:月份|2:课次)
                        int chargeType = scRow.Field<int>("ChargeType");
                        if (chargeType == 0 || chargeType == 1)
                        {
                            // 提前2周提醒
                            if (DateDiff(scRow.Field<DateTime>("ExpireTime"), DateTime.Now) <= 14)
                            {
                                ShowSignInSuccessInfo(true);
                            }
                            else
                            {
                                ShowSignInSuccessInfo(false);
                            }
                        }
                        else
                        {
                            // 最后2次提醒
                            int actualCost = scRow.Field<int>("ChargeAmount");
                            int courseNum = scRow.Field<int>("CourseNum");
                            int balance = scRow.Field<int>("Balance");
                            if (courseNum <= 2)
                            {
                                if (actualCost > balance)
                                {
                                    ShowSignInFailedInfo("余额不足，请及时缴费");
                                    return;
                                }
                                else
                                {
                                    ShowSignInSuccessInfo(true);
                                }
                            }
                            else 
                            {
                                ShowSignInSuccessInfo(false);
                            }
                            ChargeByCourse(balance, actualCost, row, scRow, scRow.Field<int>("CourseTimeID"));
                        }
                        studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                    }
                    else
                    {
                        // 当前有多门课，弹框供用户选择后刷卡
                        StudentCourseForm studentCourseForm = new StudentCourseForm();
                        studentCourseForm.StartPosition = FormStartPosition.CenterScreen;
                        studentCourseForm.studentId = row.Field<int>("ID");
                        studentCourseForm.studentName = row.Field<string>("Name");
                        studentCourseForm.currentDayOfWeek = _currentDayOfWeek;
                        if (studentCourseForm.ShowDialog() != DialogResult.OK)
                        {
                            ClearStudentInfo();
                            return;
                        }
                        else
                        {
                            int retCourseId = studentCourseForm.courseId;
                            DataRow[] scRow = this.signInDataSet.StudentCourse.Select("CourseID = " + retCourseId);
                            // 1.判断该课程是否过期
                            if (scRow[0].Field<DateTime>("ExpireTime") < DateTime.Now)
                            {
                                ShowSignInFailedInfo("您已欠费，请及时缴费");
                                return;
                            }
                            // 2.判断上课时间是否已过
                            string courseEndTime = DateTime.Now.ToShortDateString() + " " + studentCourseForm.endTime;
                            // 上课时间已过
                            if (DateTime.Now.CompareTo(DateTime.Parse(courseEndTime)) != -1)
                            {
                                ShowTimeNotMatchInfo("请核对上课时间");
                                studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                                return;
                            }

                            // 3.根据收费类型进行判断 收费类型(0:季度|1:月份|2:课次)
                            int chargeType = scRow[0].Field<int>("ChargeType");
                            if (chargeType == 0 || chargeType == 1)
                            {
                                // 提前2周提醒
                                if (DateDiff(scRow[0].Field<DateTime>("ExpireTime"), DateTime.Now) <= 14)
                                {
                                    ShowSignInSuccessInfo(true);
                                }
                                else
                                {
                                    ShowSignInSuccessInfo(false);
                                }
                            }
                            else
                            {
                                // 最后2次提醒
                                int actualCost = scRow[0].Field<int>("ChargeAmount");
                                int courseNum = scRow[0].Field<int>("CourseNum");
                                int balance = scRow[0].Field<int>("Balance");

                                if (courseNum <= 2)
                                {
                                    if (actualCost > balance)
                                    {
                                        ShowSignInFailedInfo("余额不足，请及时缴费");
                                        return;
                                    }
                                    else
                                    {
                                        ShowSignInSuccessInfo(true);
                                    }
                                }
                                else
                                {
                                    ShowSignInSuccessInfo(false);
                                }
                                ChargeByCourse(balance, actualCost, row, scRow[0], studentCourseForm.courseTimeId);
                            }
                            studentSignInTableAdapter.InsertSignInRecord(row.Field<int>("ID"), DateTime.Now);
                        }
                    }
                }
            }
        }

        private void StudentSignInForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“signInDataSet.StudentCost”中。您可以根据需要移动或删除它。
            this.studentCostTableAdapter.Fill(this.signInDataSet.StudentCost);
            this.signInDataSet.EnforceConstraints = false;
            this.coursesTableAdapter.Fill(this.signInDataSet.Courses);

            // 初始化设备
            if (_icdev <= 0)
            {
                _icdev = dc_init(100, 115200);
            }

            if (_icdev > 0)
            {
                threadReadCardno = new Thread(ReadCard);
                threadGetCardNo = new Thread(GetCardNo);
                threadReadCardno.Start();
                threadGetCardNo.Start();
            }
            else
            {
                MessageBox.Show("初始化读卡器失败！", "初始化读卡器失败", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            studentsTableAdapter.Fill(signInDataSet.Students);
            ClearStudentInfo();
        }

        
        private void ShowTimeNotMatchInfo(string info) {
            lblStatus.Text = "刷卡成功！" + info;
            txtCardNo.Text = "";
            txtCardNo.Focus();
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Application.StartupPath + "//time.wav";
            soundPlayer.Load();
            soundPlayer.Play();
        }

        private void ShowSignInFailedInfo(string details)
        {
            // 刷卡失败
            lblStatus.Text = "刷卡失败！" + details;

            txtCardNo.Text = "";
            txtCardNo.Focus();

            // 播放声音
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Application.StartupPath + "//arrears.wav";
            soundPlayer.Load();
            soundPlayer.Play();
        }

        private void ShowSignInSuccessInfo(bool isNeedRemind)
        {
            // 刷卡成功
            lblStatus.Text = "刷卡成功！";

            txtCardNo.Text = "";
            txtCardNo.Focus();

            // 播放声音
            SoundPlayer soundPlayer = new SoundPlayer();
            if (isNeedRemind)
            {
                soundPlayer.SoundLocation = Application.StartupPath + "//balance.wav";
            }
            else 
            {
                soundPlayer.SoundLocation = Application.StartupPath + "//success.wav";
            }
            soundPlayer.Load();
            soundPlayer.Play();
        }

        private void ShowStudentsInfo(DataRow row)
        {
            lblName.Text = row.Field<string>("Name");
            switch (row.Field<int>("CardType"))
            {
                case 0:
                    lblCardType.Text = "普通卡";
                    lblCardType.ForeColor = Color.Black;
                    break;
                case 1:
                    lblCardType.Text = "VIP卡";
                    lblCardType.ForeColor = Color.Red;
                    break;
                default:
                    lblCardType.Text = "";
                    break;
            }
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClearStudentInfo()
        {
            lblName.Text = "";
            lblCardType.Text = "";
            lblTime.Text = "";
            lblStatus.Text = "";
        }

        private void StudentSignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadReadCardno != null)
                threadReadCardno.Abort();
            if (threadGetCardNo != null)
                threadGetCardNo.Abort();
            dc_exit(_icdev);
        }

        public bool _isActive = true;

        private void StudentSignInForm_Activated(object sender, EventArgs e)
        {
            Monitor.Enter(this);    //锁定，保持同步
            if (_icdev <= 0)
            {
                _icdev = dc_init(100, 115200);
            }
            if (_icdev <= 0)
            {
                MessageBox.Show("重新初始化读卡器失败！", "初始化读卡器失败", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            _isActive = true;
            Monitor.Exit(this);
        }

        private void StudentSignInForm_Deactivate(object sender, EventArgs e)
        {
            Monitor.Enter(this);//锁定，保持同步
            if (_icdev > 0)
            {
                dc_exit(_icdev);
                _icdev = 0;
            }
            _isActive = false;
            Monitor.Exit(this);
        }

        private int DateDiff(DateTime dateTimeOne, DateTime dateTimeTwo)
        {
            string dateDiff = null;
            try
            {
                TimeSpan ts1 = new TimeSpan(dateTimeOne.Ticks);
                TimeSpan ts2 = new TimeSpan(dateTimeTwo.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                dateDiff = Math.Round(ts.TotalDays).ToString();
            }
            catch
            {

            }
            return int.Parse(dateDiff);
        }

        private void ChargeBack(int balance, int actualCost, int courseTimeId, DataRow studentRow, DataRow studentCourseRow) {
            // 1.更新总金额
            balance -= actualCost;
            int courseNum = studentCourseRow.Field<int>("CourseNum");
            courseNum -= 1;
            studentCourseTableAdapter.UpdateBalance(balance, courseNum, studentRow.Field<int>("ID"), studentCourseRow.Field<int>("CourseID"));

            // 2.新增扣钱记录
            studentCoursesCostTableAdapter.InsertCost(
                studentRow.Field<int>("ID"),
                studentCourseRow.Field<int>("CourseID"),
                courseTimeId,
                studentCourseRow.Field<int>("ChargeAmount"),
                DateTime.Now,
                100,
                studentCourseRow.Field<int>("ChargeAmount"),
                "按课次收费",
                studentRow.Field<string>("Name")
                );
        }

        private void ChargeByCourse(int balance, int actualCost, DataRow studentRow, 
            DataRow studentCourseRow, int currentCourseTimeId)
        {
            // 当天的起始时间
            DateTime beginTime = DateTime.Parse(DateTime.Now.ToShortDateString());

            // 判断到该课程结束前是否已经扣过费
            this.studentCoursesCostTableAdapter.FillByCondition(this.signInDataSet.studentCoursesCost, studentRow.Field<int>("ID"),
                studentCourseRow.Field<int>("CourseID"), beginTime, currentCourseTimeId);

            int costCount = this.signInDataSet.studentCoursesCost.Rows.Count;
            // 如果未扣费则进行扣费
            if (costCount == 0)
            {
                ChargeBack(balance, actualCost, currentCourseTimeId, studentRow, studentCourseRow);
            }
        }
    }
}
