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
    public partial class ConfirmChangeCourseForm : Form
    {
        public string StudentName;
        public string Balance;

        public string CourseTypeName;
        public string CourseSubtypeName;
        public string CourseName;
        public string ChargeTypeName;
        public string ChargeAmount;
        public string ExpireDate;

        public string NewCourseTypeName;
        public string NewCourseSubtypeName;
        public string NewCourseName;
        public string NewChargeTypeName;
        public string NewChargeAmount;
        public string SignUpPeriod;
        public string NewExpireDate;

        public string SettlementAmount;
        public string TotalAmount;
        public string DiscountLevelName;
        public string InbackAmount;
        public string DiscountReason;

        public ConfirmChangeCourseForm()
        {
            InitializeComponent();
        }

        private void ConfirmChangeCourseForm_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = this.StudentName;
            txtBalance.Text = this.Balance;

            txtCourseType.Text = this.CourseTypeName;
            txtCourseSubType.Text = this.CourseSubtypeName;
            txtCourseName.Text = this.CourseName;
            txtChargeType.Text = this.ChargeTypeName;
            txtChargeAmount.Text = this.ChargeAmount;
            txtExpireDate.Text = this.ExpireDate;

            txtNewCouseType.Text = this.NewCourseTypeName;
            txtNewCourseSubtype.Text = this.NewCourseSubtypeName;
            txtNewCourse.Text = this.NewCourseName;
            txtNewChargeType.Text = this.NewChargeTypeName;
            txtNewChargeAmount.Text = this.NewChargeAmount;
            txtSignUpPeriod.Text = this.SignUpPeriod;
            txtNewExpireDate.Text = this.NewExpireDate;

            txtSettlementAmount.Text = this.SettlementAmount;
            txtTotalAmount.Text = this.TotalAmount;
            txtDiscount.Text = this.DiscountLevelName;
            txtInbackAmount.Text = this.InbackAmount;
            txtDiscountReason.Text = this.DiscountReason;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
