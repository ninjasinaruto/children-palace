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
    public partial class MainForm : Form
    {
        private const string currentVersion = "1.0.5";
        private Form currentForm = null;
        private ToolStripButton currentButton = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 检测版本信息
            softwareVersionTableAdapter.Fill(versionDataSet.SoftwareVersion);
            DataRow[] rows = versionDataSet.SoftwareVersion.Select("SoftwareName = 'BanGongPingTai'");
            if (rows.Length <= 0)
            {
                MessageBox.Show("数据库配置错误，无法找到版本信息！", "数据库配置错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            string latestVersion = rows[0].Field<string>("SoftwareVersion");
            if (latestVersion != currentVersion)
            {
                MessageBox.Show("软件版本过期，当前版本为" + currentVersion + "，请更新至" + latestVersion + "版",
                    "软件版本过期", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // 登录用户
            LoginForm frmLogin = new LoginForm();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }

            // 设置访问权限
            if (User.CurrentUser.UserType == 0)
            {
                // 合作用户
                tsbAffairApproval.Enabled = false;
                tsbFinanceManage.Enabled = false;
                tsbMaterialsManage.Enabled = false;
                tsbTeachersManage.Enabled = false;
                tsbUsersManage.Enabled = false;
                tsbPublishNotice.Enabled = false;
            }
            else if (User.CurrentUser.UserType == 1)
            {
                // 前台用户，无法审批事务，无法管理合作用户
                tsbAffairApproval.Enabled = false;
                tsbPublishNotice.Enabled = false;
                tsbUsersManage.Enabled = false;
            }
            else if (User.CurrentUser.UserType == 3)
            {
                // 董事长用户，无需上报事务
                tsbAffairManage.Enabled = false;
            }

            toolBtnWelcome.Text = "欢迎您：" + User.CurrentUser.UserName;

            // 打开默认页面
            if (User.CurrentUser.UserType >= 2)
            {
                currentForm = new AffairApprovalForm();
                currentForm.MdiParent = this;
                currentForm.Show();
                currentForm.Location = new Point(0, 0);

                currentButton = tsbAffairApproval;
                currentButton.Checked = true;
            }
            else
            {
                currentForm = new AffairManageForm();
                currentForm.MdiParent = this;
                currentForm.Show();
                currentForm.Location = new Point(0, 0);

                currentButton = tsbAffairManage;
                currentButton.Checked = true;
            }
        }

        private void tsbTeachersManage_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = new TeachersManageForm();
            currentForm.MdiParent = this;
            currentForm.WindowState = FormWindowState.Maximized;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbTeachersManage;
            currentButton.Checked = true;
        }

        private void tsbMaterialsManage_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = new MaterialsManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbMaterialsManage;
            currentButton.Checked = true;
        }

        private void tsbFinanceManage_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = new FinanceManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbFinanceManage;
            currentButton.Checked = true;
        }

        private void tsbUsersManage_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = new UsersManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbUsersManage;
            currentButton.Checked = true;
        }

        private void tsbAffairManage_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = new AffairManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbAffairManage;
            currentButton.Checked = true;
        }

        private void tsbAffairApproval_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = new AffairApprovalForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbAffairApproval;
            currentButton.Checked = true;
        }

        private void tsbPublishNotice_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = new PublishNoticeForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbPublishNotice;
            currentButton.Checked = true;
        }

        private void tsbPasswordUpdate_Click(object sender, EventArgs e)
        {
            PasswordUpdateForm frmPasswordUpdate = new PasswordUpdateForm();
            if (frmPasswordUpdate.ShowDialog() != DialogResult.OK)
                return;
            MessageBox.Show("密码修改成功！", "密码修改成功", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
