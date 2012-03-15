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
    public partial class CourseSignUpForm : Form
    {
        public string CardNo;
        public string StudentName;
        public string Balance;
        public DataGridViewRow row;

        public int CourseId;
        public int DiscountLevel;
        public string CourseType;
        public string CourseSubType;
        public string CourseName;
        public string ExpireDate;
        public string SignUpTime;
        public string SignUpPeriod;
        public string TotalCost;
        public string Discount;
        public string DiscountReason;
        public string ActualCostAmount;
        public string ChargeType;
        
        public CourseSignUpForm()
        {
            InitializeComponent();
        }

        private void CourseSignUpForm_Load(object sender, EventArgs e)
        {
            txtCardNo.Text = CardNo;
            txtName.Text = StudentName;
            txtBalance.Text = Balance;

            // 获取收费类别
            this.chargeTypeTableAdapter.Fill(this.staticDataSet.ChargeType);
            this.discountLevelTableAdapter.Fill(this.staticDataSet.DiscountLevel);

            // 获取CourseTypes列表，填充对应的ComboBox
            this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "CourseTypeID";

            // 初始化date
            dtSignUpDate.Value = DateTime.Now;

            cmbDiscount.SelectedIndex = 0;
        }

        private void courseTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position < 0)
                return;
            int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
            this.courseSubtypesTableAdapter.Fill(coursesDataSet.CourseSubtypes, courseTypeID);
        }

        private void courseSubTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.courseSubTypesBindingSource.Position < 0)
            {
                coursesDataSet.Courses.Clear();
                return;
            }
            int courseSubTypeID = this.coursesDataSet.CourseSubtypes.Rows[this.courseSubTypesBindingSource.Position].Field<int>("ID");
            coursesTableAdapter.Fill(coursesDataSet.Courses, courseSubTypeID);

            coursesDataSet.Courses.CourseSubTypeIDColumn.DefaultValue = courseSubTypeID;
        }

        private void coursesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.coursesBindingSource.Position < 0)
            {
                btnSignup.Enabled = false;
                txtTotalCost.Text = "";
                txtExpireDate.Text = "";
                cmbDiscount.SelectedIndex = 0;
                txtDiscountReason.Text = "";
                txtActualCostAmount.Text = "";
            }
            else
            {
                btnSignup.Enabled = true;
                int chargeType = coursesDataSet.Courses.Rows[this.coursesBindingSource.Position].Field<int>("ChargeType");
                switch (chargeType)
                { 
                    case 0:
                        lblCostType.Text = "季度";
                        break;
                    case 1:
                        lblCostType.Text = "月";
                        break;
                    case 2:
                        lblCostType.Text = "课次";
                        break;
                }
                UpdateExpireTime();
                UpdateActualCost();
            }
        }
        private void UpdateActualCost()
        {
            if (coursesBindingSource.Position < 0 || cmbDiscount.SelectedIndex < 0)
                return;

            int costTimes;
            try
            {
                costTimes = int.Parse(txtSignupTimes.Text);
                if (costTimes <= 0)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            DateTime expireTime = dtSignUpDate.Value;
            switch (lblCostType.Text)
            {
                case "季度":
                    expireTime = expireTime.AddMonths(3 * costTimes);
                    break;
                case "月":
                    expireTime = expireTime.AddMonths(costTimes);
                    break;
            }
            txtExpireDate.Text = expireTime.ToLongDateString();

            int cost = coursesDataSet.Courses.Rows[coursesBindingSource.Position].Field<int>("ChargeAmount") * costTimes;
            int discount = int.Parse(cmbDiscount.SelectedValue.ToString());
            int actualCost = cost * discount / 100;
            txtTotalCost.Text = cost.ToString();
            txtActualCostAmount.Text = actualCost.ToString();
        }

        private void txtSignupTimes_TextChanged(object sender, EventArgs e)
        {
            if (coursesBindingSource.Position < 0 || cmbDiscount.SelectedIndex < 0)
                return;

            int costTimes;
            try
            {
                costTimes = int.Parse(txtSignupTimes.Text);
                if (costTimes <= 0)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            DateTime expireTime = dtSignUpDate.Value;
            switch (lblCostType.Text)
            {
                case "季度":
                    expireTime = expireTime.AddMonths(3 * costTimes);
                    break;
                case "月":
                    expireTime = expireTime.AddMonths(costTimes);
                    break;
            }
            txtExpireDate.Text = expireTime.ToLongDateString();

            int cost = coursesDataSet.Courses.Rows[coursesBindingSource.Position].Field<int>("ChargeAmount") * costTimes;
            int discount = int.Parse(cmbDiscount.SelectedValue.ToString());
            int actualCost = cost * discount / 100;
            txtTotalCost.Text = cost.ToString();
            txtActualCostAmount.Text = actualCost.ToString();
        }

        private void UpdateExpireTime()
        {
            if (coursesBindingSource.Position < 0 || cmbDiscount.SelectedIndex < 0)
                return;

            int costTimes;
            try
            {
                costTimes = int.Parse(txtSignupTimes.Text);
                if (costTimes <= 0)
                {
                    MessageBox.Show("请输入要报名的时长（必须为正整数）", "报名时长不合法", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    txtSignupTimes.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入要报名的时长（必须为正整数）", "报名时长不合法", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                txtSignupTimes.Focus();
                return;
            }

            DateTime expireTime = dtSignUpDate.Value;
            switch (lblCostType.Text)
            {
                case "季度":
                    expireTime = expireTime.AddMonths(3 * costTimes);
                    break;
                case "月":
                    expireTime = expireTime.AddMonths(costTimes);
                    break;
            }
            txtExpireDate.Text = expireTime.ToLongDateString();
        }

        private void txtSignupTimes_Leave(object sender, EventArgs e)
        {
            UpdateExpireTime();
        }

        private void cmbChargeMethod_TextChanged(object sender, EventArgs e)
        {
            if (cmbChargeMethod.Text.Contains("季度"))
            {
                lblCostType.Text = "季度";

                // 过期时间自动生成
                txtExpireDate.Visible = true;
                dtExpireDate.Visible = false;
            }
            else if (cmbChargeMethod.Text.Contains("月"))
            {
                lblCostType.Text = "月";

                // 过期时间自动生成
                txtExpireDate.Visible = true;
                dtExpireDate.Visible = false;
            }
            else if (cmbChargeMethod.Text.Contains("课次"))
            {
                lblCostType.Text = "课次";

                // 提示输入过期时间
                MessageBox.Show("该课程的收费方式为按照课次收费，请手动指定过期时间", "请指定过期时间",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExpireDate.Visible = false;
                dtExpireDate.Visible = true;
                dtExpireDate.Focus();
            }
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateActualCostAmount();
        }

        private void UpdateActualCostAmount()
        {
            if (cmbDiscount.SelectedIndex < 0)
                return;

            int totalCost;
            if (!int.TryParse(txtTotalCost.Text, out totalCost) || totalCost < 0)
            {
                if (!txtTotalCost.Text.Equals("")) {
                    MessageBox.Show("收费金额必须为非负整数", "收费金额不合法", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
                txtTotalCost.Focus();
                return;
            }

            int discount = int.Parse(cmbDiscount.SelectedValue.ToString());
            int actualCost = totalCost * discount / 100;
            txtActualCostAmount.Text = actualCost.ToString();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtCourseId.Text == "")
                return;
            UpdateExpireTime();

            int balance;
            int actualCost;
            try
            {
                balance = int.Parse(txtBalance.Text);
                actualCost = int.Parse(txtActualCostAmount.Text);

                if (balance < actualCost)
                {
                    MessageBox.Show("余额不足，请充值或减少所要报名的时长", "余额不足，无法报名", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            this.CourseType = lstCourseType.Text;
            this.CourseSubType = lstCourseSubtypes.Text;
            this.CourseName = txtCourseName.Text;
            this.CourseId = int.Parse(lstCourses.SelectedValue.ToString());
            this.DiscountLevel = int.Parse(cmbDiscount.SelectedValue.ToString());

            if (txtExpireDate.Visible == true)
                this.ExpireDate = txtExpireDate.Text;
            else
                this.ExpireDate = dtExpireDate.Text;
            this.SignUpTime = txtSignupTimes.Text;
            this.SignUpPeriod = txtSignupTimes.Text + "个" + lblCostType.Text;
            this.TotalCost = txtTotalCost.Text;

            this.Discount = cmbDiscount.Text;
            this.DiscountReason = txtDiscountReason.Text;
            this.ActualCostAmount = txtActualCostAmount.Text;
            this.ChargeType = cmbChargeMethod.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void dtSignUpDate_ValueChanged(object sender, EventArgs e)
        {
            int costTimes;
            try
            {
                costTimes = int.Parse(txtSignupTimes.Text);
                if (costTimes <= 0)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            DateTime expireTime = dtSignUpDate.Value;
            switch (lblCostType.Text)
            {
                case "季度":
                    expireTime = expireTime.AddMonths(3 * costTimes);
                    break;
                case "月":
                    expireTime = expireTime.AddMonths(costTimes);
                    break;
            }
            txtExpireDate.Text = expireTime.ToLongDateString();
        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {
            UpdateActualCostAmount();
        }
    }
}
