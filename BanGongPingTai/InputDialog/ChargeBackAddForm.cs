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
    public partial class ChargeBackAddForm : Form
    {
        public string ChargeBackName;
        public string ChargeBackType;
        public double ChargeBackPrice;
        public int ChargeBackNum;
        public double ChargeBackAmount;
        public string Remark;

        public ChargeBackAddForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtChargeBackType.Text.Trim() == "") {
                MessageBox.Show("请输入扣款类别！", "提示", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                txtChargeBackType.Focus();
                return;
            }
            if (txtStandardPrice.Text.Trim() == "")
            {
                MessageBox.Show("请输入对应标准！", "提示", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                txtStandardPrice.Focus();
                return;
            }
            if (txtChargeBackNum.Text.Trim() == "")
            {
                MessageBox.Show("请输入数量！", "提示", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                txtChargeBackNum.Focus();
                return;
            }
            if (txtChargeBackAmount.Text.Trim() == "")
            {
                MessageBox.Show("请输入金额！", "提示", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                txtChargeBackAmount.Focus();
                return;
            }
            this.ChargeBackName = cbChargeBackName.Text;
            this.ChargeBackType = txtChargeBackType.Text;
            this.ChargeBackPrice = txtStandardPrice.Value;
            this.ChargeBackNum = txtChargeBackNum.Value;
            this.ChargeBackAmount = txtChargeBackAmount.Value;
            this.Remark = txtRemark.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void txtStandardPrice_ValueChanged(object sender, EventArgs e)
        {
            if (txtStandardPrice.Text != null && txtChargeBackNum.Text != null)
            {
                txtChargeBackAmount.Text = txtStandardPrice.Value * txtChargeBackNum.Value + "";
            }
        }

        private void txtChargeBackNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtStandardPrice.Text != null && txtChargeBackNum.Text != null)
            {
                txtChargeBackAmount.Text = txtStandardPrice.Value * txtChargeBackNum.Value + "";
            }
        }

        private void ChargeBackAddForm_Load(object sender, EventArgs e)
        {
            cbChargeBackName.SelectedIndex = 0;
        }
    }
}
