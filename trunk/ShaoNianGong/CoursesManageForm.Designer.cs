namespace ShaoNianGong
{
    partial class CoursesManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.courseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staticDataSet = new ShaoNianGong.StaticDataSet();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdVwCourseTime = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroomNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddCourseTime = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseTimeID = new System.Windows.Forms.Label();
            this.btnRemoveCourseTime = new System.Windows.Forms.Button();
            this.courseTypesTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.CourseTypesTableAdapter();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayOfWeekTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.DayOfWeekTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCourseSubtypes = new System.Windows.Forms.ListBox();
            this.courseSubTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstCourseType = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelCourseSubtype = new System.Windows.Forms.Button();
            this.btnUpdateCourseSubtype = new System.Windows.Forms.Button();
            this.btnDelCourseType = new System.Windows.Forms.Button();
            this.btnUpdateCourseType = new System.Windows.Forms.Button();
            this.btnAddCourseType = new System.Windows.Forms.Button();
            this.btnAddCourseSubtype = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChangeTeacher = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.tearchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersDataSet = new ShaoNianGong.TeachersDataSet();
            this.cmbChargeMethod = new System.Windows.Forms.ComboBox();
            this.chargeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chargeTypeTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.ChargeTypeTableAdapter();
            this.coursesTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CoursesTableAdapter();
            this.classroomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classroomsTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.ClassroomsTableAdapter();
            this.courseTimeTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CourseTimeTableAdapter();
            this.courseSubtypesTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CourseSubtypesTableAdapter();
            this.tearchersTableAdapter = new ShaoNianGong.TeachersDataSetTableAdapters.TearchersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwCourseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTimeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubTypesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tearchersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // courseTypesBindingSource
            // 
            this.courseTypesBindingSource.DataMember = "CourseTypes";
            this.courseTypesBindingSource.DataSource = this.staticDataSet;
            this.courseTypesBindingSource.PositionChanged += new System.EventHandler(this.courseTypesBindingSource_PositionChanged);
            // 
            // staticDataSet
            // 
            this.staticDataSet.DataSetName = "StaticDataSet";
            this.staticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCourseName
            // 
            this.txtCourseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseName", true));
            this.txtCourseName.Location = new System.Drawing.Point(122, 30);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(359, 21);
            this.txtCourseName.TabIndex = 0;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.coursesDataSet;
            this.coursesBindingSource.PositionChanged += new System.EventHandler(this.coursesBindingSource_PositionChanged);
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "课程名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类别选择：";
            // 
            // grdVwCourseTime
            // 
            this.grdVwCourseTime.AllowUserToAddRows = false;
            this.grdVwCourseTime.AllowUserToDeleteRows = false;
            this.grdVwCourseTime.AutoGenerateColumns = false;
            this.grdVwCourseTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwCourseTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.columnDayOfWeek,
            this.beginTimeColumn,
            this.endTimeDataGridViewTextBoxColumn1,
            this.classroomNameColumn});
            this.grdVwCourseTime.DataSource = this.courseTimeBindingSource;
            this.grdVwCourseTime.Location = new System.Drawing.Point(20, 28);
            this.grdVwCourseTime.Name = "grdVwCourseTime";
            this.grdVwCourseTime.ReadOnly = true;
            this.grdVwCourseTime.RowHeadersVisible = false;
            this.grdVwCourseTime.RowTemplate.Height = 23;
            this.grdVwCourseTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwCourseTime.Size = new System.Drawing.Size(520, 347);
            this.grdVwCourseTime.TabIndex = 17;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "课时ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // columnDayOfWeek
            // 
            this.columnDayOfWeek.DataPropertyName = "DayOfWeekName";
            dataGridViewCellStyle10.NullValue = null;
            this.columnDayOfWeek.DefaultCellStyle = dataGridViewCellStyle10;
            this.columnDayOfWeek.HeaderText = "上课日期";
            this.columnDayOfWeek.Name = "columnDayOfWeek";
            this.columnDayOfWeek.ReadOnly = true;
            this.columnDayOfWeek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // beginTimeColumn
            // 
            this.beginTimeColumn.DataPropertyName = "BeginTime";
            dataGridViewCellStyle11.Format = "t";
            this.beginTimeColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.beginTimeColumn.HeaderText = "开课时间";
            this.beginTimeColumn.Name = "beginTimeColumn";
            this.beginTimeColumn.ReadOnly = true;
            this.beginTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // endTimeDataGridViewTextBoxColumn1
            // 
            this.endTimeDataGridViewTextBoxColumn1.DataPropertyName = "EndTime";
            dataGridViewCellStyle12.Format = "t";
            dataGridViewCellStyle12.NullValue = null;
            this.endTimeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.endTimeDataGridViewTextBoxColumn1.HeaderText = "下课时间";
            this.endTimeDataGridViewTextBoxColumn1.Name = "endTimeDataGridViewTextBoxColumn1";
            this.endTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // classroomNameColumn
            // 
            this.classroomNameColumn.DataPropertyName = "ClassroomName";
            this.classroomNameColumn.HeaderText = "上课教室";
            this.classroomNameColumn.Name = "classroomNameColumn";
            this.classroomNameColumn.ReadOnly = true;
            this.classroomNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // courseTimeBindingSource
            // 
            this.courseTimeBindingSource.DataMember = "CourseTime";
            this.courseTimeBindingSource.DataSource = this.coursesDataSet;
            this.courseTimeBindingSource.Sort = "DayOfWeek, BeginTime";
            this.courseTimeBindingSource.PositionChanged += new System.EventHandler(this.courseTimeBindingSource_PositionChanged);
            // 
            // btnAddCourseTime
            // 
            this.btnAddCourseTime.Location = new System.Drawing.Point(375, 387);
            this.btnAddCourseTime.Name = "btnAddCourseTime";
            this.btnAddCourseTime.Size = new System.Drawing.Size(75, 35);
            this.btnAddCourseTime.TabIndex = 18;
            this.btnAddCourseTime.Text = "添加课时";
            this.btnAddCourseTime.UseVisualStyleBackColor = true;
            this.btnAddCourseTime.Click += new System.EventHandler(this.btnAddCourseTime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCourseID);
            this.groupBox1.Controls.Add(this.lblCourseTimeID);
            this.groupBox1.Controls.Add(this.btnRemoveCourseTime);
            this.groupBox1.Controls.Add(this.btnAddCourseTime);
            this.groupBox1.Controls.Add(this.grdVwCourseTime);
            this.groupBox1.Location = new System.Drawing.Point(608, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 438);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "上课时间";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseID", true));
            this.lblCourseID.Location = new System.Drawing.Point(-500, 17);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(53, 12);
            this.lblCourseID.TabIndex = 19;
            this.lblCourseID.Text = "CourseID";
            // 
            // lblCourseTimeID
            // 
            this.lblCourseTimeID.AutoSize = true;
            this.lblCourseTimeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseTimeBindingSource, "ID", true));
            this.lblCourseTimeID.Location = new System.Drawing.Point(-500, 17);
            this.lblCourseTimeID.Name = "lblCourseTimeID";
            this.lblCourseTimeID.Size = new System.Drawing.Size(77, 12);
            this.lblCourseTimeID.TabIndex = 19;
            this.lblCourseTimeID.Text = "CourseTimeID";
            // 
            // btnRemoveCourseTime
            // 
            this.btnRemoveCourseTime.Location = new System.Drawing.Point(465, 387);
            this.btnRemoveCourseTime.Name = "btnRemoveCourseTime";
            this.btnRemoveCourseTime.Size = new System.Drawing.Size(75, 35);
            this.btnRemoveCourseTime.TabIndex = 18;
            this.btnRemoveCourseTime.Text = "删除课时";
            this.btnRemoveCourseTime.UseVisualStyleBackColor = true;
            this.btnRemoveCourseTime.Click += new System.EventHandler(this.btnRemoveCourseTime_Click);
            // 
            // courseTypesTableAdapter
            // 
            this.courseTypesTableAdapter.ClearBeforeFill = true;
            // 
            // lstCourses
            // 
            this.lstCourses.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "CourseID", true));
            this.lstCourses.DataSource = this.coursesBindingSource;
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 12;
            this.lstCourses.Location = new System.Drawing.Point(17, 57);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(237, 496);
            this.lstCourses.TabIndex = 22;
            this.lstCourses.ValueMember = "CourseID";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // classroomIDDataGridViewTextBoxColumn
            // 
            this.classroomIDDataGridViewTextBoxColumn.DataPropertyName = "ClassroomID";
            this.classroomIDDataGridViewTextBoxColumn.HeaderText = "ClassroomID";
            this.classroomIDDataGridViewTextBoxColumn.Name = "classroomIDDataGridViewTextBoxColumn";
            // 
            // dayOfWeekDataGridViewTextBoxColumn
            // 
            this.dayOfWeekDataGridViewTextBoxColumn.DataPropertyName = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.HeaderText = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.Name = "dayOfWeekDataGridViewTextBoxColumn";
            // 
            // beginTimeDataGridViewTextBoxColumn
            // 
            this.beginTimeDataGridViewTextBoxColumn.DataPropertyName = "BeginTime";
            this.beginTimeDataGridViewTextBoxColumn.HeaderText = "BeginTime";
            this.beginTimeDataGridViewTextBoxColumn.Name = "beginTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // dayOfWeekBindingSource
            // 
            this.dayOfWeekBindingSource.DataMember = "DayOfWeek";
            this.dayOfWeekBindingSource.DataSource = this.staticDataSet;
            // 
            // dayOfWeekTableAdapter
            // 
            this.dayOfWeekTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "科目选择：";
            // 
            // lstCourseSubtypes
            // 
            this.lstCourseSubtypes.DataSource = this.courseSubTypesBindingSource;
            this.lstCourseSubtypes.DisplayMember = "CourseSubtypeName";
            this.lstCourseSubtypes.FormattingEnabled = true;
            this.lstCourseSubtypes.ItemHeight = 12;
            this.lstCourseSubtypes.Location = new System.Drawing.Point(23, 301);
            this.lstCourseSubtypes.Name = "lstCourseSubtypes";
            this.lstCourseSubtypes.Size = new System.Drawing.Size(269, 256);
            this.lstCourseSubtypes.TabIndex = 22;
            this.lstCourseSubtypes.ValueMember = "ID";
            // 
            // courseSubTypesBindingSource
            // 
            this.courseSubTypesBindingSource.DataMember = "CourseSubtypes";
            this.courseSubTypesBindingSource.DataSource = this.coursesDataSet;
            this.courseSubTypesBindingSource.PositionChanged += new System.EventHandler(this.courseSubTypesBindingSource_PositionChanged);
            // 
            // lstCourseType
            // 
            this.lstCourseType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courseSubTypesBindingSource, "CourseTypeID", true));
            this.lstCourseType.FormattingEnabled = true;
            this.lstCourseType.ItemHeight = 12;
            this.lstCourseType.Location = new System.Drawing.Point(23, 57);
            this.lstCourseType.Name = "lstCourseType";
            this.lstCourseType.Size = new System.Drawing.Size(270, 172);
            this.lstCourseType.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelCourseSubtype);
            this.groupBox3.Controls.Add(this.btnUpdateCourseSubtype);
            this.groupBox3.Controls.Add(this.btnDelCourseType);
            this.groupBox3.Controls.Add(this.btnUpdateCourseType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnAddCourseType);
            this.groupBox3.Controls.Add(this.btnAddCourseSubtype);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lstCourseType);
            this.groupBox3.Controls.Add(this.lstCourseSubtypes);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 613);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择分类";
            // 
            // btnDelCourseSubtype
            // 
            this.btnDelCourseSubtype.Location = new System.Drawing.Point(226, 570);
            this.btnDelCourseSubtype.Name = "btnDelCourseSubtype";
            this.btnDelCourseSubtype.Size = new System.Drawing.Size(67, 23);
            this.btnDelCourseSubtype.TabIndex = 26;
            this.btnDelCourseSubtype.Text = "删除";
            this.btnDelCourseSubtype.UseVisualStyleBackColor = true;
            this.btnDelCourseSubtype.Click += new System.EventHandler(this.btnDelCourseSubtype_Click);
            // 
            // btnUpdateCourseSubtype
            // 
            this.btnUpdateCourseSubtype.Location = new System.Drawing.Point(150, 570);
            this.btnUpdateCourseSubtype.Name = "btnUpdateCourseSubtype";
            this.btnUpdateCourseSubtype.Size = new System.Drawing.Size(67, 23);
            this.btnUpdateCourseSubtype.TabIndex = 25;
            this.btnUpdateCourseSubtype.Text = "修改";
            this.btnUpdateCourseSubtype.UseVisualStyleBackColor = true;
            this.btnUpdateCourseSubtype.Click += new System.EventHandler(this.btnUpdateCourseSubtype_Click);
            // 
            // btnDelCourseType
            // 
            this.btnDelCourseType.Location = new System.Drawing.Point(225, 241);
            this.btnDelCourseType.Name = "btnDelCourseType";
            this.btnDelCourseType.Size = new System.Drawing.Size(67, 23);
            this.btnDelCourseType.TabIndex = 24;
            this.btnDelCourseType.Text = "删除";
            this.btnDelCourseType.UseVisualStyleBackColor = true;
            this.btnDelCourseType.Click += new System.EventHandler(this.btnDelCourseType_Click);
            // 
            // btnUpdateCourseType
            // 
            this.btnUpdateCourseType.Location = new System.Drawing.Point(150, 241);
            this.btnUpdateCourseType.Name = "btnUpdateCourseType";
            this.btnUpdateCourseType.Size = new System.Drawing.Size(67, 23);
            this.btnUpdateCourseType.TabIndex = 23;
            this.btnUpdateCourseType.Text = "修改";
            this.btnUpdateCourseType.UseVisualStyleBackColor = true;
            this.btnUpdateCourseType.Click += new System.EventHandler(this.btnUpdateCourseType_Click);
            // 
            // btnAddCourseType
            // 
            this.btnAddCourseType.Location = new System.Drawing.Point(77, 241);
            this.btnAddCourseType.Name = "btnAddCourseType";
            this.btnAddCourseType.Size = new System.Drawing.Size(67, 23);
            this.btnAddCourseType.TabIndex = 18;
            this.btnAddCourseType.Text = "添加";
            this.btnAddCourseType.UseVisualStyleBackColor = true;
            this.btnAddCourseType.Click += new System.EventHandler(this.btnAddCourseType_Click);
            // 
            // btnAddCourseSubtype
            // 
            this.btnAddCourseSubtype.Location = new System.Drawing.Point(77, 570);
            this.btnAddCourseSubtype.Name = "btnAddCourseSubtype";
            this.btnAddCourseSubtype.Size = new System.Drawing.Size(67, 23);
            this.btnAddCourseSubtype.TabIndex = 18;
            this.btnAddCourseSubtype.Text = "添加";
            this.btnAddCourseSubtype.UseVisualStyleBackColor = true;
            this.btnAddCourseSubtype.Click += new System.EventHandler(this.btnAddCourseSubtype_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelCourse);
            this.groupBox4.Controls.Add(this.btnUpdateCourse);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lstCourses);
            this.groupBox4.Controls.Add(this.btnAddCourse);
            this.groupBox4.Location = new System.Drawing.Point(333, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 613);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "课程选择";
            // 
            // btnDelCourse
            // 
            this.btnDelCourse.Location = new System.Drawing.Point(187, 568);
            this.btnDelCourse.Name = "btnDelCourse";
            this.btnDelCourse.Size = new System.Drawing.Size(67, 23);
            this.btnDelCourse.TabIndex = 24;
            this.btnDelCourse.Text = "删除";
            this.btnDelCourse.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(114, 568);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(67, 23);
            this.btnUpdateCourse.TabIndex = 23;
            this.btnUpdateCourse.Text = "修改";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "课程列表：";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(41, 568);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(67, 23);
            this.btnAddCourse.TabIndex = 18;
            this.btnAddCourse.Text = "添加";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtCourseName);
            this.groupBox5.Controls.Add(this.btnChangeTeacher);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cmbTeacher);
            this.groupBox5.Controls.Add(this.cmbChargeMethod);
            this.groupBox5.Controls.Add(this.txtChargeAmount);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(608, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(559, 165);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "课程信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "元";
            // 
            // btnChangeTeacher
            // 
            this.btnChangeTeacher.Location = new System.Drawing.Point(366, 103);
            this.btnChangeTeacher.Name = "btnChangeTeacher";
            this.btnChangeTeacher.Size = new System.Drawing.Size(115, 35);
            this.btnChangeTeacher.TabIndex = 18;
            this.btnChangeTeacher.Text = "修改老师";
            this.btnChangeTeacher.UseVisualStyleBackColor = true;
            this.btnChangeTeacher.Click += new System.EventHandler(this.btnChangeTeacher_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "收取费用：";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "TeacherID", true));
            this.cmbTeacher.DataSource = this.tearchersBindingSource;
            this.cmbTeacher.DisplayMember = "Name";
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.Enabled = false;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(122, 111);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(115, 20);
            this.cmbTeacher.TabIndex = 19;
            this.cmbTeacher.ValueMember = "ID";
            // 
            // tearchersBindingSource
            // 
            this.tearchersBindingSource.DataMember = "Tearchers";
            this.tearchersBindingSource.DataSource = this.teachersDataSet;
            // 
            // teachersDataSet
            // 
            this.teachersDataSet.DataSetName = "TeachersDataSet";
            this.teachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbChargeMethod
            // 
            this.cmbChargeMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "ChargeType", true));
            this.cmbChargeMethod.DataSource = this.chargeTypeBindingSource;
            this.cmbChargeMethod.DisplayMember = "ChargeTypeName";
            this.cmbChargeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChargeMethod.Enabled = false;
            this.cmbChargeMethod.FormattingEnabled = true;
            this.cmbChargeMethod.Location = new System.Drawing.Point(122, 73);
            this.cmbChargeMethod.Name = "cmbChargeMethod";
            this.cmbChargeMethod.Size = new System.Drawing.Size(115, 20);
            this.cmbChargeMethod.TabIndex = 19;
            this.cmbChargeMethod.ValueMember = "ChargeTypeID";
            // 
            // chargeTypeBindingSource
            // 
            this.chargeTypeBindingSource.DataMember = "ChargeType";
            this.chargeTypeBindingSource.DataSource = this.staticDataSet;
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "ChargeAmount", true));
            this.txtChargeAmount.Location = new System.Drawing.Point(366, 72);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.ReadOnly = true;
            this.txtChargeAmount.Size = new System.Drawing.Size(94, 21);
            this.txtChargeAmount.TabIndex = 0;
            this.txtChargeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "任课教师：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "收费方式：";
            // 
            // chargeTypeTableAdapter
            // 
            this.chargeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // classroomsBindingSource
            // 
            this.classroomsBindingSource.DataMember = "Classrooms";
            this.classroomsBindingSource.DataSource = this.coursesDataSet;
            // 
            // classroomsTableAdapter
            // 
            this.classroomsTableAdapter.ClearBeforeFill = true;
            // 
            // courseTimeTableAdapter
            // 
            this.courseTimeTableAdapter.ClearBeforeFill = true;
            // 
            // courseSubtypesTableAdapter
            // 
            this.courseSubtypesTableAdapter.ClearBeforeFill = true;
            // 
            // tearchersTableAdapter
            // 
            this.tearchersTableAdapter.ClearBeforeFill = true;
            // 
            // CoursesManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 637);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "CoursesManageForm";
            this.Text = "课程管理";
            this.Load += new System.EventHandler(this.CoursesManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwCourseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTimeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubTypesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tearchersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CoursesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdVwCourseTime;
        private System.Windows.Forms.Button btnAddCourseTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private StaticDataSetTableAdapters.CourseTypesTableAdapter courseTypesTableAdapter;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.BindingSource courseTypesBindingSource;
        private System.Windows.Forms.BindingSource classroomsBindingSource;
        private CoursesDataSetTableAdapters.ClassroomsTableAdapter classroomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCourseTimeID;
        private System.Windows.Forms.Label lblCourseID;
        private StaticDataSet staticDataSet;
        private System.Windows.Forms.BindingSource dayOfWeekBindingSource;
        private StaticDataSetTableAdapters.DayOfWeekTableAdapter dayOfWeekTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource courseTimeBindingSource;
        private CoursesDataSetTableAdapters.CourseTimeTableAdapter courseTimeTableAdapter;
        private System.Windows.Forms.ListBox lstCourseSubtypes;
        private System.Windows.Forms.BindingSource courseSubTypesBindingSource;
        private CoursesDataSetTableAdapters.CourseSubtypesTableAdapter courseSubtypesTableAdapter;
        private System.Windows.Forms.ListBox lstCourseType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbChargeMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.BindingSource chargeTypeBindingSource;
        private StaticDataSetTableAdapters.ChargeTypeTableAdapter chargeTypeTableAdapter;
        private System.Windows.Forms.Button btnAddCourseType;
        private System.Windows.Forms.Button btnAddCourseSubtype;
        private System.Windows.Forms.Button btnRemoveCourseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroomNameColumn;
        private System.Windows.Forms.Button btnChangeTeacher;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label2;
        private TeachersDataSet teachersDataSet;
        private System.Windows.Forms.BindingSource tearchersBindingSource;
        private TeachersDataSetTableAdapters.TearchersTableAdapter tearchersTableAdapter;
        private System.Windows.Forms.Button btnDelCourseType;
        private System.Windows.Forms.Button btnUpdateCourseType;
        private System.Windows.Forms.Button btnDelCourseSubtype;
        private System.Windows.Forms.Button btnUpdateCourseSubtype;
        private System.Windows.Forms.Button btnDelCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
    }
}