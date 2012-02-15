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
    public partial class CourseExtendForm : Form
    {
        public string StudentName;
        public string Balance;
        public string CurrentExpireDate;

        public string CourseType;
        public string CourseSubtype;
        public string CourseName;
        public string ChargeType;
        public string ChargeAmount;

        // Output
        public DateTime ExpireDate;
        public int signUpTime;
        public int TotalCost;
        public int ActualCost;
        public string DiscountReason;

        public CourseExtendForm()
        {
            InitializeComponent();
        }

        private void CourseExtendForm_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = StudentName;
            txtBalance.Text = Balance;

            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubtype;
            txtCourseName.Text = CourseName;
            txtChargeType.Text = ChargeType;
            txtChargeAmount.Text = ChargeAmount;

            txtCost.Text = ChargeAmount;
            txtActualCost.Text = ChargeAmount;

            dtSignUpDate.Value = DateTime.Parse(CurrentExpireDate);
            DateTime expireTime = dtSignUpDate.Value;
            if (txtChargeType.Text.Contains("季度"))
            {
                lblCostType.Text = "季度";
                expireTime = expireTime.AddMonths(3);
                txtExpireDate.Text = expireTime.ToLongDateString();
                // 过期时间自动生成
                txtExpireDate.Visible = true;
                dtExpireDate.Visible = false;
            }
            else if (txtChargeType.Text.Contains("月"))
            {
                lblCostType.Text = "月";
                expireTime = expireTime.AddMonths(1);
                txtExpireDate.Text = expireTime.ToLongDateString();
                // 过期时间自动生成
                txtExpireDate.Visible = true;
                dtExpireDate.Visible = false;
            }
            else
            {
                lblCostType.Text = "课次";
                // 过期时间手动输入
                txtExpireDate.Visible = false;
                dtExpireDate.Visible = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int costTimes;
            if (!int.TryParse(txtSignupTimes.Text, out costTimes))
            {
                MessageBox.Show("请输入要报名的时长（必须为正整数）", "报名时长不合法", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSignupTimes.Focus();
                return;
            }

            // 更新到期时间
            DateTime expireTime = dtSignUpDate.Value;
            if (txtChargeType.Text.Contains("季度"))
                expireTime = expireTime.AddMonths(3 * costTimes);
            else if (txtChargeType.Text.Contains("月"))
                expireTime = expireTime.AddMonths(costTimes);
            txtExpireDate.Text = expireTime.ToLongDateString();

            int balance = int.Parse(txtBalance.Text);
            if (!int.TryParse(txtActualCost.Text, out this.ActualCost))
            {
                MessageBox.Show("实际费用必须为正整数", "实际费用不合法", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtActualCost.Focus();
                return;
            }
            if (balance < ActualCost)
            {
                MessageBox.Show("余额不足，请充值或减少所要报名的时长", "余额不足，无法报名", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.TotalCost = int.Parse(txtCost.Text);
            if (this.ActualCost < this.TotalCost)
            {
                if (txtDiscountReason.Text.Trim() == "")
                {
                    MessageBox.Show("请输入折扣原因", "请输入折扣原因", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (txtExpireDate.Visible == true)
                this.ExpireDate = DateTime.Parse(txtExpireDate.Text);
            else
                this.ExpireDate = dtExpireDate.Value;

            if (MessageBox.Show("确认报名“" + txtCourseName.Text + "”，花费“" + txtActualCost.Text + "”元，有效期至“" + this.ExpireDate.ToLongDateString() + "”吗？",
                "确认报名课程", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            this.signUpTime = int.Parse(txtSignupTimes.Text);
            this.DiscountReason = txtDiscountReason.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtSignupTimes_TextChanged(object sender, EventArgs e)
        {
            int costTimes;
            if (!int.TryParse(txtSignupTimes.Text, out costTimes))
                return;

            // 计算费用
            int cost = int.Parse(txtChargeAmount.Text) * costTimes;
            txtCost.Text = cost.ToString();
            txtActualCost.Text = cost.ToString();

            // 计算到期时间
            DateTime expireTime = dtSignUpDate.Value;
            if (txtChargeType.Text.Contains("季度"))
                expireTime = expireTime.AddMonths(3 * costTimes);
            else if (txtChargeType.Text.Contains("月"))
                expireTime = expireTime.AddMonths(costTimes);
            txtExpireDate.Text = expireTime.ToLongDateString();
        }

        private void dtSignUpDate_ValueChanged(object sender, EventArgs e)
        {
            int costTimes;
            if (!int.TryParse(txtSignupTimes.Text, out costTimes))
                return;

            // 计算到期时间
            DateTime expireTime = dtSignUpDate.Value;
            if (txtChargeType.Text.Contains("季度"))
                expireTime = expireTime.AddMonths(3 * costTimes);
            else if (txtChargeType.Text.Contains("月"))
                expireTime = expireTime.AddMonths(costTimes);
            txtExpireDate.Text = expireTime.ToLongDateString();
        }

        private void dtExpireDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
