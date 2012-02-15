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
    public partial class PreregisterForm : Form
    {
        public string studentName = "";

        public PreregisterForm()
        {
            InitializeComponent();
        }

        private void btnPreregister_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不可为空");
                return;
            }

            ConfirmPreregisterForm frmConfirmPreregister = new ConfirmPreregisterForm();
            frmConfirmPreregister.StudentCourseType = lstCourseType.Text;
            frmConfirmPreregister.StudentCourseSubType = lstCourseSubtypes.Text;
            frmConfirmPreregister.StudentName = txtName.Text;
            frmConfirmPreregister.StudentSex = cmbSex.Text;
            frmConfirmPreregister.StudentBirthday = dateBirth.Text;
            frmConfirmPreregister.StudentAddress = txtAddress.Text;
            frmConfirmPreregister.StudentPhone = txtPhone.Text;
            frmConfirmPreregister.StudentFartherName = txtFartherName.Text;
            frmConfirmPreregister.StudentFartherPhone = txtFartherPhone.Text;
            frmConfirmPreregister.StudentFartherWork = txtFartherWork.Text;
            frmConfirmPreregister.StudentMotherName = txtMotherName.Text;
            frmConfirmPreregister.StudentMotherPhone = txtMotherPhone.Text;
            frmConfirmPreregister.StudentMotherWork = txtMotherWork.Text;
            frmConfirmPreregister.Text = "确定为" + txtName.Text + "进行预报名？";
            if (frmConfirmPreregister.ShowDialog() != DialogResult.OK)
                return;
 
            try
            {
                int? courseSubtype;
                if (lstCourseSubtypes.SelectedValue == null)
                    courseSubtype = null;
                else
                    courseSubtype = int.Parse(lstCourseSubtypes.SelectedValue.ToString());

                studentsPreregTableAdapter.Insert(txtName.Text,
                    cmbSex.Text, txtPhone.Text, txtAddress.Text,
                    dateBirth.Value.ToString(), txtFartherName.Text, txtFartherWork.Text, txtFartherPhone.Text,
                    txtMotherName.Text, txtMotherWork.Text, txtMotherPhone.Text, 0, courseSubtype, txtRecommender.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            studentName = txtName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PreregisterForm_Load(object sender, EventArgs e)
        {
            // 填充CourseTypes列表
            this.courseTypesTableAdapter.Fill(this.staticDataSet.CourseTypes);
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "CourseTypeID";

            this.studentsPreregTableAdapter.Fill(this.preregisterDataset.studentsPrereg);
            cmbSex.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void courseTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            int courseTypeID = this.staticDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
            this.courseSubtypesTableAdapter.Fill(coursesDataSet.CourseSubtypes, courseTypeID);
            coursesDataSet.Courses.CourseSubTypeIDColumn.DefaultValue = courseTypeID;
        }

        private void courseTypesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
