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
    public partial class MaterialSelectedForm : Form
    {
        public int MaterialId;
        public string MaterialName;
        public MaterialSelectedForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MaterialId = int.Parse(lstMaterialName.SelectedValue.ToString());
            MaterialName = lstMaterialName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void MaterialSelectedForm_Load(object sender, EventArgs e)
        {
            this.materialsTableAdapter.Fill(this.materials._Materials);
        }
    }
}
