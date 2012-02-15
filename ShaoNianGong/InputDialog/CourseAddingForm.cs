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
    public partial class CourseAddingForm : Form
    {
        public string CourseType;
        public string CourseSubType;
        public string CourseName;
        public int ChargeType;
        public int ChargeAmount;

        public CourseAddingForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

            ConfirmCourseAddingForm frmConfirm = new ConfirmCourseAddingForm();
            frmConfirm.CourseType = txtCourseType.Text;
            frmConfirm.CourseSubType = txtCourseSubtype.Text;
            frmConfirm.CourseName = txtCourseName.Text;
            frmConfirm.ChargeType = cmbChargeMethod.Text;
            frmConfirm.ChargeAmount = txtChargeAmount.Text;
            if (frmConfirm.ShowDialog() != DialogResult.OK)
                return;

            CourseName = txtCourseName.Text.Trim();
            ChargeType = cmbChargeMethod.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }

        private void CourseAddingForm_Load(object sender, EventArgs e)
        {
            cmbChargeMethod.SelectedIndex = 0;
            txtCourseType.Text = CourseType;
            txtCourseSubtype.Text = CourseSubType;
        }
    }
}
