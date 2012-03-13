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
    public partial class LeftCourseForm : Form
    {
        public string UserName;
        public int UserType;

        public LeftCourseForm()
        {
            InitializeComponent();
        }

        private void LeftCourseForm_Load(object sender, EventArgs e)
        {
            this.leaveCourseTableAdapter.FillByBeginDate(this.leaveCourseDataSet.LeaveCourse);
            if (leaveCourseDataSet.LeaveCourse.Rows.Count > 0)
            {
                lblStudentsCount.Text = leaveCourseDataSet.LeaveCourse.Rows[0].Field<int>("StudentCount") + "人";
            }
            else
            {
                lblStudentsCount.Text = "0人";
            }
            txtShowRange.Text = "本月";
        }

        private void LeftCourseForm_Resize(object sender, EventArgs e)
        {
            dgvLeaveCourse.Width = this.Width - 20;
            dgvLeaveCourse.Height = this.Height - 192;
        }

        private void btnSearchByCourseType_Click(object sender, EventArgs e)
        {
            CourseTypeSelectForm frmCourseTypeSelect = new CourseTypeSelectForm();
            DateTime beginDate = dtRefundBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtRefundEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (UserType == 0)
            {
                frmCourseTypeSelect.isPrivate = true;
                frmCourseTypeSelect.userName = this.UserName;
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.leaveCourseTableAdapter.FillByUserNameCourseTypeWithDate(leaveCourseDataSet.LeaveCourse, frmCourseTypeSelect.CourseTypeId, beginDate, endDate, this.UserName);
            }
            else
            {
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.leaveCourseTableAdapter.FillByCourseTypeWithDate(leaveCourseDataSet.LeaveCourse, frmCourseTypeSelect.CourseTypeId, beginDate, endDate);
            }

            txtShowRange.Text = frmCourseTypeSelect.CourseTypeName;
            if (leaveCourseDataSet.LeaveCourse.Rows.Count > 0)
            {
                lblStudentsCount.Text = leaveCourseDataSet.LeaveCourse.Rows[0].Field<int>("StudentCount") + "人";
            }
            else
            {
                lblStudentsCount.Text = "0人";
            }
        }

        private void btnSearchByCourse_Click(object sender, EventArgs e)
        {
            CourseSelectForm frmCourseSelect = new CourseSelectForm();
            DateTime beginDate = dtRefundBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtRefundEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (UserType == 0)
            {
                frmCourseSelect.isPrivate = true;
                frmCourseSelect.userName = this.UserName;
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.leaveCourseTableAdapter.FillByUserNameCourseWithDate(this.leaveCourseDataSet.LeaveCourse, frmCourseSelect.CourseID, beginDate, endDate, this.UserName);
            }
            else
            {
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.leaveCourseTableAdapter.FillByCourseWithDate(this.leaveCourseDataSet.LeaveCourse, frmCourseSelect.CourseID, beginDate, endDate);
            }
            txtShowRange.Text = frmCourseSelect.CourseTypeName + " - " +
                frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName;
            if (leaveCourseDataSet.LeaveCourse.Rows.Count > 0)
            {
                lblStudentsCount.Text = leaveCourseDataSet.LeaveCourse.Rows[0].Field<int>("StudentCount") + "人";
            }
            else
            {
                lblStudentsCount.Text = "0人";
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.leaveCourseTableAdapter.Fill(this.leaveCourseDataSet.LeaveCourse);
            txtShowRange.Text = "所有";
            if (leaveCourseDataSet.LeaveCourse.Rows.Count > 0)
            {
                lblStudentsCount.Text = leaveCourseDataSet.LeaveCourse.Rows[0].Field<int>("StudentCount") + "人";
            }
            else
            {
                lblStudentsCount.Text = "0人";
            }
        }

        private void dgvLeaveCourse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvLeaveCourse.Rows.Count > 0)
                for (int i = 0; i < dgvLeaveCourse.Rows.Count; i++)
                {
                    dgvLeaveCourse.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void leaveCourseBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int totalRefundAmount = 0;
            foreach (DataRow row in leaveCourseDataSet.LeaveCourse.Rows)
            {
                totalRefundAmount += row.Field<int>("RefundAmount");
            }
            txtTotalRefundAmount.Text = totalRefundAmount.ToString();
        }

        private void btnShowThisMonthBuy_Click(object sender, EventArgs e)
        {
            this.leaveCourseTableAdapter.FillByBeginDate(this.leaveCourseDataSet.LeaveCourse);
            if (leaveCourseDataSet.LeaveCourse.Rows.Count > 0)
            {
                lblStudentsCount.Text = leaveCourseDataSet.LeaveCourse.Rows[0].Field<int>("StudentCount") + "人";
            }
            else
            {
                lblStudentsCount.Text = "0人";
            }
            txtShowRange.Text = "本月";
        }

        private void btnShowFilterBuy_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtRefundBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtRefundEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.leaveCourseTableAdapter.FillByBeginEndDate(this.leaveCourseDataSet.LeaveCourse, beginDate, endDate);
            if (leaveCourseDataSet.LeaveCourse.Rows.Count > 0)
            {
                lblStudentsCount.Text = leaveCourseDataSet.LeaveCourse.Rows[0].Field<int>("StudentCount") + "人";
            }
            else
            {
                lblStudentsCount.Text = "0人";
            }
            txtShowRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }
    }
}
