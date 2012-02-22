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
    public partial class LeftCourseForm : Form
    {
        public LeftCourseForm()
        {
            InitializeComponent();
        }

        private void LeftCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“leaveCourseDataSet.LeaveCourse”中。您可以根据需要移动或删除它。
            this.leaveCourseTableAdapter.Fill(this.leaveCourseDataSet.LeaveCourse);

        }

        private void LeftCourseForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height - 150;
        }
    }
}
