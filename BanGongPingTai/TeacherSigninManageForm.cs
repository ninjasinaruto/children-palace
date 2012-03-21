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
    public partial class TeacherSigninManageForm : Form
    {
        public TeacherSigninManageForm()
        {
            InitializeComponent();
        }

        private void TeacherSigninManageForm_Load(object sender, EventArgs e)
        {
            this.teacherSigninReportTableAdapter.FillByDay(this.teachersDataSet.TeacherSigninReport);
            txtShowRange.Text = "今天";
        }

        private void TeacherSigninManageForm_Resize(object sender, EventArgs e)
        {
            this.dgvSigninReport.Width = this.Width - 30;
            this.dgvSigninReport.Height = this.Height / 2 - 100;
            this.panel1.Width = this.Width - 30;
            this.panel1.Top = this.Height / 2 - 60;
        }

        private void dgvSigninReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvSigninReport.Rows.Count > 0)
                for (int i = 0; i < dgvSigninReport.Rows.Count; i++)
                {
                    dgvSigninReport.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtStime.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtEtime.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (txtTeacherName.Text.Trim() == "")
            {
                this.teacherSigninReportTableAdapter.FillByBeginEndDate(this.teachersDataSet.TeacherSigninReport, beginDate, endDate);
                txtShowRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
            }
            else
            {
                this.teacherSigninReportTableAdapter.FillByBeginEndDateWithTeacherName(this.teachersDataSet.TeacherSigninReport, beginDate, endDate, "%"+txtTeacherName.Text.Trim()+"%");
                txtShowRange.Text = txtTeacherName.Text.Trim() + " - " + beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
            }
        }

        private void btnSearchByMonth_Click(object sender, EventArgs e)
        {
            if (txtTeacherName.Text.Trim() == "")
            {
                this.teacherSigninReportTableAdapter.FillByMonth(this.teachersDataSet.TeacherSigninReport);
                txtShowRange.Text = "本月";
            }
            else
            {
                this.teacherSigninReportTableAdapter.FillByMonthWithTeacherName(this.teachersDataSet.TeacherSigninReport, "%" + txtTeacherName.Text.Trim() + "%");
                txtShowRange.Text = txtTeacherName.Text.Trim() + " - 本月";
            }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            if (txtTeacherName.Text.Trim() == "")
            {
                this.teacherSigninReportTableAdapter.Fill(this.teachersDataSet.TeacherSigninReport);
                txtShowRange.Text = "所有";
            }
            else
            {
                this.teacherSigninReportTableAdapter.FillByAllWithTeacherName(this.teachersDataSet.TeacherSigninReport, "%" + txtTeacherName.Text.Trim() + "%");
                txtShowRange.Text = txtTeacherName.Text.Trim() + " - 所有";
            }
        }

        private void btnSearchByDay_Click(object sender, EventArgs e)
        {
            if (txtTeacherName.Text.Trim() == "")
            {
                this.teacherSigninReportTableAdapter.FillByDay(this.teachersDataSet.TeacherSigninReport);
                txtShowRange.Text = "今天";
            }
            else
            {
                this.teacherSigninReportTableAdapter.FillByDayWithTeacherName(this.teachersDataSet.TeacherSigninReport, "%" + txtTeacherName.Text.Trim() + "%");
                txtShowRange.Text = txtTeacherName.Text.Trim() + " - 今天";
            }
        }

        private void teacherSigninReportBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblSigninCount.Text = teachersDataSet.TeacherSigninReport.Rows.Count + "条";
        }

        private void btnRemark_Click(object sender, EventArgs e)
        {
            if (teacherSigninReportBindingSource.Position < 0)
                return;

            int rowIndex = dgvSigninReport.CurrentRow.Index;

            UpdateTeacherSigninReportForm frmUpdateTeacherSigninReport = new UpdateTeacherSigninReportForm();
            DataRow row = teachersDataSet.TeacherSigninReport.Rows[teacherSigninReportBindingSource.Position];
            if (!row.IsNull("Leave"))
            {
                frmUpdateTeacherSigninReport.leave = row.Field<decimal>("Leave");
            }
            else
            {
                frmUpdateTeacherSigninReport.leave = 0;
            }

            if (!row.IsNull("SickLeave"))
            {
                frmUpdateTeacherSigninReport.sickLeave = row.Field<decimal>("SickLeave");
            }
            else
            {
                frmUpdateTeacherSigninReport.sickLeave = 0;
            }

            if (!row.IsNull("GoOut"))
            {
                frmUpdateTeacherSigninReport.goOut = row.Field<decimal>("GoOut");
            }
            else
            {
                frmUpdateTeacherSigninReport.goOut = 0;
            }

            if (!row.IsNull("BeLate"))
            {
                frmUpdateTeacherSigninReport.beLate = row.Field<int>("BeLate");
            }
            else
            {
                frmUpdateTeacherSigninReport.beLate = 0;
            }

            if (!row.IsNull("LeaveEarly"))
            {
                frmUpdateTeacherSigninReport.beLate = row.Field<int>("LeaveEarly");
            }
            else
            {
                frmUpdateTeacherSigninReport.beLate = 0;
            }
            frmUpdateTeacherSigninReport.remark = row.Field<string>("Remark");

            if (frmUpdateTeacherSigninReport.ShowDialog() != DialogResult.OK)
                return;
            if (MessageBox.Show("您确定要备注该考勤信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                teacherSigninReportTableAdapter.UpdateByTeacherID(frmUpdateTeacherSigninReport.leave, frmUpdateTeacherSigninReport.sickLeave, frmUpdateTeacherSigninReport.goOut,
                frmUpdateTeacherSigninReport.beLate, frmUpdateTeacherSigninReport.leaveEarly, frmUpdateTeacherSigninReport.remark, User.CurrentUser.UserName, row.Field<int>("ID"));
                if (txtTeacherName.Text.Trim() == "")
                {
                    this.teacherSigninReportTableAdapter.FillByDay(this.teachersDataSet.TeacherSigninReport);
                    txtShowRange.Text = "今天";
                }
                else
                {
                    this.teacherSigninReportTableAdapter.FillByDayWithTeacherName(this.teachersDataSet.TeacherSigninReport, "%" + txtTeacherName.Text.Trim() + "%");
                    txtShowRange.Text = txtTeacherName.Text.Trim() + " - 今天";
                }
                if (rowIndex >= 0)
                {
                    this.dgvSigninReport.Rows[rowIndex].Selected = true;
                    this.dgvSigninReport.CurrentCell = this.dgvSigninReport.Rows[rowIndex].Cells[0];
                }
            }
        }
    }
}
