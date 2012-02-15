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

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherAddingForm frmTeachersAdding = new TeacherAddingForm();
            if (frmTeachersAdding.ShowDialog() != DialogResult.OK)
                return;

            teachersTableAdapter.Insert(frmTeachersAdding.Name,
                frmTeachersAdding.Phone, null, frmTeachersAdding.Sex, frmTeachersAdding.Address, 0);
            teachersTableAdapter.Fill(teachersDataSet.Tearchers);
        }

        private void TeachersManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“teachersDataSet.TeacherSalaryAdjust”中。您可以根据需要移动或删除它。
            this.teacherSalaryAdjustTableAdapter.Fill(this.teachersDataSet.TeacherSalaryAdjust);
            // TODO: 这行代码将数据加载到表“teachersDataSet.Tearchers”中。您可以根据需要移动或删除它。
            this.teachersTableAdapter.Fill(this.teachersDataSet.Tearchers);
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

        private void btnChangeSalary_Click(object sender, EventArgs e)
        {
            
        /*
            if (dgvTeachers.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvTeachers.SelectedRows[0];
            SalaryChangeForm frmSalaryChange = new SalaryChangeForm();
            frmSalaryChange.TeacherName = row.Cells["teacherNameColumn"].Value.ToString();
            frmSalaryChange.Sex = row.Cells["sexColumn"].Value.ToString();
            frmSalaryChange.Address = row.Cells["addressColumn"].Value.ToString();
            frmSalaryChange.Phone = row.Cells["phoneColumn"].Value.ToString();
            frmSalaryChange.OriginalSalary = row.Cells["salaryColumn"].Value.ToString();
            if (frmSalaryChange.ShowDialog() != DialogResult.OK)
                return;

            row.Cells["salaryColumn"].Value = frmSalaryChange.NewSalary.ToString();
            // 1> Update teacher salary in database;
            teachersTableAdapter.UpdateSalary(frmSalaryChange.NewSalary, int.Parse(txtID.Text));
            // 2> Insert the update record in database;
            teacherSalaryAdjustTableAdapter.Insert(int.Parse(txtID.Text), frmSalaryChange.AdjustDate,
                frmSalaryChange.NewSalary);
         */
        }
    }
}
