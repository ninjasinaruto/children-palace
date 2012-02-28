namespace ShaoNianGong
{
    partial class ClassroomManageForm
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
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.classroomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.classroomsTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.ClassroomsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dayOfWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staticDataSet = new ShaoNianGong.StaticDataSet();
            this.dayOfWeekTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.DayOfWeekTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCourseOfClassroom = new System.Windows.Forms.DataGridView();
            this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesOfClassroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesOfClassroomTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CoursesOfClassroomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseOfClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesOfClassroomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classroomsBindingSource
            // 
            this.classroomsBindingSource.DataMember = "Classrooms";
            this.classroomsBindingSource.DataSource = this.coursesDataSet;
            this.classroomsBindingSource.PositionChanged += new System.EventHandler(this.classroomsBindingSource_PositionChanged);
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classroomsBindingSource, "ClassroomID", true));
            this.listBox1.DataSource = this.classroomsBindingSource;
            this.listBox1.DisplayMember = "ClassroomName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(11, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 280);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "ClassroomID";
            // 
            // classroomsTableAdapter
            // 
            this.classroomsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教室列表：";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(160, 315);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(67, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上课日期";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.dayOfWeekBindingSource;
            this.listBox2.DisplayMember = "DayOfWeekName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(13, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(99, 160);
            this.listBox2.TabIndex = 0;
            this.listBox2.ValueMember = "DayOfWeekValue";
            // 
            // dayOfWeekBindingSource
            // 
            this.dayOfWeekBindingSource.DataMember = "DayOfWeek";
            this.dayOfWeekBindingSource.DataSource = this.staticDataSet;
            this.dayOfWeekBindingSource.PositionChanged += new System.EventHandler(this.dayOfWeekBindingSource_PositionChanged);
            // 
            // staticDataSet
            // 
            this.staticDataSet.DataSetName = "StaticDataSet";
            this.staticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dayOfWeekTableAdapter
            // 
            this.dayOfWeekTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCourseOfClassroom);
            this.groupBox3.Location = new System.Drawing.Point(391, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 355);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "课程信息";
            // 
            // dgvCourseOfClassroom
            // 
            this.dgvCourseOfClassroom.AllowUserToAddRows = false;
            this.dgvCourseOfClassroom.AllowUserToDeleteRows = false;
            this.dgvCourseOfClassroom.AutoGenerateColumns = false;
            this.dgvCourseOfClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseOfClassroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.courseSubtypeNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.TeacherName,
            this.beginTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dgvCourseOfClassroom.DataSource = this.coursesOfClassroomBindingSource;
            this.dgvCourseOfClassroom.Location = new System.Drawing.Point(14, 21);
            this.dgvCourseOfClassroom.Name = "dgvCourseOfClassroom";
            this.dgvCourseOfClassroom.ReadOnly = true;
            this.dgvCourseOfClassroom.RowHeadersVisible = false;
            this.dgvCourseOfClassroom.RowTemplate.Height = 23;
            this.dgvCourseOfClassroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseOfClassroom.Size = new System.Drawing.Size(692, 318);
            this.dgvCourseOfClassroom.TabIndex = 0;
            // 
            // courseTypeNameDataGridViewTextBoxColumn
            // 
            this.courseTypeNameDataGridViewTextBoxColumn.DataPropertyName = "CourseTypeName";
            this.courseTypeNameDataGridViewTextBoxColumn.HeaderText = "课程类别";
            this.courseTypeNameDataGridViewTextBoxColumn.Name = "courseTypeNameDataGridViewTextBoxColumn";
            this.courseTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseSubtypeNameDataGridViewTextBoxColumn
            // 
            this.courseSubtypeNameDataGridViewTextBoxColumn.DataPropertyName = "CourseSubtypeName";
            this.courseSubtypeNameDataGridViewTextBoxColumn.HeaderText = "所属科目";
            this.courseSubtypeNameDataGridViewTextBoxColumn.Name = "courseSubtypeNameDataGridViewTextBoxColumn";
            this.courseSubtypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "教师姓名";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // beginTimeDataGridViewTextBoxColumn
            // 
            this.beginTimeDataGridViewTextBoxColumn.DataPropertyName = "BeginTime";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.beginTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.beginTimeDataGridViewTextBoxColumn.HeaderText = "开课时间";
            this.beginTimeDataGridViewTextBoxColumn.Name = "beginTimeDataGridViewTextBoxColumn";
            this.beginTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.beginTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.endTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "下课时间";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // coursesOfClassroomBindingSource
            // 
            this.coursesOfClassroomBindingSource.DataMember = "CoursesOfClassroom";
            this.coursesOfClassroomBindingSource.DataSource = this.coursesDataSet;
            this.coursesOfClassroomBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.coursesOfClassroomBindingSource_ListChanged);
            // 
            // coursesOfClassroomTableAdapter
            // 
            this.coursesOfClassroomTableAdapter.ClearBeforeFill = true;
            // 
            // ClassroomManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ClassroomManageForm";
            this.Text = "教室管理";
            this.Load += new System.EventHandler(this.ClassroomManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseOfClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesOfClassroomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource classroomsBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private CoursesDataSetTableAdapters.ClassroomsTableAdapter classroomsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource dayOfWeekBindingSource;
        private StaticDataSet staticDataSet;
        private StaticDataSetTableAdapters.DayOfWeekTableAdapter dayOfWeekTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCourseOfClassroom;
        private System.Windows.Forms.BindingSource coursesOfClassroomBindingSource;
        private CoursesDataSetTableAdapters.CoursesOfClassroomTableAdapter coursesOfClassroomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}