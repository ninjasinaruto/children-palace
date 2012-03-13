using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShaoNianGong
{
    public partial class MaterialBuyListForm : Form
    {
        public string UserName;
        public int UserType;

        public MaterialBuyListForm()
        {
            InitializeComponent();
        }

        private void MaterialBuyListForm_Load(object sender, EventArgs e)
        {
            this.studentMaterialsTableAdapter.FillByBeginDate(this.materialsDataSet.StudentMaterials);
            txtShowRange.Text = "本月";
        }

        private void btnShowThisMonthBuy_Click(object sender, EventArgs e)
        {
            this.studentMaterialsTableAdapter.FillByBeginDate(this.materialsDataSet.StudentMaterials);
            txtShowRange.Text = "本月";
        }

        private void btnShowAllBuy_Click(object sender, EventArgs e)
        {
            this.studentMaterialsTableAdapter.Fill(this.materialsDataSet.StudentMaterials);
            txtShowRange.Text = "所有";
        }

        private void btnShowFilterBuy_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBuyBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtBuyEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.studentMaterialsTableAdapter.FillByBeginEndDate(this.materialsDataSet.StudentMaterials, beginDate, endDate);
            txtShowRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void bindingSource1_ListChanged(object sender, EventArgs e)
        {
            
        }

        private void MaterialBuyListForm_Resize(object sender, EventArgs e)
        {
            dgvMaterials.Width = this.Width - 20;
            dgvMaterials.Height = this.Height - 192;
        }

        private void dgvMaterials_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvMaterials.Rows.Count > 0)
                for (int i = 0; i < dgvMaterials.Rows.Count; i++)
                {
                    dgvMaterials.Rows[i].Cells[0].Value = i + 1;
                }
        }

        private void materialsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            int totalBuy = 0;
            int totalPaid = 0;
            foreach (DataRow row in materialsDataSet.StudentMaterials.Rows)
            {
                totalBuy += row.Field<int>("MaterialPrice") * row.Field<int>("BuyCount");
                totalPaid += row.Field<int>("TotalCost");
            }

            txtTotalBuy.Text = totalBuy.ToString();
            txtTotalPaid.Text = totalPaid.ToString();
            lblBuyCount.Text = this.materialsDataSet.StudentMaterials.Rows.Count + "条";
        }

        private void btnSearchByCourseType_Click(object sender, EventArgs e)
        {
            CourseTypeSelectForm frmCourseTypeSelect = new CourseTypeSelectForm();
            DateTime beginDate = dtBuyBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtBuyEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (UserType == 0)
            {
                frmCourseTypeSelect.isPrivate = true;
                frmCourseTypeSelect.userName = this.UserName;
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentMaterialsTableAdapter.FillByUserNameCourseTypeWithDate(this.materialsDataSet.StudentMaterials, frmCourseTypeSelect.CourseTypeId, beginDate, endDate, this.UserName);
            }
            else
            {
                if (frmCourseTypeSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentMaterialsTableAdapter.FillByCourseTypeWithDate(this.materialsDataSet.StudentMaterials, frmCourseTypeSelect.CourseTypeId, beginDate, endDate);
            }
            txtShowRange.Text = frmCourseTypeSelect.CourseTypeName;
        }

        private void btnSearchByCourse_Click(object sender, EventArgs e)
        {
            CourseSelectForm frmCourseSelect = new CourseSelectForm();
            DateTime beginDate = dtBuyBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtBuyEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            if (UserType == 0)
            {
                frmCourseSelect.isPrivate = true;
                frmCourseSelect.userName = this.UserName;
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentMaterialsTableAdapter.FillByUserNameCourseIDWithDate(this.materialsDataSet.StudentMaterials, frmCourseSelect.CourseID, beginDate, endDate, this.UserName);
            }
            else
            {
                if (frmCourseSelect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.studentMaterialsTableAdapter.FillByCourseIDWithDate(this.materialsDataSet.StudentMaterials, frmCourseSelect.CourseID, beginDate, endDate);
            }
            txtShowRange.Text = frmCourseSelect.CourseTypeName + " - " + frmCourseSelect.CourseSubtypeName + " - " + frmCourseSelect.CourseName;
        }
    }
}
