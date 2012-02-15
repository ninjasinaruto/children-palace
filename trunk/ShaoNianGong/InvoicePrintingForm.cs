using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Xml;
using System.Collections;
using System.Text.RegularExpressions;

namespace ShaoNianGong
{
    public partial class InvoicePrintingForm : Form
    {
        private FormatPrint formatPrint = null;
        public bool isReadOnly = false;
        public string userName = "";
        public List<PrintRecord> recordList = null;
        public string headName = "高世峰";
        public string accountingName = "许雪峰";
        public string cashierName = User.CurrentUser.UserName;
        public float totalAmount;
        public string totalAmountStr = "";

        SortedList topList = null;
        SortedList totalList = null;
        SortedList bottomList = null;

        public InvoicePrintingForm()
        {
            InitializeComponent();
        }

        private void InvoicePrintingForm_Load(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls) {
                if (c is TextBox) {
                    TextBox txtBox = (TextBox) c;
                    if (!isReadOnly)
                    {
                        if ("txtTotal".Equals(c.Name) || "txtHead".Equals(c.Name) || "txtAccounting".Equals(c.Name) || "txtCashier".Equals(c.Name))
                        {
                            txtBox.ReadOnly = !isReadOnly;
                        }
                        else {
                            txtBox.ReadOnly = isReadOnly;
                        }
                    }
                    else 
                    {
                        if (c.Name.IndexOf("txtRemark") != -1)
                        {
                            txtBox.ReadOnly = !isReadOnly;
                        }
                        else
                        {
                            txtBox.ReadOnly = isReadOnly;
                        }
                    }
                }
            }
            txtUserName.Text = userName;
            dateTimePicker.Text = DateTime.Now.ToLongDateString();
            txtHead.Text = headName;
            txtAccounting.Text = accountingName;
            txtCashier.Text = cashierName;

            if (recordList != null)
            {
                int i = 1;
                foreach (PrintRecord pr in recordList)
                {
                    TextBox txtName = GetTextBoxByName("txtName" + i);
                    txtName.Text = pr.name;
                    TextBox txtNum = GetTextBoxByName("txtNum" + i);
                    txtNum.Text = pr.num + "";
                    TextBox txtPrice = GetTextBoxByName("txtPrice" + i);
                    txtPrice.Text = pr.price;
                    TextBox txtAmount = GetTextBoxByName("txtAmount" + i);
                    txtAmount.Text = pr.amount;
                    i++;
                }
            }
        }

        private bool SetPrintRecord() {
            try
            {
                totalAmount = float.Parse(txtTotal.Text);
            }
            catch (Exception)
            {
                totalAmount = 0;
            }
            
            if (totalAmount > 99999.99)
            {
                MessageBox.Show("发票金额不能大于99999.99元", "发票金额不能大于99999.99元", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (totalAmount > 0)
            {
                totalAmountStr = ConvertNum(totalAmount);
            }
            else {
                MessageBox.Show("发票金额不能小于等于0元", "发票金额不能小于等于0元", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return false;
            }

            if (!isReadOnly)
            {
                recordList = null;
                formatPrint = null;
            }
            formatPrint = new FormatPrint();
            formatPrint.loadPrintTemplate("PrtTemplate.xml");
            topList = formatPrint.topList;
            totalList = formatPrint.totalList;
            bottomList = formatPrint.bottomList;

            // 票头
            formatPrint.SetPrintPointValue("userName", txtUserName.Text, topList, 0);
            formatPrint.SetPrintPointValue("year", DateTime.Now.Year.ToString(), topList, 0);
            formatPrint.SetPrintPointValue("month", DateTime.Now.Month.ToString(), topList, 0);
            formatPrint.SetPrintPointValue("day", DateTime.Now.Day.ToString(), topList, 0);

            if (recordList == null) {
                recordList = new List<PrintRecord>();
                for (int m = 1; m <= 4; m++) {
                    PrintRecord pr = new PrintRecord();
                    pr.id = m;
                    TextBox txtName = GetTextBoxByName("txtName" + m);
                    pr.name = "".Equals(txtName.Text) ? "" : txtName.Text;
                    TextBox txtNum = GetTextBoxByName("txtNum" + m);
                    pr.num = "".Equals(txtNum.Text) ? "" : txtNum.Text;
                    TextBox txtPrice = GetTextBoxByName("txtPrice" + m);
                    pr.price = "".Equals(txtPrice.Text) ? "" : Math.Round(float.Parse(txtPrice.Text),2).ToString("0.00");
                    TextBox txtAmount = GetTextBoxByName("txtAmount" + m);
                    pr.amount = "".Equals(txtAmount.Text) ? "" : txtAmount.Text;
                    recordList.Add(pr);
                }
            }

            int j = 1;
            foreach (PrintRecord pr in recordList)
            {
                // 内容
                formatPrint.SetPrintPointValue("name", pr.name, null, j);
                formatPrint.SetPrintPointValue("num", pr.num + "", null, j);
                formatPrint.SetPrintPointValue("price", pr.price, null, j);
                if (!"".Equals(pr.amount)) {
                    formatPrint.SetPrintPointValue("unit", "元", null, j);
                    string amountStr = Math.Round(float.Parse(pr.amount),2).ToString("00000.00").Replace(".","");
                    formatPrint.SetPrintPointValue("amountWan", amountStr.Substring(0, 1), null, j);
                    formatPrint.SetPrintPointValue("amountQian", amountStr.Substring(1, 1), null, j);
                    formatPrint.SetPrintPointValue("amountBai", amountStr.Substring(2, 1), null, j);
                    formatPrint.SetPrintPointValue("amountShi", amountStr.Substring(3, 1), null, j);
                    formatPrint.SetPrintPointValue("amountYuan", amountStr.Substring(4, 1), null, j);
                    formatPrint.SetPrintPointValue("amountJiao", amountStr.Substring(5, 1), null, j);
                    formatPrint.SetPrintPointValue("amountFen", amountStr.Substring(6, 1), null, j);
                }
                formatPrint.SetPrintPointValue("remark", GetTextBoxByName("txtRemark" + j).Text, null, j);
                j++;
            }

            if (!"".Equals(totalAmountStr))
            {
                formatPrint.SetPrintPointValue("totalWan", totalAmountStr.Substring(0, 1), totalList, 0);
                formatPrint.SetPrintPointValue("totalQian", totalAmountStr.Substring(1, 1), totalList, 0);
                formatPrint.SetPrintPointValue("totalBai", totalAmountStr.Substring(2, 1), totalList, 0);
                formatPrint.SetPrintPointValue("totalShi", totalAmountStr.Substring(3, 1), totalList, 0);
                formatPrint.SetPrintPointValue("totalYuan", totalAmountStr.Substring(4, 1), totalList, 0);
                formatPrint.SetPrintPointValue("totalJiao", totalAmountStr.Substring(5, 1), totalList, 0);
                formatPrint.SetPrintPointValue("totalFen", totalAmountStr.Substring(6, 1), totalList, 0);
            }
            formatPrint.SetPrintPointValue("totalNum", totalAmount.ToString(), totalList, 0);

            // 票尾
            formatPrint.SetPrintPointValue("head", txtHead.Text, bottomList, 0);
            formatPrint.SetPrintPointValue("accounting", txtAccounting.Text, bottomList, 0);
            formatPrint.SetPrintPointValue("cashier", txtCashier.Text, bottomList, 0);

            return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (SetPrintRecord()) {
                formatPrint.Print();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (SetPrintRecord()) {
                formatPrint.Preview();
            }
        }

        private void numKeyPressEvent(KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            numKeyPressEvent(e);
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            numKeyPressEvent(e);
        }

        private void txtNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            numKeyPressEvent(e);
        }

        private void txtNum4_KeyPress(object sender, KeyPressEventArgs e)
        {
            numKeyPressEvent(e);
        }

        private void priceKeyPressEvent(TextBox txtBox, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 || e.KeyChar == 46)    //小数点
            {
                if (txtBox.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldF;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtBox.Text, out oldF);
                    b2 = float.TryParse(txtBox.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void txtPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
           priceKeyPressEvent(txtPrice1, e);
        }

        private void txtPrice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtPrice2, e);
        }

        private void txtPrice3_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtPrice3, e);
        }

