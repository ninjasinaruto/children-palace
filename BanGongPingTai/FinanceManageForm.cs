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
    public partial class FinanceManageForm : Form
    {
        public FinanceManageForm()
        {
            InitializeComponent();
        }

        private void FinanceManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“financeManageDataSet.MaterialsBuy”中。您可以根据需要移动或删除它。
            this.materialsBuyTableAdapter.Fill(this.financeManageDataSet.MaterialsBuy);

            DateTime beginDate = DateTime.Now;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
            this.depositListTableAdapter.FillByBeginDate(this.depositListDataSet.DepositList, beginDate);

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
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialsBuyBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int originalCost = 0;
            int totalCost = 0;
            foreach (DataRow row in financeManageDataSet.MaterialsBuy.Rows )
            {
                originalCost += row.Field<int>("TotalCost");
                totalCost += row.Field<int>("ActualPay");
            }

            txtMaterialsCost.Text = totalCost.ToString();
            txtOriginalCost.Text = originalCost.ToString();
        }

        private void btnShowAllDeposit_Click(object sender, EventArgs e)
        {
            this.depositListTableAdapter.Fill(this.depositListDataSet.DepositList);
        }

        private void btnShowThisMonthDeposit_Click(object sender, EventArgs e)
        {
            DateTime beginDate = DateTime.Now;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
            this.depositListTableAdapter.FillByBeginDate(this.depositListDataSet.DepositList, beginDate);
        }

        private void btnShowFilterDeposit_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtDepositBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtDepositEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.depositListTableAdapter.FillByBeginEndDate(this.depositListDataSet.DepositList, beginDate, endDate);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
