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
    public partial class SalaryChangeForm : Form
    {
        public string TeacherName;
        public string Sex;
        public string Address;
        public string Phone;
        public string OriginalSalary;

        public DateTime AdjustDate;
        public int NewSalary;

        public SalaryChangeForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewSalary.Text != txtConfirmNewSalary.Text)
            {
                MessageBox.Show("两次输入的工资金额不同", "工资金额不同", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNewSalary.Focus();
                return;
            }
            if (!int.TryParse(txtNewSalary.Text, out NewSalary) || NewSalary < 0)
            {
                MessageBox.Show("工资必须为非负整数", "输入工资非法", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNewSalary.Focus();
                return;
            }
            this.AdjustDate = dtSalaryAdjust.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SalaryChangeForm_Load(object sender, EventArgs e)
        {
            txtName.Text = TeacherName;
            txtSex.Text = Sex;
            txtAddress.Text = Address;
            txtPhone.Text = Phone;
            txtOriginalSalary.Text = OriginalSalary;
            dtSalaryAdjust.Value = DateTime.Now;
        }
    }
}
