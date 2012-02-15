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
    public partial class CourseTypeUpdateForm : Form
    {
        public string CourseTypeName;
        public CourseTypeUpdateForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCourseTypeName.Text.Trim() == "")
            {
                MessageBox.Show("请输入类别名称", "请输入类别名称", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCourseTypeName.Focus();
                return;
            }

            CourseTypeName = txtCourseTypeName.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void CourseTypeUpdateForm_Shown(object sender, EventArgs e)
        {
            txtCourseTypeName.Focus();
        }

        private void CourseTypeUpdateForm_Load(object sender, EventArgs e)
        {
            txtCourseTypeName.Text = CourseTypeName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
