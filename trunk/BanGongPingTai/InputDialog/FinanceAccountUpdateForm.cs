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
    public partial class FinanceAccountUpdateForm : Form
    {
        public DateTime createDate;
        public string summary;
        public double income;
        public double pay;
        public string remark;

        public FinanceAccountUpdateForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSummary.Text.Trim() == "")
            {
                MessageBox.Show("请输入摘要！", "提示", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                txtSummary.Focus();
                return;
            }
            this.createDate = dtCreateDate.Value;
            this.summary = txtSummary.Text;
            this.income = txtIncome.Value;
            this.pay = txtPay.Value;
            this.remark = txtRemark.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FinanceAccountUpdateForm_Load(object sender, EventArgs e)
        {
            dtCreateDate.Value = createDate;
            txtSummary.Text = summary;
            txtIncome.Text = income + "";
            txtPay.Text = pay + "";
            txtRemark.Text = remark;
        }
    }
}
