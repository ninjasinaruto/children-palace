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
    public partial class AffairManageForm : Form
    {
        public AffairManageForm()
        {
            InitializeComponent();
        }

        private void AffairApplyListForm_Load(object sender, EventArgs e)
        {
            this.affairApplyTableAdapter.FillByUserName(this.affairDataSet.AffairApply, User.CurrentUser.UserName);
            this.noticesTableAdapter.FillByAllowedUserName(noticeDataSet.Notices, User.CurrentUser.UserName);
        }

        private void btnApplyNewAffair_Click(object sender, EventArgs e)
        {
            AffairDetailForm affairApplyForm = new AffairDetailForm();
            affairApplyForm.ShowDialog();
            this.affairApplyTableAdapter.FillByUserName(this.affairDataSet.AffairApply, User.CurrentUser.UserName);
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

        private void btnShowNoticeDetail_Click(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count <= 0)
                return;
            int position = Common.Algorithm.GetTablePositionFromDataGridViewRow(dgvNotices.SelectedRows[0],
                noticeDataSet.Notices.Rows);
            ViewNoticeForm frmViewNotice = new ViewNoticeForm(
                noticeDataSet.Notices.Rows[position].Field<int>("ID"));
            frmViewNotice.ShowDialog();
        }

        private void AffairManageForm_Resize(object sender, EventArgs e)
        {
            groupBox2.Width = this.Width - 25;
            groupBox1.Width = this.Width - 25;
            groupBox1.Height = this.Height - 260;
            btnShowNoticeDetail.Left = this.Width - 130;
            dgvNotices.Width = this.Width - 155;
            dgvAffair.Width = this.Width - 43;
            dgvAffair.Height = this.Height - 320;
        }

        private void dgvNotices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvNotices.Rows.Count > 0)
                for (int i = 0; i < dgvNotices.Rows.Count; i++)
                {
                    dgvNotices.Rows[i].Cells[0].Value = i + 1;
                }
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
            }
            if (dgvAffair.Rows.Count > 0)
                for (int i = 0; i < dgvAffair.Rows.Count; i++)
                {
                    dgvAffair.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void btnSearchByApplyDate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.affairApplyTableAdapter.FillByUserNameWithApplyDate(this.affairDataSet.AffairApply, User.CurrentUser.UserName, beginDate, endDate);
        }

        private void btnSearchByCheckDate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.affairApplyTableAdapter.FillByUserNameWithCheckDate(this.affairDataSet.AffairApply, User.CurrentUser.UserName, beginDate, endDate);
        }

        private void btnReplyDate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.affairApplyTableAdapter.FillByUserNameWithApprovalDate(this.affairDataSet.AffairApply, User.CurrentUser.UserName, beginDate, endDate);
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            this.affairApplyTableAdapter.FillByUserName(this.affairDataSet.AffairApply, User.CurrentUser.UserName);
        }
    }
}
