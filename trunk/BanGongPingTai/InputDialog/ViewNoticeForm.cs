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
    public partial class ViewNoticeForm : Form
    {
        private int noticeId;

        public ViewNoticeForm(int noticeId)
        {
            InitializeComponent();
            this.noticeId = noticeId;
        }

        private void ViewNoticeForm_Load(object sender, EventArgs e)
        {
            // Fill the content
            noticesTableAdapter.FillByNoticeId(noticeDataSet.Notices, noticeId);
            txtTitle.Text = noticeDataSet.Notices.Rows[0].Field<string>("NoticeTitle");
            txtContent.Text = noticeDataSet.Notices.Rows[0].Field<string>("NoticeContent");
        }
    }
}
