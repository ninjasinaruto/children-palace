using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QianDao
{
    public partial class StudentCourseForm : Form
    {
        public int studentId; 
        public string studentName;
        public int currentDayOfWeek;
        public int courseId;
        public int courseTimeId;
        public string endTime;

        public StudentCourseForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void StudentCourseForm_Load(object sender, EventArgs e)
        {
            this.lblInfo.Text = "【"+studentName+"】今日可上如下课程，请进行选择：";
            this.lblDate.Text = DateTime.Now.Year + "年" + DateTime.Now.Month + "月" + DateTime.Now.Day + "日 " + GetWeekStr();
            
            // 查询当前学生当天该时间段可以上的所有课程
            this.studentCourseTableAdapter.Fill(this.signInDataSet.StudentCourse, studentId, currentDayOfWeek);
            courseId = int.Parse(lstCourses.SelectedValue.ToString());
            ShowCourseInfo();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseId = int.Parse(lstCourses.SelectedValue.ToString());
            ShowCourseInfo();
        }

        private void ShowCourseInfo() {
            DataRow courseRow = this.signInDataSet.StudentCourse.Rows[studentCourseBindingSource.Position];
            lblChargeType.Text = courseRow.Field<string>("ChargeTypeName");
            lblChargeAmount.Text = courseRow.Field<int>("ChargeAmount") + "元";
            lblClassroom.Text = courseRow.Field<string>("ClassroomName");
            lblBeginTime.Text = courseRow.Field<DateTime>("BeginTime").ToLongTimeString();
            lblEndTime.Text = courseRow.Field<DateTime>("EndTime").ToLongTimeString();

            courseTimeId = courseRow.Field<int>("CourseTimeID");
            endTime = courseRow.Field<DateTime>("EndTime").ToLongTimeString();
        }

        private string GetWeekStr() {
            string weekStr = "";
            // 获取今天的星期
            switch (currentDayOfWeek)
            {
                case 1:
                    weekStr = "星期一";
                    break;
                case 2:
                    weekStr = "星期二";
                    break;
                case 3:
                    weekStr = "星期三";
                    break;
                case 4:
                    weekStr = "星期四";
                    break;
                case 5:
                    weekStr = "星期五";
                    break;
                case 6:
                    weekStr = "星期六";
                    break;
                case 7:
                    weekStr = "星期日";
                    break;
            }
            return weekStr;
        }
    }
}
