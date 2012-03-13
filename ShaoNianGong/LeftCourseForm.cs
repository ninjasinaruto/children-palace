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
        public LeftCourseForm()
        {
            InitializeComponent();
        }

        private void LeftCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“leaveCourseDataSet.LeaveCourse”中。您可以根据需要移动或删除它。
            this.leaveCourseTableAdapter.Fill(this.leaveCourseDataSet.LeaveCourse);
            if (leaveCourseDataSet.LeaveCourse.Rows.Count > 0)
            {
                lblStudentsCount.Text = leaveCourseDataSet.LeaveCourse.Rows[0].Field<int>("StudentCount") + "人";
            }
            else
            {
                lblStudentsCount.Text = "0人";
            }
        }

        private void LeftCourseForm_Resize(object sender, EventArgs e)
        {
            dgvLeaveCourse.Width = this.Width - 20;
            dgvLeaveCourse.Height = this.Height - 192;
        }

        private void btnSearchByCourseType_Click(object sender, EventArgs e)
        {
            CourseTypeSelectForm frmCourseTypeSelect = new CourseTypeSelectForm();
            if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            leaveCourseTableAdapter.FillByCourseType(leaveCourseDataSet.LeaveCourse, frmCourseTypeSelect.CourseTypeId);
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
            if (frmCourseSelect.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            leaveCourseTableAdapter.FillByCourse(leaveCourseDataSet.LeaveCourse, frmCourseSelect.CourseID);
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
    }
}
