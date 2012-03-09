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
    public partial class TeacherCheckWageForm : Form
    {
        public string TeacherName;
        public DateTime wageTime;
        public double TeacherWage;
        public string TeacherPwd;

        public TeacherCheckWageForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtTeacherPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入核实密码！");
                txtTeacherPwd.Focus();
                return;
            }
            if (!TeacherPwd.Equals(txtTeacherPwd.Text))
            {
                MessageBox.Show("对不起，您的核实密码不正确，请重新输入！");
                txtTeacherPwd.Text = "";
                txtTeacherPwd.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void TeacherCheckWageForm_Load(object sender, EventArgs e)
        {
            lblTeacherName.Text = TeacherName;
            lblTeacherWage.Text = TeacherWage + "元";
            lblWageTime.Text = wageTime.ToString("yyyy年MM月");
        }
    }
}
