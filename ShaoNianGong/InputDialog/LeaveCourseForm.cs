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
    public partial class LeaveCourseForm : Form
    {
        public string StudentName;
        public string ExpireTime;

        public string CourseType;
        public string CourseSubtype;
        public string CourseName;
        public string ChargeType;
        public string ChargeAmount;

        public int RefundAmount;
        public string LeaveReason;

        public LeaveCourseForm()
        {
            InitializeComponent();
        }

        private void LeaveCourseForm_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = StudentName;
            txtExpireTime.Text = ExpireTime;
            
            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubtype;
            txtCourseName.Text = CourseName;
            txtChargeType.Text = ChargeType;
            txtChargeAmount.Text = ChargeAmount;
        }

        private void txtActualRefundAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtRefoundAmount.Text != txtActualRefundAmount.Text)
            {
                MessageBox.Show("两次输入的金额不一致!", "金额不一致",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRefoundAmount.Focus();
                return;
            }

            try
            {
                RefundAmount = int.Parse(txtRefoundAmount.Text);
                if (RefundAmount < 0)
                {
                    MessageBox.Show("退款金额必须为大于或等于0的整数!", "退款金额不合法",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRefoundAmount.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("退款金额必须为大于或等于0的整数!", "退款金额不合法",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRefoundAmount.Focus();
                return;
            }
            LeaveReason = txtLeaveReason.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
