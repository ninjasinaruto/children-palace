namespace BanGongPingTai
{
    partial class TeachersManageForm
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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnConnectCard = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvTeacherCourses = new System.Windows.Forms.DataGridView();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDelTeacher = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersDataSet = new BanGongPingTai.TeachersDataSet();
            this.teacherCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new BanGongPingTai.TeachersDataSetTableAdapters.TearchersTableAdapter();
            this.teacherCoursesTableAdapter = new BanGongPingTai.TeachersDataSetTableAdapters.TeacherCoursesTableAdapter();
            this.teacherSalaryAdjustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherSalaryAdjustTableAdapter = new BanGongPingTai.TeachersDataSetTableAdapters.TeacherSalaryAdjustTableAdapter();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSalaryAdjustBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AllowUserToResizeRows = false;
            this.dgvTeachers.AutoGenerateColumns = false;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cardNoColumn,
            this.teacherNameColumn,
            this.phoneColumn,
            this.sexColumn,
            this.addressColumn});
            this.dgvTeachers.DataSource = this.teachersBindingSource;
            this.dgvTeachers.Location = new System.Drawing.Point(12, 259);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.RowTemplate.Height = 23;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(597, 300);
            this.dgvTeachers.TabIndex = 3;
            this.dgvTeachers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTeachers_RowPostPaint);
            // 
            // btnConnectCard
            // 
            this.btnConnectCard.Enabled = false;
            this.btnConnectCard.Location = new System.Drawing.Point(463, 565);
            this.btnConnectCard.Name = "btnConnectCard";
            this.btnConnectCard.Size = new System.Drawing.Size(70, 36);
            this.btnConnectCard.TabIndex = 2;
            this.btnConnectCard.Text = "关联卡片";
            this.btnConnectCard.UseVisualStyleBackColor = true;
            this.btnConnectCard.Click += new System.EventHandler(this.btnConnectCard_Click);
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(-500, 222);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(117, 21);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "学号";
            // 
            // dgvTeacherCourses
            // 
            this.dgvTeacherCourses.AllowUserToAddRows = false;
            this.dgvTeacherCourses.AllowUserToDeleteRows = false;
            this.dgvTeacherCourses.AllowUserToResizeRows = false;
            this.dgvTeacherCourses.AutoGenerateColumns = false;
            this.dgvTeacherCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.courseSubtypeNameDataGridViewTextBoxColumn,
            this.chargeTypeNameDataGridViewTextBoxColumn,
            this.chargeAmountDataGridViewTextBoxColumn});
            this.dgvTeacherCourses.DataSource = this.teacherCoursesBindingSource;
            this.dgvTeacherCourses.Location = new System.Drawing.Point(12, 31);
            this.dgvTeacherCourses.Name = "dgvTeacherCourses";
            this.dgvTeacherCourses.ReadOnly = true;
            this.dgvTeacherCourses.RowHeadersVisible = false;
            this.dgvTeacherCourses.RowTemplate.Height = 23;
            this.dgvTeacherCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherCourses.Size = new System.Drawing.Size(597, 197);
            this.dgvTeacherCourses.TabIndex = 0;
            this.dgvTeacherCourses.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTeacherCourses_RowPostPaint);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(235, 565);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(70, 36);
            this.btnAddTeacher.TabIndex = 2;
            this.btnAddTeacher.Text = "添加";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.Location = new System.Drawing.Point(539, 565);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(70, 36);
            this.btnAddSalary.TabIndex = 2;
            this.btnAddSalary.Text = "添加工资";
            this.btnAddSalary.UseVisualStyleBackColor = true;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Location = new System.Drawing.Point(311, 565);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(70, 36);
            this.btnUpdateTeacher.TabIndex = 24;
            this.btnUpdateTeacher.Text = "修改";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // btnDelTeacher
            // 
            this.btnDelTeacher.Location = new System.Drawing.Point(387, 565);
            this.btnDelTeacher.Name = "btnDelTeacher";
            this.btnDelTeacher.Size = new System.Drawing.Size(70, 36);
            this.btnDelTeacher.TabIndex = 25;
            this.btnDelTeacher.Text = "删除";
            this.btnDelTeacher.UseVisualStyleBackColor = true;
            this.btnDelTeacher.Click += new System.EventHandler(this.btnDelTeacher_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 54;
            // 
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "Address";
            this.addressColumn.HeaderText = "地址";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "所授课程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "教师列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "课量工资信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(621, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 570);
            this.dataGridView1.TabIndex = 30;
            // 
            // cardNoColumn
            // 
            this.cardNoColumn.DataPropertyName = "CardNo";
            this.cardNoColumn.HeaderText = "卡号";
            this.cardNoColumn.Name = "cardNoColumn";
            this.cardNoColumn.ReadOnly = true;
            // 
            // teacherNameColumn
            // 
            this.teacherNameColumn.DataPropertyName = "Name";
            this.teacherNameColumn.HeaderText = "姓名";
            this.teacherNameColumn.Name = "teacherNameColumn";
            this.teacherNameColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "Phone";
            this.phoneColumn.HeaderText = "电话";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // sexColumn
            // 
            this.sexColumn.DataPropertyName = "Sex";
            this.sexColumn.HeaderText = "性别";
            this.sexColumn.Name = "sexColumn";
            this.sexColumn.ReadOnly = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Tearchers";
            this.teachersBindingSource.DataSource = this.teachersDataSet;
            this.teachersBindingSource.PositionChanged += new System.EventHandler(this.teachersBindingSource_PositionChanged);
            // 
            // teachersDataSet
            // 
            this.teachersDataSet.DataSetName = "TeachersDataSet";
            this.teachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherCoursesBindingSource
            // 
            this.teacherCoursesBindingSource.DataMember = "TeacherCourses";
            this.teacherCoursesBindingSource.DataSource = this.teachersDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teacherCoursesTableAdapter
            // 
            this.teacherCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // teacherSalaryAdjustBindingSource
            // 
            this.teacherSalaryAdjustBindingSource.DataMember = "TeacherSalaryAdjust";
            this.teacherSalaryAdjustBindingSource.DataSource = this.teachersDataSet;
            // 
            // teacherSalaryAdjustTableAdapter
            // 
            this.teacherSalaryAdjustTableAdapter.ClearBeforeFill = true;
            // 
            // SEQ
            // 
            this.SEQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SEQ.HeaderText = "序号";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            this.SEQ.Width = 54;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseTypeNameDataGridViewTextBoxColumn
            // 
            this.courseTypeNameDataGridViewTextBoxColumn.DataPropertyName = "CourseTypeName";
            this.courseTypeNameDataGridViewTextBoxColumn.HeaderText = "所属类别";
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
            // chargeTypeNameDataGridViewTextBoxColumn
            // 
            this.chargeTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ChargeTypeName";
            this.chargeTypeNameDataGridViewTextBoxColumn.HeaderText = "收费类型";
            this.chargeTypeNameDataGridViewTextBoxColumn.Name = "chargeTypeNameDataGridViewTextBoxColumn";
            this.chargeTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chargeAmountDataGridViewTextBoxColumn
            // 
            this.chargeAmountDataGridViewTextBoxColumn.DataPropertyName = "ChargeAmount";
            this.chargeAmountDataGridViewTextBoxColumn.HeaderText = "收费金额";
            this.chargeAmountDataGridViewTextBoxColumn.Name = "chargeAmountDataGridViewTextBoxColumn";
            this.chargeAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TeachersManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTeacherCourses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.btnDelTeacher);
            this.Controls.Add(this.btnUpdateTeacher);
            this.Controls.Add(this.btnConnectCard);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.txtID);
            this.Name = "TeachersManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "教师管理";
            this.Load += new System.EventHandler(this.TeachersManageForm_Load);
            this.Resize += new System.EventHandler(this.TeachersManageForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSalaryAdjustBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnConnectCard;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvTeacherCourses;
        private System.Windows.Forms.Button btnAddTeacher;
        private TeachersDataSet teachersDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private TeachersDataSetTableAdapters.TearchersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teacherCoursesBindingSource;
        private TeachersDataSetTableAdapters.TeacherCoursesTableAdapter teacherCoursesTableAdapter;
        private System.Windows.Forms.Button btnAddSalary;
        private System.Windows.Forms.BindingSource teacherSalaryAdjustBindingSource;
        private TeachersDataSetTableAdapters.TeacherSalaryAdjustTableAdapter teacherSalaryAdjustTableAdapter;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnDelTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeAmountDataGridViewTextBoxColumn;
    }
}