﻿using System;
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
        public bool isBirthDayNull;
        public DateTime BirthDay;
        public string Ethnic;
        public string Hometown;
        public string Sex;
        public string Degree;
        public string School;
        public bool isGraduationTimeNull;
        public DateTime GraduationTime;
        public string Professional;
        public string Phone;
        public string Address;
        public bool isEntryDateNull;
        public DateTime EntryDate;
        public string Password;
        public List<SigninTime> signinTimeList;

        public TeacherUpdateForm()
        {
            InitializeComponent();
        }

        private void TeacherUpdateForm_Load(object sender, EventArgs e)
        {
            txtName.Text = TeacherName;
            if (!isBirthDayNull)
                dtBirthDay.Value = BirthDay;
            txtEthnic.Text = Ethnic;
            txtHometown.Text = Hometown;
            for (int i = 0; i < cmbSex.Items.Count; i++)
            {
                if (cmbSex.Items[i].ToString().Equals(Sex))
                {
                    cmbSex.SelectedIndex = i;
                    break;
                }
            }
            txtDegree.Text = Degree;
            txtSchool.Text = School;
            if (!isGraduationTimeNull)
                dtGraduationTime.Value = GraduationTime;
            txtProfessional.Text = Professional;
            txtPhone.Text = Phone;
            txtAddress.Text = Address;
            if (!isEntryDateNull)
                dtEntryDate.Value = EntryDate;
            txtPassword.Text = Password;
            txtPasswordConfirm.Text = Password;
            foreach (SigninTime st in signinTimeList)
            {
                int range = st.range;
                if (1 == range)
                {
                    dtBeginTimeOne.Checked = true;
                    dtBeginTimeOne.Value = st.beginTime;
                    dtEndTimeOne.Checked = true;
                    dtEndTimeOne.Value = st.endTime;
                }
                else if (2 == range)
                {
                    dtBeginTimeTwo.Checked = true;
                    dtBeginTimeTwo.Value = st.beginTime;
                    dtEndTimeTwo.Checked = true;
                    dtEndTimeTwo.Value = st.endTime;
                }
                else
                {
                    dtBeginTimeThree.Checked = true;
                    dtBeginTimeThree.Value = st.beginTime;
                    dtEndTimeThree.Checked = true;
                    dtEndTimeThree.Value = st.endTime;
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
                MessageBox.Show("请输入姓名！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (txtPasswordConfirm.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPasswordConfirm.Focus();
                return;
            }
            if (!txtPassword.Text.Trim().Equals(txtPasswordConfirm.Text.Trim()))
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.Focus();
                return;
            }
            if (dtBeginTimeOne.Checked || dtEndTimeOne.Checked)
            {
                if (dtBeginTimeOne.Checked)
                {
                    if (!dtEndTimeOne.Checked)
                    {
                        MessageBox.Show("请选择下班时间1！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtEndTimeOne.Focus();
                        return;
                    }
                }
                if (dtEndTimeOne.Checked)
                {
                    if (!dtBeginTimeOne.Checked)
                    {
                        MessageBox.Show("请选择上班时间1！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtBeginTimeOne.Focus();
                        return;
                    }
                }
            }
            if (dtBeginTimeTwo.Checked || dtEndTimeTwo.Checked)
            {
                if (dtBeginTimeTwo.Checked)
                {
                    if (!dtEndTimeTwo.Checked)
                    {
                        MessageBox.Show("请选择下班时间2！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtEndTimeTwo.Focus();
                        return;
                    }
                }
                if (dtEndTimeTwo.Checked)
                {
                    if (!dtBeginTimeTwo.Checked)
                    {
                        MessageBox.Show("请选择上班时间2！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtBeginTimeTwo.Focus();
                        return;
                    }
                }
            }
            if (dtBeginTimeThree.Checked || dtEndTimeThree.Checked)
            {
                if (dtBeginTimeThree.Checked)
                {
                    if (!dtEndTimeThree.Checked)
                    {
                        MessageBox.Show("请选择下班时间3！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtEndTimeThree.Focus();
                        return;
                    }
                }
                if (dtEndTimeThree.Checked)
                {
                    if (!dtBeginTimeThree.Checked)
                    {
                        MessageBox.Show("请选择上班时间3！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtBeginTimeThree.Focus();
                        return;
                    }
                }
            }
            List<SigninTime> stList = new List<SigninTime>();
            if (dtBeginTimeOne.Checked && dtEndTimeOne.Checked)
            {
                SigninTime st = new SigninTime();
                st.beginTime = dtBeginTimeOne.Value;
                st.endTime = dtEndTimeOne.Value;
                st.range = 1;
                stList.Add(st);
            }
            if (dtBeginTimeTwo.Checked && dtEndTimeTwo.Checked)
            {
                SigninTime st = new SigninTime();
                st.beginTime = dtBeginTimeTwo.Value;
                st.endTime = dtEndTimeTwo.Value;
                st.range = 2;
                stList.Add(st);
            }
            if (dtBeginTimeThree.Checked && dtEndTimeThree.Checked)
            {
                SigninTime st = new SigninTime();
                st.beginTime = dtBeginTimeThree.Value;
                st.endTime = dtEndTimeThree.Value;
                st.range = 3;
                stList.Add(st);
            }
            this.Name = txtName.Text;
            this.BirthDay = dtBirthDay.Value;
            this.Ethnic = txtEthnic.Text;
            this.Hometown = txtHometown.Text;
            this.Sex = cmbSex.Text;
            this.Degree = txtDegree.Text;
            this.School = txtSchool.Text;
            this.GraduationTime = dtGraduationTime.Value;
            this.Professional = txtProfessional.Text;
            this.Phone = txtPhone.Text;
            this.Address = txtAddress.Text;
            this.EntryDate = dtEntryDate.Value;
            this.Password = txtPassword.Text;
            this.signinTimeList = stList;
            this.DialogResult = DialogResult.OK;
        }
    }
}
