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
    public partial class GetStudentNameForm : Form
    {
        public string StudentName;

        public GetStudentNameForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入学生姓名", "请输入学生姓名", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            StudentName = txtName.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void GetStudentNameForm_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
