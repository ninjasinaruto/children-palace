﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShaoNianGong
{
    public partial class ClassroomManageForm : Form
    {
        public int currentDayOfWeek;
        public ClassroomManageForm()
        {
            InitializeComponent();
        }

        private void ClassroomManageForm_Load(object sender, EventArgs e)
        {
            // 获取今天的星期
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    currentDayOfWeek = 1;
                    break;
                case DayOfWeek.Tuesday:
                    currentDayOfWeek = 2;
                    break;
                case DayOfWeek.Wednesday:
                    currentDayOfWeek = 3;
                    break;
                case DayOfWeek.Thursday:
                    currentDayOfWeek = 4;
                    break;
                case DayOfWeek.Friday:
                    currentDayOfWeek = 5;
                    break;
                case DayOfWeek.Saturday:
                    currentDayOfWeek = 6;
                    break;
                case DayOfWeek.Sunday:
                    currentDayOfWeek = 7;
                    break;
            }

            this.dayOfWeekTableAdapter.Fill(this.staticDataSet.DayOfWeek);
            this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
            this.coursesOfClassroomTableAdapter.Fill(this.coursesDataSet.CoursesOfClassroom);

            if (dgvCourseOfClassroom.Rows.Count > 0)
                dgvCourseOfClassroom.Rows[0].Selected = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClassroomAddForm frmClassroomAdd = new ClassroomAddForm();
            if (frmClassroomAdd.ShowDialog() != DialogResult.OK)
                return;
            classroomsTableAdapter.Insert(frmClassroomAdd.ClassroomName);
            this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.classroomsBindingSource.Position == -1)
            {
                MessageBox.Show("请选择要修改的教室！");
                return;
            }
            else
            {
                int classroomID = this.coursesDataSet.Classrooms.Rows[this.classroomsBindingSource.Position].Field<int>("ClassroomID");
                string classroomName = this.coursesDataSet.Classrooms.Rows[this.classroomsBindingSource.Position].Field<string>("ClassroomName");
                ClassroomUpdateForm frmClassroomUpdate = new ClassroomUpdateForm();
                frmClassroomUpdate.ClassroomName = classroomName;
                if (frmClassroomUpdate.ShowDialog() != DialogResult.OK)
                    return;
                classroomsTableAdapter.UpdateByID(frmClassroomUpdate.ClassroomName, classroomID);
                this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.classroomsBindingSource.Position == -1)
            {
                MessageBox.Show("请选择要删除的教室！");
                return;
            }
            else
            {
                int classroomID = this.coursesDataSet.Classrooms.Rows[this.classroomsBindingSource.Position].Field<int>("ClassroomID");
                string classroomName = this.coursesDataSet.Classrooms.Rows[this.classroomsBindingSource.Position].Field<string>("ClassroomName");
                int courseCount = this.coursesDataSet.Classrooms.Rows[this.classroomsBindingSource.Position].Field<int>("CourseCount");
                if (courseCount > 0)
                {
                    MessageBox.Show("该教室有安排课程，无法删除！");
                    return;
                }
                else
                {
                    if (MessageBox.Show("您确定要删除该教室吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        classroomsTableAdapter.DeleteByID(classroomID);
                        this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
                    }
                }
            }
        }

        private void coursesOfClassroomBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int count = this.coursesDataSet.CoursesOfClassroom.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    DateTime beginTime = this.coursesDataSet.CoursesOfClassroom.Rows[i].Field<DateTime>("BeginTime");
                    DateTime endTime = this.coursesDataSet.CoursesOfClassroom.Rows[i].Field<DateTime>("EndTime");
                    int dayOfWeek = this.coursesDataSet.CoursesOfClassroom.Rows[i].Field<int>("DayOfWeekValue");
                    if (isBetweenBeginAndEndTime(beginTime, endTime) && dayOfWeek == currentDayOfWeek)
                    {
                        dgvCourseOfClassroom.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 0, 0);
                    }
                }
            }
        }

        private bool isBetweenBeginAndEndTime(DateTime beginTime, DateTime endTime)
        {
            DateTime now = DateTime.Parse(DateTime.Now.ToShortTimeString());
            DateTime sTime = DateTime.Parse(beginTime.ToShortTimeString());
            DateTime eTime = DateTime.Parse(endTime.ToShortTimeString());
            if (now.CompareTo(sTime) >= 1 && now.CompareTo(eTime) <= -1)
                return true;
            return false;
        }

        private void btnSearchByDay_Click(object sender, EventArgs e)
        {
            int dayOfWeek = this.staticDataSet.DayOfWeek.Rows[dayOfWeekBindingSource.Position].Field<int>("DayOfWeekValue");
            this.coursesOfClassroomTableAdapter.FillByDayOfWeek(coursesDataSet.CoursesOfClassroom, dayOfWeek);
            if (dgvCourseOfClassroom.Rows.Count > 0)
                dgvCourseOfClassroom.Rows[0].Selected = false;
        }

        private void btnSearchByClassroom_Click(object sender, EventArgs e)
        {
            if (classroomsBindingSource.Position < 0)
            {
                coursesDataSet.CoursesOfClassroom.Clear();
                return;
            }
            int classroomID = this.coursesDataSet.Classrooms.Rows[classroomsBindingSource.Position].Field<int>("ClassroomID");
            this.coursesOfClassroomTableAdapter.FillByClassroomID(coursesDataSet.CoursesOfClassroom, classroomID);
            if (dgvCourseOfClassroom.Rows.Count > 0)
                dgvCourseOfClassroom.Rows[0].Selected = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (classroomsBindingSource.Position < 0)
            {
                coursesDataSet.CoursesOfClassroom.Clear();
                return;
            }
            int classroomID = this.coursesDataSet.Classrooms.Rows[classroomsBindingSource.Position].Field<int>("ClassroomID");
            int dayOfWeek = this.staticDataSet.DayOfWeek.Rows[dayOfWeekBindingSource.Position].Field<int>("DayOfWeekValue");
            this.coursesOfClassroomTableAdapter.FillByClassroomIDAndDayOfWeek(coursesDataSet.CoursesOfClassroom, classroomID, dayOfWeek);
            if (dgvCourseOfClassroom.Rows.Count > 0)
                dgvCourseOfClassroom.Rows[0].Selected = false;
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            this.coursesOfClassroomTableAdapter.Fill(this.coursesDataSet.CoursesOfClassroom);
            if (dgvCourseOfClassroom.Rows.Count > 0)
                dgvCourseOfClassroom.Rows[0].Selected = false;
        }
    }
}
