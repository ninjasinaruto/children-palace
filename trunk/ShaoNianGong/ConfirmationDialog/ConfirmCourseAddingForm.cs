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
    public partial class ConfirmCourseAddingForm : Form
    {
        public string CourseType;
        public string CourseSubType;
        public string CourseName;
        public string ChargeType;
        public string ChargeAmount;

        public ConfirmCourseAddingForm()
        {
            InitializeComponent();
        }

        private void ConfirmCourseAddingForm_Load(object sender, EventArgs e)
        {
            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubType;
            txtCourseName.Text = CourseName;
            txtChargeMethod.Text = ChargeType;
            txtChargeAmount.Text = ChargeAmount;
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
