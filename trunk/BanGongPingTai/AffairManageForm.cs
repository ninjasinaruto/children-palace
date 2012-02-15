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
            // Fill affairs by current user
            this.affairApplyTableAdapter.FillByUserName(this.affairDataSet.AffairApply, User.CurrentUser.UserName);
            // Fill notices by current user
            this.noticesTableAdapter.FillByAllowedUserName(noticeDataSet.Notices, User.CurrentUser.UserName);
        }

        private void btnApplyNewAffair_Click(object sender, EventArgs e)
        {
            AffairDetailForm affairApplyForm = new AffairDetailForm();
            affairApplyForm.ShowDialog();
            this.affairApplyTableAdapter.FillByUserName(this.affairDataSet.AffairApply, User.CurrentUser.UserName);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < affairDataSet.AffairApply.Rows.Count; ++i )
            {
                int ApprovalStatus = affairDataSet.AffairApply.Rows[i].Field<int>("Status");
                DataGridViewCell statusCell = dgvAffair.Rows[i].Cells["ApprovalStatusColumn"];
                switch (ApprovalStatus)
                {
                    case 0:
                        statusCell.Value = "审批中";
                        break;
                    case 1:
                        statusCell.Value = "审批通过";
                        break;
                    case 2:
                        statusCell.Value = "审批失败";
                        break;
                }
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
    }
}
