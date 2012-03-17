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
    public partial class FinanceAccountForm : Form
    {
        public FinanceAccountForm()
        {
            InitializeComponent();
        }

        private void FinanceAccountForm_Resize(object sender, EventArgs e)
        {
            this.groupBox1.Left = 20;
            this.groupBox1.Width = this.Width / 2 - 30;
            this.groupBox1.Height = this.Height - 70;
            this.dgvFinanceByPXZX.Width = this.Width / 2 - 65;
            this.dgvFinanceByPXZX.Height = this.Height - 210;
            this.panel1.Top = this.Height - 120;
            this.groupBox2.Left = this.Width / 2 + 10;
            this.groupBox2.Width = this.Width / 2 - 30;
            this.groupBox2.Height = this.Height - 70;
            this.dgvFinanceByHYJY.Width = this.Width / 2 - 65;
            this.dgvFinanceByHYJY.Height = this.Height - 210;
            this.panel2.Top = this.Height - 120; 
        }

        private void FinanceAccountForm_Load(object sender, EventArgs e)
        {
            this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
            this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
            txtShowRangeByPXZX.Text = "所有";
            if (User.CurrentUser.UserType > 1)
            {
                this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
                this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
                txtShowRangeByHYJY.Text = "所有";
                this.groupBox2.Visible = true;
            }
            else
            {
                this.groupBox2.Visible = false;
            }
        }

        private void btnSearchAllByPXZX_Click(object sender, EventArgs e)
        {
            this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
            this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
            txtShowRangeByPXZX.Text = "所有";
        }

        private void btnSearchAllByHYJY_Click(object sender, EventArgs e)
        {
            this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType+1);
            this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType+1);
            txtShowRangeByHYJY.Text = "所有";
        }

        private void btnSearchMonthByPXZX_Click(object sender, EventArgs e)
        {
            this.financialAccountsPXZXTableAdapter.FillByAccountTypeWithMonth(this.financeManageDataSet.FinancialAccountsPXZX);
            this.financeAmountPXZXTableAdapter.FillByMonth(this.financeManageDataSet.FinanceAmountPXZX);
            txtShowRangeByPXZX.Text = "本月";
        }

        private void btnSearchMonthByHYJY_Click(object sender, EventArgs e)
        {
            this.financialAccountsHYJYTableAdapter.FillByAccountTypeWithMonth(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType+1);
            this.financeAmountHYJYTableAdapter.FillByMonth(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType+1);
            txtShowRangeByHYJY.Text = "本月";
        }

        private void btnSearchByPXZX_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDateByPXZX.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDateByPXZX.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.financialAccountsPXZXTableAdapter.FillByAccountTypeWithDate(this.financeManageDataSet.FinancialAccountsPXZX, beginDate, endDate);
            this.financeAmountPXZXTableAdapter.FillByBeginEndDate(this.financeManageDataSet.FinanceAmountPXZX, endDate);
            txtShowRangeByPXZX.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void btnSearchByHYJY_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDateByHYJY.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEndDateByHYJY.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.financialAccountsHYJYTableAdapter.FillByAccountTypeWithDate(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1, beginDate, endDate);
            this.financeAmountHYJYTableAdapter.FillByBeginEndDate(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType+1, endDate);
            txtShowRangeByHYJY.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void dgvFinanceByPXZX_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvFinanceByPXZX.Rows.Count > 0)
                for (int i = 0; i < dgvFinanceByPXZX.Rows.Count; i++)
                {
                    dgvFinanceByPXZX.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void dgvFinanceByHYJY_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvFinanceByHYJY.Rows.Count > 0)
                for (int i = 0; i < dgvFinanceByHYJY.Rows.Count; i++)
                {
                    dgvFinanceByHYJY.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void FinancePXZXBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblCountByPXZX.Text = this.financeManageDataSet.FinancialAccountsPXZX.Rows.Count + "条";
            if (this.financeManageDataSet.FinancialAccountsPXZX.Rows.Count == 0)
            {
                btnCheckByPXZX.Enabled = false;
                btnDelByPXZX.Enabled = false;
                btnUpdateByPXZX.Enabled = false;
            }
            else
            {
                btnDelByPXZX.Enabled = true;
            }
        }

        private void FinanceHYJYBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblCountByHYJY.Text = this.financeManageDataSet.FinancialAccountsHYJY.Rows.Count + "条";
            if (this.financeManageDataSet.FinancialAccountsHYJY.Rows.Count == 0)
            {
                btnCheckByHYJY.Enabled = false;
                btnDelByHYJY.Enabled = false;
                btnUpdateByHYJY.Enabled = false;
            }
            else
            {
                btnDelByHYJY.Enabled = true;
            }
        }

        private void btnAddByPXZX_Click(object sender, EventArgs e)
        {
            addFinanceAccount(1);
        }

        private void btnUpdateByPXZX_Click(object sender, EventArgs e)
        {
            if (this.FinancePXZXBindingSource.Position < 0)
                return;
            int ID = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<int>("ID");
            DateTime createDate = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<DateTime>("CreateDate");
            string summary = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<string>("Summary");
            decimal income = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<decimal>("Income");
            decimal pay = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<decimal>("Pay");
            string remark = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<string>("Remark");
            FinanceAccountUpdateForm frmFinanceAccountUpdate = new FinanceAccountUpdateForm();
            frmFinanceAccountUpdate.createDate = createDate;
            frmFinanceAccountUpdate.summary = summary;
            frmFinanceAccountUpdate.income = (double)income;
            frmFinanceAccountUpdate.pay = (double)pay;
            frmFinanceAccountUpdate.remark = remark;
            if (frmFinanceAccountUpdate.ShowDialog() != DialogResult.OK)
                return;
            this.financialAccountsPXZXTableAdapter.UpdateWithoutCheck(frmFinanceAccountUpdate.remark, (decimal)frmFinanceAccountUpdate.income, (decimal)frmFinanceAccountUpdate.pay,
                frmFinanceAccountUpdate.remark, frmFinanceAccountUpdate.createDate, ID);
            this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
            this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
            txtShowRangeByPXZX.Text = "所有";
            if (User.CurrentUser.UserType > 1)
            {
                this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
                this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
                txtShowRangeByHYJY.Text = "所有";
            }
        }

        private void btnDelByPXZX_Click(object sender, EventArgs e)
        {
            if (this.FinancePXZXBindingSource.Position < 0)
                return;
            if (MessageBox.Show("您确定要删除该条明细吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int ID = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<int>("ID");
                this.financialAccountsPXZXTableAdapter.DeleteByID(ID);
                this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
                this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
                txtShowRangeByPXZX.Text = "所有";
                if (User.CurrentUser.UserType > 1)
                {
                    this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
                    this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
                    txtShowRangeByHYJY.Text = "所有";
                }
            }
        }

        private void btnCheckByPXZX_Click(object sender, EventArgs e)
        {
            if (this.FinancePXZXBindingSource.Position < 0)
                return;
            if (MessageBox.Show("您确定要审核该条明细吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int ID = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<int>("ID");
                this.financialAccountsPXZXTableAdapter.UpdateByCheck(User.CurrentUser.UserName, ID);
                this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
                this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
                txtShowRangeByPXZX.Text = "所有";
                if (User.CurrentUser.UserType > 1)
                {
                    this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
                    this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
                    txtShowRangeByHYJY.Text = "所有";
                }
            }
        }

        private void btnAddByHYJY_Click(object sender, EventArgs e)
        {
            addFinanceAccount(2);
        }

        private void btnUpdateByHYJY_Click(object sender, EventArgs e)
        {
            if (this.FinanceHYJYBindingSource.Position < 0)
                return;
            int ID = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<int>("ID");
            DateTime createDate = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<DateTime>("CreateDate");
            string summary = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<string>("Summary");
            decimal income = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<decimal>("Income");
            decimal pay = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<decimal>("Pay");
            string remark = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<string>("Remark");
            FinanceAccountUpdateForm frmFinanceAccountUpdate = new FinanceAccountUpdateForm();
            frmFinanceAccountUpdate.createDate = createDate;
            frmFinanceAccountUpdate.summary = summary;
            frmFinanceAccountUpdate.income = (double)income;
            frmFinanceAccountUpdate.pay = (double)pay;
            frmFinanceAccountUpdate.remark = remark;
            if (frmFinanceAccountUpdate.ShowDialog() != DialogResult.OK)
                return;
            this.financialAccountsPXZXTableAdapter.UpdateWithoutCheck(frmFinanceAccountUpdate.remark, (decimal)frmFinanceAccountUpdate.income, (decimal)frmFinanceAccountUpdate.pay,
                frmFinanceAccountUpdate.remark, frmFinanceAccountUpdate.createDate, ID);
            this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
            this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
            txtShowRangeByPXZX.Text = "所有";
            this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
            this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
            txtShowRangeByHYJY.Text = "所有";
        }

        private void btnDelByHYJY_Click(object sender, EventArgs e)
        {
            if (this.FinanceHYJYBindingSource.Position < 0)
                return;
            if (MessageBox.Show("您确定要删除该条明细吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int ID = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<int>("ID");
                this.financialAccountsPXZXTableAdapter.DeleteByID(ID);
                this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
                this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
                txtShowRangeByPXZX.Text = "所有";
                this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
                this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
                txtShowRangeByHYJY.Text = "所有";
            }
        }

        private void btnCheckByHYJY_Click(object sender, EventArgs e)
        {
            if (this.FinanceHYJYBindingSource.Position < 0)
                return;
            if (MessageBox.Show("您确定要审核该条明细吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int ID = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<int>("ID");
                this.financialAccountsPXZXTableAdapter.UpdateByCheck(User.CurrentUser.UserName, ID);
                this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
                this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
                txtShowRangeByPXZX.Text = "所有";
                this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
                this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
                txtShowRangeByHYJY.Text = "所有";
            }
        }

        private void addFinanceAccount(int type)
        {
            FinanceAccountAddForm frmFinanceAccountAdd = new FinanceAccountAddForm();
            if (frmFinanceAccountAdd.ShowDialog() != DialogResult.OK)
                return;
            this.financialAccountsPXZXTableAdapter.InsertWithoutCheck(frmFinanceAccountAdd.summary, (decimal)frmFinanceAccountAdd.income, (decimal)frmFinanceAccountAdd.pay,
                frmFinanceAccountAdd.remark, frmFinanceAccountAdd.createDate, User.CurrentUser.UserName, User.CurrentUser.UserType);
            this.financialAccountsPXZXTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsPXZX);
            this.financeAmountPXZXTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountPXZX);
            txtShowRangeByPXZX.Text = "所有";
            if (User.CurrentUser.UserType > 1)
            {
                this.financialAccountsHYJYTableAdapter.FillByAccountType(this.financeManageDataSet.FinancialAccountsHYJY, User.CurrentUser.UserType + 1);
                this.financeAmountHYJYTableAdapter.FillByAll(this.financeManageDataSet.FinanceAmountHYJY, User.CurrentUser.UserType + 1);
                txtShowRangeByHYJY.Text = "所有";
            }
        }

        private void FinancePXZXBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.FinancePXZXBindingSource.Position < 0)
                return;
            string checkName = financeManageDataSet.FinancialAccountsPXZX.Rows[FinancePXZXBindingSource.Position].Field<string>("CheckUser");
            if (checkName != null && !"".Equals(checkName))
            {
                btnUpdateByPXZX.Enabled = false;
                btnCheckByPXZX.Enabled = false;
            }
            else
            {
                btnUpdateByPXZX.Enabled = true;
                if (User.CurrentUser.UserType > 1)
                {
                    btnCheckByPXZX.Enabled = true;
                }
            }
        }

        private void FinanceHYJYBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.FinanceHYJYBindingSource.Position < 0)
                return;
            string checkName = financeManageDataSet.FinancialAccountsHYJY.Rows[FinanceHYJYBindingSource.Position].Field<string>("CheckUser");
            if (checkName != null && !"".Equals(checkName))
            {
                btnUpdateByHYJY.Enabled = false;
                btnCheckByHYJY.Enabled = false;
            }
            else
            {
                btnUpdateByHYJY.Enabled = true;
                if (User.CurrentUser.UserType > 1)
                {
                    btnCheckByHYJY.Enabled = true;
                }
            }
        }
    }
}
