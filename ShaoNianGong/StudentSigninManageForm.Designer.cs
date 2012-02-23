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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "课程列表：";
            // 
            // lstCourses
            // 
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 12;
            this.lstCourses.Location = new System.Drawing.Point(12, 156);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(262, 400);
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
            this.dgvStudents.Location = new System.Drawing.Point(292, 66);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 23;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(827, 490);
            this.dgvStudents.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.btnCoursesToday);
            this.groupBox1.Controls.Add(this.btnSearchCourses);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 94);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程列表过滤";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(15, 59);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker.TabIndex = 29;
            // 
            // btnCoursesToday
            // 
            this.btnCoursesToday.Location = new System.Drawing.Point(15, 20);
            this.btnCoursesToday.Name = "btnCoursesToday";
            this.btnCoursesToday.Size = new System.Drawing.Size(229, 31);
            this.btnCoursesToday.TabIndex = 28;
            this.btnCoursesToday.Text = "本日课程";
            this.btnCoursesToday.UseVisualStyleBackColor = true;
            this.btnCoursesToday.Click += new System.EventHandler(this.btnCoursesToday_Click);
            // 
            // btnSearchCourses
            // 
            this.btnSearchCourses.Location = new System.Drawing.Point(168, 54);
            this.btnSearchCourses.Name = "btnSearchCourses";
            this.btnSearchCourses.Size = new System.Drawing.Size(76, 31);
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
            this.CardNoColumn.DataPropertyName = "CardNo";
            this.CardNoColumn.HeaderText = "卡号";
            this.CardNoColumn.Name = "CardNoColumn";
            this.CardNoColumn.ReadOnly = true;
            this.CardNoColumn.Width = 54;
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
            this.StudentCourseNameColumn.DataPropertyName = "CourseName";
            this.StudentCourseNameColumn.HeaderText = "所报课程";
            this.StudentCourseNameColumn.Name = "StudentCourseNameColumn";
            this.StudentCourseNameColumn.ReadOnly = true;
            this.StudentCourseNameColumn.Width = 78;
            // 
            // ExpireTime
            // 
            this.ExpireTime.DataPropertyName = "ExpireTime";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.ExpireTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.ExpireTime.HeaderText = "缴费到期时间";
            this.ExpireTime.Name = "ExpireTime";
            this.ExpireTime.ReadOnly = true;
            this.ExpireTime.Width = 72;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.DataPropertyName = "Telephone";
            this.PhoneColumn.HeaderText = "电话";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            this.PhoneColumn.Width = 51;
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
            this.BirthdayColumn.DataPropertyName = "Birthday";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.BirthdayColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.BirthdayColumn.HeaderText = "生日";
            this.BirthdayColumn.Name = "BirthdayColumn";
            this.BirthdayColumn.ReadOnly = true;
            this.BirthdayColumn.Width = 51;
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
            this.MotherTelColumn.DataPropertyName = "MotherTel";
            this.MotherTelColumn.HeaderText = "母亲电话";
            this.MotherTelColumn.Name = "MotherTelColumn";
            this.MotherTelColumn.ReadOnly = true;
            this.MotherTelColumn.Width = 61;
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
            this.FartherTelColumn.DataPropertyName = "FartherTel";
            this.FartherTelColumn.HeaderText = "父亲电话";
            this.FartherTelColumn.Name = "FartherTelColumn";
            this.FartherTelColumn.ReadOnly = true;
            this.FartherTelColumn.Width = 61;
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
            this.Controls.Add(this.txtSignInRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCourses);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
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