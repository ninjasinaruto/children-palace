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
    public partial class PublishNoticeForm : Form
    {
        public PublishNoticeForm()
        {
            InitializeComponent();
        }

        private void btnPublishNewNotice_Click(object sender, EventArgs e)
        {
            NoticeDetailForm frmPublishNew = new NoticeDetailForm();
            frmPublishNew.ShowDialog();

            noticesTableAdapter.Fill(noticeDataSet.Notices, User.CurrentUser.UserName);
        }

        private void PublishNoticeForm_Load(object sender, EventArgs e)
        {
            noticesTableAdapter.Fill(noticeDataSet.Notices, User.CurrentUser.UserName);
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count <= 0)
                return;
            int position = Common.Algorithm.GetTablePositionFromDataGridViewRow(dgvNotices.SelectedRows[0],
                noticeDataSet.Notices.Rows);
            NoticeDetailForm frmViewNotice = new NoticeDetailForm(
                noticeDataSet.Notices.Rows[position].Field<int>("ID"));
            frmViewNotice.ShowDialog();
        }

        private void noticesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (noticesBindingSource.Count <= 0)
                btnShowDetail.Enabled = false;
            else
                btnShowDetail.Enabled = true;
        }

        private void noticesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (noticesBindingSource.Position < 0)
                btnShowDetail.Enabled = false;
            else
                btnShowDetail.Enabled = true;   
        }
    }
}
