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
    public partial class CourseUpdateForm : Form
    {
        public string CourseType;
        public string CourseSubType;
        public string CourseName;
        public int ChargeType;
        public int ChargeAmount;

        public CourseUpdateForm()
        {
            InitializeComponent();
        }

        private void CourseUpdateForm_Load(object sender, EventArgs e)
        {
            cmbChargeMethod.SelectedIndex = 0;
            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubType;
            txtCourseName.Text = CourseName;
            txtChargeAmount.Text = ChargeAmount+"";
            string selChargeType = "按季度收费";
            switch(ChargeType) {
                case 0:
                    selChargeType = "按季度收费";
                    break;
                case 1:
                    selChargeType = "按月份收费";
                    break;
                case 2:
                    selChargeType = "按课次收费";
                    break;
                default:
                    break;
            }
            for (int i = 0; i < cmbChargeMethod.Items.Count; i++)
            {
                if (cmbChargeMethod.Items[i].ToString().Equals(selChargeType))
                {
                    cmbChargeMethod.SelectedIndex = i;
                    break;
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text.Trim() == "")
            {
                MessageBox.Show("请输入课程名称", "请输入课程名称", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return;
            }

            try
            {
                ChargeAmount = int.Parse(txtChargeAmount.Text);
                if (ChargeAmount <= 0)
                {
                    MessageBox.Show("收取费用必须为正整数", "收取费用不合法", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtChargeAmount.Text = "";
                    txtChargeAmount.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("收取费用必须为正整数", "收取费用不合法", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtChargeAmount.Text = "";
                txtChargeAmount.Focus();
                return;
            }

            CourseName = txtCourseName.Text.Trim();
            ChargeType = cmbChargeMethod.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
