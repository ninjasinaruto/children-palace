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
    public partial class SignUpCoursesForm : Form
    {
        public SignUpCoursesForm()
        {
            InitializeComponent();
        }

        private void SignUpCoursesForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“preregisterDataset.StudentCourses”中。您可以根据需要移动或删除它。
            this.studentCoursesTableAdapter.Fill(this.preregisterDataset.StudentCourses);
            // 获取新生列表
            this.studentsPreregTableAdapter.FillByPositiveBalance(this.preregisterDataset.studentsPrereg);
            // 获取收费类别
            this.chargeTypeTableAdapter.Fill(this.staticDataSet.ChargeType);

            // 获取CourseTypes列表，填充对应的ComboBox
            this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "CourseTypeID";

            // 初始化date
            txtCurrentDate.Text = DateTime.Now.ToLongDateString();
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
            txtPreregisterCourseSubtype.Text = "";
            if (studentsPreregBindingSource.Position < 0)
                return;

            // 更新预报名科目
            int? courseSubtypeID = this.preregisterDataset.studentsPrereg.Rows[studentsPreregBindingSource.Position].Field<int?>("PreregisterCourseSubtype");
            if (courseSubtypeID == null)
                return;
            DataRow row = preregisterDataset.CourseSubtypes.Select("ID = " + courseSubtypeID)[0];
            string courseSubtypeName = row.Field<string>("CourseSubtypeName");
            txtPreregisterCourseSubtype.Text = courseSubtypeName;
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
            int costTimes;
            try
            {
                costTimes = int.Parse(txtSignupTimes.Text);
                if (costTimes <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入要报名的时长（必须为正整数）", "报名时长不合法", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                txtSignupTimes.Focus();
                return;
            }

            int balance;
            int cost;
            try
            {
                balance = int.Parse(txtBalance.Text);
                cost = int.Parse(txtCost.Text) * costTimes;

                if (balance < cost)
                {
                    MessageBox.Show("余额不足，请充值或减少所要报名的时长", "余额不足", MessageBoxButtons.OK,
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

            frmConfirmSignUpCourses.CurrentDate = txtCurrentDate.Text;
            frmConfirmSignUpCourses.ExpireDate = txtExpireDate.Text;
            frmConfirmSignUpCourses.SignUpPeriod = txtSignupTimes.Text + "个" + lblCostType.Text;
            frmConfirmSignUpCourses.TotalCost = txtTotalCost.Text;

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
                + "个" + lblCostType.Text + "的“" + txtCourseName.Text + "”课程吗？ 共需花费" + cost + "元。";
            if (frmConfirmSignUpCourses.ShowDialog() != DialogResult.OK)
                return;

            // 报名：
            // 1> 扣钱
            balance -= cost;
            studentsPreregTableAdapter.UpdateBalance(balance, txtID.Text);
            txtBalance.Text = balance.ToString();
            if (dgvPreregStudents.SelectedRows.Count > 0)
            {
                row.Cells["BalanceColumn"].Value = txtBalance.Text;
            }

            // 2> 添加报名信息
            studentCoursesTableAdapter.Insert(int.Parse(txtID.Text), int.Parse(txtCourseId.Text), DateTime.Parse(txtExpireDate.Text));

            // 3> 更新状态，报名成功
            studentsPreregTableAdapter.UpdateStatus(1, int.Parse(txtID.Text));

            MessageBox.Show("报名成功！", "报名成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void coursesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.coursesBindingSource.Position < 0)
            {
                btnSignup.Enabled = false;
                txtTotalCost.Text = "";
                txtExpireDate.Text = "";
            }
            else
            {
                btnSignup.Enabled = true;
                UpdateExpireTime();
            }
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

        private void txtSignupTimes_Leave(object sender, EventArgs e)
        {
            UpdateExpireTime();
        }

        private void UpdateExpireTime()
        {
            int costTimes;
            try
            {
                costTimes = int.Parse(txtSignupTimes.Text);
                if (costTimes <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入要报名的时长（必须为正整数）", "报名时长不合法", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                txtSignupTimes.Focus();
                return;
            }

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
            txtExpireDate.Text = expireTime.ToLongDateString();

            if (coursesBindingSource.Position < 0)
                return;
            int cost = coursesDataSet.Courses.Rows[coursesBindingSource.Position].Field<int>("ChargeAmount") * costTimes;
            txtTotalCost.Text = cost.ToString();
        }

        private void txtSignupTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                UpdateExpireTime();
            }
        }

        private void SignUpCoursesForm_Resize(object sender, EventArgs e)
        {
            dgvPreregStudents.Width = this.Width - 45;
            dgvPreregStudents.Height = this.Height - 427;
        }

        private void SignUpCoursesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.MdiFormClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }
    }
}
