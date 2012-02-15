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
    public partial class CardConnectForm : Form
    {
        public string cardNo = "";

        public CardConnectForm()
        {
            InitializeComponent();
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cardNo = txtCardNo.Text;
                this.Close();
            }
        }

        private void CardConnectForm_Shown(object sender, EventArgs e)
        {
            txtCardNo.Text = "";
            txtCardNo.Focus();
        }
    }
}