        private void txtPrice4_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtPrice4, e);
        }

        private void txtAmount1_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtAmount1, e);
        }

        private void txtAmount2_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtAmount2, e);
        }

        private void txtAmount3_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtAmount3, e);
        }

        private void txtAmount4_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtAmount4, e);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceKeyPressEvent(txtTotal, e);
        }

        private void UpdateAmountValueByNum(TextBox txtNum, TextBox txtPrice, TextBox txtAmount) {
            if (!"".Equals(txtNum.Text))
            {
                float price;
                try
                {
                    price = float.Parse(txtPrice.Text);
                }
                catch (Exception)
                {
                    price = 0;
                }
                txtAmount.Text = Math.Round((int.Parse(txtNum.Text) * price),2).ToString("0.00");
            }
            else
            {
                txtAmount.Text = "";
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByNum(txtNum1, txtPrice1, txtAmount1);
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByNum(txtNum2, txtPrice2, txtAmount2);
        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByNum(txtNum3, txtPrice3, txtAmount3);
        }

        private void txtNum4_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByNum(txtNum4, txtPrice4, txtAmount4);
        }

        private void UpdateAmountValueByPrice(TextBox txtNum, TextBox txtPrice, TextBox txtAmount)
        {
            if (!"".Equals(txtPrice.Text))
            {
                int num;
                try
                {
                    num = int.Parse(txtNum.Text);
                }
                catch (Exception)
                {
                    num = 0;
                }
                txtAmount.Text = Math.Round((num * float.Parse(txtPrice.Text)),2).ToString("0.00");
            }
            else
            {
                txtAmount.Text = "";
            }
        }

        private void txtPrice1_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByPrice(txtNum1, txtPrice1, txtAmount1);
        }

        private void txtPrice2_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByPrice(txtNum2, txtPrice2, txtAmount2);
        }

        private void txtPrice3_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByPrice(txtNum3, txtPrice3, txtAmount3);
        }

        private void txtPrice4_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountValueByPrice(txtNum4, txtPrice4, txtAmount4);
        }

        private void UpdateTotalAmount() {
            float total = 0;
            foreach (Control c in this.Controls)
            {
                if (c.Name.IndexOf("txtAmount") != -1) {
                    try
                    {
                        total += float.Parse(c.Text);
                    }
                    catch (Exception)
                    {
                        total += 0;
                    }
                }
            }
            txtTotal.Text = Math.Round(total,2).ToString("0.00");
        }

        private void txtAmount1_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void txtAmount2_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void txtAmount3_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void txtAmount4_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private TextBox GetTextBoxByName(string txtBoxName) {
            return this.GetType().GetField(txtBoxName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic).GetValue(this) as TextBox;
        }

        private string ConvertNum(float num)
        {
            return Math.Round(num, 2).ToString("00000.00").Replace(".", "")
                       .Replace("0","零")
                       .Replace("1", "壹")
                       .Replace("2", "贰")
                       .Replace("3", "叁")
                       .Replace("4", "肆")
                       .Replace("5", "伍")
                       .Replace("6", "陆")
                       .Replace("7", "柒")
                       .Replace("8", "捌")
                       .Replace("9", "玖");
        }

    }
}
