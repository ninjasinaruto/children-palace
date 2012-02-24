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
                //DateTime beginDate = DateTime.Now;
                //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByUserNameBeginDate(this.costListDataSet.CostList, this.UserName);
            }
            else
            {
                // 显示本月
                //DateTime beginDate = DateTime.Now;
                //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByBeginDate(this.costListDataSet.CostList);
            }
            txtShowRange.Text = "本月";
        }

        private void CostListForm_Resize(object sender, EventArgs e)
        {
            dgvCost.Width = this.Size.Width - 20;
            dgvCost.Height = this.Size.Height - 192;
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
            lblCostCount.Text = costListDataSet.CostList.Rows.Count + "条";
        }

        private void btnShowThisMonthDeposit_Click(object sender, EventArgs e)
        {
            if (UserType == 0)
            {
                // 仅显示本月已授权
                //DateTime beginDate = DateTime.Now;
                //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByUserNameBeginDate(this.costListDataSet.CostList, this.UserName);
            }
            else
            {
                // 显示本月
                //DateTime beginDate = DateTime.Now;
                //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
                this.costListTableAdapter.FillByBeginDate(this.costListDataSet.CostList);
            }
            txtShowRange.Text = "本月";
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
            txtShowRange.Text = "所有";
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
                this.costListTableAdapter.FillByUserNameBeginEndDate(this.costListDataSet.CostList,beginDate,endDate,this.UserName);
            }
            else
            {
                // 显示过滤
                this.costListTableAdapter.FillByBeginEndDate(this.costListDataSet.CostList, beginDate, endDate);
            }
            txtShowRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void btnSearchByCourse_Click(object sender, EventArgs e)
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
                this.costListTableAdapter.FillByUserNameCourseID(this.costListDataSet.CostList, frmCourseSelect.CourseID, this.UserName);
            }
            else
            {
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.costListTableAdapter.FillByCourseID(this.costListDataSet.CostList, frmCourseSelect.CourseID);
            }
            txtShowRange.Text = frmCourseSelect.CourseTypeName + " - " + frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName;
        }

        private void btnSearchByCourseType_Click(object sender, EventArgs e)
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
                this.costListTableAdapter.FillByUserNameCourseType(this.costListDataSet.CostList, frmCourseTypeSelect.CourseTypeId, this.UserName);
            }
            else
            {
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.costListTableAdapter.FillByCourseType(this.costListDataSet.CostList, frmCourseTypeSelect.CourseTypeId);
            }
            txtShowRange.Text = frmCourseTypeSelect.CourseTypeName;
        }
    }
}
