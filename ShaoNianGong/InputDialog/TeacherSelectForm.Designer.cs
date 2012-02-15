namespace ShaoNianGong
{
    partial class TeacherSelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstTeachersList = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.teachersDataSet = new ShaoNianGong.TeachersDataSet();
            this.tearchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tearchersTableAdapter = new ShaoNianGong.TeachersDataSetTableAdapters.TearchersTableAdapter();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tearchersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstTeachersList);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 295);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "教师列表";
            // 
            // lstTeachersList
            // 
            this.lstTeachersList.DataSource = this.tearchersBindingSource;
            this.lstTeachersList.DisplayMember = "Name";
            this.lstTeachersList.FormattingEnabled = true;
            this.lstTeachersList.ItemHeight = 12;
            this.lstTeachersList.Location = new System.Drawing.Point(19, 20);
            this.lstTeachersList.Name = "lstTeachersList";
            this.lstTeachersList.Size = new System.Drawing.Size(166, 256);
            this.lstTeachersList.TabIndex = 28;
            this.lstTeachersList.ValueMember = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(173, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(87, 330);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // teachersDataSet
            // 
            this.teachersDataSet.DataSetName = "TeachersDataSet";
            this.teachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tearchersBindingSource
            // 
            this.tearchersBindingSource.DataMember = "Tearchers";
            this.tearchersBindingSource.DataSource = this.teachersDataSet;
            // 
            // tearchersTableAdapter
            // 
            this.tearchersTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 376);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "TeacherSelectForm";
            this.Text = "选择教师";
            this.Load += new System.EventHandler(this.TeacherSelectForm_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tearchersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstTeachersList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private TeachersDataSet teachersDataSet;
        private System.Windows.Forms.BindingSource tearchersBindingSource;
        private TeachersDataSetTableAdapters.TearchersTableAdapter tearchersTableAdapter;

    }
}