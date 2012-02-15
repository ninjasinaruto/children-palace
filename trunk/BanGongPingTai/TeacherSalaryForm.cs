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
    public partial class TeacherSalaryForm : Form
    {
        public TeacherSalaryForm()
        {
            InitializeComponent();
        }

        private void TeacherSalaryForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“teachersDataSet.Tearchers”中。您可以根据需要移动或删除它。
            this.tearchersTableAdapter.Fill(this.teachersDataSet.Tearchers);

        }
    }
}
