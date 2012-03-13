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
        public string UserName;
        public int UserType;

        public DepositListForm()
        {
            InitializeComponent();
        }

        private void DepositListForm_Load(object sender, EventArgs e)
        {
            this.studentDepositListTableAdapter.FillByMonth(this.depositListDataSet.StudentDepositList);
            txtShowRange.Text = "本月";
        }

        private void DepositListForm_Resize(object sender, EventArgs e)
        {
            dgvDeposit.Width = this.Width - 20;
            dgvDeposit.Height = this.Height - 192;
        }

        private void depositListBindingSource_ListChanged(object sender, ListChangedEventArgs e)
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

        private void btnShowAllDeposit_Click(object sender, EventArgs e)
        {
            this.studentDepositListTableAdapter.Fill(this.depositListDataSet.StudentDepositList);
            txtShowRange.Text = "所有";
        }

        private void btnShowThisMonthDeposit_Click(object sender, EventArgs e)
        {
            this.studentDepositListTableAdapter.FillByMonth(this.depositListDataSet.StudentDepositList);
            txtShowRange.Text = "本月";
        }

        private void btnShowFilterDeposit_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtDepositBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtDepositEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.studentDepositListTableAdapter.FillByBeginEndDate(this.depositListDataSet.StudentDepositList, beginDate, endDate);
            txtShowRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void dgvDeposit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvDeposit.Rows.Count > 0)
                for (int i = 0; i < dgvDeposit.Rows.Count; i++)
                {
                    dgvDeposit.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void btnSearchByCourseType_Click(object sender, EventArgs e)
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
            txtShowRange.Text = frmCourseTypeSelect.CourseTypeName;
        }

        private void btnSearchByCourse_Click(object sender, EventArgs e)
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
            txtShowRange.Text = frmCourseSelect.CourseTypeName + " - " + frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName;
        }
    }
}
