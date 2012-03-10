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
    public partial class SalaryUpdateForm : Form
    {
        public int LogID;
        public int TeacherID;
        public string TeacherName;
        public DateTime wageTime;
        public List<BasicWage> bwList;
        public double cwCoefficient;
        public List<CourseWage> cwList;
        public StudentAward sa;
        public List<TeacherAward> taList;
        public List<ChargeBack> cbList;
        public double ShouldWages;
        public double RealWages;

        public SalaryUpdateForm()
        {
            InitializeComponent();
        }

        private void SalaryUpdateForm_Load(object sender, EventArgs e)
        {
            // 基本工资
            this.teacherBasicWageTableAdapter.FillByBasicWage(this.teacherWageDataSet.TeacherBasicWage, LogID);
            txtBasicWage.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageStandard") + "";
            txtBasicWageNum.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<int>("WageNum") + "";
            txtBasicWageAmount.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageAmount") + "";
            txtBasicWageRemark.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<string>("Remark");
            // 职务工资
            this.teacherBasicWageTableAdapter.FillByJobWage(this.teacherWageDataSet.TeacherBasicWage, LogID);
            txtJobWage.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageStandard") + "";
            txtJobWageNum.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<int>("WageNum") + "";
            txtJobWageAmount.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageAmount") + "";
            txtJobWageRemark.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<string>("Remark");
            // 工龄补贴
            this.teacherBasicWageTableAdapter.FillByAgeWage(this.teacherWageDataSet.TeacherBasicWage, LogID);
            txtAgeSubsidy.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageStandard") + "";
            txtAgeSubsidyNum.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<int>("WageNum") + "";
            txtAgeSubsidyAmount.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageAmount") + "";
            txtAgeSubsidyRemark.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<string>("Remark");
            // 保险补贴
            this.teacherBasicWageTableAdapter.FillByInsuranceWage(this.teacherWageDataSet.TeacherBasicWage, LogID);
            txtInsuranceSubsidy.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageStandard") + "";
            txtInsuranceSubsidyNum.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<int>("WageNum") + "";
            txtInsuranceSubsidyAmount.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageAmount") + "";
            txtInsuranceSubsidyRemark.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<string>("Remark");
            // 节假日补贴
            this.teacherBasicWageTableAdapter.FillByHolidayWage(this.teacherWageDataSet.TeacherBasicWage, LogID);
            txtHolidaysSubsidy.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageStandard") + "";
            txtHolidaysSubsidyNum.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<int>("WageNum") + "";
            txtHolidaysSubsidyAmount.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageAmount") + "";
            txtHolidaysSubsidyRemark.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<string>("Remark");
            // 加班补贴
            this.teacherBasicWageTableAdapter.FillByWorkWage(this.teacherWageDataSet.TeacherBasicWage, LogID);
            txtWorkSubsidy.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageStandard") + "";
            txtWorkSubsidyNum.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<int>("WageNum") + "";
            txtWorkSubsidyAmount.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageAmount") + "";
            txtWorkSubsidyRemark.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<string>("Remark");
            // 其他补贴
            this.teacherBasicWageTableAdapter.FillByOtherWage(this.teacherWageDataSet.TeacherBasicWage, LogID);
            txtOtherSubsidy.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageStandard") + "";
            txtOtherSubsidyNum.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<int>("WageNum") + "";
            txtOtherSubsidyAmount.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<decimal>("WageAmount") + "";
            txtOtherSubsidyRemark.Text = this.teacherWageDataSet.TeacherBasicWage.Rows[0].Field<string>("Remark");
            // 工资系数
            this.teacherCoefficientTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherCoefficient, LogID);
            txtCourseWageCoefficient.Text = this.teacherWageDataSet.TeacherCoefficient.Rows[0].Field<double>("Coefficient") + "";
            // 课量工资
            this.teacherCourseWageTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherCourseWage, LogID);
            {
                foreach (DataRow dataRow in this.teacherWageDataSet.TeacherCourseWage.Rows)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in this.dgvCourseWage.Columns)
                    {
                        dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);  //给行添加单元格
                    }
                    dr.Cells[0].Value = dataRow.Field<string>("CourseType");
                    dr.Cells[1].Value = dataRow.Field<int>("CourseNum");
                    dr.Cells[2].Value = (double)dataRow.Field<decimal>("StandardPrice");
                    dr.Cells[3].Value = (double)dataRow.Field<decimal>("ActualPrice");
                    dr.Cells[4].Value = (double)dataRow.Field<decimal>("CourseAmount");
                    dr.Cells[5].Value = dataRow.Field<string>("Remark");
                    this.dgvCourseWage.Rows.Add(dr);
                }
            }
            // 学生管理奖
            this.teacherStudentAwardTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherStudentAward, LogID);
            txtTotalStudentNum.Text = this.teacherWageDataSet.TeacherStudentAward.Rows[0].Field<int>("TotalStudent") + "";
            txtActualStudentNum.Text = this.teacherWageDataSet.TeacherStudentAward.Rows[0].Field<int>("ActualStudent") + "";
            txtStudentStandardPrice.Text = this.teacherWageDataSet.TeacherStudentAward.Rows[0].Field<decimal>("StandardPrice") + "";
            txtStudentActualPrice.Text = this.teacherWageDataSet.TeacherStudentAward.Rows[0].Field<decimal>("ActualPrice") + "";
            txtStudentAmount.Text = this.teacherWageDataSet.TeacherStudentAward.Rows[0].Field<decimal>("Amount") + "";
            // 满勤奖
            this.teacherAwardTableAdapter.FillBySeasonAward(this.teacherWageDataSet.TeacherAward, LogID);
            txtFullAttendanceAwardStandardPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("StandardPrice") + "";
            txtFullAttendanceAwardActualPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("ActualPrice") + "";
            txtFullAttendanceAwardNum.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<int>("AwardNum") + "";
            txtFullAttendanceAwardAmount.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("AwardAmount") + "";
            txtFullAttendanceAwardRemark.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<string>("Remark");
            // 季节补贴
            this.teacherAwardTableAdapter.FillBySeasonAward(this.teacherWageDataSet.TeacherAward, LogID);
            txtSeasonSubsidyStandardPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("StandardPrice") + "";
            txtSeasonSubsidyActualPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("ActualPrice") + "";
            txtSeasonSubsidyNum.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<int>("AwardNum") + "";
            txtSeasonSubsidyAmount.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("AwardAmount") + "";
            txtSeasonSubsidyRemark.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<string>("Remark");
            // 超生奖励
            this.teacherAwardTableAdapter.FillByAbleAward(this.teacherWageDataSet.TeacherAward, LogID);
            txtAbleAwardStandardPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("StandardPrice") + "";
            txtAbleAwardActualPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("ActualPrice") + "";
            txtAbleAwardNum.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<int>("AwardNum") + "";
            txtAbleAwardAmount.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("AwardAmount") + "";
            txtAbleAwardRemark.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<string>("Remark");
            // 出差补贴
            this.teacherAwardTableAdapter.FillByTravelAward(this.teacherWageDataSet.TeacherAward, LogID);
            txtTravelSubsidyStandardPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("StandardPrice") + "";
            txtTravelSubsidyActualPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("ActualPrice") + "";
            txtTravelSubsidyNum.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<int>("AwardNum") + "";
            txtTravelSubsidyAmount.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("AwardAmount") + "";
            txtTravelSubsidyRemark.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<string>("Remark");
            // 绩效考核奖
            this.teacherAwardTableAdapter.FillByAppraisalAward(this.teacherWageDataSet.TeacherAward, LogID);
            txtAppraisalAwardStandardPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("StandardPrice") + "";
            txtAppraisalAwardActualPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("ActualPrice") + "";
            txtAppraisalAwardNum.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<int>("AwardNum") + "";
            txtAppraisalAwardAmount.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("AwardAmount") + "";
            txtAppraisalAwardRemark.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<string>("Remark");
            // 其他
            this.teacherAwardTableAdapter.FillByOtherAward(this.teacherWageDataSet.TeacherAward, LogID);
            txtOtherAwardStandardPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("StandardPrice") + "";
            txtOtherAwardActualPrice.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("ActualPrice") + "";
            txtOtherAwardNum.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<int>("AwardNum") + "";
            txtOtherAwardAmount.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<decimal>("AwardAmount") + "";
            txtOtherAwardRemark.Text = this.teacherWageDataSet.TeacherAward.Rows[0].Field<string>("Remark");
            // 代扣处罚
            this.teacherChargeBackTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherChargeBack, LogID);
            {
                foreach (DataRow dataRow in this.teacherWageDataSet.TeacherChargeBack.Rows)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in this.dgvChargeback.Columns)
                    {
                        dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);  //给行添加单元格
                    }
                    dr.Cells[0].Value = dataRow.Field<string>("ChargeBackName");
                    dr.Cells[1].Value = dataRow.Field<string>("ChargeBackType");
                    dr.Cells[2].Value = (double)dataRow.Field<decimal>("StandardPrice");
                    dr.Cells[3].Value = dataRow.Field<int>("ChargeBackNum");
                    dr.Cells[4].Value = (double)dataRow.Field<decimal>("ChargeBackAmount");
                    dr.Cells[5].Value = dataRow.Field<string>("Remark");
                    this.dgvChargeback.Rows.Add(dr);
                }
            }
            lblTeacherName.Text = TeacherName;
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
            if (txtHolidaysSubsidy.Text != null && txtHolidaysSubsidyNum.Text != null)
            {
                txtHolidaysSubsidyAmount.Text = txtHolidaysSubsidy.Value * txtHolidaysSubsidyNum.Value + "";
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

        // 新增课量工资
        private void btnAddCourseWage_Click(object sender, EventArgs e)
        {
            CourseWageAddForm frmCourseWageAdd = new CourseWageAddForm();
            frmCourseWageAdd.Coefficient = txtCourseWageCoefficient.Value;
            if (frmCourseWageAdd.ShowDialog() != DialogResult.OK)
                return;

            DataGridViewRow dr = new DataGridViewRow();
            foreach (DataGridViewColumn c in this.dgvCourseWage.Columns)
            {
                dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);  //给行添加单元格
            }
            dr.Cells[0].Value = frmCourseWageAdd.CourseType;
            dr.Cells[1].Value = frmCourseWageAdd.CourseNum;
            dr.Cells[2].Value = frmCourseWageAdd.StandardPrice;
            dr.Cells[3].Value = frmCourseWageAdd.ActualPrice;
            dr.Cells[4].Value = frmCourseWageAdd.CourseAmount;
            dr.Cells[5].Value = frmCourseWageAdd.Remark;
            this.dgvCourseWage.Rows.Add(dr);
        }

        // 修改课量工资
        private void btnUpdateCourseWage_Click(object sender, EventArgs e)
        {
            if (dgvCourseWage.CurrentRow == null)
                return;
            int idx = this.dgvCourseWage.CurrentRow.Index;
            if (idx < 0)
                return;
            CourseWageUpdateForm frmCourseWageUpdate = new CourseWageUpdateForm();
            frmCourseWageUpdate.Coefficient = txtCourseWageCoefficient.Value;
            frmCourseWageUpdate.CourseType = this.dgvCourseWage.CurrentRow.Cells[0].Value + "";
            frmCourseWageUpdate.CourseNum = (int)this.dgvCourseWage.CurrentRow.Cells[1].Value;
            frmCourseWageUpdate.StandardPrice = (double)this.dgvCourseWage.CurrentRow.Cells[2].Value;
            frmCourseWageUpdate.ActualPrice = (double)this.dgvCourseWage.CurrentRow.Cells[3].Value;
            frmCourseWageUpdate.CourseAmount = (double)this.dgvCourseWage.CurrentRow.Cells[4].Value;
            frmCourseWageUpdate.Remark = this.dgvCourseWage.CurrentRow.Cells[5].Value + "";
            if (frmCourseWageUpdate.ShowDialog() != DialogResult.OK)
                return;

            this.dgvCourseWage.CurrentRow.Cells[0].Value = frmCourseWageUpdate.CourseType;
            this.dgvCourseWage.CurrentRow.Cells[1].Value = frmCourseWageUpdate.CourseNum;
            this.dgvCourseWage.CurrentRow.Cells[2].Value = frmCourseWageUpdate.StandardPrice;
            this.dgvCourseWage.CurrentRow.Cells[3].Value = frmCourseWageUpdate.ActualPrice;
            this.dgvCourseWage.CurrentRow.Cells[4].Value = frmCourseWageUpdate.CourseAmount;
            this.dgvCourseWage.CurrentRow.Cells[5].Value = frmCourseWageUpdate.Remark;

            if (idx >= 0)
            {
                this.dgvCourseWage.Rows[idx].Selected = true;
                this.dgvCourseWage.CurrentCell = this.dgvCourseWage.Rows[idx].Cells[0];
            }
        }

        // 删除课量工资
        private void btnDelCourseWage_Click(object sender, EventArgs e)
        {
            if (dgvCourseWage.CurrentRow == null)
                return;
            int idx = this.dgvCourseWage.CurrentRow.Index;
            if (idx < 0)
                return;
            if (MessageBox.Show("您确定要删除该条课量工资记录吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.dgvCourseWage.Rows.Remove(this.dgvCourseWage.CurrentRow);
                dgvCourseWage_SelectionChanged(sender, e);
            }
        }

        private void dgvCourseWage_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourseWage.CurrentRow == null)
                return;
        }

        // 添加扣款
        private void btnAddChargeback_Click(object sender, EventArgs e)
        {
            ChargeBackAddForm frmChargeBackAdd = new ChargeBackAddForm();
            if (frmChargeBackAdd.ShowDialog() != DialogResult.OK)
                return;

            DataGridViewRow dr = new DataGridViewRow();
            foreach (DataGridViewColumn c in this.dgvChargeback.Columns)
            {
                dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);  //给行添加单元格
            }
            dr.Cells[0].Value = frmChargeBackAdd.ChargeBackName;
            dr.Cells[1].Value = frmChargeBackAdd.ChargeBackType;
            dr.Cells[2].Value = frmChargeBackAdd.ChargeBackPrice;
            dr.Cells[3].Value = frmChargeBackAdd.ChargeBackNum;
            dr.Cells[4].Value = frmChargeBackAdd.ChargeBackAmount;
            dr.Cells[5].Value = frmChargeBackAdd.Remark;
            this.dgvChargeback.Rows.Add(dr);
        }

        // 修改扣款
        private void btnUpdateChargeback_Click(object sender, EventArgs e)
        {
            if (dgvChargeback.CurrentRow == null)
                return;
            int idx = this.dgvChargeback.CurrentRow.Index;
            if (idx < 0)
                return;
            ChargeBackUpdateForm frmChargeBackUpdate = new ChargeBackUpdateForm();

            frmChargeBackUpdate.ChargeBackName = this.dgvChargeback.CurrentRow.Cells[0].Value + "";
            frmChargeBackUpdate.ChargeBackType = this.dgvChargeback.CurrentRow.Cells[1].Value + "";
            frmChargeBackUpdate.ChargeBackPrice = (double)this.dgvChargeback.CurrentRow.Cells[2].Value;
            frmChargeBackUpdate.ChargeBackNum = (int)this.dgvChargeback.CurrentRow.Cells[3].Value;
            frmChargeBackUpdate.ChargeBackAmount = (double)this.dgvChargeback.CurrentRow.Cells[4].Value;
            frmChargeBackUpdate.Remark = this.dgvChargeback.CurrentRow.Cells[5].Value + "";
            if (frmChargeBackUpdate.ShowDialog() != DialogResult.OK)
                return;

            this.dgvChargeback.CurrentRow.Cells[0].Value = frmChargeBackUpdate.ChargeBackName;
            this.dgvChargeback.CurrentRow.Cells[1].Value = frmChargeBackUpdate.ChargeBackType;
            this.dgvChargeback.CurrentRow.Cells[2].Value = frmChargeBackUpdate.ChargeBackPrice;
            this.dgvChargeback.CurrentRow.Cells[3].Value = frmChargeBackUpdate.ChargeBackNum;
            this.dgvChargeback.CurrentRow.Cells[4].Value = frmChargeBackUpdate.ChargeBackAmount;
            this.dgvChargeback.CurrentRow.Cells[5].Value = frmChargeBackUpdate.Remark;

            if (idx >= 0)
            {
                this.dgvChargeback.Rows[idx].Selected = true;
                this.dgvChargeback.CurrentCell = this.dgvChargeback.Rows[idx].Cells[0];
            }
        }

        // 删除扣款
        private void btnDelChargeback_Click(object sender, EventArgs e)
        {
            if (dgvChargeback.CurrentRow == null)
                return;
            int idx = this.dgvChargeback.CurrentRow.Index;
            if (idx < 0)
                return;
            if (MessageBox.Show("您确定要删除该条扣款记录吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.dgvChargeback.Rows.Remove(this.dgvChargeback.CurrentRow);
                dgvChargeback_SelectionChanged(sender, e);
            }
        }

        private void dgvChargeback_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChargeback.CurrentRow == null)
                return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double shouldWages = 0.0;
            double minusWages = 0.0;
            // 1.新增基本工资
            List<BasicWage> basicWageList = new List<BasicWage>();
            BasicWage basic = new BasicWage();
            basic.WageType = "基本工资";
            basic.WageStandard = txtBasicWage.Value;
            basic.WageNum = txtBasicWageNum.Value;
            basic.WageAmount = txtBasicWageAmount.Value;
            basic.Remark = txtBasicWageRemark.Text;
            basicWageList.Add(basic);
            shouldWages += txtBasicWageAmount.Value;

            BasicWage job = new BasicWage();
            job.WageType = "职务工资";
            job.WageStandard = txtJobWage.Value;
            job.WageNum = txtJobWageNum.Value;
            job.WageAmount = txtJobWageAmount.Value;
            job.Remark = txtJobWageRemark.Text;
            basicWageList.Add(job);
            shouldWages += txtJobWageAmount.Value;

            BasicWage age = new BasicWage();
            age.WageType = "工龄补贴";
            age.WageStandard = txtAgeSubsidy.Value;
            age.WageNum = txtAgeSubsidyNum.Value;
            age.WageAmount = txtAgeSubsidyAmount.Value;
            age.Remark = txtAgeSubsidyRemark.Text;
            basicWageList.Add(age);
            shouldWages += txtAgeSubsidyAmount.Value;

            BasicWage insurance = new BasicWage();
            insurance.WageType = "保险补贴";
            insurance.WageStandard = txtInsuranceSubsidy.Value;
            insurance.WageNum = txtInsuranceSubsidyNum.Value;
            insurance.WageAmount = txtInsuranceSubsidyAmount.Value;
            insurance.Remark = txtInsuranceSubsidyRemark.Text;
            basicWageList.Add(insurance);
            shouldWages += txtInsuranceSubsidyAmount.Value;

            BasicWage holiday = new BasicWage();
            holiday.WageType = "节假日补贴";
            holiday.WageStandard = txtHolidaysSubsidy.Value;
            holiday.WageNum = txtHolidaysSubsidyNum.Value;
            holiday.WageAmount = txtHolidaysSubsidyAmount.Value;
            holiday.Remark = txtHolidaysSubsidyRemark.Text;
            basicWageList.Add(holiday);
            shouldWages += txtHolidaysSubsidyAmount.Value;

            BasicWage work = new BasicWage();
            work.WageType = "加班补贴";
            work.WageStandard = txtWorkSubsidy.Value;
            work.WageNum = txtWorkSubsidyNum.Value;
            work.WageAmount = txtWorkSubsidyAmount.Value;
            work.Remark = txtWorkSubsidyRemark.Text;
            basicWageList.Add(work);
            shouldWages += txtWorkSubsidyAmount.Value;

            BasicWage other = new BasicWage();
            other.WageType = "其他补贴";
            other.WageStandard = txtOtherSubsidy.Value;
            other.WageNum = txtOtherSubsidyNum.Value;
            other.WageAmount = txtOtherSubsidyAmount.Value;
            other.Remark = txtOtherSubsidyRemark.Text;
            basicWageList.Add(other);
            shouldWages += txtOtherSubsidyAmount.Value;

            //2.教师系数
            double courseWageCoefficient = txtCourseWageCoefficient.Value;

            //3.课量工资
            DataSet courseWageDs = GetDataSetFromDataGridView(this.dgvCourseWage);
            List<CourseWage> courseWageList = new List<CourseWage>();
            for (int i = 0; i < dgvCourseWage.RowCount; i++)
            {
                CourseWage courseWage = new CourseWage();
                courseWage.CourseType = courseWageDs.Tables[0].Rows[i][0] + "";
                courseWage.CourseNum = int.Parse(courseWageDs.Tables[0].Rows[i][1] + "");
                courseWage.StandardPrice = double.Parse(courseWageDs.Tables[0].Rows[i][2] + "");
                courseWage.ActualPrice = double.Parse(courseWageDs.Tables[0].Rows[i][3] + "");
                courseWage.CourseAmount = double.Parse(courseWageDs.Tables[0].Rows[i][4] + "");
                courseWage.Remark = courseWageDs.Tables[0].Rows[i][5] + "";
                courseWageList.Add(courseWage);
                shouldWages += double.Parse(courseWageDs.Tables[0].Rows[i][4] + "");
            }

            //4.学生管理奖
            StudentAward studentAward = new StudentAward();
            studentAward.TotalStudent = txtTotalStudentNum.Value;
            studentAward.ActualStudent = txtActualStudentNum.Value;
            studentAward.StandardPrice = txtStudentStandardPrice.Value;
            studentAward.ActualPrice = txtStudentActualPrice.Value;
            studentAward.Amount = txtStudentAmount.Value;
            shouldWages += txtStudentAmount.Value;

            //5.奖励工资
            List<TeacherAward> teacherAwardList = new List<TeacherAward>();
            TeacherAward fullAttendanceAward = new TeacherAward();
            fullAttendanceAward.AwardName = "满勤奖";
            fullAttendanceAward.StandardPrice = txtFullAttendanceAwardStandardPrice.Value;
            fullAttendanceAward.ActualPrice = txtFullAttendanceAwardActualPrice.Value;
            fullAttendanceAward.AwardNum = txtFullAttendanceAwardNum.Value;
            fullAttendanceAward.AwardAmount = txtFullAttendanceAwardAmount.Value;
            fullAttendanceAward.Remark = txtFullAttendanceAwardRemark.Text;
            teacherAwardList.Add(fullAttendanceAward);
            shouldWages += txtFullAttendanceAwardAmount.Value;

            TeacherAward seasonSubsidyAward = new TeacherAward();
            seasonSubsidyAward.AwardName = "季节补贴";
            seasonSubsidyAward.StandardPrice = txtSeasonSubsidyStandardPrice.Value;
            seasonSubsidyAward.ActualPrice = txtSeasonSubsidyActualPrice.Value;
            seasonSubsidyAward.AwardNum = txtSeasonSubsidyNum.Value;
            seasonSubsidyAward.AwardAmount = txtSeasonSubsidyAmount.Value;
            seasonSubsidyAward.Remark = txtSeasonSubsidyRemark.Text;
            teacherAwardList.Add(seasonSubsidyAward);
            shouldWages += txtSeasonSubsidyAmount.Value;

            TeacherAward ableAward = new TeacherAward();
            ableAward.AwardName = "超生奖励";
            ableAward.StandardPrice = txtAbleAwardStandardPrice.Value;
            ableAward.ActualPrice = txtAbleAwardActualPrice.Value;
            ableAward.AwardNum = txtAbleAwardNum.Value;
            ableAward.AwardAmount = txtAbleAwardAmount.Value;
            ableAward.Remark = txtAbleAwardRemark.Text;
            teacherAwardList.Add(ableAward);
            shouldWages += txtAbleAwardAmount.Value;

            TeacherAward travelAward = new TeacherAward();
            travelAward.AwardName = "出差补贴";
            travelAward.StandardPrice = txtTravelSubsidyStandardPrice.Value;
            travelAward.ActualPrice = txtTravelSubsidyActualPrice.Value;
            travelAward.AwardNum = txtTravelSubsidyNum.Value;
            travelAward.AwardAmount = txtTravelSubsidyAmount.Value;
            travelAward.Remark = txtTravelSubsidyRemark.Text;
            teacherAwardList.Add(travelAward);
            shouldWages += txtTravelSubsidyAmount.Value;

            TeacherAward appraisalAward = new TeacherAward();
            appraisalAward.AwardName = "绩效考核奖";
            appraisalAward.StandardPrice = txtAppraisalAwardStandardPrice.Value;
            appraisalAward.ActualPrice = txtAppraisalAwardActualPrice.Value;
            appraisalAward.AwardNum = txtAppraisalAwardNum.Value;
            appraisalAward.AwardAmount = txtAppraisalAwardAmount.Value;
            appraisalAward.Remark = txtAppraisalAwardRemark.Text;
            teacherAwardList.Add(appraisalAward);
            shouldWages += txtAppraisalAwardAmount.Value;

            TeacherAward otherAward = new TeacherAward();
            otherAward.AwardName = "其他";
            otherAward.StandardPrice = txtOtherAwardStandardPrice.Value;
            otherAward.ActualPrice = txtOtherAwardActualPrice.Value;
            otherAward.AwardNum = txtOtherAwardNum.Value;
            otherAward.AwardAmount = txtOtherAwardAmount.Value;
            otherAward.Remark = txtOtherAwardRemark.Text;
            teacherAwardList.Add(otherAward);
            shouldWages += txtOtherAwardAmount.Value;

            //6.代扣处罚
            DataSet chargeBackDs = GetDataSetFromDataGridView(this.dgvChargeback);
            List<ChargeBack> chargeBackList = new List<ChargeBack>();
            for (int i = 0; i < dgvChargeback.RowCount; i++)
            {
                ChargeBack chargeBack = new ChargeBack();
                chargeBack.ChargeBackName = chargeBackDs.Tables[0].Rows[i][0] + "";
                chargeBack.ChargeBackType = chargeBackDs.Tables[0].Rows[i][1] + "";
                chargeBack.StandardPrice = double.Parse(chargeBackDs.Tables[0].Rows[i][2] + "");
                chargeBack.ChargeBackNum = int.Parse(chargeBackDs.Tables[0].Rows[i][3] + "");
                chargeBack.ChargeBackAmount = double.Parse(chargeBackDs.Tables[0].Rows[i][4] + "");
                chargeBack.Remark = chargeBackDs.Tables[0].Rows[i][5] + "";
                chargeBackList.Add(chargeBack);
                minusWages += double.Parse(chargeBackDs.Tables[0].Rows[i][4] + "");
            }

            if (txtCourseWageCoefficient.Text.Trim() == "")
            {
                MessageBox.Show("请输入系数！", "提示", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                txtCourseWageCoefficient.Focus();
                return;
            }
            if (courseWageList.Count <= 0)
            {
                MessageBox.Show("请添加课量工资！", "提示", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return;
            }
            if (chargeBackList.Count <= 0)
            {
                MessageBox.Show("请添加代扣处罚项目！", "提示", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return;
            }
            this.wageTime = dtpBasic.Value;
            this.bwList = basicWageList;
            this.cwCoefficient = courseWageCoefficient;
            this.cwList = courseWageList;
            this.sa = studentAward;
            this.taList = teacherAwardList;
            this.cbList = chargeBackList;
            this.ShouldWages = shouldWages;
            this.RealWages = shouldWages - minusWages;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private static DataSet GetDataSetFromDataGridView(DataGridView dgv)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                dt.Columns.Add(dgv.Columns[j].HeaderCell.Value.ToString());
            }
            for (int j = 0; j < dgv.Rows.Count; j++)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Rows[j].Cells[i].Value != null)
                    {
                        dr[i] = dgv.Rows[j].Cells[i].Value.ToString();
                    }
                    else
                    {
                        dr[i] = "";
                    }
                }
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        private void txtCourseWageCoefficient_ValueChanged(object sender, EventArgs e)
        {
            if (txtCourseWageCoefficient.Text != null && txtCourseWageCoefficient.Text != null)
            {
                double coefficient = txtCourseWageCoefficient.Value;
                if (dgvCourseWage.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvCourseWage.Rows.Count; i++)
                    {
                        this.dgvCourseWage.Rows[i].Cells[3].Value = (double)this.dgvCourseWage.Rows[i].Cells[2].Value * coefficient;
                        this.dgvCourseWage.Rows[i].Cells[4].Value = (int)this.dgvCourseWage.Rows[i].Cells[1].Value * (double)this.dgvCourseWage.Rows[i].Cells[2].Value * coefficient;
                    }
                }
            }
        }
    }
}
