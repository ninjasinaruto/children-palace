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
    public partial class ConfirmAddClassroomForm : Form
    {
        public string ClassroomName;

        public ConfirmAddClassroomForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ConfirmAddClassroomForm_Load(object sender, EventArgs e)
        {
            txtClassroomName.Text = ClassroomName;
        }
    }
}
