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
        public string UserName;
        public int UserType;

        public FinanceManageForm()
        {
            InitializeComponent();
        }

        private void FinanceManageForm_Load(object sender, EventArgs e)
        {
            this.studentDepositListTableAdapter.FillByMonth(this.depositListDataSet.StudentDepositList);
            txtShowDepositRange.Text = "本月";

            this.materialsBuyTableAdapter.FillByBeginDate(this.financeManageDataSet.MaterialsBuy);
            txtShowBuyRange.Text = "本月";
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

            lblBuyCount.Text = this.financeManageDataSet.MaterialsBuy.Rows.Count + "条";
        }

        private void btnShowAllDeposit_Click(object sender, EventArgs e)
        {
            this.studentDepositListTableAdapter.Fill(this.depositListDataSet.StudentDepositList);
            txtShowDepositRange.Text = "所有";
        }

        private void btnShowAllBuy_Click(object sender, EventArgs e)
        {
            this.materialsBuyTableAdapter.Fill(this.financeManageDataSet.MaterialsBuy);
            txtShowBuyRange.Text = "所有";
        }

        private void btnShowThisMonthDeposit_Click(object sender, EventArgs e)
        {
            this.studentDepositListTableAdapter.FillByMonth(this.depositListDataSet.StudentDepositList);
            txtShowDepositRange.Text = "本月";
        }

        private void btnShowThisMonthBuy_Click(object sender, EventArgs e)
        {
            this.materialsBuyTableAdapter.FillByBeginDate(this.financeManageDataSet.MaterialsBuy);
            txtShowBuyRange.Text = "本月";
        }

        private void btnShowFilterDeposit_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtDepositBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtDepositEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (UserType == 0)
            {
                // 仅显示过滤已授权
                this.studentDepositListTableAdapter.FillByUserNameBeginEndDate(this.depositListDataSet.StudentDepositList, beginDate, endDate, this.UserName);
            }
            else
            {
                // 显示过滤
                this.studentDepositListTableAdapter.FillByBeginEndDate(this.depositListDataSet.StudentDepositList, beginDate, endDate);
            }
            txtShowDepositRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void btnShowFilterBuy_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBuyBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtBuyEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.materialsBuyTableAdapter.FillByBeginEndDate(this.financeManageDataSet.MaterialsBuy, beginDate, endDate);
        }

        private void FinanceManageForm_Resize(object sender, EventArgs e)
        {
            this.groupBox1.Width = this.Width - 20;
            this.groupBox1.Height = this.Height / 2 - 70;
            this.panel1.Width = this.Width - 30;
            this.panel1.Top = this.Height / 2 - 105;
            this.dgvDeposit.Width = this.Width - 30;
            this.dgvDeposit.Height = this.Height / 2 - 190;
            this.groupBox3.Top = this.Height /2 - 40;
            this.groupBox3.Width = this.Width - 20;
            this.groupBox3.Height = this.Height / 2 - 20;
            this.panel2.Width = this.Width - 30;
            this.panel2.Top = this.Height / 2 - 55;
            this.dgvBuy.Width = this.Width - 35;
            this.dgvBuy.Height = this.Height / 2 - 140 ;
        }

        private void btnSearchDepositByCourseType_Click(object sender, EventArgs e)
        {
            CourseTypeSelectForm frmCourseTypeSelect = new CourseTypeSelectForm();
            if (UserType == 0)
            {
                frmCourseTypeSelect.isPrivate = true;
                frmCourseTypeSelect.userName = this.UserName;
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByUserNameCourseType(this.depositListDataSet.StudentDepositList, frmCourseTypeSelect.CourseTypeId, this.UserName);
            }
            else
            {
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByCourseType(this.depositListDataSet.StudentDepositList, frmCourseTypeSelect.CourseTypeId);
            }
            txtShowDepositRange.Text = frmCourseTypeSelect.CourseTypeName;
        }

        private void btnSearchDepositByCourse_Click(object sender, EventArgs e)
        {
            CourseSelectForm frmCourseSelect = new CourseSelectForm();
            if (UserType == 0)
            {
                frmCourseSelect.isPrivate = true;
                frmCourseSelect.userName = this.UserName;
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByUserNameCourseID(this.depositListDataSet.StudentDepositList, frmCourseSelect.CourseID, this.UserName);
            }
            else
            {
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByCourseID(this.depositListDataSet.StudentDepositList, frmCourseSelect.CourseID);
            }
            txtShowDepositRange.Text = frmCourseSelect.CourseTypeName + " - " + frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName;
        }

        private void btnSearchDepositByCourseTypeWithDate_Click(object sender, EventArgs e)
        {
            CourseTypeSelectForm frmCourseTypeSelect = new CourseTypeSelectForm();
            DateTime beginDate = dtDepositBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtDepositEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (UserType == 0)
            {
                frmCourseTypeSelect.isPrivate = true;
                frmCourseTypeSelect.userName = this.UserName;
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByUserNameCourseTypeWithDate(this.depositListDataSet.StudentDepositList, frmCourseTypeSelect.CourseTypeId, beginDate, endDate, this.UserName);
            }
            else
            {
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByCourseTypeWithDate(this.depositListDataSet.StudentDepositList, frmCourseTypeSelect.CourseTypeId, beginDate, endDate);
            }
            txtShowDepositRange.Text = frmCourseTypeSelect.CourseTypeName + "    " + beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void btnSearchDepositByCourseWithDate_Click(object sender, EventArgs e)
        {
            CourseSelectForm frmCourseSelect = new CourseSelectForm();
            DateTime beginDate = dtDepositBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtDepositEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (UserType == 0)
            {
                frmCourseSelect.isPrivate = true;
                frmCourseSelect.userName = this.UserName;
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByUserNameCourseIDWithDate(this.depositListDataSet.StudentDepositList, beginDate, endDate, frmCourseSelect.CourseID, this.UserName);
            }
            else
            {
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentDepositListTableAdapter.FillByCourseIDWithDate(this.depositListDataSet.StudentDepositList, frmCourseSelect.CourseID, beginDate, endDate);
            }
            txtShowDepositRange.Text = frmCourseSelect.CourseTypeName + " - " + frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName + "    " + beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void studentDepositBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int totalDeposit = 0;
            int totalPaid = 0;
            foreach (DataRow row in depositListDataSet.StudentDepositList.Rows)
            {
                totalDeposit += row.Field<int>("DepositAmount");
                totalPaid += row.Field<int>("ActualPaidAmount");
            }

            txtTotalDeposit.Text = totalDeposit.ToString();
            txtTotalPaid.Text = totalPaid.ToString();
            lblDepositCount.Text = this.depositListDataSet.StudentDepositList.Rows.Count + "条";
        }

        private void dgvDeposit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvDeposit.Rows.Count > 0)
                for (int i = 0; i < dgvDeposit.Rows.Count; i++)
                {
                    dgvDeposit.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void dgvBuy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvBuy.Rows.Count > 0)
                for (int i = 0; i < dgvBuy.Rows.Count; i++)
                {
                    dgvBuy.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void btnSearchBuyByMaterialName_Click(object sender, EventArgs e)
        {
            MaterialSelectedForm frmMaterialSelected = new MaterialSelectedForm();
            if (frmMaterialSelected.ShowDialog() != DialogResult.OK)
                return;
            this.materialsBuyTableAdapter.FillByMaterialID(this.financeManageDataSet.MaterialsBuy, frmMaterialSelected.MaterialId);
            txtShowBuyRange.Text = frmMaterialSelected.MaterialName;
        }

        private void btnSearchBuyByMaterialNameWithDate_Click(object sender, EventArgs e)
        {
            MaterialSelectedForm frmMaterialSelected = new MaterialSelectedForm();
            if (frmMaterialSelected.ShowDialog() != DialogResult.OK)
                return;
            DateTime beginDate = dtBuyBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtBuyEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.materialsBuyTableAdapter.FillByMaterialIDWithDate(this.financeManageDataSet.MaterialsBuy, frmMaterialSelected.MaterialId, beginDate, endDate);
            txtShowBuyRange.Text = frmMaterialSelected.MaterialName + "    " + beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }
    }
}
