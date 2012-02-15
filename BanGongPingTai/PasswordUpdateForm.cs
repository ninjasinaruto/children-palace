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
    public partial class PasswordUpdateForm : Form
    {
        public PasswordUpdateForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOriginalPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入原密码", "原密码不可为空", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtOriginalPassword.Focus();
                return;
            }

            if (txtNewPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入新密码", "新密码不可为空", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("两次输入的密码不相同", "两次输入的密码不相同", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtNewPassword.Focus();
                return;
            }

            if (txtOriginalPassword.Text != User.CurrentUser.Password)
            {
                MessageBox.Show("输入的原密码错误", "原密码错误", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtOriginalPassword.Focus();
                return;
            }

            User.CurrentUser.UpdatePassword(txtNewPassword.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PasswordUpdateForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = User.CurrentUser.UserName;
        }
    }
}
