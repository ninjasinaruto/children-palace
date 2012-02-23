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
    public partial class CourseTypeSelectForm : Form
    {
        public int CourseTypeId;
        public string CourseTypeName;
        public string userName;
        public bool isPrivate = false;

        public CourseTypeSelectForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CourseTypeId = int.Parse(lstCourseType.SelectedValue.ToString());
            CourseTypeName = lstCourseType.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void CourseTypeSelectForm_Load(object sender, EventArgs e)
        {
            if (!isPrivate)
            {
                courseTypesTableAdapter.Fill(staticDataSet.CourseTypes);
            }
            else
            {
                courseTypesTableAdapter.FillByUserName(staticDataSet.CourseTypes, userName);
            }
            lstCourseType.SelectedIndex = 0;
        }
    }
}
