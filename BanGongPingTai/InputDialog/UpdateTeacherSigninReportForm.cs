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
    public partial class UpdateTeacherSigninReportForm : Form
    {
        public decimal leave;
        public decimal sickLeave;
        public decimal goOut;
        public int beLate;
        public int leaveEarly;
        public string remark;

        public UpdateTeacherSigninReportForm()
        {
            InitializeComponent();
        }

        private void UpdateTeacherSigninReportForm_Load(object sender, EventArgs e)
        {
            if (leave != 0)
            {
                txtLeave.Text = leave + "";
            }
            if (sickLeave != 0)
            {
                txtSickLeave.Text = sickLeave + "";
            }
            if (goOut != 0)
            {
                txtGoOut.Text = goOut + "";
            }
            if (beLate != 0)
            {
                txtBeLate.Text = beLate + "";
            }
            if (leaveEarly != 0)
            {
                txtLeaveEarly.Text = leaveEarly + "";
            }
            if (remark != null && !"".Equals(remark))
            {
                txtRemark.Text = remark.Trim();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            leave = (decimal)txtLeave.Value;
            sickLeave = (decimal)txtSickLeave.Value;
            goOut = (decimal)txtGoOut.Value;
            beLate = txtBeLate.Value;
            leaveEarly = txtLeaveEarly.Value;
            remark = txtRemark.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
