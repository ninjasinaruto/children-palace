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
        public string Password;

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
                MessageBox.Show("请输入姓名！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (txtPasswordConfirm.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPasswordConfirm.Focus();
                return;
            }
            if (!txtPassword.Text.Trim().Equals(txtPasswordConfirm.Text.Trim()))
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.Focus();
                return;
            }
            this.Name = txtName.Text;
            this.Sex = cmbSex.Text;
            this.Address = txtAddress.Text;
            this.Phone = txtPhone.Text;
            this.Password = txtPassword.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
