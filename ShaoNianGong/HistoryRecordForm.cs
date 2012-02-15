﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShaoNianGong
{
    public partial class HistoryRecordForm : Form
    {
        public int StudentID;

        public HistoryRecordForm()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoryRecordForm_Load(object sender, EventArgs e)
        {
            depositListTableAdapter.FillByStudentID(depositListDataSet.DepositList, this.StudentID);
            costListTableAdapter.FillByStudentID(costListDataSet.CostList, this.StudentID);
            studentMaterialsTableAdapter.FillByStudentID(materialsDataSet1.StudentMaterials, this.StudentID);
            leaveCourseTableAdapter.FillByStudentID(leaveCourseDataSet.LeaveCourse, this.StudentID);
        }
    }
}
