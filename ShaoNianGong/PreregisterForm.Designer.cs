namespace ShaoNianGong
{
    partial class PreregisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtMotherWork = new System.Windows.Forms.TextBox();
            this.txtFartherWork = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotherPhone = new System.Windows.Forms.TextBox();
            this.txtFartherPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFartherName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecommender = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreregister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.preregisterDataset = new ShaoNianGong.PreregisterDataset();
            this.studentsPreregBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsPreregTableAdapter = new ShaoNianGong.PreregisterDatasetTableAdapters.studentsPreregTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lstCourseType = new System.Windows.Forms.ListBox();
            this.lstCourseSubtypes = new System.Windows.Forms.ListBox();
            this.courseSubTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.courseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staticDataSet = new ShaoNianGong.StaticDataSet();
            this.courseTypesTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.CourseTypesTableAdapter();
            this.courseSubtypesTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CourseSubtypesTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new ShaoNianGong.StudentsDataSet();
            this.studentsTableAdapter = new ShaoNianGong.StudentsDataSetTableAdapters.StudentsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preregisterDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsPreregBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateBirth);
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Controls.Add(this.txtMotherWork);
            this.groupBox1.Controls.Add(this.txtFartherWork);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMotherPhone);
            this.groupBox1.Controls.Add(this.txtFartherPhone);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMotherName);
            this.groupBox1.Controls.Add(this.txtFartherName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRecommender);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本资料";
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(111, 59);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(117, 21);
            this.dateBirth.TabIndex = 7;
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(339, 24);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(56, 20);
            this.cmbSex.TabIndex = 5;
            // 
            // txtMotherWork
            // 
            this.txtMotherWork.Location = new System.Drawing.Point(339, 133);
            this.txtMotherWork.Name = "txtMotherWork";
            this.txtMotherWork.Size = new System.Drawing.Size(137, 21);
            this.txtMotherWork.TabIndex = 21;
            // 
            // txtFartherWork
            // 
            this.txtFartherWork.Location = new System.Drawing.Point(339, 96);
            this.txtFartherWork.Name = "txtFartherWork";
            this.txtFartherWork.Size = new System.Drawing.Size(137, 21);
            this.txtFartherWork.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "母亲工作单位：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "父亲工作单位：";
            // 
            // txtMotherPhone
            // 
            this.txtMotherPhone.Location = new System.Drawing.Point(562, 132);
            this.txtMotherPhone.Name = "txtMotherPhone";
            this.txtMotherPhone.Size = new System.Drawing.Size(106, 21);
            this.txtMotherPhone.TabIndex = 23;
            // 
            // txtFartherPhone
            // 
            this.txtFartherPhone.Location = new System.Drawing.Point(562, 95);
            this.txtFartherPhone.Name = "txtFartherPhone";
            this.txtFartherPhone.Size = new System.Drawing.Size(106, 21);
            this.txtFartherPhone.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "母亲电话：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "父亲电话：";
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(111, 133);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(117, 21);
            this.txtMotherName.TabIndex = 19;
            // 
            // txtFartherName
            // 
            this.txtFartherName.Location = new System.Drawing.Point(111, 96);
            this.txtFartherName.Name = "txtFartherName";
            this.txtFartherName.Size = new System.Drawing.Size(117, 21);
            this.txtFartherName.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "母亲姓名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "父亲姓名：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(339, 59);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 21);
            this.txtAddress.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "推荐人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "地址：";
            // 
            // txtRecommender
            // 
            this.txtRecommender.Location = new System.Drawing.Point(562, 24);
            this.txtRecommender.Name = "txtRecommender";
            this.txtRecommender.Size = new System.Drawing.Size(106, 21);
            this.txtRecommender.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(562, 58);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(106, 21);
            this.txtPhone.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "性别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 21);
            this.txtName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "出生日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // btnPreregister
            // 
            this.btnPreregister.Location = new System.Drawing.Point(620, 326);
            this.btnPreregister.Name = "btnPreregister";
            this.btnPreregister.Size = new System.Drawing.Size(110, 44);
            this.btnPreregister.TabIndex = 1;
            this.btnPreregister.Text = "预报名";
            this.btnPreregister.UseVisualStyleBackColor = true;
            this.btnPreregister.Click += new System.EventHandler(this.btnPreregister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(620, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 44);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // preregisterDataset
            // 
            this.preregisterDataset.DataSetName = "PreregisterDataset";
            this.preregisterDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsPreregBindingSource
            // 
            this.studentsPreregBindingSource.DataMember = "studentsPrereg";
            this.studentsPreregBindingSource.DataSource = this.preregisterDataset;
            // 
            // studentsPreregTableAdapter
            // 
            this.studentsPreregTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(268, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "科目选择：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 23;
            this.label15.Text = "类别选择：";
            // 
            // lstCourseType
            // 
            this.lstCourseType.FormattingEnabled = true;
            this.lstCourseType.ItemHeight = 12;
            this.lstCourseType.Location = new System.Drawing.Point(111, 24);
            this.lstCourseType.Name = "lstCourseType";
            this.lstCourseType.Size = new System.Drawing.Size(117, 172);
            this.lstCourseType.TabIndex = 26;
            // 
            // lstCourseSubtypes
            // 
            this.lstCourseSubtypes.DataSource = this.courseSubTypesBindingSource;
            this.lstCourseSubtypes.DisplayMember = "CourseSubtypeName";
            this.lstCourseSubtypes.FormattingEnabled = true;
            this.lstCourseSubtypes.ItemHeight = 12;
            this.lstCourseSubtypes.Location = new System.Drawing.Point(339, 24);
            this.lstCourseSubtypes.Name = "lstCourseSubtypes";
            this.lstCourseSubtypes.Size = new System.Drawing.Size(137, 172);
            this.lstCourseSubtypes.TabIndex = 25;
            this.lstCourseSubtypes.ValueMember = "ID";
            // 
            // courseSubTypesBindingSource
            // 
            this.courseSubTypesBindingSource.DataMember = "CourseSubtypes";
            this.courseSubTypesBindingSource.DataSource = this.coursesDataSet;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lstCourseType);
            this.groupBox2.Controls.Add(this.lstCourseSubtypes);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 208);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预报科目";
            // 
            // courseTypesBindingSource
            // 
            this.courseTypesBindingSource.DataMember = "CourseTypes";
            this.courseTypesBindingSource.DataSource = this.staticDataSet;
            this.courseTypesBindingSource.CurrentChanged += new System.EventHandler(this.courseTypesBindingSource_CurrentChanged);
            this.courseTypesBindingSource.PositionChanged += new System.EventHandler(this.courseTypesBindingSource_PositionChanged);
            // 
            // staticDataSet
            // 
            this.staticDataSet.DataSetName = "StaticDataSet";
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
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // PreregisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreregister);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PreregisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "预报名";
            this.Load += new System.EventHandler(this.PreregisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preregisterDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsPreregBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtMotherWork;
        private System.Windows.Forms.TextBox txtFartherWork;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotherPhone;
        private System.Windows.Forms.TextBox txtFartherPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFartherName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreregister;
        private PreregisterDataset preregisterDataset;
        private System.Windows.Forms.BindingSource studentsPreregBindingSource;
        private PreregisterDatasetTableAdapters.studentsPreregTableAdapter studentsPreregTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lstCourseType;
        private System.Windows.Forms.ListBox lstCourseSubtypes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource courseTypesBindingSource;
        private StaticDataSetTableAdapters.CourseTypesTableAdapter courseTypesTableAdapter;
        private StaticDataSet staticDataSet;
        private CoursesDataSetTableAdapters.CourseSubtypesTableAdapter courseSubtypesTableAdapter;
        private System.Windows.Forms.BindingSource courseSubTypesBindingSource;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecommender;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentsDataSet studentsDataSet;
        private StudentsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}