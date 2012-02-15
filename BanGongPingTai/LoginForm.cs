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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名", "请输入用户名", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "请输入密码", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            DataRow[] rows = usersDataSet.Users.Select("UserName = '" + txtUserName.Text.Trim() + "'");
            if (rows.Length <= 0 || rows[0].Field<string>("Password") != txtPassword.Text )
            {
                MessageBox.Show("用户名或密码无效，请重新输入", "用户名或密码无效，请重新输入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtUserName.Focus();
                return;
            }

            // 更新User信息
            User.CurrentUser.UserName = txtUserName.Text;
            User.CurrentUser.Password = txtPassword.Text;
            User.CurrentUser.UserType = rows[0].Field<int>("UserType");
            this.DialogResult = DialogResult.OK;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“usersDataSet.Users”中。您可以根据需要移动或删除它。
            this.usersTableAdapter.FillAllUsers(this.usersDataSet.Users);
        }
    }
}
