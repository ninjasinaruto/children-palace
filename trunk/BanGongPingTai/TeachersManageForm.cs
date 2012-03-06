using System;
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

        public TeachersManageForm()
        {
            InitializeComponent();
        }

        private void TeachersManageForm_Load(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Fill(this.teachersDataSet.Tearchers);
            if (teachersDataSet.Tearchers.Rows.Count > 0)
            {
                teacherCoursesTableAdapter.Fill(teachersDataSet.TeacherCourses,
                    teachersDataSet.Tearchers.Rows[0].Field<int>("ID"));
            }
        }

        private void TeachersManageForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 630;
            dataGridView1.Height = this.Height - 85;
            dgvTeachers.Height = this.Height - 360;
            btnAddTeacher.Top = this.Height - 90;
            btnUpdateTeacher.Top = this.Height - 90;
            btnDelTeacher.Top = this.Height - 90;
            btnConnectCard.Top = this.Height - 90;
            btnAddSalary.Top = this.Height - 90;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherAddingForm frmTeachersAdding = new TeacherAddingForm();
            if (frmTeachersAdding.ShowDialog() != DialogResult.OK)
                return;

            teachersTableAdapter.Insert(frmTeachersAdding.Name,
                frmTeachersAdding.Phone, null, frmTeachersAdding.Sex, frmTeachersAdding.Address, 0);
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
            TeacherUpdateForm frmTeacherUpdate = new TeacherUpdateForm();
            frmTeacherUpdate.TeacherName = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Name");
            frmTeacherUpdate.Sex = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Sex");
            frmTeacherUpdate.Address = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Address");
            frmTeacherUpdate.Phone = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Phone");
            if (frmTeacherUpdate.ShowDialog() != DialogResult.OK)
                return;
            int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
            teachersTableAdapter.UpdateByID(frmTeacherUpdate.TeacherName, frmTeacherUpdate.Phone, frmTeacherUpdate.Sex, frmTeacherUpdate.Address, teacherID);
            teachersTableAdapter.Fill(teachersDataSet.Tearchers);
            if (rowIndex >= 0)
            {
                this.dgvTeachers.Rows[rowIndex].Selected = true;
                this.dgvTeachers.CurrentCell = this.dgvTeachers.Rows[rowIndex].Cells[0];
            }
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
            // 获取卡号
            CardConnectForm frmCardConnect = new CardConnectForm();
            frmCardConnect.ShowDialog();
            if (frmCardConnect.cardNo == "")
                return;

            // 更新卡号信息
            teachersTableAdapter.UpdateCardNo(frmCardConnect.cardNo, int.Parse(txtID.Text));

            // 刷新界面
            this.teachersTableAdapter.Fill(this.teachersDataSet.Tearchers);
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

            // 新增基本工资
            for (int i = 0; i < basicWageList.Count; i++)
            {
                teacherBasicWageTableAdapter.Insert(teacherID, basicWageList[i].WageType, (decimal)basicWageList[i].WageStandard,
                    basicWageList[i].WageNum, (decimal)basicWageList[i].WageAmount, basicWageList[i].Remark, wageTime,
                    User.CurrentUser.UserName);
            }
            // 新增系数
            teacherCoefficientTableAdapter.Insert(teacherID, courseWageCoefficient, wageTime, User.CurrentUser.UserName);
            // 新增课量工资
            for (int i = 0; i < courseWageList.Count; i++)
            {
                teacherCourseWageTableAdapter.Insert(teacherID, courseWageList[i].CourseType, courseWageList[i].CourseNum,
                    (decimal)courseWageList[i].StandardPrice, (decimal)courseWageList[i].ActualPrice, (decimal)courseWageList[i].CourseAmount,
                    courseWageList[i].Remark, wageTime, User.CurrentUser.UserName);
            }
            // 新增学生管理奖
            teacherStudentAwardTableAdapter.Insert(teacherID, studentAward.TotalStudent, studentAward.ActualStudent, (decimal)studentAward.StandardPrice,
                (decimal)studentAward.ActualPrice, (decimal)studentAward.Amount, wageTime, User.CurrentUser.UserName);
            // 新增奖励工资
            for (int i = 0; i < teacherAwardList.Count; i++)
            {
                teacherAwardTableAdapter.Insert(teacherID, teacherAwardList[i].AwardName, (decimal)teacherAwardList[i].StandardPrice,
                    (decimal)teacherAwardList[i].ActualPrice, teacherAwardList[i].AwardNum, (decimal)teacherAwardList[i].AwardAmount,
                    teacherAwardList[i].Remark, wageTime, User.CurrentUser.UserName);
            }
            // 新增扣款
            for (int i = 0; i < chargeBackList.Count; i++)
            {
                teacherChargeBackTableAdapter.Insert(teacherID, chargeBackList[i].ChargeBackName, chargeBackList[i].ChargeBackType,
                    (decimal)chargeBackList[i].StandardPrice, chargeBackList[i].ChargeBackNum, (decimal)chargeBackList[i].ChargeBackAmount,
                    chargeBackList[i].Remark, wageTime, User.CurrentUser.UserName);
            }
            MessageBox.Show("添加工资成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void dgvTeachers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dgvTeachers.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dgvTeachers.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }

        private void dgvTeacherCourses_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dgvTeacherCourses.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dgvTeacherCourses.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }
    }
}
