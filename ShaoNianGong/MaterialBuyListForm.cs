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
        public MaterialBuyListForm()
        {
            InitializeComponent();
        }

        private void MaterialBuyListForm_Load(object sender, EventArgs e)
        {
            //DateTime beginDate = DateTime.Now;
            //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
            // TODO: 这行代码将数据加载到表“materialsDataSet1.StudentMaterials”中。您可以根据需要移动或删除它。
            //this.studentMaterialsTableAdapter.Fill(this.materialsDataSet1.StudentMaterials);
            this.studentMaterialsTableAdapter.FillByBeginDate(this.materialsDataSet1.StudentMaterials);
            txtShowRange.Text = "本月";
        }

        private void btnShowThisMonthBuy_Click(object sender, EventArgs e)
        {
            //DateTime beginDate = DateTime.Now;
            //beginDate = new DateTime(beginDate.Year, beginDate.Month, 1, 0, 0, 0);
            this.studentMaterialsTableAdapter.FillByBeginDate(this.materialsDataSet1.StudentMaterials);
            txtShowRange.Text = "本月";
        }

        private void btnShowAllBuy_Click(object sender, EventArgs e)
        {
            this.studentMaterialsTableAdapter.Fill(this.materialsDataSet1.StudentMaterials);
            txtShowRange.Text = "所有";
        }

        private void btnShowFilterBuy_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBuyBeginDate.Value;
            beginDate = new DateTime(beginDate.Year, beginDate.Month, beginDate.Day, 0, 0, 0);
            DateTime endDate = dtBuyEndDate.Value;
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);
            this.studentMaterialsTableAdapter.FillByBeginEndDate(this.materialsDataSet1.StudentMaterials, beginDate, endDate);
            txtShowRange.Text = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
        }

        private void bindingSource1_ListChanged(object sender, EventArgs e)
        {
            int totalBuy = 0;
            int totalPaid = 0;
            foreach (DataRow row in materialsDataSet1.StudentMaterials.Rows)
            {
                totalBuy += row.Field<int>("MaterialPrice") * row.Field<int>("BuyCount");
                totalPaid += row.Field<int>("TotalCost");
            }

            txtTotalBuy.Text = totalBuy.ToString();
            txtTotalPaid.Text = totalPaid.ToString();
            lblBuyCount.Text = this.materialsDataSet1.StudentMaterials.Rows.Count + "条";
        }

        private void MaterialBuyListForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height - 192;
        }
    }
}
