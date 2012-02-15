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
    public partial class CourseTimeAddingForm : Form
    {
        public string CourseType;
        public string CourseSubType;
        public string CourseName;
        public string ChargeType;
        public string ChargeAmount;

        public int ClassroomId;
        public int DayOfWeek;
        public DateTime CourseBeginTime;
        public DateTime CourseEndTime;

        public CourseTimeAddingForm()
        {
            InitializeComponent();
        }

        private void CourseTimeAddingForm_Load(object sender, EventArgs e)
        {
            // 绑定dayOfWeek
            this.dayOfWeekTableAdapter.Fill(this.staticDataSet.DayOfWeek);
            cmbDayOfWeek.DataSource = dayOfWeekBindingSource;
            cmbDayOfWeek.DisplayMember = "DayOfWeekName";
            cmbDayOfWeek.ValueMember = "DayOfWeekValue";

            // 绑定教室
            this.classroomsTableAdapter.Fill(this.coursesDataSet.Classrooms);
            cmbClassroom.DataSource = classroomsBindingSource;
            cmbClassroom.DisplayMember = "ClassroomName";
            cmbClassroom.ValueMember = "ClassroomID";

            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubType;
            txtCourseName.Text = CourseName;
            txtChargeType.Text = ChargeType;
            txtChargeAmount.Text = ChargeAmount;

            cmbDayOfWeek.SelectedIndex = 0;
            cmbClassroom.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ConfirmCourseTimeAddingForm frmConfirm = new ConfirmCourseTimeAddingForm();
            frmConfirm.CourseType = txtCourseType.Text;
            frmConfirm.CourseSubType = txtCourseSubtype.Text;
            frmConfirm.CourseName = txtCourseName.Text;
            frmConfirm.ChargeType = txtChargeType.Text;
            frmConfirm.ChargeAmount = txtChargeAmount.Text;
            frmConfirm.DayOfWeek = cmbDayOfWeek.Text;
            frmConfirm.Classroom = cmbClassroom.Text;
            frmConfirm.CourseBeginTime = dtCourseBeginTime.Text;
            frmConfirm.CourseEndTime = dtCourseEndTime.Text;
            if (frmConfirm.ShowDialog() != DialogResult.OK)
                return;

            ClassroomId = int.Parse(cmbClassroom.SelectedValue.ToString());
            DayOfWeek = int.Parse(cmbDayOfWeek.SelectedValue.ToString());
            CourseBeginTime = dtCourseBeginTime.Value;
            CourseEndTime = dtCourseEndTime.Value;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
