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
    public partial class PreregSignUpCoursesForm : Form
    {
        public PreregSignUpCoursesForm()
        {
            InitializeComponent();
        }

        private void SignUpCoursesForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“staticDataSet.DiscountLevel”中。您可以根据需要移动或删除它。
            this.discountLevelTableAdapter.Fill(this.staticDataSet.DiscountLevel);
            // TODO: 这行代码将数据加载到表“preregisterDataset.StudentCourses”中。您可以根据需要移动或删除它。
            this.studentCoursesTableAdapter.Fill(this.preregisterDataset.StudentCourses);
            // 获取新生列表
            this.studentsPreregTableAdapter.Fill(this.preregisterDataset.studentsPrereg);
            // 获取收费类别
            this.chargeTypeTableAdapter.Fill(this.staticDataSet.ChargeType);

            // 获取CourseTypes列表，填充对应的ComboBox
            this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "CourseTypeID";

            // 初始化date
            dtCurrentDate.Value = DateTime.Now;

            cmbDiscount.SelectedIndex = 0;
        }

        /// <summary>
        /// course_type变化时，更新course_sub_types
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courseTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position < 0)
                return;
            int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
            this.courseSubtypesTableAdapter.Fill(coursesDataSet.CourseSubtypes, courseTypeID);
        }

        /// <summary>
        /// course_sub_type变化时，更新courses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void studentsPreregBindingSource_PositionChanged(object sender, EventArgs e)
        {
            /*
            txtPreregisterCourseSubtype.Text = "";
            if (studentsPreregBindingSource.Position < 0)
                return;

            // 更新预报名科目
            int? courseSubtypeID = this.preregisterDataset.studentsPrereg.Rows[studentsPreregBindingSource.Position].Field<int?>("PreregisterCourseSubtype");
            if (courseSubtypeID == null)
                return;
            DataRow[] rows = preregisterDataset.CourseSubtypes.Select("ID = " + courseSubtypeID);
            if (rows.Length <= 0)
                return;
            DataRow row = rows[0];
            string courseSubtypeName = row.Field<string>("CourseSubtypeName");
            txtPreregisterCourseSubtype.Text = courseSubtypeName;
             */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CardConnectForm frmCardConnect = new CardConnectForm();
            frmCardConnect.ShowDialog();

            if (frmCardConnect.cardNo == "")
                return;

            studentsPreregBindingSource.MoveFirst();
            while (dgvPreregStudents.SelectedRows[0].Cells["CardNoColumn"].Value.ToString() != frmCardConnect.cardNo
                && dgvPreregStudents.SelectedRows[0].Index < dgvPreregStudents.Rows.Count - 1)
            {
                studentsPreregBindingSource.MoveNext();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtCourseId.Text == "")
                return;

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

            ConfirmSignUpCoursesForm frmConfirmSignUpCourses = new ConfirmSignUpCoursesForm();
            if (dgvPreregStudents.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvPreregStudents.SelectedRows[0];
            frmConfirmSignUpCourses.CourseType = lstCourseType.Text;
            frmConfirmSignUpCourses.CourseSubType = lstCourseSubtypes.Text;
            frmConfirmSignUpCourses.CourseName = txtCourseName.Text;

            frmConfirmSignUpCourses.CurrentDate = dtCurrentDate.Value.ToString();
            if (txtExpireDate.Visible == true)
                frmConfirmSignUpCourses.ExpireDate = txtExpireDate.Text;
            else
                frmConfirmSignUpCourses.ExpireDate = dtExpireDate.Text;
            frmConfirmSignUpCourses.SignUpPeriod = txtSignupTimes.Text + "个" + lblCostType.Text;
            frmConfirmSignUpCourses.TotalCost = txtTotalCost.Text;

            frmConfirmSignUpCourses.Discount = cmbDiscount.Text;
            frmConfirmSignUpCourses.DiscountReason = txtDiscountReason.Text;
            frmConfirmSignUpCourses.ActualCostAmount = txtActualCostAmount.Text;

            frmConfirmSignUpCourses.StudentName = row.Cells["NameColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentSex = row.Cells["SexColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentBirthday = row.Cells["BirthdayColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentAddress = row.Cells["AddressColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentPhone = row.Cells["TelephoneColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentFartherName = row.Cells["FartherNameColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentFartherPhone = row.Cells["FartherTelColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentFartherWork = row.Cells["FartherWorkColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentMotherName = row.Cells["MotherNameColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentMotherPhone = row.Cells["MotherTelColumn"].Value.ToString();
            frmConfirmSignUpCourses.StudentMotherWork = row.Cells["MotherWorkColumn"].Value.ToString();

            frmConfirmSignUpCourses.Text = "确认要为“" + txtName.Text + "”报名" + txtSignupTimes.Text
                + "个" + lblCostType.Text + "的“" + txtCourseName.Text + "”课程吗？ 共需花费" + actualCost + "元。";
            if (frmConfirmSignUpCourses.ShowDialog() != DialogResult.OK)
                return;

            // 报名：
            // 1> 扣钱:
            // 1.1> 更新balance
            balance -= actualCost;
            studentsPreregTableAdapter.UpdateBalance(balance, txtID.Text);
            txtBalance.Text = balance.ToString();
            if (dgvPreregStudents.SelectedRows.Count > 0)
            {
                row.Cells["BalanceColumn"].Value = txtBalance.Text;
            }
            // 1.2> 添加扣钱记录
            studentCostTableAdapter.Insert(int.Parse(txtID.Text), int.Parse(txtCourseId.Text), int.Parse(txtCost.Text), dtCurrentDate.Value,
                int.Parse(cmbDiscount.SelectedValue.ToString()), int.Parse(txtActualCostAmount.Text), txtDiscountReason.Text, User.CurrentUser.UserName);

            // 2> 添加报名信息
            DateTime expireDate;
            if (txtExpireDate.Visible == true)
                expireDate = DateTime.Parse(txtExpireDate.Text);
            else
                expireDate = dtExpireDate.Value;
            studentCoursesTableAdapter.Insert(int.Parse(txtID.Text), int.Parse(txtCourseId.Text), expireDate, int.Parse(txtTotalCost.Text), int.Parse(txtSignupTimes.Text));

            // 3> 更新学生的学费过期时间
            studentsPreregTableAdapter.UpdateExpireTime(expireDate, int.Parse(txtID.Text));

            // 4> 更新状态，报名成功
            studentsPreregTableAdapter.UpdateStatus(1, int.Parse(txtID.Text));

            MessageBox.Show("报名成功！", "报名课程成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                UpdateExpireTime();
                UpdateActualCost();
            }
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

        private void txtSignupTimes_Leave(object sender, EventArgs e)
        {
            UpdateExpireTime();
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

            DateTime expireTime = dtCurrentDate.Value;
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

            DateTime expireTime = dtCurrentDate.Value;
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

        private void txtSignupTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void SignUpCoursesForm_Resize(object sender, EventArgs e)
        {
            dgvPreregStudents.Width = this.Width - 45;
            dgvPreregStudents.Height = this.Height - 427;
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
            try
            {
                totalCost = int.Parse(txtTotalCost.Text);
                if (totalCost < 0)
                {
                    if (!"".Equals(txtTotalCost.Text))
                    {
                        MessageBox.Show("收费金额必须为非负整数", "收费金额不合法", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }
                    txtTotalCost.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                if (!"".Equals(txtTotalCost.Text))
                {
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

            DateTime expireTime = dtCurrentDate.Value;
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

        private void dtExpireDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtCurrentDate_ValueChanged(object sender, EventArgs e)
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

            DateTime expireTime = dtCurrentDate.Value;
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
