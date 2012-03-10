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
    public partial class WageDetailPrintForm : Form
    {
        public int LogID;
        public int TeacherID;
        public string TeacherName;
        public string printTitle;
        public double coefficient = 1.0;
        public double shouldWages;
        public double realWages;
        public WageDetailPrintForm()
        {
            InitializeComponent();
        }

        private void WageDetailPrintForm_Load(object sender, EventArgs e)
        {
            this.teacherBasicWageTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherBasicWage, LogID);
            this.teacherCourseWageTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherCourseWage, LogID);
            this.teacherStudentAwardTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherStudentAward, LogID);
            this.teacherAwardTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherAward, LogID);
            this.teacherChargeBackTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherChargeBack, LogID);
            this.teacherCoefficientTableAdapter.FillByLogID(this.teacherWageDataSet.TeacherCoefficient, LogID);
            if (this.teacherWageDataSet.TeacherCoefficient.Rows.Count > 0)
            {
                coefficient = this.teacherWageDataSet.TeacherCoefficient.Rows[0].Field<double>("Coefficient");
            }
            vbPrint.InvalidatePreview();
        }

        private void vbPrint_PrintDocument()
        {
            vbPrint.NewPage();
            vbPrint.PrintDGV(dgvBasicWage, printTitle, new Font("黑体", 14), "", null, StringAlignment.Center, "1111",
                true, true, new Font("黑体", 10, FontStyle.Bold), "教师姓名：" + TeacherName, "", "打印时间：" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString(), null, null, Color.Black, Color.WhiteSmoke,
                "",
                false, false, "", System.ComponentModel.ListSortDirection.Ascending, "", false, "",
                "", "", 6, true, true, false, 0, 0);
            vbPrint.NewRow(30);
            vbPrint.PrintDGV(dgvCourseWage, "", new Font("黑体", 18), "", null, StringAlignment.Center, "1111",
                true, true, new Font("黑体", 10, FontStyle.Bold), "系数：" + coefficient, "", "", null, null, Color.Black, Color.WhiteSmoke,
                "",
                false, false, "", System.ComponentModel.ListSortDirection.Ascending, "", false, "",
                "", "", 6, true, true, false, 0, 0);
            vbPrint.NewRow(30);
            vbPrint.PrintDGV(dgvStudentAward, "", new Font("黑体", 18), "", null, StringAlignment.Center, "1111",
                true, true, new Font("黑体", 10, FontStyle.Bold), "学生管理奖", "", "", null, null, Color.Black, Color.WhiteSmoke,
                "",
                false, false, "", System.ComponentModel.ListSortDirection.Ascending, "", false, "",
                "", "", 6, true, true, false, 0, 0);
            vbPrint.NewRow(30);
            vbPrint.PrintDGV(dgvTeacherAward, "", new Font("黑体", 18), "", null, StringAlignment.Center, "1111",
                true, true, new Font("黑体", 10, FontStyle.Bold), "奖励工资", "", "", null, null, Color.Black, Color.WhiteSmoke,
                "",
                false, false, "", System.ComponentModel.ListSortDirection.Ascending, "", false, "",
                "", "", 6, true, true, false, 0, 0);
            vbPrint.NewRow(30);
            vbPrint.DrawLine(vbPrint.Currentx, vbPrint.Currenty, vbPrint.PaperPrintWidth, vbPrint.Currenty, Color.Gray, 1);
            vbPrint.NewRow(10);
            vbPrint.DrawText("合计：" + shouldWages.ToString("0.00"), vbPrint.PaperPrintWidth, vbPrint.LastDrawTextHeight, new Font("黑体", 10, FontStyle.Bold), Color.Black, StringAlignment.Near, StringAlignment.Center, true, true, true, false, 6, 0);
            vbPrint.NewRow(30);
            dgvChargeBack.Columns[0].Tag = "合并";
            vbPrint.PrintDGV(dgvChargeBack, "", new Font("黑体", 18), "", null, StringAlignment.Center, "1111",
                true, true, new Font("黑体", 10, FontStyle.Bold), "代扣处罚", "", "", null, null, Color.Black, Color.WhiteSmoke,
                "",
                false, false, "", System.ComponentModel.ListSortDirection.Ascending, "", false, "",
                "", "", 6, true, true, false, 0, 0);
            vbPrint.NewRow(30);
            vbPrint.DrawLine(vbPrint.Currentx, vbPrint.Currenty, vbPrint.PaperPrintWidth, vbPrint.Currenty, Color.Gray, 1);
            vbPrint.NewRow(10);
            vbPrint.DrawText("实发工资：" + realWages.ToString("0.00"), vbPrint.PaperPrintWidth, vbPrint.LastDrawTextHeight, new Font("黑体", 10, FontStyle.Bold), Color.Black, StringAlignment.Near, StringAlignment.Center, true, true, true, false, 6, 0);
            vbPrint.NewRow(vbPrint.LastDrawTextHeight);
        }

        private void vbPrint_HeaderFooterOut(int pages, int curpage)
        {
            vbPrint.PrintFooter("", "第" + curpage + "页 共" + pages + "页", "", new Font("宋体", 10), Color.Black, 0);
        }

        private void WageDetailPrintForm_Resize(object sender, EventArgs e)
        {
            this.lblMask.Width = this.Width - 540;
        }
    }
}
