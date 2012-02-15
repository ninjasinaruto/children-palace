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
    public partial class ClassroomManageForm : Form
    {
        public ClassroomManageForm()
        {
            InitializeComponent();
        }

        private void ClassroomManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“coursesDataSet.Classrooms”中。您可以根据需要移动或删除它。
            this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
        }

        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            if (txtClassroomName.Text == "")
            {
                MessageBox.Show("请输入教室名称", "请输入教室名称", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassroomName.Focus();
                return;
            }

            ConfirmAddClassroomForm frmAddClassroom = new ConfirmAddClassroomForm();
            frmAddClassroom.ClassroomName = txtClassroomName.Text;
            if (frmAddClassroom.ShowDialog() != DialogResult.OK)
                return;

            classroomsTableAdapter.Insert(txtClassroomName.Text);
            this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
            txtClassroomName.Text = "";
            txtClassroomName.Focus();
        }
    }
}
