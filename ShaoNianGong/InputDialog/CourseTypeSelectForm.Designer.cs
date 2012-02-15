namespace ShaoNianGong
{
    partial class CourseTypeSelectForm
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
            this.lstCourseType = new System.Windows.Forms.ListBox();
            this.courseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staticDataSet = new ShaoNianGong.StaticDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.courseTypesTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.CourseTypesTableAdapter();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstCourseType);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 295);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "课程类别";
            // 
            // lstCourseType
            // 
            this.lstCourseType.DataSource = this.courseTypesBindingSource;
            this.lstCourseType.DisplayMember = "CourseTypeName";
            this.lstCourseType.FormattingEnabled = true;
            this.lstCourseType.ItemHeight = 12;
            this.lstCourseType.Location = new System.Drawing.Point(19, 20);
            this.lstCourseType.Name = "lstCourseType";
            this.lstCourseType.Size = new System.Drawing.Size(166, 256);
            this.lstCourseType.TabIndex = 28;
            this.lstCourseType.ValueMember = "CourseTypeID";
            // 
            // courseTypesBindingSource
            // 
            this.courseTypesBindingSource.DataMember = "CourseTypes";
            this.courseTypesBindingSource.DataSource = this.staticDataSet;
            // 
            // staticDataSet
            // 
            this.staticDataSet.DataSetName = "StaticDataSet";
            this.staticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(173, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(87, 330);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // courseTypesTableAdapter
            // 
            this.courseTypesTableAdapter.ClearBeforeFill = true;
            // 
            // CourseTypeSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 377);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CourseTypeSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择您要查询的课程类别";
            this.Load += new System.EventHandler(this.CourseTypeSelectForm_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private StaticDataSet staticDataSet;
        private System.Windows.Forms.BindingSource courseTypesBindingSource;
        private StaticDataSetTableAdapters.CourseTypesTableAdapter courseTypesTableAdapter;
        private System.Windows.Forms.ListBox lstCourseType;
    }
}