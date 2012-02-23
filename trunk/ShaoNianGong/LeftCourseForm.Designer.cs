namespace ShaoNianGong
{
    partial class LeftCourseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchByCourseType = new System.Windows.Forms.Button();
            this.btnSearchByCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtShowRange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblStudentsCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.refundDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveCourseDataSet = new ShaoNianGong.LeaveCourseDataSet();
            this.leaveCourseTableAdapter = new ShaoNianGong.LeaveCourseDataSetTableAdapters.LeaveCourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refundDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.refundReasonDataGridViewTextBoxColumn,
            this.refundAmountDataGridViewTextBoxColumn,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.courseSubtypeNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.expireTimeDataGridViewTextBoxColumn,
            this.OperatorColumn});
            this.dataGridView1.DataSource = this.leaveCourseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.DataPropertyName = "Operator";
            this.OperatorColumn.HeaderText = "经办人";
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.ReadOnly = true;
            // 
            // btnSearchByCourseType
            // 
            this.btnSearchByCourseType.Location = new System.Drawing.Point(124, 24);
            this.btnSearchByCourseType.Name = "btnSearchByCourseType";
            this.btnSearchByCourseType.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourseType.TabIndex = 18;
            this.btnSearchByCourseType.Text = "按分类查询";
            this.btnSearchByCourseType.UseVisualStyleBackColor = true;
            this.btnSearchByCourseType.Click += new System.EventHandler(this.btnSearchByCourseType_Click);
            // 
            // btnSearchByCourse
            // 
            this.btnSearchByCourse.Location = new System.Drawing.Point(226, 24);
            this.btnSearchByCourse.Name = "btnSearchByCourse";
            this.btnSearchByCourse.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourse.TabIndex = 17;
            this.btnSearchByCourse.Text = "按课程查询";
            this.btnSearchByCourse.UseVisualStyleBackColor = true;
            this.btnSearchByCourse.Click += new System.EventHandler(this.btnSearchByCourse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStudentsCount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtShowRange);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 48);
            this.panel1.TabIndex = 28;
            // 
            // txtShowRange
            // 
            this.txtShowRange.AutoSize = true;
            this.txtShowRange.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShowRange.Location = new System.Drawing.Point(111, 11);
            this.txtShowRange.Name = "txtShowRange";
            this.txtShowRange.Size = new System.Drawing.Size(31, 12);
            this.txtShowRange.TabIndex = 25;
            this.txtShowRange.Text = "所有";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "当前显示范围：";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(22, 24);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 36);
            this.btnShowAll.TabIndex = 29;
            this.btnShowAll.Text = "显示所有";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblStudentsCount
            // 
            this.lblStudentsCount.AutoSize = true;
            this.lblStudentsCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudentsCount.Location = new System.Drawing.Point(452, 11);
            this.lblStudentsCount.Name = "lblStudentsCount";
            this.lblStudentsCount.Size = new System.Drawing.Size(25, 12);
            this.lblStudentsCount.TabIndex = 27;
            this.lblStudentsCount.Text = "0人";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "学生总数：";
            // 
            // refundDateDataGridViewTextBoxColumn
            // 
            this.refundDateDataGridViewTextBoxColumn.DataPropertyName = "RefundDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.refundDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.refundDateDataGridViewTextBoxColumn.HeaderText = "离班日期";
            this.refundDateDataGridViewTextBoxColumn.Name = "refundDateDataGridViewTextBoxColumn";
            this.refundDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "学生姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refundReasonDataGridViewTextBoxColumn
            // 
            this.refundReasonDataGridViewTextBoxColumn.DataPropertyName = "RefundReason";
            this.refundReasonDataGridViewTextBoxColumn.HeaderText = "离班原因";
            this.refundReasonDataGridViewTextBoxColumn.Name = "refundReasonDataGridViewTextBoxColumn";
            this.refundReasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refundAmountDataGridViewTextBoxColumn
            // 
            this.refundAmountDataGridViewTextBoxColumn.DataPropertyName = "RefundAmount";
            this.refundAmountDataGridViewTextBoxColumn.HeaderText = "退款金额";
            this.refundAmountDataGridViewTextBoxColumn.Name = "refundAmountDataGridViewTextBoxColumn";
            this.refundAmountDataGridViewTextBoxColumn.ReadOnly = true;
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
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "教师姓名";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expireTimeDataGridViewTextBoxColumn
            // 
            this.expireTimeDataGridViewTextBoxColumn.DataPropertyName = "ExpireTime";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.expireTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.expireTimeDataGridViewTextBoxColumn.HeaderText = "缴费到期时间";
            this.expireTimeDataGridViewTextBoxColumn.Name = "expireTimeDataGridViewTextBoxColumn";
            this.expireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaveCourseBindingSource
            // 
            this.leaveCourseBindingSource.DataMember = "LeaveCourse";
            this.leaveCourseBindingSource.DataSource = this.leaveCourseDataSet;
            // 
            // leaveCourseDataSet
            // 
            this.leaveCourseDataSet.DataSetName = "LeaveCourseDataSet";
            this.leaveCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveCourseTableAdapter
            // 
            this.leaveCourseTableAdapter.ClearBeforeFill = true;
            // 
            // LeftCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 572);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchByCourseType);
            this.Controls.Add(this.btnSearchByCourse);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LeftCourseForm";
            this.Text = "离班记录汇总";
            this.Load += new System.EventHandler(this.LeftCourseForm_Load);
            this.Resize += new System.EventHandler(this.LeftCourseForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LeaveCourseDataSet leaveCourseDataSet;
        private System.Windows.Forms.BindingSource leaveCourseBindingSource;
        private LeaveCourseDataSetTableAdapters.LeaveCourseTableAdapter leaveCourseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
        private System.Windows.Forms.Button btnSearchByCourseType;
        private System.Windows.Forms.Button btnSearchByCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtShowRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblStudentsCount;
        private System.Windows.Forms.Label label7;
    }
}