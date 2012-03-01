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
    public partial class TeacherUpdateForm : Form
    {
        public string TeacherName;
        public string Sex;
        public string Address;
        public string Phone;

        public TeacherUpdateForm()
        {
            InitializeComponent();
        }

        private void TeacherUpdateForm_Load(object sender, EventArgs e)
        {
            txtName.Text = TeacherName;
            txtAddress.Text = Address;
            txtPhone.Text = Phone;
            for (int i = 0; i < cmbSex.Items.Count; i++)
            {
                if (cmbSex.Items[i].ToString().Equals(Sex))
                {
                    cmbSex.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入教师姓名", "请输入教师姓名", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            this.TeacherName = txtName.Text;
            this.Sex = cmbSex.Text;
            this.Address = txtAddress.Text;
            this.Phone = txtPhone.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
