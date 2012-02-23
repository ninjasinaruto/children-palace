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
    public partial class StudentsManageForm : Form
    {
        public string UserName;
        public int UserType;
        public ToolStripButton tsbInvoicePrinting;

        public StudentsManageForm()
        {
            InitializeComponent();
        }

        public StudentsManageForm(ToolStripButton tsbPrint) {
            InitializeComponent();
            this.tsbInvoicePrinting = tsbPrint;
        }

        private void StudentsManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentsDataSet.StudentVacate”中。您可以根据需要移动或删除它。
            this.studentVacateTableAdapter.Fill(this.studentsDataSet.StudentVacate);
            // TODO: 这行代码将数据加载到表“studentsDataSet.CardList”中。您可以根据需要移动或删除它。
            this.cardListTableAdapter.Fill(this.studentsDataSet.CardList);

            if (this.UserType == 0)
            {
                btnBuyMaterial.Enabled = false;
                btnCardConnect.Enabled = false;
                btnDeposit.Enabled = false;
                btnExtendSignUp.Enabled = false;
                btnLeaveCourse.Enabled = false;
                btnReportBack.Enabled = false;
                btnVacate.Enabled = false;
                btnSignUpCourses.Enabled = false;
                btnChangeCourses.Enabled = false;

                btnShowAll.Enabled = false;
                btnShowLeft.Enabled = false;
                btnSearchByCourse.Enabled = false;
                btnSearchByCourseType.Enabled = false;
                btnCardDisconnect.Enabled = false;

                // 只加载被授权的学生
                this.studentsTableAdapter.FillByUserName(this.studentsDataSet.Students, this.UserName);
            }
            else
            {
                // 加载所有的学生
                //this.studentsTableAdapter.Fill(this.studentsDataSet.Students);
                this.studentsTableAdapter.FillByStatus(this.studentsDataSet.Students);
            }
        }

        private void studentsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (studentsBindingSource.Position < 0)
            {
                btnDeposit.Enabled = false;
                studentsDataSet.StudentCourses.Clear();
                return;
            }
            if (UserType > 0)
            {
                btnDeposit.Enabled = true;
            }

            int index;
            if (dgvStudents.SelectedRows.Count <= 0)
                index = studentsBindingSource.Position;
            else
                index = Common.Algorithm.GetTablePositionFromDataGridViewRow(dgvStudents.SelectedRows[0], studentsDataSet.Students.Rows);

            int studentID = studentsDataSet.Students.Rows[index].Field<int>("ID");
            studentCoursesTableAdapter.Fill(studentsDataSet.StudentCourses, studentID);

            if (UserType == 0)
                return;
            int studentStatus = studentsDataSet.Students.Rows[index].Field<int>("Status");
            switch (studentStatus )
            {
                case 1:
                    // 正常状态
                    btnVacate.Enabled = true;
                    btnReportBack.Enabled = false;
                    break;
                case 2:
                    // 请假状态
                    btnVacate.Enabled = false;
                    btnReportBack.Enabled = true;
                    break;
                default:
                    btnVacate.Enabled = false;
                    btnReportBack.Enabled = false;
                    break;
            }

            if (studentsDataSet.StudentCourses.Rows.Count > 0)
            {
                btnLeaveCourse.Enabled = true;
                btnExtendSignUp.Enabled = true;
                btnChangeCourses.Enabled = false;
            }
            else
            {
                btnLeaveCourse.Enabled = false;
                btnExtendSignUp.Enabled = false;
                btnChangeCourses.Enabled = false;
            }
        }

        private void btnSearchByCardNo_Click(object sender, EventArgs e)
        {
            CardConnectForm frmCardConnect = new CardConnectForm();
            frmCardConnect.ShowDialog();

            if (frmCardConnect.cardNo == "")
                return;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells["CardNoColumn"].Value.ToString() == frmCardConnect.cardNo)
                {
                    studentsBindingSource.Position = row.Index;
                    return;
                }
            }
            MessageBox.Show("找不到卡号为“" + frmCardConnect.cardNo + "”的学生",
                "找不到学生", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //this.studentsTableAdapter.Fill(this.studentsDataSet.Students);
            this.studentsTableAdapter.FillByStatus(this.studentsDataSet.Students);
            this.Text = "学生资料管理 - [所有]";
            txtShowRange.Text = "所有";
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;

            int studentId = int.Parse(txtID.Text);

            GetDepositAmountForm frmGetDepositAmount = new GetDepositAmountForm();
            frmGetDepositAmount.StudentName = txtName.Text;
            frmGetDepositAmount.CardNo = txtCardNo.Text;
            frmGetDepositAmount.CardType = txtCardType.Text;
            if (frmGetDepositAmount.ShowDialog() != DialogResult.OK)
                return;

            int depositAmount = frmGetDepositAmount.DepositAmount;
            int paidAmount = frmGetDepositAmount.PaidAmount;
            int tuitionAmount = frmGetDepositAmount.tuitionAmount;
            int materialsAmount = frmGetDepositAmount.materialsAmount;
            int otherAmount = frmGetDepositAmount.otherAmount;

            DataGridViewRow row = dgvStudents.SelectedRows[0];

            ConfirmDepositForm frmConfirmDeposit = new ConfirmDepositForm();
            frmConfirmDeposit.DepositAmount = depositAmount.ToString();
            frmConfirmDeposit.PaidAmount = paidAmount.ToString();
            frmConfirmDeposit.TuitionAmount = tuitionAmount.ToString();
            frmConfirmDeposit.MaterialsAmount = materialsAmount.ToString();
            frmConfirmDeposit.OtherAmount = otherAmount.ToString();
            frmConfirmDeposit.StudentName = txtName.Text;
            frmConfirmDeposit.StudentSex = row.Cells["SexColumn"].Value.ToString();
            frmConfirmDeposit.StudentBirthday = row.Cells["BirthdayColumn"].Value.ToString();
            frmConfirmDeposit.StudentAddress = row.Cells["AddressColumn"].Value.ToString();
            frmConfirmDeposit.StudentPhone = row.Cells["PhoneColumn"].Value.ToString();
            frmConfirmDeposit.StudentFartherName = row.Cells["FartherNameColumn"].Value.ToString();
            frmConfirmDeposit.StudentFartherPhone = row.Cells["FartherTelColumn"].Value.ToString();
            frmConfirmDeposit.StudentFartherWork = row.Cells["FartherWorkColumn"].Value.ToString();
            frmConfirmDeposit.StudentMotherName = row.Cells["MotherNameColumn"].Value.ToString();
            frmConfirmDeposit.StudentMotherPhone = row.Cells["MotherTelColumn"].Value.ToString();
            frmConfirmDeposit.StudentMotherWork = row.Cells["MotherWorkColumn"].Value.ToString();
            frmConfirmDeposit.Text = "确定为“" + txtName.Text + "”充值" + depositAmount + "元吗？";
            if (frmConfirmDeposit.ShowDialog() != DialogResult.OK)
                return;

            depositListTableAdapter.Insert(studentId, depositAmount, DateTime.Now, paidAmount, User.CurrentUser.UserName);

            int newBalance = int.Parse(txtBalance.Text) + depositAmount;
            studentsTableAdapter.UpdateBalance(newBalance, studentId);

            txtBalance.Text = newBalance.ToString();
            row.Cells["Balance"].Value = txtBalance.Text;

            if (MessageBox.Show("需要打印发票吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                List<PrintRecord> list = new List<PrintRecord>();
                if (tuitionAmount == 0 && materialsAmount == 0 && otherAmount == 0)
                {
                    PrintRecord prAmount = new PrintRecord();
                    prAmount.id = 1;
                    prAmount.name = "充值";
                    prAmount.num = "1";
                    prAmount.price = depositAmount.ToString();
                    prAmount.amount = depositAmount.ToString();
                    list.Add(prAmount);
                }
                else {
                    if (tuitionAmount != 0)
                    {
                        PrintRecord prTuition = new PrintRecord();
                        prTuition.id = 1;
                        prTuition.name = "学费";
                        prTuition.num = "1";
                        prTuition.price = tuitionAmount.ToString();
                        prTuition.amount = tuitionAmount.ToString();
                        list.Add(prTuition);
                    }

                    if (materialsAmount != 0)
                    {
                        PrintRecord prMaterials = new PrintRecord();
                        prMaterials.id = 2;
                        prMaterials.name = "材料费";
                        prMaterials.num = "1";
                        prMaterials.price = materialsAmount.ToString();
                        prMaterials.amount = materialsAmount.ToString();
                        list.Add(prMaterials);
                    }

                    if (otherAmount != 0)
                    {
                        PrintRecord prOther = new PrintRecord();
                        prOther.id = 3;
                        prOther.name = "其他";
                        prOther.num = "1";
                        prOther.price = otherAmount.ToString();
                        prOther.amount = otherAmount.ToString();
                        list.Add(prOther);
                    }
                }

                InvoicePrintingForm printForm = new InvoicePrintingForm();
                printForm.MdiParent = this.Owner;
                printForm.StartPosition = FormStartPosition.CenterScreen;
                printForm.isReadOnly = true;
                printForm.userName = txtName.Text;
                printForm.recordList = list;
                printForm.totalAmount = depositAmount;
                printForm.Show();
            }
        }

        private void studentCoursesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (studentCoursesBindingSource.Position < 0)
            {
                studentsDataSet.CourseTimes.Clear();
                return;
            }

            int index;

            if (dgvStudentCourses.SelectedRows.Count <= 0)
                index = studentCoursesBindingSource.Position;
            else
            {
                DataRowView drv = dgvStudentCourses.SelectedRows[0].DataBoundItem as DataRowView;
                index = studentsDataSet.StudentCourses.Rows.IndexOf(drv.Row);
            }

            int courseID = studentsDataSet.StudentCourses.Rows[index].Field<int>("CourseID");
            courseTimesTableAdapter.Fill(studentsDataSet.CourseTimes, courseID);
        }

        private void StudentsManageForm_Resize(object sender, EventArgs e)
        {
            dgvStudents.Width = this.Width - 25;
            dgvStudents.Height = this.Height - 392;
        }

        private void btnSearchByCourseType_Click(object sender, EventArgs e)
        {
            CourseTypeSelectForm frmCourseTypeSelect = new CourseTypeSelectForm();
            if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            studentsTableAdapter.FillByCourseType(studentsDataSet.Students,
                frmCourseTypeSelect.CourseTypeId);
            this.Text = "学生资料管理 - [" + frmCourseTypeSelect.CourseTypeName + "]";
            txtShowRange.Text = frmCourseTypeSelect.CourseTypeName;
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            GetStudentNameForm frmGetStudentName = new GetStudentNameForm();
            if (frmGetStudentName.ShowDialog() != DialogResult.OK)
                return;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells["NameColumn"].Value.ToString() == frmGetStudentName.StudentName)
                {
                    studentsBindingSource.Position = row.Index;
                    return;
                }
            }
            MessageBox.Show("找不到姓名为“" + frmGetStudentName.StudentName + "”的学生",
                "找不到学生", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchByCourse_Click(object sender, EventArgs e)
        {
            CourseSelectForm frmCourseSelect = new CourseSelectForm();
            if (frmCourseSelect.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            studentsTableAdapter.FillByCourse(studentsDataSet.Students, frmCourseSelect.CourseID);
            this.Text = "学生资料管理 - [" + frmCourseSelect.CourseTypeName + " - " +
                frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName + "]";
            txtShowRange.Text = frmCourseSelect.CourseTypeName + " - " +
                frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName;
        }

        private void studentsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblStudentsCount.Text = studentsDataSet.Students.Rows.Count + "人";
        }

        private void btnSignUpCourses_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            CourseSignUpForm frmCourseSignUp = new CourseSignUpForm();
            frmCourseSignUp.CardNo = txtCardNo.Text;
            frmCourseSignUp.StudentName = txtName.Text;
            frmCourseSignUp.Balance = txtBalance.Text;
            frmCourseSignUp.row = row;
            if (frmCourseSignUp.ShowDialog() != DialogResult.OK)
                return;

            ConfirmSignUpCoursesForm frmConfirmSignUpCourses = new ConfirmSignUpCoursesForm();
            frmConfirmSignUpCourses.CourseType = frmCourseSignUp.CourseType;
            frmConfirmSignUpCourses.CourseSubType = frmCourseSignUp.CourseSubType;
            frmConfirmSignUpCourses.CourseName = frmCourseSignUp.CourseName;

            frmConfirmSignUpCourses.CurrentDate = DateTime.Now.ToLongDateString();
            frmConfirmSignUpCourses.ExpireDate = frmCourseSignUp.ExpireDate;
            frmConfirmSignUpCourses.SignUpPeriod = frmCourseSignUp.SignUpPeriod;
            frmConfirmSignUpCourses.TotalCost = frmCourseSignUp.TotalCost;

            frmConfirmSignUpCourses.Discount = frmCourseSignUp.Discount;
            frmConfirmSignUpCourses.DiscountReason = frmCourseSignUp.DiscountReason;
            frmConfirmSignUpCourses.ActualCostAmount = frmCourseSignUp.ActualCostAmount;

            frmConfirmSignUpCourses.StudentName = row.Cells["NameColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentSex = row.Cells["SexColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentBirthday = row.Cells["BirthdayColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentAddress = row.Cells["AddressColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentPhone = row.Cells["PhoneColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentFartherName = row.Cells["FartherNameColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentFartherPhone = row.Cells["FartherTelColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentFartherWork = row.Cells["FartherWorkColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentMotherName = row.Cells["MotherNameColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentMotherPhone = row.Cells["MotherTelColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentMotherWork = row.Cells["MotherWorkColumn"].Value.ToString();

            if (frmConfirmSignUpCourses.ShowDialog() != DialogResult.OK)
                return;

            // 报名：
            // 1> 扣钱:
            // 1.1> 更新balance
            frmCourseSignUp.Balance = txtBalance.Text;
            int balance = int.Parse(frmCourseSignUp.Balance);
            int actualCost = int.Parse(frmCourseSignUp.ActualCostAmount);
            balance -= actualCost;
            studentsTableAdapter.UpdateBalance(balance, int.Parse(txtID.Text));
            txtBalance.Text = balance.ToString();
            // 1.2> 添加扣钱记录
            studentCostTableAdapter1.InsertCost(int.Parse(txtID.Text), frmCourseSignUp.CourseId,
                int.Parse(frmCourseSignUp.TotalCost), DateTime.Now,
                frmCourseSignUp.DiscountLevel,
                int.Parse(frmCourseSignUp.ActualCostAmount), frmCourseSignUp.DiscountReason, User.CurrentUser.UserName);

            // 2> 添加报名信息
            DateTime expireDate = DateTime.Parse(frmCourseSignUp.ExpireDate);
            studentCoursesTableAdapter.InsertStudentCourse(int.Parse(txtID.Text), frmCourseSignUp.CourseId,
                expireDate, int.Parse(frmCourseSignUp.TotalCost), int.Parse(frmCourseSignUp.SignUpTime));

            // 3> 更新学生的学费过期时间，看哪个过期时间更近
            studentsTableAdapter.UpdateExpireTime(expireDate, int.Parse(txtID.Text));

            MessageBox.Show("报名成功！", "报名课程成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int GetSelectedStudentCourseIndex()
        {
            if (dgvStudentCourses.SelectedRows.Count <= 0)
                return 0;
            // Get course id;
            DataRowView drv = dgvStudentCourses.SelectedRows[0].DataBoundItem as DataRowView;
            return studentsDataSet.StudentCourses.Rows.IndexOf(drv.Row);
        }

        private void btnExtendSignUp_Click(object sender, EventArgs e)
        {
            if (dgvStudentCourses.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudentCourses.SelectedRows[0];

            // Get course id;
            int selectedStudentCourseIndex = GetSelectedStudentCourseIndex();
            int studentCourseId = studentsDataSet.StudentCourses.Rows[selectedStudentCourseIndex].Field<int>("ID");
            int courseID = studentsDataSet.StudentCourses.Rows[selectedStudentCourseIndex].Field<int>("CourseID");
            int studentId = int.Parse(txtID.Text);

            CourseExtendForm frmCourseExtend = new CourseExtendForm();
            frmCourseExtend.StudentName = txtName.Text;
            frmCourseExtend.Balance = txtBalance.Text;

            frmCourseExtend.CurrentExpireDate = row.Cells["ExpireTimeColumn"].Value.ToString();
            frmCourseExtend.CourseType = row.Cells["CourseTypeColumn"].Value.ToString();
            frmCourseExtend.CourseSubtype = row.Cells["CourseSubtypeColumn"].Value.ToString();
            frmCourseExtend.CourseName = row.Cells["CourseNameColumn"].Value.ToString();
            frmCourseExtend.ChargeType = row.Cells["ChargeTypeColumn"].Value.ToString();
            frmCourseExtend.ChargeAmount = row.Cells["ChargeAmountColumn"].Value.ToString();

            if (frmCourseExtend.ShowDialog() != DialogResult.OK)
                return;

            // 续报班：
            // 1> 扣除余额
            int balance = int.Parse(txtBalance.Text);
            balance -= frmCourseExtend.ActualCost;
            studentsTableAdapter.UpdateBalance(balance, int.Parse(txtID.Text));
            studentCoursesTableAdapter.UpdateBalance(frmCourseExtend.TotalCost, frmCourseExtend.signUpTime, studentId, courseID);
            txtBalance.Text = balance.ToString();

            // 2> 添加扣钱记录
            studentCostTableAdapter1.InsertCost(int.Parse(txtID.Text), courseID, frmCourseExtend.TotalCost, DateTime.Now, 100,
                frmCourseExtend.ActualCost, frmCourseExtend.DiscountReason, User.CurrentUser.UserName);

            // 3> 更新课程到期时间
            studentCoursesTableAdapter.UpdateExpireTime(frmCourseExtend.ExpireDate, studentCourseId);

            // 4> 更新学生的学费过期时间，看哪个过期时间更近
            studentsTableAdapter.UpdateExpireTime(frmCourseExtend.ExpireDate, int.Parse(txtID.Text));

            // 5> 刷新显示
            studentCoursesTableAdapter.Fill(studentsDataSet.StudentCourses, studentId);
        }

        private void btnBuyMaterial_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            BuyMaterialsForm frmBuyMaterials = new BuyMaterialsForm();
            frmBuyMaterials.StudentName = txtName.Text;
            frmBuyMaterials.Balance = txtBalance.Text;
            if(frmBuyMaterials.ShowDialog() != DialogResult.OK)
                return;
            // 1> 添加购买记录
            materialsCostTableAdapter.Insert(int.Parse(txtID.Text), frmBuyMaterials.MaterialID,
                frmBuyMaterials.MaterialPrice, frmBuyMaterials.BuyCount, frmBuyMaterials.TotalCost,
                DateTime.Now, User.CurrentUser.UserName);
            // 2> 更新balance
            int balance = int.Parse(txtBalance.Text);
            balance -= frmBuyMaterials.TotalCost;
            studentsTableAdapter.UpdateBalance(balance, int.Parse(txtID.Text));
            txtBalance.Text = balance.ToString();
            row.Cells["Balance"].Value = balance;

            if (MessageBox.Show("需要打印发票吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<PrintRecord> list = new List<PrintRecord>();
                PrintRecord prAmount = new PrintRecord();
                prAmount.id = 1;
                prAmount.name = frmBuyMaterials.MaterialName;
                prAmount.num = frmBuyMaterials.BuyCount+"";
                prAmount.price = frmBuyMaterials.MaterialPrice+"";
                prAmount.amount = frmBuyMaterials.TotalCost + "";
                list.Add(prAmount);

                InvoicePrintingForm printForm = new InvoicePrintingForm();
                printForm.MdiParent = this.Owner;
                printForm.StartPosition = FormStartPosition.CenterScreen;
                printForm.isReadOnly = true;
                printForm.userName = txtName.Text;
                printForm.recordList = list;
                printForm.totalAmount = frmBuyMaterials.TotalCost;
                printForm.Show();
            }
        }

        private void btnVacate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            ConfirmVacateForm frmConfirmVacate = new ConfirmVacateForm();
            frmConfirmVacate.StudentName = txtName.Text;
            frmConfirmVacate.StudentSex = row.Cells["SexColumn"].Value.ToString();
            frmConfirmVacate.StudentBirthday = row.Cells["BirthdayColumn"].Value.ToString();
            frmConfirmVacate.StudentAddress = row.Cells["AddressColumn"].Value.ToString();
            frmConfirmVacate.StudentPhone = row.Cells["PhoneColumn"].Value.ToString();
            frmConfirmVacate.StudentFartherName = row.Cells["FartherNameColumn"].Value.ToString();
            frmConfirmVacate.StudentFartherPhone = row.Cells["FartherTelColumn"].Value.ToString();
            frmConfirmVacate.StudentFartherWork = row.Cells["FartherWorkColumn"].Value.ToString();
            frmConfirmVacate.StudentMotherName = row.Cells["MotherNameColumn"].Value.ToString();
            frmConfirmVacate.StudentMotherPhone = row.Cells["MotherTelColumn"].Value.ToString();
            frmConfirmVacate.StudentMotherWork = row.Cells["MotherWorkColumn"].Value.ToString();
            frmConfirmVacate.Text = "确定为“" + txtName.Text + "”请假？";
            if (frmConfirmVacate.ShowDialog() != DialogResult.OK)
                return;

            int studentId = int.Parse(txtID.Text);
            // 添加请假记录
            studentVacateTableAdapter.Insert(studentId, DateTime.Now, null);
            // 更新学生状态
            studentsTableAdapter.UpdateStatus(2, studentId);
            studentsTableAdapter.Fill(studentsDataSet.Students);
        }

        private void btnLeaveCourse_Click(object sender, EventArgs e)
        {
            if (dgvStudentCourses.SelectedRows.Count <= 0)
                return;

            DataGridViewRow row = dgvStudentCourses.SelectedRows[0];

            LeaveCourseForm frmLeaveCourse = new LeaveCourseForm();
            frmLeaveCourse.StudentName = txtName.Text;
            frmLeaveCourse.ExpireTime = ((DateTime)row.Cells["ExpireTimeColumn"].Value).ToLongDateString();

            frmLeaveCourse.CourseType = row.Cells["CourseTypeColumn"].Value.ToString();
            frmLeaveCourse.CourseSubtype = row.Cells["CourseSubtypeColumn"].Value.ToString();
            frmLeaveCourse.CourseName = row.Cells["CourseNameColumn"].Value.ToString();
            frmLeaveCourse.ChargeType = row.Cells["ChargeTypeColumn"].Value.ToString();
            frmLeaveCourse.ChargeAmount = row.Cells["ChargeAmountColumn"].Value.ToString();

            if (frmLeaveCourse.ShowDialog() != DialogResult.OK)
                return;

            // 1> 添加退款记录
            studentRefundTableAdapter.Insert(int.Parse(txtID.Text),
                studentsDataSet.StudentCourses.Rows[studentCoursesBindingSource.Position].Field<int>("CourseID"),
                frmLeaveCourse.RefundAmount, DateTime.Now, frmLeaveCourse.LeaveReason, User.CurrentUser.UserName);

            // 2> 增加余额
            int balance = int.Parse(txtBalance.Text);
            balance += frmLeaveCourse.RefundAmount;
            studentsTableAdapter.UpdateBalance(balance, int.Parse(txtID.Text));
            txtBalance.Text = balance.ToString();

            // 3> 从课程中删除学生
            studentCoursesTableAdapter.DeleteStudentCourse(
                studentsDataSet.StudentCourses.Rows[studentCoursesBindingSource.Position].Field<int>("ID"));

            // 4> 刷新显示
            studentCoursesTableAdapter.Fill(studentsDataSet.StudentCourses, int.Parse(txtID.Text));
        }

        private void btnReportBack_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            DialogResult result = MessageBox.Show("确认为“" + txtName.Text + "”销假吗？",
                "确认学生销假", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
                return;
            
            int studentId = int.Parse(txtID.Text);
            studentsTableAdapter.UpdateStatus(1, studentId);
            studentsTableAdapter.Fill(studentsDataSet.Students);
        }

        private void btnCardConnect_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            // 获取卡号
            CardConnectForm frmCardConnect = new CardConnectForm();
            frmCardConnect.ShowDialog();
            if (frmCardConnect.cardNo == "")
                return;

            // 查询是否有卡号冲突
            DataRow[] rows = studentsDataSet.CardList.Select("CardNo = '" + frmCardConnect.cardNo + "'");
            if (rows.Length > 0)
            {
                DataRow cardInfoRow = rows[0];
                MessageBox.Show("该卡片[" + frmCardConnect.cardNo + "]已被学生["
                    + cardInfoRow.Field<string>("Name") + "]所使用，请使用新卡片", "卡号已被使用",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };

            // 获取卡号的类型
            CardTypeSelectForm frmCardTypeSelect = new CardTypeSelectForm();
            if (frmCardTypeSelect.ShowDialog() != DialogResult.OK)
                return;
            int cardType = frmCardTypeSelect.CardType;
            string cardTypeName = "";
            switch (cardType)
            {
                case 0:
                    cardTypeName = "普通卡";
                    break;
                case 1:
                    cardTypeName = "VIP卡";
                    break;
            }

            // 显示确认对话框
            ConfirmCardConnectForm frmConfirmCardConnect = new ConfirmCardConnectForm();
            frmConfirmCardConnect.CardNo = frmCardConnect.cardNo;
            frmConfirmCardConnect.CardType = cardTypeName;
            frmConfirmCardConnect.StudentName = txtName.Text;
            frmConfirmCardConnect.StudentSex = row.Cells["SexColumn"].Value.ToString();
            frmConfirmCardConnect.StudentBirthday = row.Cells["BirthdayColumn"].Value.ToString();
            frmConfirmCardConnect.StudentAddress = row.Cells["AddressColumn"].Value.ToString();
            frmConfirmCardConnect.StudentPhone = row.Cells["PhoneColumn"].Value.ToString();
            frmConfirmCardConnect.StudentFartherName = row.Cells["FartherNameColumn"].Value.ToString();
            frmConfirmCardConnect.StudentFartherPhone = row.Cells["FartherTelColumn"].Value.ToString();
            frmConfirmCardConnect.StudentFartherWork = row.Cells["FartherWorkColumn"].Value.ToString();
            frmConfirmCardConnect.StudentMotherName = row.Cells["MotherNameColumn"].Value.ToString();
            frmConfirmCardConnect.StudentMotherPhone = row.Cells["MotherTelColumn"].Value.ToString();
            frmConfirmCardConnect.StudentMotherWork = row.Cells["MotherWorkColumn"].Value.ToString();

            if (frmConfirmCardConnect.ShowDialog() != DialogResult.OK)
                return;

            // 更新卡号信息
            studentsTableAdapter.UpdateCardInfo(frmCardConnect.cardNo, cardType, int.Parse(txtID.Text));

            // 刷新界面
            txtCardNo.Text = frmCardConnect.cardNo;
            txtCardType.Text = cardTypeName;
            row.Cells["CardNoColumn"].Value = txtCardNo.Text;
            row.Cells["CardTypeNameColumn"].Value = cardTypeName;
        }

        private void StudentsManageForm_Shown(object sender, EventArgs e)
        {
        }

        private void btnShowLeft_Click(object sender, EventArgs e)
        {
            //this.studentsTableAdapter.FillByLeftCourse(this.studentsDataSet.Students);
            this.studentsTableAdapter.FillByLeave(this.studentsDataSet.Students);
            this.Text = "学生资料管理 - [离班]";
            txtShowRange.Text = "离班";
        }

        private void btnCardDisconnect_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            if (MessageBox.Show("确认要回收“" + txtName.Text + "”的卡号为“"
                + txtCardNo.Text + "”的卡片吗？", "确认回收卡片", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK)
                return;

            // 更新卡号信息
            studentsTableAdapter.UpdateCardInfo("", 0, int.Parse(txtID.Text));

            // 刷新界面
            txtCardNo.Text = "";
            txtCardType.Text = "普通卡";
            row.Cells["CardNoColumn"].Value = txtCardNo.Text;
            row.Cells["CardTypeNameColumn"].Value = "普通卡";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            StudentInfoEditForm frmStudentInfoEdit = new StudentInfoEditForm();
            frmStudentInfoEdit.StudentName = txtName.Text;
            frmStudentInfoEdit.StudentSex = row.Cells["SexColumn"].Value.ToString();
            frmStudentInfoEdit.StudentBirthday = row.Cells["BirthdayColumn"].Value.ToString();
            frmStudentInfoEdit.StudentAddress = row.Cells["AddressColumn"].Value.ToString();
            frmStudentInfoEdit.StudentPhone = row.Cells["PhoneColumn"].Value.ToString();
            frmStudentInfoEdit.StudentFartherName = row.Cells["FartherNameColumn"].Value.ToString();
            frmStudentInfoEdit.StudentFartherPhone = row.Cells["FartherTelColumn"].Value.ToString();
            frmStudentInfoEdit.StudentFartherWork = row.Cells["FartherWorkColumn"].Value.ToString();
            frmStudentInfoEdit.StudentMotherName = row.Cells["MotherNameColumn"].Value.ToString();
            frmStudentInfoEdit.StudentMotherPhone = row.Cells["MotherTelColumn"].Value.ToString();
            frmStudentInfoEdit.StudentMotherWork = row.Cells["MotherWorkColumn"].Value.ToString();
            if (frmStudentInfoEdit.ShowDialog() != DialogResult.OK)
                return;

            studentsTableAdapter.UpdateBasicInfo(frmStudentInfoEdit.StudentPhone, frmStudentInfoEdit.StudentAddress,
                frmStudentInfoEdit.StudentFartherName, frmStudentInfoEdit.StudentFartherWork, frmStudentInfoEdit.StudentFartherPhone,
                frmStudentInfoEdit.StudentMotherName, frmStudentInfoEdit.StudentMotherWork, frmStudentInfoEdit.StudentMotherPhone,
                int.Parse(txtID.Text));

            row.Cells["AddressColumn"].Value = frmStudentInfoEdit.StudentAddress;
            row.Cells["PhoneColumn"].Value = frmStudentInfoEdit.StudentPhone;
            row.Cells["FartherNameColumn"].Value = frmStudentInfoEdit.StudentFartherName;
            row.Cells["FartherTelColumn"].Value = frmStudentInfoEdit.StudentFartherPhone;
            row.Cells["FartherWorkColumn"].Value = frmStudentInfoEdit.StudentFartherWork;
            row.Cells["MotherNameColumn"].Value = frmStudentInfoEdit.StudentMotherName;
            row.Cells["MotherTelColumn"].Value = frmStudentInfoEdit.StudentMotherPhone;
            row.Cells["MotherWorkColumn"].Value = frmStudentInfoEdit.StudentMotherWork;
        }

        private void btnHistoryRecord_Click(object sender, EventArgs e)
        {
            HistoryRecordForm frmHistroryRecord = new HistoryRecordForm();
            if (!int.TryParse(txtID.Text, out frmHistroryRecord.StudentID))
                return;
            frmHistroryRecord.ShowDialog();
        }

        private void btnChangeCourses_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            ChangeCourseForm frmChangeCourse = new ChangeCourseForm();
            frmChangeCourse.CardNo = txtCardNo.Text;
            frmChangeCourse.StudentName = txtName.Text;
            frmChangeCourse.Balance = txtBalance.Text;
            frmChangeCourse.row = row;
            if (frmChangeCourse.ShowDialog() != DialogResult.OK)
                return;
            //GetDepositAmountForm frmGetDepositAmount = new GetDepositAmountForm();
            //frmGetDepositAmount.StudentName = txtName.Text;
            //frmGetDepositAmount.CardNo = txtCardNo.Text;
            //frmGetDepositAmount.CardType = txtCardType.Text;
            //if (frmGetDepositAmount.ShowDialog() != DialogResult.OK)
            //    return;

            //int depositAmount = frmGetDepositAmount.DepositAmount;
            //int paidAmount = frmGetDepositAmount.PaidAmount;
            //int tuitionAmount = frmGetDepositAmount.tuitionAmount;
            //int materialsAmount = frmGetDepositAmount.materialsAmount;
            //int otherAmount = frmGetDepositAmount.otherAmount;

            //DataGridViewRow row = dgvStudents.SelectedRows[0];

            //ConfirmDepositForm frmConfirmDeposit = new ConfirmDepositForm();
            //frmConfirmDeposit.DepositAmount = depositAmount.ToString();
            //frmConfirmDeposit.PaidAmount = paidAmount.ToString();
            //frmConfirmDeposit.TuitionAmount = tuitionAmount.ToString();
            //frmConfirmDeposit.MaterialsAmount = materialsAmount.ToString();
            //frmConfirmDeposit.OtherAmount = otherAmount.ToString();
            //frmConfirmDeposit.StudentName = txtName.Text;
            //frmConfirmDeposit.StudentSex = row.Cells["SexColumn"].Value.ToString();
            //frmConfirmDeposit.StudentBirthday = row.Cells["BirthdayColumn"].Value.ToString();
            //frmConfirmDeposit.StudentAddress = row.Cells["AddressColumn"].Value.ToString();
            //frmConfirmDeposit.StudentPhone = row.Cells["PhoneColumn"].Value.ToString();
            //frmConfirmDeposit.StudentFartherName = row.Cells["FartherNameColumn"].Value.ToString();
            //frmConfirmDeposit.StudentFartherPhone = row.Cells["FartherTelColumn"].Value.ToString();
            //frmConfirmDeposit.StudentFartherWork = row.Cells["FartherWorkColumn"].Value.ToString();
            //frmConfirmDeposit.StudentMotherName = row.Cells["MotherNameColumn"].Value.ToString();
            //frmConfirmDeposit.StudentMotherPhone = row.Cells["MotherTelColumn"].Value.ToString();
            //frmConfirmDeposit.StudentMotherWork = row.Cells["MotherWorkColumn"].Value.ToString();
            //frmConfirmDeposit.Text = "确定为“" + txtName.Text + "”充值" + depositAmount + "元吗？";
        }
    }
}
