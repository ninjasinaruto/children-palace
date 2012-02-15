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
    public partial class ConfirmDepositForm : Form
    {
        public string DepositAmount;
        public string PaidAmount;
        public string TuitionAmount;
        public string MaterialsAmount;
        public string OtherAmount;
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

        public ConfirmDepositForm()
        {
            InitializeComponent();
        }

        private void ConfirmDepositForm_Load(object sender, EventArgs e)
        {
            txtDepositAmount.Text = DepositAmount;
            txtPaidAmount.Text = PaidAmount;
            txtTuition.Text = TuitionAmount;
            txtMaterials.Text = MaterialsAmount;
            txtOther.Text = OtherAmount;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
