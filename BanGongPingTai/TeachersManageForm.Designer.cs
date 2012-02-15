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
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersDataSet = new BanGongPingTai.TeachersDataSet();
            this.label15 = new System.Windows.Forms.Label();
            this.btnConnectCard = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTeacherCourses = new System.Windows.Forms.DataGridView();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.teachersTableAdapter = new BanGongPingTai.TeachersDataSetTableAdapters.TearchersTableAdapter();
            this.teacherCoursesTableAdapter = new BanGongPingTai.TeachersDataSetTableAdapters.TeacherCoursesTableAdapter();
            this.btnChangeSalary = new System.Windows.Forms.Button();
            this.teacherSalaryAdjustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherSalaryAdjustTableAdapter = new BanGongPingTai.TeachersDataSetTableAdapters.TeacherSalaryAdjustTableAdapter();
            this.cardNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCourses)).BeginInit();
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
            this.cardNoColumn,
            this.teacherNameColumn,
            this.phoneColumn,
            this.sexColumn,
            this.addressColumn});
            this.dgvTeachers.DataSource = this.teachersBindingSource;
            this.dgvTeachers.Location = new System.Drawing.Point(12, 201);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.RowTemplate.Height = 23;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(609, 420);
            this.dgvTeachers.TabIndex = 3;
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
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(12, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "教师列表：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnectCard
            // 
            this.btnConnectCard.Location = new System.Drawing.Point(427, 159);
            this.btnConnectCard.Name = "btnConnectCard";
            this.btnConnectCard.Size = new System.Drawing.Size(94, 36);
            this.btnConnectCard.TabIndex = 2;
            this.btnConnectCard.Text = "关联卡片";
            this.btnConnectCard.UseVisualStyleBackColor = true;
            this.btnConnectCard.Click += new System.EventHandler(this.btnConnectCard_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(527, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "刷卡查找";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTeacherCourses);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 140);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "所教授课程";
            // 
            // dgvTeacherCourses
            // 
            this.dgvTeacherCourses.AllowUserToAddRows = false;
            this.dgvTeacherCourses.AllowUserToDeleteRows = false;
            this.dgvTeacherCourses.AllowUserToResizeRows = false;
            this.dgvTeacherCourses.AutoGenerateColumns = false;
            this.dgvTeacherCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseNameDataGridViewTextBoxColumn,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.courseSubtypeNameDataGridViewTextBoxColumn,
            this.chargeTypeNameDataGridViewTextBoxColumn,
            this.chargeAmountDataGridViewTextBoxColumn});
            this.dgvTeacherCourses.DataSource = this.teacherCoursesBindingSource;
            this.dgvTeacherCourses.Location = new System.Drawing.Point(6, 20);
            this.dgvTeacherCourses.Name = "dgvTeacherCourses";
            this.dgvTeacherCourses.ReadOnly = true;
            this.dgvTeacherCourses.RowHeadersVisible = false;
            this.dgvTeacherCourses.RowTemplate.Height = 23;
            this.dgvTeacherCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherCourses.Size = new System.Drawing.Size(597, 114);
            this.dgvTeacherCourses.TabIndex = 0;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
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
            // teacherCoursesBindingSource
            // 
            this.teacherCoursesBindingSource.DataMember = "TeacherCourses";
            this.teacherCoursesBindingSource.DataSource = this.teachersDataSet;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(114, 159);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(94, 36);
            this.btnAddTeacher.TabIndex = 2;
            this.btnAddTeacher.Text = "添加教师";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teacherCoursesTableAdapter
            // 
            this.teacherCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // btnChangeSalary
            // 
            this.btnChangeSalary.Location = new System.Drawing.Point(214, 159);
            this.btnChangeSalary.Name = "btnChangeSalary";
            this.btnChangeSalary.Size = new System.Drawing.Size(94, 36);
            this.btnChangeSalary.TabIndex = 2;
            this.btnChangeSalary.Text = "工资调整";
            this.btnChangeSalary.UseVisualStyleBackColor = true;
            this.btnChangeSalary.Visible = false;
            this.btnChangeSalary.Click += new System.EventHandler(this.btnChangeSalary_Click);
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
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "Address";
            this.addressColumn.HeaderText = "地址";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // TeachersManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 633);
            this.Controls.Add(this.btnChangeSalary);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnConnectCard);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtID);
            this.Name = "TeachersManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "教师管理";
            this.Load += new System.EventHandler(this.TeachersManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSalaryAdjustBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnConnectCard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTeacherCourses;
        private System.Windows.Forms.Button btnAddTeacher;
        private TeachersDataSet teachersDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private TeachersDataSetTableAdapters.TearchersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teacherCoursesBindingSource;
        private TeachersDataSetTableAdapters.TeacherCoursesTableAdapter teacherCoursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnChangeSalary;
        private System.Windows.Forms.BindingSource teacherSalaryAdjustBindingSource;
        private TeachersDataSetTableAdapters.TeacherSalaryAdjustTableAdapter teacherSalaryAdjustTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
    }
}