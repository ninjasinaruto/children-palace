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
            this.teacherWagesTableAdapter.FillByID(this.teacherWageDataSet.TeacherWages);
            this.teachersTableAdapter.Fill(this.teachersDataSet.Tearchers);
            if (teachersDataSet.Tearchers.Rows.Count > 0)
            {
                teacherCoursesTableAdapter.Fill(teachersDataSet.TeacherCourses,
                    teachersDataSet.Tearchers.Rows[0].Field<int>("ID"));
            }
            dgvTeacherWages.ColHeaderTreeView = wageColumnsTree;
        }

        private void TeachersManageForm_Resize(object sender, EventArgs e)
        {
            dgvTeacherWages.Width = this.Width - 630;
            dgvTeacherWages.Height = this.Height - 130;
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
                frmTeachersAdding.Phone, null, frmTeachersAdding.Sex, frmTeachersAdding.Address, 0, frmTeachersAdding.Password);
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
            frmTeacherUpdate.Password = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<string>("Password");
            if (frmTeacherUpdate.ShowDialog() != DialogResult.OK)
                return;
            int teacherID = teachersDataSet.Tearchers.Rows[teachersBindingSource.Position].Field<int>("ID");
            teachersTableAdapter.UpdateByID(frmTeacherUpdate.TeacherName, frmTeacherUpdate.Phone, frmTeacherUpdate.Sex, frmTeacherUpdate.Address, frmTeacherUpdate.Password, teacherID);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //dgVprint1.MainTitle = "供应商明细表";
            //dgVprint1.SubTitle = "这是子标题，当然也可以不设的";
            //dgVprint1.PaperLandscape = true;//用横向打印，默认是纵向哦
            //dgVprint1.Print(this.dgvTeacherWages, wageColumnsTree);
            PrintForm newform;
            newform = new PrintForm();
            //传递要打印的内容
            newform.dataGridView = dgvTeacherWages;
            newform.treeView = wageColumnsTree;
            newform.ShowDialog();//请注意Form2中编写的实现代码
        }
    }
}
