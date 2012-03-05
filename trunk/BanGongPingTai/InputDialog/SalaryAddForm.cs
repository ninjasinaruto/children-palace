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
    public partial class SalaryAddForm : Form
    {
        public int TeacherID;
        public string TeacherName;
        public SalaryAddForm()
        {
            InitializeComponent();
        }

        private void SalaryAddForm_Load(object sender, EventArgs e)
        {
            lblTeacherName.Text = TeacherName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBasicWage.Value+"");
        }

        private void txtBasicWage_ValueChanged(object sender, EventArgs e)
        {
            if (txtBasicWage.Text != null && txtBasicWageNum.Text != null)
            {
                txtBasicWageAmount.Text = txtBasicWage.Value * txtBasicWageNum.Value + "";
            }
        }

        private void txtBasicWageNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtBasicWage.Text != null && txtBasicWageNum.Text != null)
            {
                txtBasicWageAmount.Text = txtBasicWage.Value * txtBasicWageNum.Value + "";
            }
        }

        private void txtJobWage_ValueChanged(object sender, EventArgs e)
        {
            if (txtJobWage.Text != null && txtJobWageNum.Text != null)
            {
                txtJobWageAmount.Text = txtJobWage.Value * txtJobWageNum.Value + "";
            }
        }

        private void txtJobWageNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtJobWage.Text != null && txtJobWageNum.Text != null)
            {
                txtJobWageAmount.Text = txtJobWage.Value * txtJobWageNum.Value + "";
            }
        }

        private void txtAgeSubsidy_ValueChanged(object sender, EventArgs e)
        {
            if (txtAgeSubsidy.Text != null && txtAgeSubsidyNum.Text != null)
            {
                txtAgeSubsidyAmount.Text = txtAgeSubsidy.Value * txtAgeSubsidyNum.Value + "";
            }
        }

        private void txtAgeSubsidyNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtAgeSubsidy.Text != null && txtAgeSubsidyNum.Text != null)
            {
                txtAgeSubsidyAmount.Text = txtAgeSubsidy.Value * txtAgeSubsidyNum.Value + "";
            }
        }

        private void txtInsuranceSubsidy_ValueChanged(object sender, EventArgs e)
        {
            if (txtInsuranceSubsidy.Text != null && txtInsuranceSubsidyNum.Text != null)
            {
                txtInsuranceSubsidyAmount.Text = txtInsuranceSubsidy.Value * txtInsuranceSubsidyNum.Value + "";
            }
        }

        private void txtInsuranceSubsidyNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtInsuranceSubsidy.Text != null && txtInsuranceSubsidyNum.Text != null)
            {
                txtInsuranceSubsidyAmount.Text = txtInsuranceSubsidy.Value * txtInsuranceSubsidyNum.Value + "";
            }
        }

        private void txtHolidaysSubsidy_ValueChanged(object sender, EventArgs e)
        {
            if (txtHolidaysSubsidy.Text != null && txtHolidaysSubsidyNum.Text != null)
            {
                txtHolidaysSubsidyAmount.Text = txtHolidaysSubsidy.Value * txtHolidaysSubsidyNum.Value + "";
            }
        }

        private void txtHolidaysSubsidyNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtHolidaysSubsidy.Text != null && txtHolidaysSubsidyNum.Text != null)
            {
                txtHolidaysSubsidyAmount.Text = txtHolidaysSubsidy.Value * txtHolidaysSubsidyNum.Value + "";
            }
        }

        private void txtWorkSubsidy_ValueChanged(object sender, EventArgs e)
        {
            if (txtWorkSubsidy.Text != null && txtWorkSubsidyNum.Text != null)
            {
                txtWorkSubsidyAmount.Text = txtWorkSubsidy.Value * txtWorkSubsidyNum.Value + "";
            }
        }

        private void txtWorkSubsidyNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtWorkSubsidy.Text != null && txtWorkSubsidyNum.Text != null)
            {
                txtWorkSubsidyAmount.Text = txtWorkSubsidy.Value * txtWorkSubsidyNum.Value + "";
            }
        }

        private void txtOtherSubsidy_ValueChanged(object sender, EventArgs e)
        {
            if (txtOtherSubsidy.Text != null && txtOtherSubsidyNum.Text != null)
            {
                txtOtherSubsidyAmount.Text = txtOtherSubsidy.Value * txtOtherSubsidyNum.Value + "";
            }
        }

        private void txtOtherSubsidyNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtOtherSubsidy.Text != null && txtOtherSubsidyNum.Text != null)
            {
                txtOtherSubsidyAmount.Text = txtOtherSubsidy.Value * txtOtherSubsidyNum.Value + "";
            }
        }

        private void txtActualStudentNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtActualStudentNum.Text != null && txtStudentActualPrice.Text != null)
            {
                txtStudentAmount.Text = txtStudentActualPrice.Value * txtActualStudentNum.Value + "";
            }
        }

        private void txtStudentActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtActualStudentNum.Text != null && txtStudentActualPrice.Text != null)
            {
                txtStudentAmount.Text = txtStudentActualPrice.Value * txtActualStudentNum.Value + "";
            }
        }

        private void txtFullAttendanceAwardActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtFullAttendanceAwardActualPrice.Text != null && txtFullAttendanceAwardNum.Text != null)
            {
                txtFullAttendanceAwardAmount.Text = txtFullAttendanceAwardActualPrice.Value * txtFullAttendanceAwardNum.Value + "";
            }
        }

        private void txtFullAttendanceAwardNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtFullAttendanceAwardActualPrice.Text != null && txtFullAttendanceAwardNum.Text != null)
            {
                txtFullAttendanceAwardAmount.Text = txtFullAttendanceAwardActualPrice.Value * txtFullAttendanceAwardNum.Value + "";
            }
        }

        private void txtSeasonSubsidyActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtSeasonSubsidyActualPrice.Text != null && txtSeasonSubsidyNum.Text != null)
            {
                txtSeasonSubsidyAmount.Text = txtSeasonSubsidyActualPrice.Value * txtSeasonSubsidyNum.Value + "";
            }
        }

        private void txtSeasonSubsidyNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtSeasonSubsidyActualPrice.Text != null && txtSeasonSubsidyNum.Text != null)
            {
                txtSeasonSubsidyAmount.Text = txtSeasonSubsidyActualPrice.Value * txtSeasonSubsidyNum.Value + "";
            }
        }

        private void txtAbleAwardActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtAbleAwardActualPrice.Text != null && txtAbleAwardNum.Text != null)
            {
                txtAbleAwardAmount.Text = txtAbleAwardActualPrice.Value * txtAbleAwardNum.Value + "";
            }
        }

        private void txtAbleAwardNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtAbleAwardActualPrice.Text != null && txtAbleAwardNum.Text != null)
            {
                txtAbleAwardAmount.Text = txtAbleAwardActualPrice.Value * txtAbleAwardNum.Value + "";
            }
        }

        private void txtTravelSubsidyActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtTravelSubsidyActualPrice.Text != null && txtTravelSubsidyNum.Text != null)
            {
                txtTravelSubsidyAmount.Text = txtTravelSubsidyActualPrice.Value * txtTravelSubsidyNum.Value + "";
            }
        }

        private void txtTravelSubsidyNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtTravelSubsidyActualPrice.Text != null && txtTravelSubsidyNum.Text != null)
            {
                txtTravelSubsidyAmount.Text = txtTravelSubsidyActualPrice.Value * txtTravelSubsidyNum.Value + "";
            }
        }

        private void txtAppraisalAwardActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtAppraisalAwardActualPrice.Text != null && txtAppraisalAwardNum.Text != null)
            {
                txtAppraisalAwardAmount.Text = txtAppraisalAwardActualPrice.Value * txtAppraisalAwardNum.Value + "";
            }
        }

        private void txtAppraisalAwardNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtAppraisalAwardActualPrice.Text != null && txtAppraisalAwardNum.Text != null)
            {
                txtAppraisalAwardAmount.Text = txtAppraisalAwardActualPrice.Value * txtAppraisalAwardNum.Value + "";
            }
        }

        private void txtOtherAwardActualPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtOtherAwardActualPrice.Text != null && txtOtherAwardNum.Text != null)
            {
                txtOtherAwardAmount.Text = txtOtherAwardActualPrice.Value * txtOtherAwardNum.Value + "";
            }
        }

        private void txtOtherAwardNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtOtherAwardActualPrice.Text != null && txtOtherAwardNum.Text != null)
            {
                txtOtherAwardAmount.Text = txtOtherAwardActualPrice.Value * txtOtherAwardNum.Value + "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
