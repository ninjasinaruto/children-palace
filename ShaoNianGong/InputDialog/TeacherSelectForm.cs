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
    public partial class TeacherSelectForm : Form
    {
        public int TeacherID;
        public string TeacherName;

        public TeacherSelectForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstTeachersList.Text.Trim() == "")
                this.DialogResult = DialogResult.Cancel;
            TeacherID = int.Parse(lstTeachersList.SelectedValue.ToString());
            TeacherName = lstTeachersList.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void TeacherSelectForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“teachersDataSet.Tearchers”中。您可以根据需要移动或删除它。
            this.tearchersTableAdapter.Fill(this.teachersDataSet.Tearchers);
        }
    }
}
