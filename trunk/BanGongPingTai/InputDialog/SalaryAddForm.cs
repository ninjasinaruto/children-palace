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
        public DateTime wageTime;
        public List<BasicWage> bwList;
        public double cwCoefficient;
        public List<CourseWage> cwList;
        public StudentAward sa;
        public List<TeacherAward> taList;
        public List<ChargeBack> cbList;
        public double ShouldWages;
        public double RealWages;

        public SalaryAddForm()
        {
            InitializeComponent();
        }

        private void SalaryAddForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“teacherWageDataSet.TeacherBasicWage”中。您可以根据需要移动或删除它。
            this.teacherBasicWageTableAdapter.Fill(this.teacherWageDataSet.TeacherBasicWage);
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
                courseWage.CourseNum = int.Parse(courseWageDs.Tables[0].Rows[i][1]+"");
                courseWage.StandardPrice = double.Parse(courseWageDs.Tables[0].Rows[i][2]+"");
                courseWage.ActualPrice = double.Parse(courseWageDs.Tables[0].Rows[i][3]+"");
                courseWage.CourseAmount = double.Parse(courseWageDs.Tables[0].Rows[i][4]+"");
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
                chargeBack.StandardPrice = double.Parse(chargeBackDs.Tables[0].Rows[i][2]+"");
                chargeBack.ChargeBackNum = int.Parse(chargeBackDs.Tables[0].Rows[i][3]+"");
                chargeBack.ChargeBackAmount = double.Parse(chargeBackDs.Tables[0].Rows[i][4]+"");
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

        

        
    }
}
