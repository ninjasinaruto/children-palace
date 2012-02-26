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
    public partial class ChangeCourseForm : Form
    {
        public int StudentID;
        public string StudentName;
        public string Balance;
        public string CurrentExpireDate;

        public int CourseID;
        public string CourseType;
        public string CourseSubtype;
        public string CourseName;
        public string ChargeType;
        public string ChargeAmount;

        public int NewCourseID;
        public string NewCourseType;
        public string NewCourseSubtype;
        public string NewCourseName;
        public int NewChargeType;
        public string NewChargeTypeName;
        public string NewChargeAmount;
        public string NewDiscountLevel;

        public int SignUpTime;
        public string SignUpPeriod;
        public int TotalCost;
        public int ActualCost;
        public DateTime NewExpireTime;
        public int DiscountLevel;
        public string DiscountLevelName;
        public string DiscountReason;

        public int SettlementAmount;
        public int InbackAmount;

        public ChangeCourseForm()
        {
            InitializeComponent();
        }

        private void ChangeCourseForm_Load(object sender, EventArgs e)
        {
            this.studentCoursesTableAdapter.Fill(this.staticDataSet.StudentCourses, StudentID);
            // TODO: 这行代码将数据加载到表“staticDataSet.CourseTypes”中。您可以根据需要移动或删除它。
            this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            // TODO: 这行代码将数据加载到表“staticDataSet.DiscountLevel”中。您可以根据需要移动或删除它。
            this.discountLevelTableAdapter.Fill(this.staticDataSet.DiscountLevel);
            // TODO: 这行代码将数据加载到表“staticDataSet.ChargeType”中。您可以根据需要移动或删除它。
            this.chargeTypeTableAdapter.Fill(this.staticDataSet.ChargeType);
            txtStudentName.Text = StudentName;
            txtBalance.Text = Balance;
            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubtype;
            txtCourseName.Text = CourseName;
            txtChargeType.Text = ChargeType;
            txtChargeAmount.Text = ChargeAmount;

            // 获取收费类别
            this.chargeTypeTableAdapter.Fill(this.staticDataSet.ChargeType);
            this.discountLevelTableAdapter.Fill(this.staticDataSet.DiscountLevel);

            // 获取CourseTypes列表，填充对应的ComboBox
            this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "CourseTypeID";

            txtCurrentExpireTime.Text = DateTime.Parse(CurrentExpireDate).ToLongDateString();
            dtExpireDate.Value = DateTime.Parse(CurrentExpireDate);
            cmbDiscount.SelectedIndex = 0;

            doCalculate();
        }

        private void doCalculate()
        {
            if (coursesBindingSource.Position < 0 || cmbDiscount.SelectedIndex < 0)
                return;
            cmbDiscount.SelectedIndex = 0;
            txtSignupTimes.Text = "1";
            if (!cmbChargeMethod.Text.Equals(txtChargeType.Text))
            {
                // 收费方式不同
                txtSettlementAmount.Text = "";
                txtSettlementAmount.ReadOnly = false;

                txtSettlementAmount.Focus();
                DateTime expireTime = DateTime.Now;
                switch (lblCostType.Text)
                {
                    case "季度":
                        expireTime = expireTime.AddMonths(3 * 1);
                        break;
                    case "月":
                        expireTime = expireTime.AddMonths(1);
                        break;
                }
                dtExpireDate.Value = expireTime;

                int newCost = coursesDataSet.Courses.Rows[coursesBindingSource.Position].Field<int>("ChargeAmount") * 1;
                int discount = int.Parse(cmbDiscount.SelectedValue.ToString());
                int actualCost = newCost * discount / 100;
                txtTotalCost.Text = newCost.ToString();
                txtActualCostAmount.Text = actualCost.ToString();
            }
            else
            {
                // 收费方式相同
                // 原有课程费用
                int amount = int.Parse(ChargeAmount);
                // 新课费用
                int cost = 0;
                // 差额
                int diff = 0;
                if (!"".Equals(txtCost.Text))
                {
                    cost = int.Parse(txtCost.Text);
                }
                // 计算补缴金额
                if (amount < cost)
                {
                    diff = cost - amount;
                    txtTotalCost.Text = diff + "";
                    txtActualCostAmount.Text = diff + "";
                    
                    txtSettlementAmount.Text = "";
                    txtSettlementAmount.ReadOnly = true;
                }
                else
                {
                    diff = amount - cost;
                    txtTotalCost.Text = "0";
                    txtActualCostAmount.Text = "0";

                    txtSettlementAmount.Text = diff + "";
                    txtSettlementAmount.ReadOnly = false;
                }
                dtExpireDate.Value = DateTime.Parse(CurrentExpireDate);
            }
        }

        private void courseTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position < 0)
                return;
            int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
            this.courseSubtypesTableAdapter.Fill(coursesDataSet.CourseSubtypes, courseTypeID);
        }

        private void courseSubtypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.courseSubtypesBindingSource.Position < 0)
            {
                coursesDataSet.Courses.Clear();
                return;
            }
            int courseSubTypeID = this.coursesDataSet.CourseSubtypes.Rows[this.courseSubtypesBindingSource.Position].Field<int>("ID");
            coursesTableAdapter.Fill(coursesDataSet.Courses, courseSubTypeID);

            coursesDataSet.Courses.CourseSubTypeIDColumn.DefaultValue = courseSubTypeID;
            doCalculate();
        }

        private void coursesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.coursesBindingSource.Position < 0)
            {
                txtChangeCourseName.Text = "";
                cmbChargeMethod.SelectedIndex = 0;
                txtCost.Text = "";
                txtSettlementAmount.Text = "";
                txtSettlementAmount.ReadOnly = true;
                txtSignupTimes.Text = "1";
                txtTotalCost.Text = "0";
                dtExpireDate.Value = DateTime.Parse(CurrentExpireDate);
                txtActualCostAmount.Text = "0";
                cmbDiscount.SelectedIndex = 0;
                txtDiscountReason.Text = "";
                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;
                doCalculate();
            }
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
            // 判断课程收费方式是否相同
            if (!cmbChargeMethod.Text.Equals(txtChargeType.Text))
            {
                // 收费方式不同
                txtSettlementAmount.ReadOnly = false;

                txtSettlementAmount.Focus();
                DateTime expireTime = DateTime.Now;
                switch (lblCostType.Text)
                {
                    case "季度":
                        expireTime = expireTime.AddMonths(3 * costTimes);
                        break;
                    case "月":
                        expireTime = expireTime.AddMonths(costTimes);
                        break;
                }
                dtExpireDate.Value = expireTime;

                int newCost = coursesDataSet.Courses.Rows[coursesBindingSource.Position].Field<int>("ChargeAmount") * costTimes;
                int discount = int.Parse(cmbDiscount.SelectedValue.ToString());
                int actualCost = newCost * discount / 100;
                txtTotalCost.Text = newCost.ToString();
                txtActualCostAmount.Text = actualCost.ToString();
            }
            else
            { 
                // 收费方式相同
                // 原有课程费用
                int amount = int.Parse(ChargeAmount);
                // 新课费用
                int cost = 0;
                // 差额
                int diff = 0;
                if (!"".Equals(txtCost.Text))
                {
                    cost = int.Parse(txtCost.Text);
                }
                // 计算补缴金额
                if (amount < cost*costTimes)
                {
                    diff = cost*costTimes - amount;
                    txtTotalCost.Text = diff + "";
                    txtActualCostAmount.Text = diff + "";

                    txtSettlementAmount.Text = "";
                    txtSettlementAmount.ReadOnly = true;
                }
                else
                {
                    diff = amount - cost*costTimes;
                    txtTotalCost.Text = "0";
                    txtActualCostAmount.Text = "0";

                    txtSettlementAmount.Text = diff + "";
                    txtSettlementAmount.ReadOnly = false;
                }
                DateTime expireTime = DateTime.Parse(CurrentExpireDate);
                if (costTimes > 1)
                {
                    switch (lblCostType.Text)
                    {
                        case "季度":
                            expireTime = expireTime.AddMonths(3 * (costTimes-1));
                            break;
                        case "月":
                            expireTime = expireTime.AddMonths(costTimes-1);
                            break;
                    }
                }
                dtExpireDate.Value = expireTime;
            }
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
            // 判断课程收费方式是否相同
            if (!cmbChargeMethod.Text.Equals(txtChargeType.Text))
            {
                // 收费方式不同
                DateTime expireTime = DateTime.Now;
                switch (lblCostType.Text)
                {
                    case "季度":
                        expireTime = expireTime.AddMonths(3 * costTimes);
                        break;
                    case "月":
                        expireTime = expireTime.AddMonths(costTimes);
                        break;
                }
                dtExpireDate.Value = expireTime;
            }
            else
            { 
                // 收费方式相同
                DateTime expireTime = DateTime.Parse(CurrentExpireDate);
                if (costTimes > 1)
                {
                    switch (lblCostType.Text)
                    {
                        case "季度":
                            expireTime = expireTime.AddMonths(3 * (costTimes - 1));
                            break;
                        case "月":
                            expireTime = expireTime.AddMonths(costTimes - 1);
                            break;
                    }
                }
                dtExpireDate.Value = expireTime;
            }
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
            }
            else if (cmbChargeMethod.Text.Contains("月"))
            {
                lblCostType.Text = "月";
            }
            else if (cmbChargeMethod.Text.Contains("课次"))
            {
                lblCostType.Text = "课次";
            }
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateActualCostAmount();
        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
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
                if (!txtTotalCost.Text.Equals(""))
                {
                    MessageBox.Show("补缴费用必须为非负整数", "补缴费用不合法", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
                txtTotalCost.Focus();
                return;
            }

            int discount = int.Parse(cmbDiscount.SelectedValue.ToString());
            int actualCost = totalCost * discount / 100;
            txtActualCostAmount.Text = actualCost.ToString();
        }

        private void numKeyPressEvent(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtSettlementAmount_TextChanged(object sender, EventArgs e)
        {
            int settlementAmount = 0;
            if (!"".Equals(txtSettlementAmount.Text))
            {
                settlementAmount = int.Parse(txtSettlementAmount.Text);
            }
            else
            {
                txtBalance.Text = Balance + "";
            }
            txtBalance.Text = int.Parse(Balance)+settlementAmount+"";
        }

        private void txtSettlementAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            numKeyPressEvent(e);
        }

        private void txtSignupTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            numKeyPressEvent(e);
        }

        private void txtTotalCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            numKeyPressEvent(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCourseId.Text == "")
            {
                MessageBox.Show("请选择需要转入的课程！");
                return;
            }
            DataRow[] scRow = this.staticDataSet.StudentCourses.Select("CourseID = " + txtCourseId.Text);
            if (scRow.Length > 0)
            {
                MessageBox.Show("该生已报过相同课程，无需重复报名！");
                return;
            }
            UpdateExpireTime();
            // 判断课程收费方式是否相同
            if (!cmbChargeMethod.Text.Equals(txtChargeType.Text))
            {
                if ("".Equals(txtSettlementAmount.Text))
                {
                    MessageBox.Show("请输入结算费用！");
                    txtSettlementAmount.Focus();
                    return;
                }
            }

            int balance;
            int actualCost;
            try
            {
                balance = int.Parse(txtBalance.Text);
                actualCost = int.Parse(txtActualCostAmount.Text);

                if (balance < actualCost)
                {
                    MessageBox.Show("余额不足，请充值或减少所要报名的时长！", "余额不足，无法报名", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            // 新课程信息
            this.NewCourseType = lstCourseType.Text;
            this.NewCourseSubtype = lstCourseSubtypes.Text;
            this.NewCourseName = lstCourses.Text;
            this.NewCourseID = int.Parse(lstCourses.SelectedValue.ToString());
            this.NewChargeTypeName = cmbChargeMethod.Text;
            this.NewChargeAmount = txtCost.Text;
            this.NewExpireTime = dtExpireDate.Value;
            this.DiscountLevel = int.Parse(cmbDiscount.SelectedValue.ToString());
            this.NewDiscountLevel = cmbDiscount.Text;
            this.DiscountReason = txtDiscountReason.Text;
            this.SettlementAmount = "".Equals(txtSettlementAmount.Text) ? 0 : int.Parse(txtSettlementAmount.Text);
            this.TotalCost = "".Equals(txtTotalCost.Text) ? 0 : int.Parse(txtTotalCost.Text);
            this.InbackAmount = "".Equals(txtActualCostAmount.Text) ? 0 : int.Parse(txtActualCostAmount.Text);

            this.SignUpTime = int.Parse(txtSignupTimes.Text);
            this.SignUpPeriod = txtSignupTimes.Text + "个" + lblCostType.Text;
           
            this.DialogResult = DialogResult.OK;
        }
    }
}
