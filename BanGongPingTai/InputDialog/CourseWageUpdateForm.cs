using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanGongPingTai
{
    public partial class CourseWageUpdateForm : Form
    {
        public double Coefficient = 1.0;
        public string CourseType;
        public int CourseNum;
        public double StandardPrice;
        public double ActualPrice;
        public double CourseAmount;
        public string Remark;

        public CourseWageUpdateForm()
        {
            InitializeComponent();
        }

        private void CourseWageUpdateForm_Load(object sender, EventArgs e)
        {
            txtCourseType.Text = CourseType;
            txtCourseNum.Text = CourseNum + "";
            txtStandardPrice.Text = StandardPrice + "";
            txtActualPrice.Text = ActualPrice + "";
            txtAmount.Text = CourseAmount + "";
            txtRemark.Text = Remark;
        }

        private void txtCourseNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtActualPrice.Text != null && txtCourseNum.Text != null)
            {
                txtAmount.Text = txtActualPrice.Value * txtCourseNum.Value * Coefficient + "";
            }
        }

        private void txtActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtActualPrice.Text != null && txtCourseNum.Text != null)
            {
                txtAmount.Text = txtActualPrice.Value * txtCourseNum.Value * Coefficient + "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCourseType.Text.Trim() == "")
            {
                MessageBox.Show("请输入课程类型！", "提示", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                txtCourseType.Focus();
                return;
            }
            if (txtCourseNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入月实际上课次数（人数）！", "提示", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                txtCourseNum.Focus();
                return;
            }
            if (txtStandardPrice.Text.Trim() == "")
            {
                MessageBox.Show("请输入对应单价（标准）！", "提示", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                txtStandardPrice.Focus();
                return;
            }
            if (txtActualPrice.Text.Trim() == "")
            {
                MessageBox.Show("请输入对应单价（实际）！", "提示", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                txtActualPrice.Focus();
                return;
            }
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("请输入课量工资（标准）！", "提示", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }
            this.CourseType = txtCourseType.Text;
            this.CourseNum = txtCourseNum.Value;
            this.StandardPrice = txtStandardPrice.Value;
            this.ActualPrice = txtActualPrice.Value;
            this.CourseAmount = txtAmount.Value;
            this.Remark = txtRemark.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
