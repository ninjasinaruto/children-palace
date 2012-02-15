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
    public partial class BuyMaterialsForm : Form
    {
        public string StudentName;
        public string Balance;

        public int MaterialID;
        public string MaterialName;
        public int MaterialPrice;
        public int BuyCount;
        public int TotalCost;

        public BuyMaterialsForm()
        {
            InitializeComponent();
        }

        private void txtMaterialPrice_TextChanged(object sender, EventArgs e)
        {
            if (dgvMaterialList.SelectedRows.Count <= 0)
                return;
            int count;
            try
            {
                count = int.Parse(txtBuyCount.Text);
            }
            catch
            {
                return;
            }
            if(count <= 0)
                return;

            int price = int.Parse(dgvMaterialList.SelectedRows[0].Cells["materialPriceColumn"].Value.ToString());
            txtTotalCost.Text = (price * count).ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvMaterialList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择您要购买的材料", "选择购买材料", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int count;
            try
            {
                count = int.Parse(txtBuyCount.Text);
            }
            catch
            {
                MessageBox.Show("购买的数量必须为正整数", "购买的数量必须为正整数", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBuyCount.Focus();
                return;
            }
            if (count <= 0)
            {
                MessageBox.Show("购买的数量必须为正整数", "购买的数量必须为正整数", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBuyCount.Focus();
                return;
            }
            int leftCount = int.Parse(dgvMaterialList.SelectedRows[0].Cells["materialCountColumn"].Value.ToString());
            if (count > leftCount)
            {
                MessageBox.Show("库存不足，无法购买", "库存不足，无法购买", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBuyCount.Focus();
                return;
            }

            int price = int.Parse(dgvMaterialList.SelectedRows[0].Cells["materialPriceColumn"].Value.ToString());
            txtTotalCost.Text = (price * count).ToString();

            if (int.Parse(txtBalance.Text) < price * count)
            {
                MessageBox.Show("余额不足，无法购买", "余额不足，无法购买", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBuyCount.Focus();
                return;
            }

            if (MessageBox.Show("确认为“" + StudentName + "”购买“" + count + "”个“" +
                dgvMaterialList.SelectedRows[0].Cells["materialNameColumn"].Value.ToString()
                + "”吗？共需花费“" + txtTotalCost.Text + "”元", "确认购买材料", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            this.MaterialID = int.Parse(dgvMaterialList.SelectedRows[0].Cells["materialIDColumn"].Value.ToString());
            this.MaterialName = dgvMaterialList.SelectedRows[0].Cells["materialNameColumn"].Value.ToString();
            this.MaterialPrice = price;
            this.BuyCount = count;
            this.TotalCost = count * price;

            // 更新库存
            materialsTableAdapter.UpdateMaterialCount(leftCount - count, this.MaterialID);

            this.DialogResult = DialogResult.OK;
        }

        private void BuyMaterialsForm_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = StudentName;
            txtBalance.Text = Balance;
            materialsTableAdapter.Fill(materialsDataSet.Materials);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
