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
    public partial class ConfirmCourseTimeAddingForm : Form
    {
        public string CourseType;
        public string CourseSubType;
        public string CourseName;
        public string ChargeType;
        public string ChargeAmount;

        public string DayOfWeek;
        public string Classroom;
        public string CourseBeginTime;
        public string CourseEndTime;

        public ConfirmCourseTimeAddingForm()
        {
            InitializeComponent();
        }

        private void ConfirmCourseTimeAddingForm_Load(object sender, EventArgs e)
        {
            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubType;
            txtCourseName.Text = CourseName;
            txtChargeType.Text = ChargeType;
            txtChargeAmount.Text = ChargeAmount;

            txtDayOfWeek.Text = DayOfWeek;
            txtClassroom.Text = Classroom;
            txtCourseBeginTime.Text = CourseBeginTime;
            txtCourseEndTime.Text = CourseEndTime;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
