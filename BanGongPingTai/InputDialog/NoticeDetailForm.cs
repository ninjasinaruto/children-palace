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
    public partial class NoticeDetailForm : Form
    {
        private int noticeId;

        public NoticeDetailForm(int noticeId = 0)
        {
            InitializeComponent();
            this.noticeId = noticeId;
        }

        private void PublishNewNoticeForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“usersDataSet.Users”中。您可以根据需要移动或删除它。
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

            chkLstUsers.DataSource = usersBindingSource;
            chkLstUsers.DisplayMember = "UserName";
            chkLstUsers.ValueMember = "UserName";

            if (noticeId > 0)
            {
                // Fill the content
                noticesTableAdapter.FillByNoticeId(noticeDataSet.Notices, noticeId);
                txtTitle.Text = noticeDataSet.Notices.Rows[0].Field<string>("NoticeTitle");
                txtContent.Text = noticeDataSet.Notices.Rows[0].Field<string>("NoticeContent");

                // Check the user names
                noticePrivilegeTableAdapter.FillByNoticeId(noticeDataSet.NoticePrivilege, noticeId);
                HashSet<string> userNameSet = new HashSet<string>();
                foreach (DataRow row in noticeDataSet.NoticePrivilege.Rows)
                {
                    userNameSet.Add(row.Field<string>("AllowedUserName"));
                }
                for(int i = 0; i < chkLstUsers.Items.Count; ++i)
                {
                    DataRowView row = chkLstUsers.Items[i] as DataRowView;
                    string allowedUserName = row.Row.Field<string>("UserName");
                    if (userNameSet.Contains(allowedUserName))
                        chkLstUsers.SetItemChecked(i, true);
                }

                txtTitle.ReadOnly = true;
                txtContent.ReadOnly = true;
                chkLstUsers.Enabled = false;
                btnPublish.Visible = false;
                btnCancel.Visible = false;
                this.Text = "查看公告";
                groupBox2.Text = "详细公告信息";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("请输入公告的标题", "标题不可为空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }
            if (chkLstUsers.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请选择可以查看到此公告的用户", "请选择目标用户", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("确认发布吗？", "请确认发布", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            // 输入数据库
            int resultId = (int)noticesTableAdapter.InsertNotice(User.CurrentUser.UserName, DateTime.Now, txtTitle.Text, txtContent.Text);
            foreach (DataRowView row in chkLstUsers.CheckedItems)
            {
                string allowedUserName = row.Row.Field<string>("UserName");
                noticePrivilegeTableAdapter.Insert(resultId, allowedUserName);
            }
            MessageBox.Show("发布成功！", "公告发布成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
