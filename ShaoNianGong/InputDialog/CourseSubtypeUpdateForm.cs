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
    public partial class CourseSubtypeUpdateForm : Form
    {
        public string CourseTypeName;
        public string CourseSubtypeName;

        public CourseSubtypeUpdateForm()
        {
            InitializeComponent();
        }

        private void CourseSubtypeUpdateForm_Shown(object sender, EventArgs e)
        {
            txtCourseSubtype.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCourseSubtype.Text.Trim() == "")
            {
                MessageBox.Show("请输入科目名称", "请输入科目名称", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCourseSubtype.Focus();
                return;
            }

            CourseSubtypeName = txtCourseSubtype.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CourseSubtypeUpdateForm_Load(object sender, EventArgs e)
        {
            txtCourseType.Text = CourseTypeName;
            txtCourseSubtype.Text = CourseSubtypeName;
        }
    }
}
