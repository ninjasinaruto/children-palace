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
    public partial class StudentInfoEditForm : Form
    {
        public string StudentName;
        public string StudentBirthday;
        public string StudentSex;
        public string StudentAddress;
        public string StudentPhone;
        public string StudentFartherName;
        public string StudentFartherWork;
        public string StudentFartherPhone;
        public string StudentMotherName;
        public string StudentMotherWork;
        public string StudentMotherPhone;

        public StudentInfoEditForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认修改“" + txtName.Text + "”的信息？", "确认修改信息",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            StudentAddress = txtAddress.Text;
            StudentPhone = txtPhone.Text;
            StudentFartherName = txtFartherName.Text;
            StudentFartherPhone = txtFartherPhone.Text;
            StudentFartherWork = txtFartherWork.Text;
            StudentMotherName = txtMotherName.Text;
            StudentMotherPhone = txtMotherPhone.Text;
            StudentMotherWork = txtMotherWork.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void StudentInfoEditForm_Load(object sender, EventArgs e)
        {
            txtName.Text = StudentName;
            txtSex.Text = StudentSex;
            txtBirthday.Text = StudentBirthday;

            txtAddress.Text = StudentAddress;
            txtPhone.Text = StudentPhone;

            txtFartherName.Text = StudentFartherName;
            txtFartherWork.Text = StudentFartherWork;
            txtFartherPhone.Text = StudentFartherPhone;

            txtMotherName.Text = StudentMotherName;
            txtMotherWork.Text = StudentMotherWork;
            txtMotherPhone.Text = StudentMotherPhone;
        }
    }
}
