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
    public partial class CostListForm : Form
    {
        public string UserName;
        public int UserType;

        public CostListForm()
        {
            InitializeComponent();
        }

        private void CostListForm_Load(object sender, EventArgs e)
        {
            if (UserType == 0)
            {
                // 仅显示本月已授权
                DateTime beginDate = DateTime.Now;
                beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByUserNameBeginDate(this.costListDataSet.CostList, this.UserName, beginDate);
            }
            else
            {
                // 显示本月
                DateTime beginDate = DateTime.Now;
                beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByBeginDate(this.costListDataSet.CostList, beginDate);
            }
        }

        private void CostListForm_Resize(object sender, EventArgs e)
        {
            dgvCost.Height = this.Size.Height - 150;
            dgvCost.Width = this.Size.Width - 20;
        }

        private void costListBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int totalCost = 0;
            int totalPaid = 0;
            foreach (DataRow row in costListDataSet.CostList.Rows)
            {
                totalCost += row.Field<int>("CostAmount");
                totalPaid += row.Field<int>("ActualCostAmount");
            }
            txtTotalCost.Text = totalCost.ToString();
            txtTotalPaid.Text = totalPaid.ToString();
        }

        private void btnShowThisMonthDeposit_Click(object sender, EventArgs e)
        {
            if (UserType == 0)
            {
                // 仅显示本月已授权
                DateTime beginDate = DateTime.Now;
                beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByUserNameBeginDate(this.costListDataSet.CostList, this.UserName, beginDate);
            }
            else
            {
                // 显示本月
                DateTime beginDate = DateTime.Now;
                beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByBeginDate(this.costListDataSet.CostList, beginDate);
            }
        }

        private void btnShowAllDeposit_Click(object sender, EventArgs e)
        {
            if (UserType == 0)
            {
                // 仅显示已授权
                this.costListTableAdapter.FillByUserName(this.costListDataSet.CostList, this.UserName);
            }
            else
            {
                // 显示所有
                this.costListTableAdapter.Fill(this.costListDataSet.CostList);
            }
        }

        private void btnShowFilterDeposit_Click(object sender, EventArgs e)
        {
            if (UserType == 0)
            {
                // 仅显示过滤已授权
                DateTime beginDate = dtDepositBeginDate.Value;
                beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
                DateTime endDate = dtDepositEndDate.Value;
                endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
                this.costListTableAdapter.FillByUserNameBeginEndDate(this.costListDataSet.CostList, this.UserName, beginDate, endDate);
            }
            else
            {
                // 显示过滤
                DateTime beginDate = dtDepositBeginDate.Value;
                beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
                DateTime endDate = dtDepositEndDate.Value;
                endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
                this.costListTableAdapter.FillByBeginEndDate(this.costListDataSet.CostList, beginDate, endDate);
            }
        }
    }
}
