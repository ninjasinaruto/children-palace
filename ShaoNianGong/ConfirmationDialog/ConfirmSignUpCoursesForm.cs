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
    public partial class ConfirmSignUpCoursesForm : Form
    {
        public string CourseType;
        public string CourseSubType;
        public string CourseName;

        public string SignUpPeriod;
        public string CurrentDate;
        public string ExpireDate;
        public string TotalCost;

        public string Discount;
        public string ActualCostAmount;
        public string DiscountReason;

        public string StudentName;
        public string StudentBirthday;
        public string StudentSex;
        public string StudentAddress;
        public string StudentPhone;
        public string StudentFartherName;
        public string StudentFartherWork;
        public string StudentFartherPhone;
        public string StudentMotherName;
        public string StudentMotherWork;
        public string StudentMotherPhone;

        public ConfirmSignUpCoursesForm()
        {
            InitializeComponent();
        }

        private void ConfirmSignUpCoursesForm_Load(object sender, EventArgs e)
        {
            txtCourseType.Text = CourseType;
            txtCourseSubType.Text = CourseSubType;
            txtCourseName.Text = CourseName;

            txtSignUpPeriod.Text = SignUpPeriod;
            txtCurrentDate.Text = CurrentDate;
            txtExpireDate.Text = ExpireDate;
            txtTotalCost.Text = TotalCost;

            txtDiscount.Text = Discount;
            txtDiscountReason.Text = DiscountReason;
            txtActualCostAmount.Text = ActualCostAmount;

            txtName.Text = StudentName;
            txtSex.Text = StudentSex;
            txtBirthday.Text = StudentBirthday;

            txtAddress.Text = StudentAddress;
            txtPhone.Text = StudentPhone;

            txtFartherName.Text = StudentFartherName;
            txtFartherWork.Text = StudentFartherWork;
            txtFartherPhone.Text = StudentFartherPhone;

            txtMotherName.Text = StudentMotherName;
            txtMotherWork.Text = StudentMotherWork;
            txtMotherPhone.Text = StudentMotherPhone;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
