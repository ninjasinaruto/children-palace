using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShaoNianGong
{
    public partial class DepositListForm : Form
    {
        public DepositListForm()
        {
            InitializeComponent();
        }

        private void DepositListForm_Load(object sender, EventArgs e)
        {
            //DateTime beginDate = DateTime.Now;
            //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
            //this.depositListTableAdapter.FillByBeginDate(this.depositListDataSet.DepositList, beginDate);
            this.depositListTableAdapter.FillByYMOfDate(this.depositListDataSet.DepositList);
            txtShowRange.Text = "本月";
        }

        private void DepositListForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height - 192;
        }

        private void depositListBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int totalDeposit = 0;
            int totalPaid = 0;
            foreach (DataRow row in depositListDataSet.DepositList.Rows)
            {
                totalDeposit += row.Field<int>("DepositAmount");
                totalPaid += row.Field<int>("ActualPaidAmount");
            }

            txtTotalDeposit.Text = totalDeposit.ToString();
            txtTotalPaid.Text = totalPaid.ToString();
            lblDepositCount.Text = this.depositListDataSet.DepositList.Rows.Count + "条";
        }

        private void btnShowAllDeposit_Click(object sender, EventArgs e)
        {
            this.depositListTableAdapter.Fill(this.depositListDataSet.DepositList);
            txtShowRange.Text = "所有";
        }

        private void btnShowThisMonthDeposit_Click(object sender, EventArgs e)
        {
            //DateTime beginDate = DateTime.Now;
            //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
            //this.depositListTableAdapter.FillByBeginDate(this.depositListDataSet.DepositList, beginDate);
            this.depositListTableAdapter.FillByYMOfDate(this.depositListDataSet.DepositList);
            txtShowRange.Text = "本月";
        }

        private void btnShowFilterDeposit_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtDepositBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtDepositEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.depositListTableAdapter.FillByBeginEndDate(this.depositListDataSet.DepositList, beginDate, endDate);
            txtShowRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }
    }
}
