namespace ShaoNianGong
{
    partial class StudentSigninManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new ShaoNianGong.StudentsDataSet();
            this.studentsTableAdapter = new ShaoNianGong.StudentsDataSetTableAdapters.StudentsTableAdapter();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnCoursesToday = new System.Windows.Forms.Button();
            this.btnSearchCourses = new System.Windows.Forms.Button();
            this.signInDataSet = new ShaoNianGong.SignInDataSet();
            this.studentSigninBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentSigninTableAdapter = new ShaoNianGong.SignInDataSetTableAdapters.StudentSigninTableAdapter();
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.coursesTodayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTodayTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CoursesTodayTableAdapter();
            this.txtSignInRes = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSigninCountWithDetail = new System.Windows.Forms.Label();
            this.txtShowRangeWithDetail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvStudentSignin = new System.Windows.Forms.DataGridView();
            this.studentsSigninBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchAllWithDetail = new System.Windows.Forms.Button();
            this.btnSearchByMonthWithDetail = new System.Windows.Forms.Button();
            this.btnSearchByDayWithDetail = new System.Windows.Forms.Button();
            this.btnSearchByDateWithDetail = new System.Windows.Forms.Button();
            this.dtEtimeWithDetail = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtStimeWithDetail = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentNameWithDetail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentsSigninTableAdapter = new ShaoNianGong.SignInDataSetTableAdapters.StudentsSigninTableAdapter();
            this.StudentSigninSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signinTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fartherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fartherTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fartherWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardTypeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignInStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCourseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherTelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherWorkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FartherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FartherTelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FartherWorkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signInDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSigninBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTodayBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSignin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsSigninBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCourses
            // 
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 12;
            this.lstCourses.Location = new System.Drawing.Point(9, 86);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(246, 208);
            this.lstCourses.TabIndex = 24;
            this.lstCourses.ValueMember = "ID";
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            this.lstCourses.ValueMemberChanged += new System.EventHandler(this.lstCourses_ValueMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(293, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "学生签到情况：";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentsDataSet;
            this.studentsBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.studentsBindingSource_BindingComplete);
            this.studentsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.studentsBindingSource_ListChanged);
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
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.CardTypeNameColumn,
            this.CardNoColumn,
            this.NameColumn,
            this.SignInStatusColumn,
            this.Balance,
            this.StudentCourseNameColumn,
            this.ExpireTime,
            this.PhoneColumn,
            this.TeacherNameColumn,
            this.SexColumn,
            this.StatusName,
            this.BirthdayColumn,
            this.MotherNameColumn,
            this.MotherTelColumn,
            this.MotherWorkColumn,
            this.FartherNameColumn,
            this.FartherTelColumn,
            this.FartherWorkColumn,
            this.AddressColumn});
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(292, 62);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 23;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(827, 250);
            this.dgvStudents.TabIndex = 26;
            this.dgvStudents.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStudents_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCourses);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.btnCoursesToday);
            this.groupBox1.Controls.Add(this.btnSearchCourses);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 304);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程列表过滤";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(9, 57);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker.TabIndex = 29;
            // 
            // btnCoursesToday
            // 
            this.btnCoursesToday.Location = new System.Drawing.Point(9, 19);
            this.btnCoursesToday.Name = "btnCoursesToday";
            this.btnCoursesToday.Size = new System.Drawing.Size(246, 31);
            this.btnCoursesToday.TabIndex = 28;
            this.btnCoursesToday.Text = "本日课程";
            this.btnCoursesToday.UseVisualStyleBackColor = true;
            this.btnCoursesToday.Click += new System.EventHandler(this.btnCoursesToday_Click);
            // 
            // btnSearchCourses
            // 
            this.btnSearchCourses.Location = new System.Drawing.Point(131, 54);
            this.btnSearchCourses.Name = "btnSearchCourses";
            this.btnSearchCourses.Size = new System.Drawing.Size(124, 26);
            this.btnSearchCourses.TabIndex = 28;
            this.btnSearchCourses.Text = "查询";
            this.btnSearchCourses.UseVisualStyleBackColor = true;
            this.btnSearchCourses.Click += new System.EventHandler(this.btnSearchCourses_Click);
            // 
            // signInDataSet
            // 
            this.signInDataSet.DataSetName = "SignInDataSet";
            this.signInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentSigninBindingSource
            // 
            this.studentSigninBindingSource.DataMember = "StudentSignin";
            this.studentSigninBindingSource.DataSource = this.signInDataSet;
            // 
            // studentSigninTableAdapter
            // 
            this.studentSigninTableAdapter.ClearBeforeFill = true;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTodayBindingSource
            // 
            this.coursesTodayBindingSource.DataMember = "CoursesToday";
            this.coursesTodayBindingSource.DataSource = this.coursesDataSet;
            this.coursesTodayBindingSource.PositionChanged += new System.EventHandler(this.coursesTodayBindingSource_PositionChanged);
            // 
            // coursesTodayTableAdapter
            // 
            this.coursesTodayTableAdapter.ClearBeforeFill = true;
            // 
            // txtSignInRes
            // 
            this.txtSignInRes.AutoSize = true;
            this.txtSignInRes.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSignInRes.Location = new System.Drawing.Point(439, 22);
            this.txtSignInRes.Name = "txtSignInRes";
            this.txtSignInRes.Size = new System.Drawing.Size(459, 19);
            this.txtSignInRes.TabIndex = 29;
            this.txtSignInRes.Text = "已签到【0】人，尚未签到【0】人，出勤率【0.00%】";
            this.txtSignInRes.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.dgvStudentSignin);
            this.groupBox2.Controls.Add(this.btnSearchAllWithDetail);
            this.groupBox2.Controls.Add(this.btnSearchByMonthWithDetail);
            this.groupBox2.Controls.Add(this.btnSearchByDayWithDetail);
            this.groupBox2.Controls.Add(this.btnSearchByDateWithDetail);
            this.groupBox2.Controls.Add(this.dtEtimeWithDetail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtStimeWithDetail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtStudentNameWithDetail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 248);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生签到明细";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSigninCountWithDetail);
            this.panel2.Controls.Add(this.txtShowRangeWithDetail);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(9, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 34);
            this.panel2.TabIndex = 69;
            // 
            // lblSigninCountWithDetail
            // 
            this.lblSigninCountWithDetail.AutoSize = true;
            this.lblSigninCountWithDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSigninCountWithDetail.Location = new System.Drawing.Point(600, 11);
            this.lblSigninCountWithDetail.Name = "lblSigninCountWithDetail";
            this.lblSigninCountWithDetail.Size = new System.Drawing.Size(25, 12);
            this.lblSigninCountWithDetail.TabIndex = 28;
            this.lblSigninCountWithDetail.Text = "0条";
            // 
            // txtShowRangeWithDetail
            // 
            this.txtShowRangeWithDetail.AutoSize = true;
            this.txtShowRangeWithDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShowRangeWithDetail.Location = new System.Drawing.Point(98, 11);
            this.txtShowRangeWithDetail.Name = "txtShowRangeWithDetail";
            this.txtShowRangeWithDetail.Size = new System.Drawing.Size(31, 12);
            this.txtShowRangeWithDetail.TabIndex = 29;
            this.txtShowRangeWithDetail.Text = "今天";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(481, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "签到明细记录总数：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "当前显示范围：";
            // 
            // dgvStudentSignin
            // 
            this.dgvStudentSignin.AllowUserToAddRows = false;
            this.dgvStudentSignin.AllowUserToDeleteRows = false;
            this.dgvStudentSignin.AllowUserToResizeRows = false;
            this.dgvStudentSignin.AutoGenerateColumns = false;
            this.dgvStudentSignin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentSignin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentSigninSeq,
            this.cardTypeNameDataGridViewTextBoxColumn,
            this.cardNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.signinTimeDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.expireTimeDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.motherNameDataGridViewTextBoxColumn,
            this.motherTelDataGridViewTextBoxColumn,
            this.motherWorkDataGridViewTextBoxColumn,
            this.fartherNameDataGridViewTextBoxColumn,
            this.fartherTelDataGridViewTextBoxColumn,
            this.fartherWorkDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvStudentSignin.DataSource = this.studentsSigninBindingSource;
            this.dgvStudentSignin.Location = new System.Drawing.Point(11, 46);
            this.dgvStudentSignin.MultiSelect = false;
            this.dgvStudentSignin.Name = "dgvStudentSignin";
            this.dgvStudentSignin.ReadOnly = true;
            this.dgvStudentSignin.RowHeadersVisible = false;
            this.dgvStudentSignin.RowTemplate.Height = 23;
            this.dgvStudentSignin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentSignin.Size = new System.Drawing.Size(1084, 160);
            this.dgvStudentSignin.TabIndex = 68;
            this.dgvStudentSignin.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStudentSignin_DataBindingComplete);
            // 
            // studentsSigninBindingSource
            // 
            this.studentsSigninBindingSource.DataMember = "StudentsSignin";
            this.studentsSigninBindingSource.DataSource = this.signInDataSet;
            this.studentsSigninBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.studentsSigninBindingSource_ListChanged);
            // 
            // btnSearchAllWithDetail
            // 
            this.btnSearchAllWithDetail.Location = new System.Drawing.Point(838, 18);
            this.btnSearchAllWithDetail.Name = "btnSearchAllWithDetail";
            this.btnSearchAllWithDetail.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAllWithDetail.TabIndex = 64;
            this.btnSearchAllWithDetail.Text = "查看所有";
            this.btnSearchAllWithDetail.UseVisualStyleBackColor = true;
            this.btnSearchAllWithDetail.Click += new System.EventHandler(this.btnSearchAllWithDetail_Click);
            // 
            // btnSearchByMonthWithDetail
            // 
            this.btnSearchByMonthWithDetail.Location = new System.Drawing.Point(757, 18);
            this.btnSearchByMonthWithDetail.Name = "btnSearchByMonthWithDetail";
            this.btnSearchByMonthWithDetail.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByMonthWithDetail.TabIndex = 63;
            this.btnSearchByMonthWithDetail.Text = "查看本月";
            this.btnSearchByMonthWithDetail.UseVisualStyleBackColor = true;
            this.btnSearchByMonthWithDetail.Click += new System.EventHandler(this.btnSearchByMonthWithDetail_Click);
            // 
            // btnSearchByDayWithDetail
            // 
            this.btnSearchByDayWithDetail.Location = new System.Drawing.Point(676, 18);
            this.btnSearchByDayWithDetail.Name = "btnSearchByDayWithDetail";
            this.btnSearchByDayWithDetail.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByDayWithDetail.TabIndex = 65;
            this.btnSearchByDayWithDetail.Text = "查看今天";
            this.btnSearchByDayWithDetail.UseVisualStyleBackColor = true;
            this.btnSearchByDayWithDetail.Click += new System.EventHandler(this.btnSearchByDayWithDetail_Click);
            // 
            // btnSearchByDateWithDetail
            // 
            this.btnSearchByDateWithDetail.Location = new System.Drawing.Point(595, 18);
            this.btnSearchByDateWithDetail.Name = "btnSearchByDateWithDetail";
            this.btnSearchByDateWithDetail.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByDateWithDetail.TabIndex = 67;
            this.btnSearchByDateWithDetail.Text = "筛选";
            this.btnSearchByDateWithDetail.UseVisualStyleBackColor = true;
            this.btnSearchByDateWithDetail.Click += new System.EventHandler(this.btnSearchByDateWithDetail_Click);
            // 
            // dtEtimeWithDetail
            // 
            this.dtEtimeWithDetail.CustomFormat = "";
            this.dtEtimeWithDetail.Location = new System.Drawing.Point(467, 20);
            this.dtEtimeWithDetail.Name = "dtEtimeWithDetail";
            this.dtEtimeWithDetail.Size = new System.Drawing.Size(119, 21);
            this.dtEtimeWithDetail.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 59;
            this.label8.Text = "结束日期：";
            // 
            // dtStimeWithDetail
            // 
            this.dtStimeWithDetail.CustomFormat = "";
            this.dtStimeWithDetail.Location = new System.Drawing.Point(267, 20);
            this.dtStimeWithDetail.Name = "dtStimeWithDetail";
            this.dtStimeWithDetail.Size = new System.Drawing.Size(119, 21);
            this.dtStimeWithDetail.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 60;
            this.label6.Text = "起始日期：";
            // 
            // txtStudentNameWithDetail
            // 
            this.txtStudentNameWithDetail.Location = new System.Drawing.Point(87, 20);
            this.txtStudentNameWithDetail.Name = "txtStudentNameWithDetail";
            this.txtStudentNameWithDetail.Size = new System.Drawing.Size(100, 21);
            this.txtStudentNameWithDetail.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 61;
            this.label5.Text = "学生姓名：";
            // 
            // studentsSigninTableAdapter
            // 
            this.studentsSigninTableAdapter.ClearBeforeFill = true;
            // 
            // StudentSigninSeq
            // 
            this.StudentSigninSeq.HeaderText = "序号";
            this.StudentSigninSeq.Name = "StudentSigninSeq";
            this.StudentSigninSeq.ReadOnly = true;
            // 
            // cardTypeNameDataGridViewTextBoxColumn
            // 
            this.cardTypeNameDataGridViewTextBoxColumn.DataPropertyName = "CardTypeName";
            this.cardTypeNameDataGridViewTextBoxColumn.HeaderText = "类型";
            this.cardTypeNameDataGridViewTextBoxColumn.Name = "cardTypeNameDataGridViewTextBoxColumn";
            this.cardTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardNoDataGridViewTextBoxColumn
            // 
            this.cardNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo";
            this.cardNoDataGridViewTextBoxColumn.HeaderText = "卡号";
            this.cardNoDataGridViewTextBoxColumn.Name = "cardNoDataGridViewTextBoxColumn";
            this.cardNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // signinTimeDataGridViewTextBoxColumn
            // 
            this.signinTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.signinTimeDataGridViewTextBoxColumn.DataPropertyName = "SigninTime";
            dataGridViewCellStyle3.Format = "F";
            dataGridViewCellStyle3.NullValue = null;
            this.signinTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.signinTimeDataGridViewTextBoxColumn.HeaderText = "签到时间";
            this.signinTimeDataGridViewTextBoxColumn.Name = "signinTimeDataGridViewTextBoxColumn";
            this.signinTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.signinTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.balanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "余额";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "所报课程";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // expireTimeDataGridViewTextBoxColumn
            // 
            this.expireTimeDataGridViewTextBoxColumn.DataPropertyName = "ExpireTime";
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.expireTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.expireTimeDataGridViewTextBoxColumn.HeaderText = "缴费到期时间";
            this.expireTimeDataGridViewTextBoxColumn.Name = "expireTimeDataGridViewTextBoxColumn";
            this.expireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "teacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "任课教师";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            this.statusNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "生日";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motherNameDataGridViewTextBoxColumn
            // 
            this.motherNameDataGridViewTextBoxColumn.DataPropertyName = "MotherName";
            this.motherNameDataGridViewTextBoxColumn.HeaderText = "母亲姓名";
            this.motherNameDataGridViewTextBoxColumn.Name = "motherNameDataGridViewTextBoxColumn";
            this.motherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motherTelDataGridViewTextBoxColumn
            // 
            this.motherTelDataGridViewTextBoxColumn.DataPropertyName = "MotherTel";
            this.motherTelDataGridViewTextBoxColumn.HeaderText = "母亲电话";
            this.motherTelDataGridViewTextBoxColumn.Name = "motherTelDataGridViewTextBoxColumn";
            this.motherTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motherWorkDataGridViewTextBoxColumn
            // 
            this.motherWorkDataGridViewTextBoxColumn.DataPropertyName = "MotherWork";
            this.motherWorkDataGridViewTextBoxColumn.HeaderText = "母亲工作单位";
            this.motherWorkDataGridViewTextBoxColumn.Name = "motherWorkDataGridViewTextBoxColumn";
            this.motherWorkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fartherNameDataGridViewTextBoxColumn
            // 
            this.fartherNameDataGridViewTextBoxColumn.DataPropertyName = "FartherName";
            this.fartherNameDataGridViewTextBoxColumn.HeaderText = "父亲姓名";
            this.fartherNameDataGridViewTextBoxColumn.Name = "fartherNameDataGridViewTextBoxColumn";
            this.fartherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fartherTelDataGridViewTextBoxColumn
            // 
            this.fartherTelDataGridViewTextBoxColumn.DataPropertyName = "FartherTel";
            this.fartherTelDataGridViewTextBoxColumn.HeaderText = "父亲电话";
            this.fartherTelDataGridViewTextBoxColumn.Name = "fartherTelDataGridViewTextBoxColumn";
            this.fartherTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fartherWorkDataGridViewTextBoxColumn
            // 
            this.fartherWorkDataGridViewTextBoxColumn.DataPropertyName = "FartherWork";
            this.fartherWorkDataGridViewTextBoxColumn.HeaderText = "父亲工作单位";
            this.fartherWorkDataGridViewTextBoxColumn.Name = "fartherWorkDataGridViewTextBoxColumn";
            this.fartherWorkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // CardTypeNameColumn
            // 
            this.CardTypeNameColumn.DataPropertyName = "CardTypeName";
            this.CardTypeNameColumn.HeaderText = "类型";
            this.CardTypeNameColumn.Name = "CardTypeNameColumn";
            this.CardTypeNameColumn.ReadOnly = true;
            this.CardTypeNameColumn.Width = 54;
            // 
            // CardNoColumn
            // 
            this.CardNoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CardNoColumn.DataPropertyName = "CardNo";
            this.CardNoColumn.HeaderText = "卡号";
            this.CardNoColumn.Name = "CardNoColumn";
            this.CardNoColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "姓名";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 54;
            // 
            // SignInStatusColumn
            // 
            this.SignInStatusColumn.HeaderText = "签到状态";
            this.SignInStatusColumn.Name = "SignInStatusColumn";
            this.SignInStatusColumn.ReadOnly = true;
            this.SignInStatusColumn.Width = 78;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "余额";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 54;
            // 
            // StudentCourseNameColumn
            // 
            this.StudentCourseNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StudentCourseNameColumn.DataPropertyName = "CourseName";
            this.StudentCourseNameColumn.HeaderText = "所报课程";
            this.StudentCourseNameColumn.Name = "StudentCourseNameColumn";
            this.StudentCourseNameColumn.ReadOnly = true;
            this.StudentCourseNameColumn.Width = 150;
            // 
            // ExpireTime
            // 
            this.ExpireTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExpireTime.DataPropertyName = "ExpireTime";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.ExpireTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.ExpireTime.HeaderText = "缴费到期时间";
            this.ExpireTime.Name = "ExpireTime";
            this.ExpireTime.ReadOnly = true;
            this.ExpireTime.Width = 120;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhoneColumn.DataPropertyName = "Telephone";
            this.PhoneColumn.HeaderText = "电话";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.DataPropertyName = "teacherName";
            this.TeacherNameColumn.HeaderText = "任课教师";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.ReadOnly = true;
            this.TeacherNameColumn.Width = 61;
            // 
            // SexColumn
            // 
            this.SexColumn.DataPropertyName = "Sex";
            this.SexColumn.HeaderText = "性别";
            this.SexColumn.Name = "SexColumn";
            this.SexColumn.ReadOnly = true;
            this.SexColumn.Width = 51;
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "状态";
            this.StatusName.Name = "StatusName";
            this.StatusName.ReadOnly = true;
            this.StatusName.Width = 54;
            // 
            // BirthdayColumn
            // 
            this.BirthdayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BirthdayColumn.DataPropertyName = "Birthday";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.BirthdayColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.BirthdayColumn.HeaderText = "生日";
            this.BirthdayColumn.Name = "BirthdayColumn";
            this.BirthdayColumn.ReadOnly = true;
            this.BirthdayColumn.Width = 120;
            // 
            // MotherNameColumn
            // 
            this.MotherNameColumn.DataPropertyName = "MotherName";
            this.MotherNameColumn.HeaderText = "母亲姓名";
            this.MotherNameColumn.Name = "MotherNameColumn";
            this.MotherNameColumn.ReadOnly = true;
            this.MotherNameColumn.Width = 61;
            // 
            // MotherTelColumn
            // 
            this.MotherTelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MotherTelColumn.DataPropertyName = "MotherTel";
            this.MotherTelColumn.HeaderText = "母亲电话";
            this.MotherTelColumn.Name = "MotherTelColumn";
            this.MotherTelColumn.ReadOnly = true;
            // 
            // MotherWorkColumn
            // 
            this.MotherWorkColumn.DataPropertyName = "MotherWork";
            this.MotherWorkColumn.HeaderText = "母亲工作单位";
            this.MotherWorkColumn.Name = "MotherWorkColumn";
            this.MotherWorkColumn.ReadOnly = true;
            this.MotherWorkColumn.Width = 72;
            // 
            // FartherNameColumn
            // 
            this.FartherNameColumn.DataPropertyName = "FartherName";
            this.FartherNameColumn.HeaderText = "父亲姓名";
            this.FartherNameColumn.Name = "FartherNameColumn";
            this.FartherNameColumn.ReadOnly = true;
            this.FartherNameColumn.Width = 61;
            // 
            // FartherTelColumn
            // 
            this.FartherTelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FartherTelColumn.DataPropertyName = "FartherTel";
            this.FartherTelColumn.HeaderText = "父亲电话";
            this.FartherTelColumn.Name = "FartherTelColumn";
            this.FartherTelColumn.ReadOnly = true;
            // 
            // FartherWorkColumn
            // 
            this.FartherWorkColumn.DataPropertyName = "FartherWork";
            this.FartherWorkColumn.HeaderText = "父亲工作单位";
            this.FartherWorkColumn.Name = "FartherWorkColumn";
            this.FartherWorkColumn.ReadOnly = true;
            this.FartherWorkColumn.Width = 72;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "Address";
            this.AddressColumn.HeaderText = "地址";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            this.AddressColumn.Width = 51;
            // 
            // StudentSigninManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSignInRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label1);
            this.Name = "StudentSigninManageForm";
            this.Text = "本日学生签到汇总";
            this.Load += new System.EventHandler(this.StudentSigninForm_Load);
            this.Resize += new System.EventHandler(this.StudentSigninManageForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signInDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSigninBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTodayBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSignin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsSigninBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourses;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource coursesTodayBindingSource;
        private CoursesDataSetTableAdapters.CoursesTodayTableAdapter coursesTodayTableAdapter;
        private System.Windows.Forms.Label label1;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnCoursesToday;
        private System.Windows.Forms.Button btnSearchCourses;
        private SignInDataSet signInDataSet;
        private System.Windows.Forms.BindingSource studentSigninBindingSource;
        private SignInDataSetTableAdapters.StudentSigninTableAdapter studentSigninTableAdapter;
        private System.Windows.Forms.Label txtSignInRes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchAllWithDetail;
        private System.Windows.Forms.Button btnSearchByMonthWithDetail;
        private System.Windows.Forms.Button btnSearchByDayWithDetail;
        private System.Windows.Forms.Button btnSearchByDateWithDetail;
        private System.Windows.Forms.DateTimePicker dtEtimeWithDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtStimeWithDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentNameWithDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvStudentSignin;
        private System.Windows.Forms.BindingSource studentsSigninBindingSource;
        private SignInDataSetTableAdapters.StudentsSigninTableAdapter studentsSigninTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSigninCountWithDetail;
        private System.Windows.Forms.Label txtShowRangeWithDetail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSigninSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signinTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fartherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fartherTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fartherWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardTypeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignInStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCourseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherTelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherWorkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FartherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FartherTelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FartherWorkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
    }
}