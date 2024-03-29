﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanGongPingTai
{
    public partial class TeachersManageForm : Form
    {
        public string studentName = "";
        public string printTitle = "";

        public TeachersManageForm()
        {
            InitializeComponent();
        }

        private void TeachersManageForm_Load(object sender, EventArgs e)
        {
            this.vCardsTableAdapter.Fill(this.teachersDataSet.VCards);
            if (User.CurrentUser.UserType > 1)
                btnAddSalary.Enabled = true;
            printTitle = "海鹰教育培训中心"+DateTime.Now.AddMonths(-1).ToString("yyyy年M月") + "工资表";
            this.teachersTableAdapter.Fill(this.teachersDataSet.Tearchers);
            if (teachersDataSet.Tearchers.Rows.Count > 0)
            {
                teacherCoursesTableAdapter.Fill(teachersDataSet.TeacherCourses,
                    teachersDataSet.Tearchers.Rows[0].Field<int>("ID"));
            }
            if (User.CurrentUser.UserType > 1 || User.CurrentUser.UserName == "郑文静")
            {
                this.groupBox1.Visible = true;
                this.teacherWagesTableAdapter.FillByLastMonth(this.teacherWageDataSet.TeacherWages);
            }
            else
            {
                this.groupBox1.Visible = false;
            }
            dgvTeacherWages.ColHeaderTreeView = wageColumnsTree;
        }

        private void TeachersManageForm_Resize(object sender, EventArgs e)
        {
            this.groupBox1.Width = this.Width - 22;
            this.groupBox1.Height = this.Height - 240;
            dgvTeacherWages.Width = this.Width - 38;
            dgvTeacherWages.Height = this.Height - 330;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherAddingForm frmTeachersAdding = new TeacherAddingForm();
            if (frmTeachersAdding.ShowDialog() != DialogResult.OK)
                return;
            int teacherID = (int)teachersTableAdapter.InsertTeacher(frmTeachersAdding.Name, frmTeachersAdding.Phone, null, frmTeachersAdding.Sex,
                frmTeachersAdding.Address, 0, frmTeachersAdding.Password, frmTeachersAdding.BirthDay, frmTeachersAdding.Ethnic,
                frmTeachersAdding.Hometown, frmTeachersAdding.GraduationTime, frmTeachersAdding.Degree, frmTeachersAdding.School,
                frmTeachersAdding.Professional,DateTime.Now,User.CurrentUser.UserName, frmTeachersAdding.EntryDate);
            List<SigninTime> stList = frmTeachersAdding.signinTimeList;
            foreach (SigninTime st in stList)
            {
                teacherSigninTimeTableAdapter.Insert(teacherID, null, DateTime.Parse(st.beginTime.ToShortTimeString()),
                    DateTime.Parse(st.endTime.ToShortTimeString()), st.range, DateTime.Now, User.CurrentUser.UserName);
            }
            teachersTableAdapter.Fill(teachersDataSet.Tearchers);
            if (teachersDataSet.Tearchers.Rows.Count > 0)
            {
                teacherCoursesTableAdapter.Fill(teachersDataSet.TeacherCourses,
                    teachersDataSet.Tearchers.Rows[0].Field<int>("ID"));
            }
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (teachersBindingSource.Position < 0)
                return;
            int rowIndex = dgvTeachers.CurrentRow.Index;
            List<SigninTime> stList = new List<SigninTime>();
            this.teacherSigninTimeTableAdapter.FillByTeacherID(teachersDataSet.TeacherSigninTime, teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID"));
            if (teachersDataSet.TeacherSigninTime.Rows.Count > 0)
            {
                for (int i = 0; i < teachersDataSet.TeacherSigninTime.Rows.Count; i++)
                {
                    DataRow row = teachersDataSet.TeacherSigninTime.Rows[i];
                    SigninTime st = new SigninTime();
                    st.beginTime = row.Field<DateTime>("BeginTime");
                    st.endTime = row.Field<DateTime>("EndTime");
                    st.range = row.Field<int>("Range");
                    stList.Add(st);
                }
            }

            TeacherUpdateForm frmTeacherUpdate = new TeacherUpdateForm();
            frmTeacherUpdate.TeacherName = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Name");
            if (!teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].IsNull("BirthDay"))
            {
                frmTeacherUpdate.isBirthDayNull = false;
                frmTeacherUpdate.BirthDay = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<DateTime>("BirthDay");
            }
            else
            {
                frmTeacherUpdate.isBirthDayNull = true;
            }
            frmTeacherUpdate.Ethnic = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Ethnic");
            frmTeacherUpdate.Hometown = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Hometown");
            frmTeacherUpdate.Sex = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Sex");
            frmTeacherUpdate.Degree = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Degree");
            frmTeacherUpdate.School = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("School");
            if (!teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].IsNull("GraduationTime"))
            {
                frmTeacherUpdate.isGraduationTimeNull = false;
                frmTeacherUpdate.GraduationTime = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<DateTime>("GraduationTime");
            }
            else
            {
                frmTeacherUpdate.isGraduationTimeNull = true;
            }
            frmTeacherUpdate.Professional = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Professional");
            frmTeacherUpdate.Phone = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Phone");
            frmTeacherUpdate.Address = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Address");
            if (!teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].IsNull("EntryDate"))
            {
                frmTeacherUpdate.isEntryDateNull = false;
                frmTeacherUpdate.EntryDate = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<DateTime>("EntryDate");
            }
            else
            {
                frmTeacherUpdate.isEntryDateNull = true;
            }
            frmTeacherUpdate.Password = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Password");
            frmTeacherUpdate.signinTimeList = stList;
            if (frmTeacherUpdate.ShowDialog() != DialogResult.OK)
                return;
            int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
            teachersTableAdapter.UpdateByID(frmTeacherUpdate.Name, frmTeacherUpdate.Phone, frmTeacherUpdate.Sex, frmTeacherUpdate.Address, frmTeacherUpdate.Password,
                frmTeacherUpdate.BirthDay, frmTeacherUpdate.Hometown, frmTeacherUpdate.Ethnic, frmTeacherUpdate.GraduationTime, frmTeacherUpdate.Degree, frmTeacherUpdate.School,
                frmTeacherUpdate.Professional, frmTeacherUpdate.EntryDate, teacherID);
            teacherSigninTimeTableAdapter.DeleteByTeacherID(teacherID);
            stList = frmTeacherUpdate.signinTimeList;
            foreach (SigninTime st in stList)
            {
                teacherSigninTimeTableAdapter.Insert(teacherID, null, DateTime.Parse(st.beginTime.ToShortTimeString()),
                    DateTime.Parse(st.endTime.ToShortTimeString()), st.range, DateTime.Now, User.CurrentUser.UserName);
            }
            teacherSigninReportTableAdapter.UpdateTeacherNameByTeacherID(frmTeacherUpdate.TeacherName, teacherID);
            teachersTableAdapter.Fill(teachersDataSet.Tearchers);
            if (rowIndex >= 0)
            {
                this.dgvTeachers.Rows[rowIndex].Selected = true;
                this.dgvTeachers.CurrentCell = this.dgvTeachers.Rows[rowIndex].Cells[0];
            }
            printTitle = "海鹰教育培训中心" + DateTime.Now.AddMonths(-1).ToString("yyyy年M月") + "工资表";
            this.teacherWagesTableAdapter.FillByLastMonth(this.teacherWageDataSet.TeacherWages);
        }

        private void btnDelTeacher_Click(object sender, EventArgs e)
        {
            if (teachersBindingSource.Position < 0)
                return;
            if (teachersDataSet.TeacherCourses.Rows.Count > 0)
            {
                MessageBox.Show("该教师有授课，无法删除！");
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要删除该教师吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
                    teachersTableAdapter.DeleteByID(teacherID);
                    teacherSigninTimeTableAdapter.DeleteByTeacherID(teacherID);
                    teacherSigninReportTableAdapter.DeleteByTeacherID(teacherID);
                    teacherSigninTableAdapter.DeleteByTeacherID(teacherID);
                    teachersTableAdapter.Fill(teachersDataSet.Tearchers);
                    if (teachersDataSet.Tearchers.Rows.Count > 0)
                    {
                        teacherCoursesTableAdapter.Fill(teachersDataSet.TeacherCourses,
                            teachersDataSet.Tearchers.Rows[0].Field<int>("ID"));
                    }
                }
            }
        }

        private void btnConnectCard_Click(object sender, EventArgs e)
        {
            if (teachersBindingSource.Position < 0)
                return;
            int rowIndex = dgvTeachers.CurrentRow.Index;

            // 获取卡号
            CardConnectForm frmCardConnect = new CardConnectForm();
            frmCardConnect.ShowDialog();
            if (frmCardConnect.cardNo == "")
                return;

            // 查询是否有卡号冲突
            DataRow[] rows = teachersDataSet.VCards.Select("CardNo = '" + frmCardConnect.cardNo + "'");
            if (rows.Length > 0)
            {
                DataRow cardInfoRow = rows[0];
                int cardType = cardInfoRow.Field<int>("CardType");
                string crowd = cardType == 1 ? "学生" : "教师";
                MessageBox.Show("该卡片[" + frmCardConnect.cardNo + "]已被"+crowd+"["
                    + cardInfoRow.Field<string>("Name") + "]所使用，请使用新卡片", "卡号已被使用",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 显示确认对话框
            ConfirmCardConnectForm frmConfirmCardConnect = new ConfirmCardConnectForm();
            frmConfirmCardConnect.CardNo = frmCardConnect.cardNo;
            frmConfirmCardConnect.TeacherName = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Name");
            frmConfirmCardConnect.TeacherSex = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Sex");
            frmConfirmCardConnect.TeacherAddress = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Address");
            frmConfirmCardConnect.TeacherPhone = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Phone");
            
            if (frmConfirmCardConnect.ShowDialog() != DialogResult.OK)
                return;

            int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
            // 更新卡号信息
            teachersTableAdapter.UpdateCardNo(frmCardConnect.cardNo, teacherID);

            // 刷新界面
            this.teachersTableAdapter.Fill(teachersDataSet.Tearchers);
            if (rowIndex >= 0)
            {
                this.dgvTeachers.Rows[rowIndex].Selected = true;
                this.dgvTeachers.CurrentCell = this.dgvTeachers.Rows[rowIndex].Cells[0];
            }
            this.vCardsTableAdapter.Fill(this.teachersDataSet.VCards);
        }

        private void btnCardDisconnect_Click(object sender, EventArgs e)
        {
            if (teachersBindingSource.Position < 0)
                return;
            int rowIndex = dgvTeachers.CurrentRow.Index;

            if (MessageBox.Show("确认要回收“" + teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Name") + "”的卡号为“"
                + teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("CardNo") + "”的卡片吗？", "确认回收卡片", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK)
                return;

            int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
            // 更新卡号信息
            teachersTableAdapter.UpdateCardNo("", teacherID);

            // 刷新界面
            this.teachersTableAdapter.Fill(teachersDataSet.Tearchers);
            if (rowIndex >= 0)
            {
                this.dgvTeachers.Rows[rowIndex].Selected = true;
                this.dgvTeachers.CurrentCell = this.dgvTeachers.Rows[rowIndex].Cells[0];
            }
            this.vCardsTableAdapter.Fill(this.teachersDataSet.VCards);
        }

        private void teachersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (teachersBindingSource.Position < 0)
                return;
            try
            {
                teacherCoursesTableAdapter.Fill(teachersDataSet.TeacherCourses,
                    int.Parse(txtID.Text));
            }
            catch
            {
                return;
            }
            finally
            {
                string cardNo = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("CardNo");
                if (cardNo != null && !"".Equals(cardNo))
                {
                    btnConnectCard.Enabled = false;
                    btnCardDisconnect.Enabled = true;
                }
                else
                {
                    btnConnectCard.Enabled = true;
                    btnCardDisconnect.Enabled = false;
                }
            }
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            if (teachersBindingSource.Position < 0)
                return;
            int rowIndex = dgvTeachers.CurrentRow.Index;
            int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
            SalaryAddForm frmSalaryAdd = new SalaryAddForm();
            frmSalaryAdd.TeacherName = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Name");
            frmSalaryAdd.TeacherID = teacherID;
            if (frmSalaryAdd.ShowDialog() != DialogResult.OK)
                return;
            DateTime wageTime = frmSalaryAdd.wageTime;
            List<BasicWage> basicWageList = frmSalaryAdd.bwList;
            double courseWageCoefficient = frmSalaryAdd.cwCoefficient;
            List<CourseWage> courseWageList = frmSalaryAdd.cwList;
            StudentAward studentAward = frmSalaryAdd.sa;
            List<TeacherAward> teacherAwardList = frmSalaryAdd.taList;
            List<ChargeBack> chargeBackList = frmSalaryAdd.cbList;

            int logID = (int)teacherSalaryLogTableAdapter.InsertQuery(teacherID, (decimal)frmSalaryAdd.ShouldWages, (decimal)frmSalaryAdd.RealWages, wageTime, User.CurrentUser.UserName);

            // 新增基本工资
            for (int i = 0; i < basicWageList.Count; i++)
            {
                teacherBasicWageTableAdapter.Insert(logID, basicWageList[i].WageType, (decimal)basicWageList[i].WageStandard,
                    basicWageList[i].WageNum, (decimal)basicWageList[i].WageAmount, basicWageList[i].Remark);
            }
            // 新增系数
            teacherCoefficientTableAdapter.Insert(logID, courseWageCoefficient);
            // 新增课量工资
            for (int i = 0; i < courseWageList.Count; i++)
            {
                teacherCourseWageTableAdapter.Insert(logID, courseWageList[i].CourseType, courseWageList[i].CourseNum,
                    (decimal)courseWageList[i].StandardPrice, (decimal)courseWageList[i].ActualPrice, (decimal)courseWageList[i].CourseAmount,
                    courseWageList[i].Remark);
            }
            // 新增学生管理奖
            teacherStudentAwardTableAdapter.Insert(logID, studentAward.TotalStudent, studentAward.ActualStudent, (decimal)studentAward.StandardPrice,
                (decimal)studentAward.ActualPrice, (decimal)studentAward.Amount);
            // 新增奖励工资
            for (int i = 0; i < teacherAwardList.Count; i++)
            {
                teacherAwardTableAdapter.Insert(logID, teacherAwardList[i].AwardName, (decimal)teacherAwardList[i].StandardPrice,
                    (decimal)teacherAwardList[i].ActualPrice, teacherAwardList[i].AwardNum, (decimal)teacherAwardList[i].AwardAmount,
                    teacherAwardList[i].Remark);
            }
            // 新增扣款
            for (int i = 0; i < chargeBackList.Count; i++)
            {
                teacherChargeBackTableAdapter.Insert(logID, chargeBackList[i].ChargeBackName, chargeBackList[i].ChargeBackType,
                    (decimal)chargeBackList[i].StandardPrice, chargeBackList[i].ChargeBackNum, (decimal)chargeBackList[i].ChargeBackAmount,
                    chargeBackList[i].Remark);
            }
            MessageBox.Show("添加工资成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            printTitle = "海鹰教育培训中心" + DateTime.Now.AddMonths(-1).ToString("yyyy年M月") + "工资表";
            this.teacherWagesTableAdapter.FillByLastMonth(this.teacherWageDataSet.TeacherWages);
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (teacherWagesBindingSource.Position < 0)
                return;
            int teacherID = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<int>("TeacherID");
            string teacherName = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<string>("TeacherName");
            int logID = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<int>("LogID");
            DateTime wageTime = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<DateTime>("WageTime");

            SalaryUpdateForm frmSalaryUpdate = new SalaryUpdateForm();
            frmSalaryUpdate.LogID = logID;
            frmSalaryUpdate.wageTime = wageTime;
            frmSalaryUpdate.TeacherID = teacherID;
            frmSalaryUpdate.TeacherName = teacherName;

            if (frmSalaryUpdate.ShowDialog() != DialogResult.OK)
                return;

            List<BasicWage> basicWageList = frmSalaryUpdate.bwList;
            double courseWageCoefficient = frmSalaryUpdate.cwCoefficient;
            List<CourseWage> courseWageList = frmSalaryUpdate.cwList;
            StudentAward studentAward = frmSalaryUpdate.sa;
            List<TeacherAward> teacherAwardList = frmSalaryUpdate.taList;
            List<ChargeBack> chargeBackList = frmSalaryUpdate.cbList;

            teacherSalaryLogTableAdapter.UpdateWagesByLogID((decimal)frmSalaryUpdate.ShouldWages, (decimal)frmSalaryUpdate.RealWages, frmSalaryUpdate.wageTime, logID);
            // 删除历史记录
            teacherChargeBackTableAdapter.DeleteByLogID(logID);
            teacherAwardTableAdapter.DeleteByLogID(logID);
            teacherStudentAwardTableAdapter.DeleteByLogID(logID);
            teacherCourseWageTableAdapter.DeleteByLogID(logID);
            teacherCoefficientTableAdapter.DeleteByLogID(logID);
            teacherBasicWageTableAdapter.DeleteByLogID(logID);

            // 新增基本工资
            for (int i = 0; i < basicWageList.Count; i++)
            {
                teacherBasicWageTableAdapter.Insert(logID, basicWageList[i].WageType, (decimal)basicWageList[i].WageStandard,
                    basicWageList[i].WageNum, (decimal)basicWageList[i].WageAmount, basicWageList[i].Remark);
            }
            // 新增系数
            teacherCoefficientTableAdapter.Insert(logID, courseWageCoefficient);
            // 新增课量工资
            for (int i = 0; i < courseWageList.Count; i++)
            {
                teacherCourseWageTableAdapter.Insert(logID, courseWageList[i].CourseType, courseWageList[i].CourseNum,
                    (decimal)courseWageList[i].StandardPrice, (decimal)courseWageList[i].ActualPrice, (decimal)courseWageList[i].CourseAmount,
                    courseWageList[i].Remark);
            }
            // 新增学生管理奖
            teacherStudentAwardTableAdapter.Insert(logID, studentAward.TotalStudent, studentAward.ActualStudent, (decimal)studentAward.StandardPrice,
                (decimal)studentAward.ActualPrice, (decimal)studentAward.Amount);
            // 新增奖励工资
            for (int i = 0; i < teacherAwardList.Count; i++)
            {
                teacherAwardTableAdapter.Insert(logID, teacherAwardList[i].AwardName, (decimal)teacherAwardList[i].StandardPrice,
                    (decimal)teacherAwardList[i].ActualPrice, teacherAwardList[i].AwardNum, (decimal)teacherAwardList[i].AwardAmount,
                    teacherAwardList[i].Remark);
            }
            // 新增扣款
            for (int i = 0; i < chargeBackList.Count; i++)
            {
                teacherChargeBackTableAdapter.Insert(logID, chargeBackList[i].ChargeBackName, chargeBackList[i].ChargeBackType,
                    (decimal)chargeBackList[i].StandardPrice, chargeBackList[i].ChargeBackNum, (decimal)chargeBackList[i].ChargeBackAmount,
                    chargeBackList[i].Remark);
            }
            MessageBox.Show("修改工资成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            printTitle = "海鹰教育培训中心" + DateTime.Now.AddMonths(-1).ToString("yyyy年M月") + "工资表";
            this.teacherWagesTableAdapter.FillByLastMonth(this.teacherWageDataSet.TeacherWages);
        }

        private void btnDelSalary_Click(object sender, EventArgs e)
        {
            if (teacherWagesBindingSource.Position < 0)
                return;
            if (MessageBox.Show("您确定要删除该条工资吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int logID = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<int>("LogID");
                teacherChargeBackTableAdapter.DeleteByLogID(logID);
                teacherAwardTableAdapter.DeleteByLogID(logID);
                teacherStudentAwardTableAdapter.DeleteByLogID(logID);
                teacherCourseWageTableAdapter.DeleteByLogID(logID);
                teacherCoefficientTableAdapter.DeleteByLogID(logID);
                teacherBasicWageTableAdapter.DeleteByLogID(logID);
                teacherSalaryLogTableAdapter.DeleteByLogID(logID);

                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printTitle = "海鹰教育培训中心" + DateTime.Now.AddMonths(-1).ToString("yyyy年M月") + "工资表";
                this.teacherWagesTableAdapter.FillByLastMonth(this.teacherWageDataSet.TeacherWages);
            }
        }

        private void teacherWagesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            double totalShouldWages = 0.00;
            double totalMinusWages = 0.00;
            double totalRealWages = 0.00;

            foreach (DataRow row in teacherWageDataSet.TeacherWages.Rows)
            {
                if (!row.IsNull("ShouldWages"))
                    totalShouldWages += (double)row.Field<decimal>("ShouldWages");
                if (!row.IsNull("MinusWages"))
                    totalMinusWages += (double)row.Field<decimal>("MinusWages");
                if (!row.IsNull("RealWages"))
                    totalRealWages += (double)row.Field<decimal>("RealWages");
            }

            txtTotalShouldWages.Text = totalShouldWages.ToString();
            txtTotalMinusWages.Text = totalMinusWages.ToString();
            txtTotalRealWages.Text = totalRealWages.ToString();
            if (teacherWageDataSet.TeacherWages.Rows.Count < 0)
            {
                btnPrint.Enabled = false;
                btnPrintDetail.Enabled = false;
                btnUpdateSalary.Enabled = false;
                btnDelSalary.Enabled = false;
                btnTeacherCheckWage.Enabled = false;
            }
            else
            {
                btnPrint.Enabled = true;
                btnPrintDetail.Enabled = true;
                if (User.CurrentUser.UserType > 1)
                {
                    btnDelSalary.Enabled = true;
                }
                btnTeacherCheckWage.Enabled = true;
            }
        }

        private void btnSearchMonth_Click(object sender, EventArgs e)
        {
            printTitle = "海鹰教育培训中心" + DateTime.Now.AddMonths(-1).ToString("yyyy年M月") + "工资表";
            this.teacherWagesTableAdapter.FillByLastMonth(this.teacherWageDataSet.TeacherWages);
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            printTitle = "海鹰教育培训中心工资总表";
            this.teacherWagesTableAdapter.Fill(this.teacherWageDataSet.TeacherWages);
        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtpSDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtpEDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.teacherWagesTableAdapter.FillByBeginAndEndDate(this.teacherWageDataSet.TeacherWages, beginDate, endDate);
            if (beginDate.ToString("yyyy年MM月").Equals(endDate.ToString("yyyy年MM月")))
            {
                printTitle = "海鹰教育培训中心" + beginDate.ToString("yyyy年M月") + "工资表";
            }
            else
            {
                printTitle = "海鹰教育培训中心" + beginDate.ToString("yyyy年M月") + "-" + endDate.ToString("yyyy年M月") + "工资表";
            }
        }

        private void dgvTeacherWages_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvTeacherWages.Rows.Count > 0)
                for (int i = 0; i < dgvTeacherWages.Rows.Count; i++)
                {
                    dgvTeacherWages.Rows[i].Cells[0].Value = i+1;
                }
        }

        private void btnSearchByTeacher_Click(object sender, EventArgs e)
        {
            if (teachersBindingSource.Position < 0)
            {
                MessageBox.Show("请先选择左侧教师列表中的任意一名教师！");
                return;
            }
            int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
            string teacherName = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Name");
            DateTime beginDate = dtpSDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtpEDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.teacherWagesTableAdapter.FillByBeginAndEndDateWithTeacherID(this.teacherWageDataSet.TeacherWages, beginDate, endDate, teacherID);
            if (beginDate.ToString("yyyy年MM月").Equals(endDate.ToString("yyyy年MM月")))
            {
                printTitle = "海鹰教育培训中心[" + teacherName + "]" + beginDate.ToString("yyyy年M月") + "工资表";
            }
            else
            {
                printTitle = "海鹰教育培训中心[" + teacherName + "]" + beginDate.ToString("yyyy年M月") + "-" + endDate.ToString("yyyy年M月") + "工资表";
            }
        }

        private void btnTeacherCheckWage_Click(object sender, EventArgs e)
        {
            if (teacherWagesBindingSource.Position < 0)
                return;
            int logID = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<int>("LogID");
            string teacherName = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<string>("TeacherName");
            string teacherPassword = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<string>("TeacherPassword");
            double realWages = (double)teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<decimal>("RealWages");
            DateTime wageTime = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<DateTime>("WageTime");

            TeacherCheckWageForm frmTeacherCheckWage = new TeacherCheckWageForm();
            frmTeacherCheckWage.TeacherName = teacherName;
            frmTeacherCheckWage.TeacherPwd = teacherPassword;
            frmTeacherCheckWage.TeacherWage = realWages;
            frmTeacherCheckWage.wageTime = wageTime;

            if (frmTeacherCheckWage.ShowDialog() != DialogResult.OK)
                return;

            this.teacherSalaryLogTableAdapter.UpdateByLogID(teacherName, logID);
            MessageBox.Show("核实成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            printTitle = "海鹰教育培训中心" + DateTime.Now.AddMonths(-1).ToString("yyyy年M月") + "工资表";
            this.teacherWagesTableAdapter.FillByLastMonth(this.teacherWageDataSet.TeacherWages);
        }

        private void teacherWagesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (teacherWagesBindingSource.Position < 0)
                return;
            string checkName = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<string>("CheckName");
            if (checkName != null && !"".Equals(checkName))
            {
                btnTeacherCheckWage.Enabled = false;
                btnUpdateSalary.Enabled = false;
            }
            else
            {
                btnTeacherCheckWage.Enabled = true;
                if (User.CurrentUser.UserType > 1)
                {
                    btnUpdateSalary.Enabled = true;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            WagePrintForm frmWagePrint = new WagePrintForm();
            frmWagePrint.printTitle = printTitle;
            frmWagePrint.dataGridView = dgvTeacherWages;
            frmWagePrint.treeView = wageColumnsTree;
            frmWagePrint.totalWages = decimal.Parse(txtTotalRealWages.Text);
            frmWagePrint.ShowDialog();
        }

        private void btnPrintDetail_Click(object sender, EventArgs e)
        {
            if (teacherWagesBindingSource.Position < 0)
                return;
            int teacherID = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<int>("TeacherID");
            string teacherName = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<string>("TeacherName");
            int logID = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<int>("LogID");
            double shouldWages = 0.0;
            double realWages = 0.0;
            if (!teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].IsNull("ShouldWages"))
                shouldWages += (double)teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<decimal>("ShouldWages");
            if (!teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].IsNull("RealWages"))
                realWages += (double)teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<decimal>("RealWages");
            DateTime wageTime = teacherWageDataSet.TeacherWages.Rows[teacherWagesBindingSource.Position].Field<DateTime>("WageTime");
            WageDetailPrintForm frmWageDetailPrint = new WageDetailPrintForm();
            frmWageDetailPrint.LogID = logID;
            frmWageDetailPrint.TeacherID = teacherID;
            frmWageDetailPrint.TeacherName = teacherName;
            frmWageDetailPrint.printTitle = "海鹰教育培训中心" + FirstDayOfMonth(wageTime).ToString("yyyy年M月d日") + "至" + LastDayOfMonth(wageTime).ToString("yyyy年M月d日") + "教师工资信息表";
            frmWageDetailPrint.shouldWages = shouldWages;
            frmWageDetailPrint.realWages = realWages;
            frmWageDetailPrint.ShowDialog();
        }

        /// <summary>  
        /// 取得某月的第一天  
        /// </summary>  
        /// <param name="datetime">要取得月份第一天的时间</param>  
        /// <returns></returns>  
        private DateTime FirstDayOfMonth(DateTime datetime)
        {  
            return datetime.AddDays(1 - datetime.Day);  
        }  
  
        /// <summary>  
        /// 取得某月的最后一天  
        /// </summary>  
        /// <param name="datetime">要取得月份最后一天的时间</param>  
        /// <returns></returns>  
        private DateTime LastDayOfMonth(DateTime datetime)  
        {
            return datetime.AddDays(1 - datetime.Day).AddMonths(1).AddDays(-1);  
        }

        private void teachersBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (teachersDataSet.Tearchers.Rows.Count < 0)
            {
                btnUpdateTeacher.Enabled = false;
                btnDelTeacher.Enabled = false;
            }
            else
            {
                btnUpdateTeacher.Enabled = true;
                btnDelTeacher.Enabled = true;
            }
        }

        private void dgvTeachers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvTeachers.Rows.Count > 0)
                for (int i = 0; i < dgvTeachers.Rows.Count; i++)
                {
                    dgvTeachers.Rows[i].Cells[0].Value = i + 1;
                }
        }
    }
}
