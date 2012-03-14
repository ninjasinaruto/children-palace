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
    public partial class CourseSelectForm : Form
    {
        public int CourseID;
        public string CourseTypeName;
        public string CourseSubtypeName;
        public string CourseName;
        public string userName;
        public bool isPrivate = false;

        public CourseSelectForm()
        {
            InitializeComponent();
        }

        private void CourseSelectForm_Load(object sender, EventArgs e)
        {
            if (!isPrivate)
            {
                this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            }
            else
            {
                this.courseTypesTableAdapter.FillByUserName(this.staticDataSet.CourseTypes, userName);
            }
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "ID";
        }

        private void courseTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position < 0)
                return;
            int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("ID");
            if (!isPrivate)
            {
                this.courseSubtypesTableAdapter.Fill(this.coursesDataSet.CourseSubtypes, courseTypeID);
            }
            else
            {
                this.courseSubtypesTableAdapter.FillByUserName(coursesDataSet.CourseSubtypes, courseTypeID, userName);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex < 0)
            {
                MessageBox.Show("请选择您要查询的课程", "请选择课程", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            CourseID = int.Parse(lstCourses.SelectedValue.ToString());
            CourseTypeName = lstCourseType.Text;
            CourseSubtypeName = lstCourseSubtypes.Text;
            CourseName = lstCourses.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void courseSubtypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.courseSubtypesBindingSource.Position < 0)
            {
                coursesDataSet.Courses.Clear();
                return;
            }

            int courseSubTypeID = this.coursesDataSet.CourseSubtypes.Rows[this.courseSubtypesBindingSource.Position].Field<int>("ID");
            if (!isPrivate)
            {
                coursesTableAdapter.Fill(coursesDataSet.Courses, courseSubTypeID);
            }
            else
            {
                coursesTableAdapter.FillByUserName(coursesDataSet.Courses, courseSubTypeID, userName);
            }
        }
    }
}
