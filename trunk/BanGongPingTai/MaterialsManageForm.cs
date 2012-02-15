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
    public partial class MaterialsManageForm : Form
    {
        public int BuyCount = 0;
        public int ActualCost;
        public string Remark;

        public MaterialsManageForm()
        {
            InitializeComponent();
        }

        private void txtBuyCount_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuyCount.Text, out BuyCount) || BuyCount < 0)
            {
                MessageBox.Show("购买的数量必须为非负整数", "购买数量不合法", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBuyCount.Focus();
                return;
            }

            txtTotalPrice.Text = (BuyCount * int.Parse(txtMaterialPrice.Text)).ToString();
            txtActualCost.Text = txtTotalPrice.Text;
        }

        private void MaterialsManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“materialsDataSet.MaterialsBuy”中。您可以根据需要移动或删除它。
            this.materialsBuyTableAdapter.Fill(this.materialsDataSet.MaterialsBuy);
            // TODO: 这行代码将数据加载到表“materialsDataSet._Materials”中。您可以根据需要移动或删除它。
            this.materialsTableAdapter.Fill(this.materialsDataSet._Materials);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvMaterialList.SelectedRows.Count <= 0)
                return;
            DataGridViewRow row = dgvMaterialList.SelectedRows[0];

            if (BuyCount <= 0)
            {
                MessageBox.Show("购买的数量必须为正整数", "购买数量不合法", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtBuyCount.Focus();
                return;
            }

            if (!int.TryParse(txtActualCost.Text, out ActualCost) || ActualCost < 0)
            {
                MessageBox.Show("实际费用必须为非负整数", "实际费用不合法", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtActualCost.Focus();
                return;
            }

            // 请求确认
            if (MessageBox.Show("确认购买[" + BuyCount + "]件[" + txtMaterialName.Text + "]材料，花费["
                + txtActualCost.Text + "]元吗？", "确认购买材料", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK)
                return;

            // 1> 更新库存
            int newCount = int.Parse(row.Cells["materialCountColumn"].Value.ToString()) + BuyCount;
            materialsTableAdapter.UpdateCount(newCount,
                int.Parse(row.Cells["materialIDColumn"].Value.ToString()));
            // 2> 添加购买记录
            materialsBuyTableAdapter.Insert(int.Parse(row.Cells["materialIDColumn"].Value.ToString()),
                BuyCount, int.Parse(txtTotalPrice.Text), ActualCost, txtRemark.Text, dtBuyTime.Value);

            // 刷新界面
            row.Cells["materialCountColumn"].Value = newCount;
            txtBuyCount.Text = "0";
            txtTotalPrice.Text = "";
            txtActualCost.Text = "";
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAddMaterialType_Click(object sender, EventArgs e)
        {
            if (txtNewMaterialName.Text.Trim() == "")
            {
                MessageBox.Show("材料名不可为空", "材料名不可为空", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNewMaterialName.Focus();
                return;
            }

            int materialPrice;
            if (!int.TryParse(txtNewMaterialPrice.Text, out materialPrice) || materialPrice <= 0)
            {
                MessageBox.Show("材料单价必须为正整数", "材料单价不合法", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNewMaterialPrice.Focus();
                return;
            }

            // 请求确认
            if (MessageBox.Show("确认添加材料[" + txtNewMaterialName.Text + "]吗？单价为["
                + txtNewMaterialPrice.Text + "]元？", "确认添加材料", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK)
                return;

            // 更新数据库
            materialsTableAdapter.Insert(txtNewMaterialName.Text, materialPrice, 0);

            // 刷新界面
            materialsTableAdapter.Fill(materialsDataSet._Materials);
        }

        private void materialsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            txtBuyCount.Text = "0";
            txtTotalPrice.Text = "";
            txtActualCost.Text = "";
        }
    }
}
