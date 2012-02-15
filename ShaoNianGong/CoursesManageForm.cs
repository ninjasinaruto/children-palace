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
    public partial class CoursesManageForm : Form
    {
        public CoursesManageForm()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            // 刷新classrooms数据
            this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
        }

        private void CoursesManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“teachersDataSet.Tearchers”中。您可以根据需要移动或删除它。
            this.tearchersTableAdapter.Fill(this.teachersDataSet.Tearchers);
            // 填充ChargeTypes
            this.chargeTypeTableAdapter.Fill(this.staticDataSet.ChargeType);

            // 首先填充静态数据：在整个form的生存周期中，都不会发生变化
            // 1> 填充CourseTypes表格及对应的ComboBox
            this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "CourseTypeID";

            // 2> 填充DayOfWeek表格及对应的ComboBox
            this.dayOfWeekTableAdapter.Fill(this.staticDataSet.DayOfWeek);

            // 初始化chargeMethod
            cmbChargeMethod.SelectedIndex = 0;
        }

        /// <summary>
        /// 当CourseType的选择发生变化时，更新CourseSubType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courseTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position < 0)
                return;
            int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
            this.courseSubtypesTableAdapter.Fill(coursesDataSet.CourseSubtypes, courseTypeID);
        }

        /// <summary>
        /// 当CourseSubType的位置发生变化时，刷新Courses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courseSubTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.courseSubTypesBindingSource.Position < 0)
            {
                btnAddCourse.Enabled = false;
                coursesDataSet.Courses.Clear();
                return;
            }

            btnAddCourse.Enabled = true;
            int courseSubTypeID = this.coursesDataSet.CourseSubtypes.Rows[this.courseSubTypesBindingSource.Position].Field<int>("ID");
            coursesTableAdapter.Fill(coursesDataSet.Courses, courseSubTypeID);

            coursesDataSet.Courses.CourseSubTypeIDColumn.DefaultValue = courseSubTypeID;
        }

        /// <summary>
        /// 当课程的选择发生变化时，更新课程时间表
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coursesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.coursesBindingSource.Position < 0)
            {
                btnAddCourseTime.Enabled = false;
                coursesDataSet.CourseTime.Clear();
                return;
            }

            btnAddCourseTime.Enabled = true;
            int courseID = coursesDataSet.Courses.Rows[coursesBindingSource.Position].Field<int>("CourseID");
            courseTimeTableAdapter.Fill(coursesDataSet.CourseTime, courseID);
        }

        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CourseAddingForm frmCourseAdding = new CourseAddingForm();
            frmCourseAdding.CourseType = lstCourseType.Text;
            frmCourseAdding.CourseSubType = lstCourseSubtypes.Text;
            if (frmCourseAdding.ShowDialog() != DialogResult.OK)
                return;
            
            int courseSubTypeID = this.coursesDataSet.CourseSubtypes.Rows[this.courseSubTypesBindingSource.Position].Field<int>("ID");
            coursesTableAdapter.Insert(frmCourseAdding.CourseName, courseSubTypeID,
                frmCourseAdding.ChargeType, frmCourseAdding.ChargeAmount);
            coursesTableAdapter.Fill(coursesDataSet.Courses, courseSubTypeID);

            coursesDataSet.Courses.CourseSubTypeIDColumn.DefaultValue = courseSubTypeID;
        }

        /// <summary>
        /// 添加课时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCourseTime_Click(object sender, EventArgs e)
        {
            CourseTimeAddingForm frmCourseTimeAdding = new CourseTimeAddingForm();
            frmCourseTimeAdding.CourseType = lstCourseType.Text;
            frmCourseTimeAdding.CourseSubType = lstCourseSubtypes.Text;
            frmCourseTimeAdding.CourseName = txtCourseName.Text;
            frmCourseTimeAdding.ChargeType = cmbChargeMethod.Text;
            frmCourseTimeAdding.ChargeAmount = txtChargeAmount.Text;
            if (frmCourseTimeAdding.ShowDialog() != DialogResult.OK)
                return;

            courseTimeTableAdapter.InsertCourseTime(int.Parse(lblCourseID.Text), frmCourseTimeAdding.ClassroomId,
                frmCourseTimeAdding.DayOfWeek, frmCourseTimeAdding.CourseBeginTime, frmCourseTimeAdding.CourseEndTime);
            courseTimeTableAdapter.Fill(coursesDataSet.CourseTime, int.Parse(lblCourseID.Text));
        }

        // 添加课程类别
        private void btnAddCourseType_Click(object sender, EventArgs e)
        {
            CourseTypeAddingForm frmCourseTypeAdding = new CourseTypeAddingForm();
            if (frmCourseTypeAdding.ShowDialog() != DialogResult.OK)
                return;

            courseTypesTableAdapter.InsertCourseType(frmCourseTypeAdding.CourseTypeName);
            courseTypesTableAdapter.Fill(staticDataSet.CourseTypes);
        }

        // 编辑课程类别
        private void btnUpdateCourseType_Click(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position != -1)
            {
                // 类别ID
                int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
                // 类别名称
                string courseTypeName = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<string>("CourseTypeName");
                CourseTypeUpdateForm frmCourseTypeUpdate = new CourseTypeUpdateForm();
                frmCourseTypeUpdate.CourseTypeName = courseTypeName;
                if (frmCourseTypeUpdate.ShowDialog() != DialogResult.OK)
                    return;
                courseTypesTableAdapter.UpdateCourseType(frmCourseTypeUpdate.CourseTypeName, courseTypeID);
                courseTypesTableAdapter.Fill(staticDataSet.CourseTypes);
            }
            else 
            {
                MessageBox.Show("请选择要修改的类别！");
                return;
            }
        }

        // 删除课程类别
        private void btnDelCourseType_Click(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position != -1)
            {
                if (MessageBox.Show("删除该类别的同时将会删除其下所有的科目与课程，您确定要删除该类别吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // 类别ID
                    int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
                    courseTypesTableAdapter.DeleteCourseType(courseTypeID);
                    courseTypesTableAdapter.Fill(staticDataSet.CourseTypes);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的类别！");
                return;
            }
        }

        private void btnAddCourseSubtype_Click(object sender, EventArgs e)
        {
            if (lstCourseType.SelectedIndex < 0)
                return;

            int courseTypeId = int.Parse(lstCourseType.SelectedValue.ToString());
            CourseSubtypeAddingForm frmCourseSubypeAdding = new CourseSubtypeAddingForm();
            frmCourseSubypeAdding.CourseTypeName = lstCourseType.Text;
            if (frmCourseSubypeAdding.ShowDialog() != DialogResult.OK)
                return;

            courseSubtypesTableAdapter.InsertCourseSubtype(courseTypeId,
                frmCourseSubypeAdding.CourseSubtypeName);
            courseSubtypesTableAdapter.Fill(coursesDataSet.CourseSubtypes, courseTypeId);
        }

        private void courseTimeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseTimeBindingSource.Position < 0)
            {
                btnRemoveCourseTime.Enabled = false;
            }
            else
            {
                btnRemoveCourseTime.Enabled = true;
            }
        }

        private void btnRemoveCourseTime_Click(object sender, EventArgs e)
        {
            if (courseTimeBindingSource.Position < 0)
                return;
            if (grdVwCourseTime.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = grdVwCourseTime.SelectedRows[0];
            if (MessageBox.Show("是否确认要删除课程“" + txtCourseName.Text + "”在“"
                + row.Cells["columnDayOfWeek"].Value.ToString() + "”，“"
                + row.Cells["classroomNameColumn"].Value.ToString() + "”的上课时间？",
                "确认删除课程", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            courseTimeTableAdapter.DeleteCourseTime(int.Parse(row.Cells["IDColumn"].Value.ToString()));
            courseTimeTableAdapter.Fill(coursesDataSet.CourseTime, int.Parse(lblCourseID.Text));
        }

        private void btnChangeTeacher_Click(object sender, EventArgs e)
        {
            TeacherSelectForm frmTeacherSelect = new TeacherSelectForm();
            if (frmTeacherSelect.ShowDialog() != DialogResult.OK)
                return;
            coursesTableAdapter.UpdateTeacher(frmTeacherSelect.TeacherID, int.Parse(lblCourseID.Text));

            cmbTeacher.SelectedValue = frmTeacherSelect.TeacherID;
        }

        // 编辑课程科目
        private void btnUpdateCourseSubtype_Click(object sender, EventArgs e)
        {
            if (this.courseSubTypesBindingSource.Position != -1)
            {
                int courseSubTypeID = this.coursesDataSet.CourseSubtypes.Rows[this.courseSubTypesBindingSource.Position].Field<int>("ID");
                MessageBox.Show(courseSubTypeID + "");
            }
            else
            {
                MessageBox.Show("请选择要修改的科目！");
                return;
            }
        }

        private void btnDelCourseSubtype_Click(object sender, EventArgs e)
        {
            if (this.courseSubTypesBindingSource.Position != -1)
            {
                int courseSubTypeID = this.coursesDataSet.CourseSubtypes.Rows[this.courseSubTypesBindingSource.Position].Field<int>("ID");
                MessageBox.Show(courseSubTypeID + "");
            }
            else
            {
                MessageBox.Show("请选择要删除的科目！");
                return;
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {

        }



        
    }
}