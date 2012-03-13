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
            this.dgvLeaveCourse = new System.Windows.Forms.DataGridView();
            this.btnSearchByCourseType = new System.Windows.Forms.Button();
            this.btnSearchByCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudentsCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShowRange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalRefundAmount = new System.Windows.Forms.TextBox();
            this.btnShowThisMonthBuy = new System.Windows.Forms.Button();
            this.dtRefundEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtRefundBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowFilterBuy = new System.Windows.Forms.Button();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveCourseDataSet = new ShaoNianGong.LeaveCourseDataSet();
            this.leaveCourseTableAdapter = new ShaoNianGong.LeaveCourseDataSetTableAdapters.LeaveCourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveCourse)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaveCourse
            // 
            this.dgvLeaveCourse.AllowUserToAddRows = false;
            this.dgvLeaveCourse.AllowUserToDeleteRows = false;
            this.dgvLeaveCourse.AllowUserToResizeRows = false;
            this.dgvLeaveCourse.AutoGenerateColumns = false;
            this.dgvLeaveCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.refundDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.expireTimeDataGridViewTextBoxColumn,
            this.refundAmountDataGridViewTextBoxColumn,
            this.refundReasonDataGridViewTextBoxColumn,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.courseSubtypeNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.OperatorColumn});
            this.dgvLeaveCourse.DataSource = this.leaveCourseBindingSource;
            this.dgvLeaveCourse.Location = new System.Drawing.Point(10, 79);
            this.dgvLeaveCourse.MultiSelect = false;
            this.dgvLeaveCourse.Name = "dgvLeaveCourse";
            this.dgvLeaveCourse.ReadOnly = true;
            this.dgvLeaveCourse.RowHeadersVisible = false;
            this.dgvLeaveCourse.RowTemplate.Height = 23;
            this.dgvLeaveCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveCourse.Size = new System.Drawing.Size(1183, 439);
            this.dgvLeaveCourse.TabIndex = 0;
            this.dgvLeaveCourse.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLeaveCourse_DataBindingComplete);
            // 
            // btnSearchByCourseType
            // 
            this.btnSearchByCourseType.Location = new System.Drawing.Point(451, 16);
            this.btnSearchByCourseType.Name = "btnSearchByCourseType";
            this.btnSearchByCourseType.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourseType.TabIndex = 18;
            this.btnSearchByCourseType.Text = "按分类查询";
            this.btnSearchByCourseType.UseVisualStyleBackColor = true;
            this.btnSearchByCourseType.Click += new System.EventHandler(this.btnSearchByCourseType_Click);
            // 
            // btnSearchByCourse
            // 
            this.btnSearchByCourse.Location = new System.Drawing.Point(553, 16);
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
            this.btnShowAll.Location = new System.Drawing.Point(349, 16);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 36);
            this.btnShowAll.TabIndex = 29;
            this.btnShowAll.Text = "显示所有";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "退款金额汇总：";
            // 
            // txtTotalRefundAmount
            // 
            this.txtTotalRefundAmount.Location = new System.Drawing.Point(107, 25);
            this.txtTotalRefundAmount.Name = "txtTotalRefundAmount";
            this.txtTotalRefundAmount.ReadOnly = true;
            this.txtTotalRefundAmount.Size = new System.Drawing.Size(120, 21);
            this.txtTotalRefundAmount.TabIndex = 31;
            // 
            // btnShowThisMonthBuy
            // 
            this.btnShowThisMonthBuy.Location = new System.Drawing.Point(247, 16);
            this.btnShowThisMonthBuy.Name = "btnShowThisMonthBuy";
            this.btnShowThisMonthBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthBuy.TabIndex = 32;
            this.btnShowThisMonthBuy.Text = "查看本月";
            this.btnShowThisMonthBuy.UseVisualStyleBackColor = true;
            this.btnShowThisMonthBuy.Click += new System.EventHandler(this.btnShowThisMonthBuy_Click);
            // 
            // dtRefundEndDate
            // 
            this.dtRefundEndDate.Location = new System.Drawing.Point(747, 41);
            this.dtRefundEndDate.Name = "dtRefundEndDate";
            this.dtRefundEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtRefundEndDate.TabIndex = 36;
            // 
            // dtRefundBeginDate
            // 
            this.dtRefundBeginDate.Location = new System.Drawing.Point(747, 16);
            this.dtRefundBeginDate.Name = "dtRefundBeginDate";
            this.dtRefundBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtRefundBeginDate.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "终止日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "起始日期：";
            // 
            // btnShowFilterBuy
            // 
            this.btnShowFilterBuy.Location = new System.Drawing.Point(882, 16);
            this.btnShowFilterBuy.Name = "btnShowFilterBuy";
            this.btnShowFilterBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterBuy.TabIndex = 33;
            this.btnShowFilterBuy.Text = "筛选";
            this.btnShowFilterBuy.UseVisualStyleBackColor = true;
            this.btnShowFilterBuy.Click += new System.EventHandler(this.btnShowFilterBuy_Click);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.DataPropertyName = "Operator";
            this.OperatorColumn.HeaderText = "经办人";
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.ReadOnly = true;
            // 
            // refundDateDataGridViewTextBoxColumn
            // 
            this.refundDateDataGridViewTextBoxColumn.DataPropertyName = "RefundDate";
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.refundDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.refundDateDataGridViewTextBoxColumn.HeaderText = "离班日期";
            this.refundDateDataGridViewTextBoxColumn.Name = "refundDateDataGridViewTextBoxColumn";
            this.refundDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.refundDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "学生姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // refundAmountDataGridViewTextBoxColumn
            // 
            this.refundAmountDataGridViewTextBoxColumn.DataPropertyName = "RefundAmount";
            this.refundAmountDataGridViewTextBoxColumn.HeaderText = "退款金额";
            this.refundAmountDataGridViewTextBoxColumn.Name = "refundAmountDataGridViewTextBoxColumn";
            this.refundAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refundReasonDataGridViewTextBoxColumn
            // 
            this.refundReasonDataGridViewTextBoxColumn.DataPropertyName = "RefundReason";
            this.refundReasonDataGridViewTextBoxColumn.HeaderText = "离班原因";
            this.refundReasonDataGridViewTextBoxColumn.Name = "refundReasonDataGridViewTextBoxColumn";
            this.refundReasonDataGridViewTextBoxColumn.ReadOnly = true;
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
            // leaveCourseBindingSource
            // 
            this.leaveCourseBindingSource.DataMember = "LeaveCourse";
            this.leaveCourseBindingSource.DataSource = this.leaveCourseDataSet;
            this.leaveCourseBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.leaveCourseBindingSource_ListChanged);
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
            this.Controls.Add(this.dtRefundEndDate);
            this.Controls.Add(this.dtRefundBeginDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowFilterBuy);
            this.Controls.Add(this.btnShowThisMonthBuy);
            this.Controls.Add(this.txtTotalRefundAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchByCourseType);
            this.Controls.Add(this.btnSearchByCourse);
            this.Controls.Add(this.dgvLeaveCourse);
            this.Name = "LeftCourseForm";
            this.Text = "离班记录汇总";
            this.Load += new System.EventHandler(this.LeftCourseForm_Load);
            this.Resize += new System.EventHandler(this.LeftCourseForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveCourse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveCourseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaveCourse;
        private LeaveCourseDataSet leaveCourseDataSet;
        private System.Windows.Forms.BindingSource leaveCourseBindingSource;
        private LeaveCourseDataSetTableAdapters.LeaveCourseTableAdapter leaveCourseTableAdapter;
        private System.Windows.Forms.Button btnSearchByCourseType;
        private System.Windows.Forms.Button btnSearchByCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtShowRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblStudentsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalRefundAmount;
        private System.Windows.Forms.Button btnShowThisMonthBuy;
        private System.Windows.Forms.DateTimePicker dtRefundEndDate;
        private System.Windows.Forms.DateTimePicker dtRefundBeginDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowFilterBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
    }
}