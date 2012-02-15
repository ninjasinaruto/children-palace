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
    public partial class AffairApprovalForm : Form
    {
        public AffairApprovalForm()
        {
            InitializeComponent();
        }

        private void AffairApprovalForm_Load(object sender, EventArgs e)
        {
            this.unprocessedAffairApplyTableAdapter.FillUnprocessedAffairApply(this.affairDataSet.UnprocessedAffairApply, User.CurrentUser.UserType - 1);
            this.affairApplyTableAdapter.FillProcessedByUserType(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (txtApprovalContent.Text.Trim() == "")
            {
                MessageBox.Show("请输入批复的内容", "批复内容不可为空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApprovalContent.Focus();
                return;
            }

            if (MessageBox.Show("确认通过审批吗？", "确认通过审批", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            // 更新记录
            unprocessedAffairApplyTableAdapter.UpdateApprovalStatus(txtApprovalContent.Text, User.CurrentUser.UserName, 1, 
                int.Parse(lstUnprocessed.SelectedValue.ToString()));
            
            // 刷新界面
            txtApprovalContent.Text = "";
            this.unprocessedAffairApplyTableAdapter.FillUnprocessedAffairApply(this.affairDataSet.UnprocessedAffairApply, User.CurrentUser.UserType - 1);
            this.affairApplyTableAdapter.FillProcessedByUserType(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1);
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (txtApprovalContent.Text.Trim() == "")
            {
                MessageBox.Show("请输入批复的内容", "批复内容不可为空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApprovalContent.Focus();
                return;
            }

            if (MessageBox.Show("确认拒绝审批吗？", "确认拒绝审批", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            // 更新记录
            unprocessedAffairApplyTableAdapter.UpdateApprovalStatus(txtApprovalContent.Text, User.CurrentUser.UserName, 2,
                int.Parse(lstUnprocessed.SelectedValue.ToString()));

            // 刷新界面
            txtApprovalContent.Text = "";
            this.unprocessedAffairApplyTableAdapter.FillUnprocessedAffairApply(this.affairDataSet.UnprocessedAffairApply, User.CurrentUser.UserType - 1);
            this.affairApplyTableAdapter.FillProcessedByUserType(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < affairDataSet.AffairApply.Rows.Count; ++i)
            {
                int ApprovalStatus = affairDataSet.AffairApply.Rows[i].Field<int>("Status");
                DataGridViewCell statusCell = dataGridView1.Rows[i].Cells["StatusColumn"];
                switch (ApprovalStatus)
                {
                    case 0:
                        statusCell.Value = "审批中";
                        break;
                    case 1:
                        statusCell.Value = "通过审批";
                        break;
                    case 2:
                        statusCell.Value = "拒绝审批";
                        break;
                }
            }
        }

        private void unprocessedAffairApplyBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (unprocessedAffairApplyBindingSource.Position < 0)
            {
                btnApprove.Enabled = false;
                btnDeny.Enabled = false;
            }
            else
            {
                btnApprove.Enabled = true;
                btnDeny.Enabled = true;
            }
        }

        private void unprocessedAffairApplyBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (unprocessedAffairApplyBindingSource.Count <= 0)
            {
                btnApprove.Enabled = false;
                btnDeny.Enabled = false;
            }
            else
            {
                btnApprove.Enabled = true;
                btnDeny.Enabled = true;
            }
        }
    }
}
