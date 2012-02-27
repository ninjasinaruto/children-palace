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
    public partial class ClassroomUpdateForm : Form
    {
        public string ClassroomName;

        public ClassroomUpdateForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClassroomUpdateForm_Load(object sender, EventArgs e)
        {
            txtClassroomName.Text = ClassroomName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtClassroomName.Text == "")
            {
                MessageBox.Show("请输入教室名称", "请输入教室名称", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassroomName.Focus();
                return;
            }
            ClassroomName = txtClassroomName.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }
    }
}
