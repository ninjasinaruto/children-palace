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
            // TODO: 这行代码将数据加载到表“materialsDataSet1.StudentMaterials”中。您可以根据需要移动或删除它。
            this.studentMaterialsTableAdapter.Fill(this.materialsDataSet1.StudentMaterials);

        }
    }
}
