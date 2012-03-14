namespace BanGongPingTai
{
    partial class CourseSelectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstCourseType = new System.Windows.Forms.ListBox();
            this.lstCourseSubtypes = new System.Windows.Forms.ListBox();
            this.courseSubtypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new BanGongPingTai.CoursesDataSet();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.courseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staticDataSet = new BanGongPingTai.staticDataSet();
            this.courseTypesTableAdapter = new BanGongPingTai.staticDataSetTableAdapters.CourseTypesTableAdapter();
            this.courseSubtypesTableAdapter = new BanGongPingTai.CoursesDataSetTableAdapters.CourseSubtypesTableAdapter();
            this.coursesTableAdapter = new BanGongPingTai.CoursesDataSetTableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubtypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类别选择：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(264, 634);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstCourseType
            // 
            this.lstCourseType.FormattingEnabled = true;
            this.lstCourseType.ItemHeight = 12;
            this.lstCourseType.Location = new System.Drawing.Point(23, 57);
            this.lstCourseType.Name = "lstCourseType";
            this.lstCourseType.Size = new System.Drawing.Size(165, 136);
            this.lstCourseType.TabIndex = 22;
            // 
            // lstCourseSubtypes
            // 
            this.lstCourseSubtypes.DataSource = this.courseSubtypesBindingSource;
            this.lstCourseSubtypes.DisplayMember = "CourseSubtypeName";
            this.lstCourseSubtypes.FormattingEnabled = true;
            this.lstCourseSubtypes.ItemHeight = 12;
            this.lstCourseSubtypes.Location = new System.Drawing.Point(23, 257);
            this.lstCourseSubtypes.Name = "lstCourseSubtypes";
            this.lstCourseSubtypes.Size = new System.Drawing.Size(165, 340);
            this.lstCourseSubtypes.TabIndex = 22;
            this.lstCourseSubtypes.ValueMember = "ID";
            // 
            // courseSubtypesBindingSource
            // 
            this.courseSubtypesBindingSource.DataMember = "CourseSubtypes";
            this.courseSubtypesBindingSource.DataSource = this.coursesDataSet;
            this.courseSubtypesBindingSource.PositionChanged += new System.EventHandler(this.courseSubtypesBindingSource_PositionChanged);
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstCourses
            // 
            this.lstCourses.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "ID", true));
            this.lstCourses.DataSource = this.coursesBindingSource;
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 12;
            this.lstCourses.Location = new System.Drawing.Point(18, 53);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(166, 544);
            this.lstCourses.TabIndex = 23;
            this.lstCourses.ValueMember = "ID";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.coursesDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "课程列表：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "科目选择：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 634);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lstCourseType);
            this.groupBox3.Controls.Add(this.lstCourseSubtypes);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 613);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择分类";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstCourses);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(222, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 613);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "课程选择";
            // 
            // courseTypesBindingSource
            // 
            this.courseTypesBindingSource.DataMember = "CourseTypes";
            this.courseTypesBindingSource.DataSource = this.staticDataSet;
            this.courseTypesBindingSource.PositionChanged += new System.EventHandler(this.courseTypesBindingSource_PositionChanged);
            // 
            // staticDataSet
            // 
            this.staticDataSet.DataSetName = "staticDataSet";
            this.staticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTypesTableAdapter
            // 
            this.courseTypesTableAdapter.ClearBeforeFill = true;
            // 
            // courseSubtypesTableAdapter
            // 
            this.courseSubtypesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // CourseSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 681);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CourseSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择您要查询的课程";
            this.Load += new System.EventHandler(this.CourseSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseSubtypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstCourseType;
        private System.Windows.Forms.ListBox lstCourseSubtypes;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource courseTypesBindingSource;
        private staticDataSet staticDataSet;
        private staticDataSetTableAdapters.CourseTypesTableAdapter courseTypesTableAdapter;
        private System.Windows.Forms.BindingSource courseSubtypesBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CoursesDataSet coursesDataSet;
        private CoursesDataSetTableAdapters.CourseSubtypesTableAdapter courseSubtypesTableAdapter;
        private CoursesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
    }
}