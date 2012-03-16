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
                MessageBox.Show("请输入回复的内容！", "回复内容不可为空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApprovalContent.Focus();
                return;
            }

            if (MessageBox.Show("确认回复该事务吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            if (btnCheck.Enabled)
            {
                unprocessedAffairApplyTableAdapter.UpdateCheckAndApproval(txtApprovalContent.Text, User.CurrentUser.UserName, int.Parse(lstUnprocessed.SelectedValue.ToString()));
            }
            else
            {
                unprocessedAffairApplyTableAdapter.UpdateApprovalStatus(txtApprovalContent.Text, User.CurrentUser.UserName, int.Parse(lstUnprocessed.SelectedValue.ToString()));
            }

            txtApprovalContent.Text = "";
            this.unprocessedAffairApplyTableAdapter.FillUnprocessedAffairApply(this.affairDataSet.UnprocessedAffairApply, User.CurrentUser.UserType - 1);
            this.affairApplyTableAdapter.FillProcessedByUserType(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认签收该事务吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            unprocessedAffairApplyTableAdapter.UpdateCheckStatus(User.CurrentUser.UserName, int.Parse(lstUnprocessed.SelectedValue.ToString()));

            this.unprocessedAffairApplyTableAdapter.FillUnprocessedAffairApply(this.affairDataSet.UnprocessedAffairApply, User.CurrentUser.UserType - 1);
            this.affairApplyTableAdapter.FillProcessedByUserType(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1);
        }

        private void unprocessedAffairApplyBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (unprocessedAffairApplyBindingSource.Position < 0)
            {
                btnApprove.Enabled = false;
                btnCheck.Enabled = false;
            }
            else
            {
                btnApprove.Enabled = true;
                {
                    int status = this.affairDataSet.UnprocessedAffairApply.Rows[unprocessedAffairApplyBindingSource.Position].Field<int>("Status");
                    if (status == 0)
                    {
                        btnCheck.Enabled = true;
                    }
                    else {
                        btnCheck.Enabled = false; 
                    }
                }
            }
        }

        private void unprocessedAffairApplyBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (unprocessedAffairApplyBindingSource.Count <= 0)
            {
                btnApprove.Enabled = false;
                btnCheck.Enabled = false;
            }
            else
            {
                btnApprove.Enabled = true;
                {
                    int status = this.affairDataSet.UnprocessedAffairApply.Rows[unprocessedAffairApplyBindingSource.Position].Field<int>("Status");
                    if (status == 0)
                    {
                        btnCheck.Enabled = true;
                    }
                    else
                    {
                        btnCheck.Enabled = false;
                    }
                }
            }
        }

        private void AffairApprovalForm_Resize(object sender, EventArgs e)
        {
            dgvAffair.Width = this.Width - 25;
            dgvAffair.Height = this.Height - 440;
        }

        private void dgvAffair_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < affairDataSet.AffairApply.Rows.Count; ++i)
            {
                int ApprovalStatus = affairDataSet.AffairApply.Rows[i].Field<int>("Status");
                DataGridViewCell statusCell = dgvAffair.Rows[i].Cells["ApprovalStatusColumn"];
                switch (ApprovalStatus)
                {
                    case 0:
                        statusCell.Value = "待签收";
                        break;
                    case 1:
                        statusCell.Value = "待回复";
                        break;
                    case 2:
                        statusCell.Value = "已完成";
                        break;
                }
                dgvAffair.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnShowAffairDetail_Click(object sender, EventArgs e)
        {
            if (dgvAffair.SelectedRows.Count <= 0)
                return;

            int position = Common.Algorithm.GetTablePositionFromDataGridViewRow(dgvAffair.SelectedRows[0],
                affairDataSet.AffairApply.Rows);
            AffairDetailForm frmViewAffair = new AffairDetailForm(
                affairDataSet.AffairApply.Rows[position].Field<int>("ID"));
            frmViewAffair.ShowDialog();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            this.affairApplyTableAdapter.FillProcessedByUserType(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1);
        }

        private void btnSearchByApplyDate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.affairApplyTableAdapter.FillByProcessedByUserTypeWithApplyDate(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1, beginDate, endDate);
        }

        private void btnSearchByCheckDate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.affairApplyTableAdapter.FillByProcessedByUserTypeWithCheckDate(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1, beginDate, endDate);
        }

        private void btnReplyDate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.affairApplyTableAdapter.FillByProcessedByUserTypeWithApprovalDate(this.affairDataSet.AffairApply, User.CurrentUser.UserType - 1, beginDate, endDate);
        }
    }
}
