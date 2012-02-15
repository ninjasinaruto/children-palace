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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentsDataSet.Students”中。您可以根据需要移动或删除它。
            //this.studentsTableAdapter.Fill(this.studentsDataSet.Students);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            studentsBindingSource.AddNew();
            txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //groupBox1.Enabled = false;

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            try
            {

                if (dataGridView1.SelectedRows[0].Index > 0)
                {
                    studentsBindingSource.MovePrevious();
                    studentsBindingSource.MoveNext();
                }
                else
                {
                    studentsBindingSource.MovePrevious();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //studentsTableAdapter.Update(studentsDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentsBindingSource.RemoveCurrent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
