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
    public partial class ConfirmCardConnectForm : Form
    {
        public string CardNo;

        public string TeacherName;
        public string TeacherSex;
        public string TeacherAddress;
        public string TeacherPhone;

        public ConfirmCardConnectForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ConfirmCardConnectForm_Load(object sender, EventArgs e)
        {
            txtCardNo.Text = CardNo;

            txtName.Text = TeacherName;
            txtSex.Text = TeacherSex;
            txtAddress.Text = TeacherAddress;
            txtPhone.Text = TeacherPhone;
        }
    }
}
