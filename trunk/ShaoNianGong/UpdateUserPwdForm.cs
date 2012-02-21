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
    public partial class UpdateUserPwdForm : Form
    {
        public UpdateUserPwdForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateUserPwdForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.usersDataSet._Users);
            lblUserName.Text = User.CurrentUser.UserName;
            txtOldPwd.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOldPwd.Text.Trim();
            if (oldPwd.Length == 0)
            {
                MessageBox.Show("旧密码不可为空！");
                txtOldPwd.Focus();
                return;
            }
            string newPwd = txtNewPwd.Text.Trim();
            if (newPwd.Length == 0)
            {
                MessageBox.Show("新密码不可为空！");
                txtNewPwd.Focus();
                return;
            }
            string newPwd2 = txtNewPwd2.Text.Trim();
            if (newPwd2.Length == 0)
            {
                MessageBox.Show("确认新密码不可为空！");
                txtNewPwd2.Focus();
                return;
            }
            if (oldPwd.Equals(User.CurrentUser.Password))
            {
                if (newPwd2.Equals(newPwd))
                {
                    this.usersTableAdapter.UpdateUserPwd(newPwd, User.CurrentUser.UserName);
                    User.CurrentUser.Password = newPwd;
                    MessageBox.Show("密码修改成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致，请检查！");
                    txtNewPwd2.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("旧密码不正确！");
                txtOldPwd.Focus();
                return;
            }
        }
    }
}
