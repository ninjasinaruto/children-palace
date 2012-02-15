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
    public partial class CardTypeSelectForm : Form
    {
        // 0为普通卡，1为VIP卡
        public int CardType;

        public CardTypeSelectForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CardType = cmbCardType.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }

        private void CardTypeSelectForm_Load(object sender, EventArgs e)
        {
            cmbCardType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
