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
    public partial class TeacherAddingForm : Form
    {
        public string TeacherName;
        public string Sex;
        public string Address;
        public string Phone;

        public TeacherAddingForm()
        {
            InitializeComponent();
        }

        private void TeacherAddingForm_Load(object sender, EventArgs e)
        {
            cmbSex.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入教师姓名", "请输入教师姓名", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            this.Name = txtName.Text;
            this.Sex = cmbSex.Text;
            this.Address = txtAddress.Text;
            this.Phone = txtPhone.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
