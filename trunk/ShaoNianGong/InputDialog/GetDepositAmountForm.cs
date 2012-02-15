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
    public partial class GetDepositAmountForm : Form
    {
        public string StudentName;
        public string CardNo;
        public string CardType;

        public int DepositAmount;
        public int PaidAmount;

        public int tuitionAmount;
        public int materialsAmount;
        public int otherAmount;
             

        public GetDepositAmountForm()
        {
            InitializeComponent();
        }

        private void GetDepositAmountForm_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = StudentName;
            txtCardNo.Text = CardNo;
            txtCardType.Text = CardType;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DepositAmount = int.Parse(txtDepositAmount.Text);
                if (DepositAmount <= 0)
                {
                    MessageBox.Show("充值金额必须为正整数", "充值金额必须为正整数", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtDepositAmount.Text = "";
                    txtDepositAmount.Focus();
                    return;
                }

                if (CardType == "VIP卡" && DepositAmount >= 1500)
                {
                    PaidAmount = (int)(DepositAmount * 0.8);
                }
                else
                {
                    PaidAmount = DepositAmount;
                }
            }
            catch
            {
                MessageBox.Show("充值金额必须为正整数", "充值金额必须为正整数", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDepositAmount.Text = "";
                txtDepositAmount.Focus();
                return;
            }

            if (DepositAmount > 99999) {
                MessageBox.Show("充值金额不能大于99999元", "充值金额不能大于99999元", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDepositAmount.Text = "";
                txtDepositAmount.Focus();
                return;
            }

            try
            {
                if (!"".Equals(txtTuition.Text))
                {
                    // 学费
                    tuitionAmount = int.Parse(txtTuition.Text);
                    if (tuitionAmount <= 0)
                    {
                        MessageBox.Show("学费金额必须为正整数", "学费金额必须为正整数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTuition.Text = "";
                        txtTuition.Focus();
                        return;
                    }
                }
                else {
                    tuitionAmount = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("学费金额必须为正整数", "学费金额必须为正整数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuition.Text = "";
                txtTuition.Focus();
                return;
            }

            try
            {
                if (!"".Equals(txtMaterials.Text))
                {
                    // 材料费
                    materialsAmount = int.Parse(txtMaterials.Text);
                    if (materialsAmount < 0)
                    {
                        MessageBox.Show("材料费金额必须为正整数", "材料费金额必须为正整数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaterials.Text = "";
                        txtMaterials.Focus();
                        return;
                    }
                }
                else
                {
                    materialsAmount = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("材料费金额必须为正整数", "材料费金额必须为正整数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaterials.Text = "";
                txtMaterials.Focus();
                return;
            }

            try
            {
                if (!"".Equals(txtOther.Text))
                {
                    // 其他
                    otherAmount = int.Parse(txtOther.Text);
                    if (otherAmount < 0)
                    {
                        MessageBox.Show("其他金额必须为正整数", "其他金额必须为正整数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOther.Text = "";
                        txtOther.Focus();
                        return;
                    }
                }
                else
                {
                    otherAmount = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("其他金额必须为正整数", "其他金额必须为正整数", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOther.Text = "";
                txtOther.Focus();
                return;
            }

            if (tuitionAmount + materialsAmount + otherAmount > DepositAmount)
            {
                MessageBox.Show("学费、材料费、其他费用总和不能大于充值金额", "学费、材料费、其他费用总和不能大于充值金额", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepositAmount.Text = "";
                txtDepositAmount.Focus();
                return;
            } else {
                if (!"".Equals(txtTuition.Text) || !"".Equals(txtMaterials.Text) || !"".Equals(txtOther.Text)) {
                    if (tuitionAmount + materialsAmount + otherAmount < DepositAmount)
                    {
                        MessageBox.Show("学费、材料费、其他费用总和不能小于充值金额", "学费、材料费、其他费用总和不能小于充值金额", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDepositAmount.Text = "";
                        txtDepositAmount.Focus();
                        return;
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void GetDepositAmountForm_Activated(object sender, EventArgs e)
        {
            txtDepositAmount.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DepositAmount = int.Parse(txtDepositAmount.Text);
            }
            catch (Exception)
            {
                return;
            }

            if (CardType == "VIP卡" && DepositAmount >= 1500)
            {
                PaidAmount = (int)(DepositAmount * 0.8);
            }
            else
            {
                PaidAmount = DepositAmount;
            }

            txtPaidAmount.Text = PaidAmount.ToString();
        }
    }
}
