using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShaoNianGong
{
    public partial class StudentSigninManageForm : Form
    {
        private int _currentDayOfWeek;
        private List<Course> _classesOfToday = new List<Course>();
        private List<Course> _classesOfSpecified = null;
        private List<Course> _classesOfAll = new List<Course>();
        private int signInNum = 0;
        private int unSignInNum = 0;

        public StudentSigninManageForm()
        {
            InitializeComponent();

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

        class Course
        {
            public Course(int courseId, string courseName)
            {
                this.CourseID = courseId;
                this.CourseName = courseName;
            }
            public int CourseID { get; set; }
            public string CourseName { get; set; }
        }

        private void StudentSigninForm_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);

            // 获取所有今天上课的课程信息
            this.coursesTodayTableAdapter.Fill(this.coursesDataSet.CoursesToday);
            
            foreach (DataRow row in coursesDataSet.CoursesToday.Rows)
            {
                Course course = new Course(row.Field<int>("ID"),
                    row.Field<string>("CourseTypeName") + " - "
                    + row.Field<string>("CourseSubtypeName") + " - "
                    + row.Field<string>("CourseName"));
                if (row.Field<int>("DayOfWeek") == _currentDayOfWeek)
                {
                    _classesOfToday.Add(course);
                }
                _classesOfAll.Add(course);
            }

            // 获取所有今天的刷卡信息
            DateTime beginDate = DateTime.Now;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            this.studentSigninTableAdapter.FillByBeginTime(signInDataSet.StudentSignin,
                beginDate);

            lstCourses.DataSource = _classesOfToday;
            lstCourses.ValueMember = "CourseID";
            lstCourses.DisplayMember = "CourseName";

            lstCourses.SelectedIndex = -1;

            this.studentsSigninTableAdapter.FillByDay(this.signInDataSet.StudentsSignin);
            txtShowRangeWithDetail.Text = "今天";
        }

        private void coursesTodayBindingSource_PositionChanged(object sender, EventArgs e)
        {
            /*
            this.Text = "学生资料管理 - [" + frmCourseSelect.CourseTypeName + " - " +
                frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName + "]";
            txtShowRange.Text = frmCourseSelect.CourseTypeName + " - " +
                frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName;
             */
        }

        private void StudentSigninManageForm_Resize(object sender, EventArgs e)
        {
            dgvStudents.Height = this.Size.Height/2 - 92;
            dgvStudents.Width = this.Size.Width - 312;
            groupBox1.Height = this.Size.Height / 2 - 40;
            lstCourses.Height = this.Height/2 - 170;
            this.groupBox2.Top = this.Height / 2 - 20;
            this.groupBox2.Width = this.Width - 30;
            this.groupBox2.Height = this.Height / 2 - 40;
            this.panel2.Top = this.Height/2 - 80;
            this.dgvStudentSignin.Width = this.Width - 50;
            this.dgvStudentSignin.Height = this.Height / 2 - 130;
        }

        private void lstCourses_ValueMemberChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedValue == null)
                return;
            int courseId;
            if (!int.TryParse(lstCourses.SelectedValue.ToString(), out courseId))
                return;
            studentsTableAdapter.FillByCourse(studentsDataSet.Students, courseId);

            signInNum = 0;
            unSignInNum = 0;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                int position = Common.Algorithm.GetTablePositionFromDataGridViewRow(row, studentsDataSet.Students.Rows);
                int studentId = studentsDataSet.Students.Rows[position].Field<int>("ID");
                if (signInDataSet.StudentSignin.Select("StudentID=" + studentId).Length > 0){
                    row.Cells["SignInStatusColumn"].Value = "已签到";
                    signInNum++;
                } else {
                    row.Cells["SignInStatusColumn"].Value = "尚未签到";
                    unSignInNum++;
                }   
            }
            showSignInRes(signInNum, unSignInNum);
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedValue == null)
                return;
            int courseId;
            if (!int.TryParse(lstCourses.SelectedValue.ToString(), out courseId))
                return;
            studentsTableAdapter.FillByCourse(studentsDataSet.Students, courseId);

            signInNum = 0;
            unSignInNum = 0;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                int position = Common.Algorithm.GetTablePositionFromDataGridViewRow(row, studentsDataSet.Students.Rows);
                int studentId = studentsDataSet.Students.Rows[position].Field<int>("ID");
                if (signInDataSet.StudentSignin.Select("StudentID=" + studentId).Length > 0)
                {
                    row.Cells["SignInStatusColumn"].Value = "已签到";
                    signInNum++;
                }
                else 
                {
                    row.Cells["SignInStatusColumn"].Value = "尚未签到";
                    unSignInNum++;
                }  
            }
            showSignInRes(signInNum, unSignInNum);
        }

        private void studentsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            signInNum = 0;
            unSignInNum = 0;
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                int position = Common.Algorithm.GetTablePositionFromDataGridViewRow(row, studentsDataSet.Students.Rows);
                int studentId = studentsDataSet.Students.Rows[position].Field<int>("ID");
                if (signInDataSet.StudentSignin.Select("StudentID=" + studentId).Length > 0)
                {
                    row.Cells["SignInStatusColumn"].Value = "已签到";
                    signInNum++;
                }
                else
                {
                    row.Cells["SignInStatusColumn"].Value = "尚未签到";
                    unSignInNum++;
                }
            }
            showSignInRes(signInNum, unSignInNum);
        }

        private void studentsBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
        }

        private void btnCoursesToday_Click(object sender, EventArgs e)
        {
            // 获取所有今天的刷卡信息
            DateTime beginDate = DateTime.Now;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            this.studentSigninTableAdapter.FillByBeginTime(signInDataSet.StudentSignin,
                beginDate);

            lstCourses.DataSource = _classesOfToday;
            lstCourses.ValueMember = "CourseID";
            lstCourses.DisplayMember = "CourseName";
        }

        private void btnSearchCourses_Click(object sender, EventArgs e)
        {
            _classesOfSpecified = new List<Course>();
            DateTime dateTime = DateTime.Parse(dateTimePicker.Text);
            // 根据日期转换成星期
            int _dayOfWeek = CaculateWeekDay(dateTime.Year, dateTime.Month, dateTime.Day);
            // 查询指定日期对应的课程
            foreach (DataRow row in coursesDataSet.CoursesToday.Rows)
            {
                Course course = new Course(row.Field<int>("ID"),
                    row.Field<string>("CourseTypeName") + " - "
                    + row.Field<string>("CourseSubtypeName") + " - "
                    + row.Field<string>("CourseName"));
                if (row.Field<int>("DayOfWeek") == _dayOfWeek)
                {
                    _classesOfSpecified.Add(course);
                }
            }
            // 查询指定日期学生的签到记录
            DateTime beginDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0);
            this.studentSigninTableAdapter.FillByBeginTime(signInDataSet.StudentSignin,
                beginDate);

            lstCourses.DataSource = _classesOfSpecified;
            lstCourses.ValueMember = "CourseID";
            lstCourses.DisplayMember = "CourseName";

            lstCourses.SelectedIndex = -1;
        }

        protected int CaculateWeekDay(int y, int m, int d)
        {
            if (m == 1 || m == 2)
            {
                m += 12;
                y--;         // 把一月和二月看成是上一年的十三月和十四月，例：如果是2004-1-10则换算成：2003-13-10来代入公式计算。
            }
            int week = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400) % 7;
            return week+1;
        }

        protected void showSignInRes(int signIn, int unsignIn) {
            string showStr = "";
            if (signIn+unsignIn == 0){
                showStr = "0.00";
                txtSignInRes.Visible = false;
            } else {
                double res = (Double.Parse(signIn+"") / Double.Parse((signIn + unsignIn)+""))*100;
                showStr = Convert.ToDouble(res).ToString("0.00");
                txtSignInRes.Text = "已签到【" + signIn + "】人，尚未签到【" + unsignIn + "】人，出勤率【" + showStr + "%】";
                txtSignInRes.Visible = true;
            }
        }

        private void dgvStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
                for (int i = 0; i < dgvStudents.Rows.Count; i++)
                {
                    dgvStudents.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void studentsSigninBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblSigninCountWithDetail.Text = signInDataSet.StudentsSignin.Rows.Count + "条";
        }

        private void dgvStudentSignin_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvStudentSignin.Rows.Count > 0)
                for (int i = 0; i < dgvStudentSignin.Rows.Count; i++)
                {
                    dgvStudentSignin.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void btnSearchByDateWithDetail_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtStimeWithDetail.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEtimeWithDetail.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (txtStudentNameWithDetail.Text.Trim() == "")
            {
                this.studentsSigninTableAdapter.FillByBeginEndDate(this.signInDataSet.StudentsSignin, beginDate, endDate);
                txtShowRangeWithDetail.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
            }
            else
            {
                this.studentsSigninTableAdapter.FillByBeginEndDateWithStudentName(this.signInDataSet.StudentsSignin, beginDate, endDate, "%" + txtStudentNameWithDetail.Text.Trim() + "%");
                txtShowRangeWithDetail.Text = txtStudentNameWithDetail.Text.Trim() + " - " + beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
            }
        }

        private void btnSearchByDayWithDetail_Click(object sender, EventArgs e)
        {
            if (txtStudentNameWithDetail.Text.Trim() == "")
            {
                this.studentsSigninTableAdapter.FillByDay(this.signInDataSet.StudentsSignin);
                txtShowRangeWithDetail.Text = "今天";
            }
            else
            {
                this.studentsSigninTableAdapter.FillByDayWithStudentName(this.signInDataSet.StudentsSignin, "%" + txtStudentNameWithDetail.Text.Trim() + "%");
                txtShowRangeWithDetail.Text = txtStudentNameWithDetail.Text.Trim() + " - 今天";
            }
        }

        private void btnSearchByMonthWithDetail_Click(object sender, EventArgs e)
        {
            if (txtStudentNameWithDetail.Text.Trim() == "")
            {

                this.studentsSigninTableAdapter.FillByMonth(this.signInDataSet.StudentsSignin);
                txtShowRangeWithDetail.Text = "本月";
            }
            else
            {
                this.studentsSigninTableAdapter.FillByMonthWithStudentName(this.signInDataSet.StudentsSignin, "%" + txtStudentNameWithDetail.Text.Trim() + "%");
                txtShowRangeWithDetail.Text = txtStudentNameWithDetail.Text.Trim() + " - 本月";
            }
        }

        private void btnSearchAllWithDetail_Click(object sender, EventArgs e)
        {
            if (txtStudentNameWithDetail.Text.Trim() == "")
            {
                this.studentsSigninTableAdapter.Fill(this.signInDataSet.StudentsSignin);
                txtShowRangeWithDetail.Text = "所有";
            }
            else
            {
                this.studentsSigninTableAdapter.FillByAllWithStudentName(this.signInDataSet.StudentsSignin, "%" + txtStudentNameWithDetail.Text.Trim() + "%");
                txtShowRangeWithDetail.Text = txtStudentNameWithDetail.Text.Trim() + " - 所有";
            }
        }
    }
}
