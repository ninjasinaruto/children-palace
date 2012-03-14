namespace ShaoNianGong
{
    partial class DepositListForm
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
            this.dgvDeposit = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDepositListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositListDataSet = new Common.DepositListDataSet();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllDeposit = new System.Windows.Forms.Button();
            this.btnShowThisMonthDeposit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowFilterDeposit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDepositBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtDepositEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDepositCount = new System.Windows.Forms.Label();
            this.txtShowRange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentDepositListTableAdapter = new Common.DepositListDataSetTableAdapters.StudentDepositListTableAdapter();
            this.btnSearchByCourseType = new System.Windows.Forms.Button();
            this.btnSearchByCourse = new System.Windows.Forms.Button();
            this.btnSearchByCourseTypeWithDate = new System.Windows.Forms.Button();
            this.btnSearchByCourseWithDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepositListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeposit
            // 
            this.dgvDeposit.AllowUserToAddRows = false;
            this.dgvDeposit.AllowUserToDeleteRows = false;
            this.dgvDeposit.AllowUserToResizeRows = false;
            this.dgvDeposit.AutoGenerateColumns = false;
            this.dgvDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.depositDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ExpireTimeColumn,
            this.depositAmountDataGridViewTextBoxColumn,
            this.ActualPaidAmount,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.courseSubtypeNameDataGridViewTextBoxColumn,
            this.CourseName,
            this.chargeTypeNameDataGridViewTextBoxColumn,
            this.OperatorColumn});
            this.dgvDeposit.DataSource = this.studentDepositListBindingSource;
            this.dgvDeposit.Location = new System.Drawing.Point(10, 79);
            this.dgvDeposit.MultiSelect = false;
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.ReadOnly = true;
            this.dgvDeposit.RowHeadersVisible = false;
            this.dgvDeposit.RowTemplate.Height = 23;
            this.dgvDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeposit.Size = new System.Drawing.Size(1183, 437);
            this.dgvDeposit.TabIndex = 0;
            this.dgvDeposit.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDeposit_DataBindingComplete);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // depositDateDataGridViewTextBoxColumn
            // 
            this.depositDateDataGridViewTextBoxColumn.DataPropertyName = "DepositDate";
            dataGridViewCellStyle3.Format = "F";
            dataGridViewCellStyle3.NullValue = null;
            this.depositDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.depositDateDataGridViewTextBoxColumn.HeaderText = "充值日期";
            this.depositDateDataGridViewTextBoxColumn.Name = "depositDateDataGridViewTextBoxColumn";
            this.depositDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.depositDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "学生姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExpireTimeColumn
            // 
            this.ExpireTimeColumn.DataPropertyName = "ExpireTime";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.ExpireTimeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExpireTimeColumn.HeaderText = "缴费到期时间";
            this.ExpireTimeColumn.Name = "ExpireTimeColumn";
            this.ExpireTimeColumn.ReadOnly = true;
            // 
            // depositAmountDataGridViewTextBoxColumn
            // 
            this.depositAmountDataGridViewTextBoxColumn.DataPropertyName = "DepositAmount";
            this.depositAmountDataGridViewTextBoxColumn.HeaderText = "充值金额";
            this.depositAmountDataGridViewTextBoxColumn.Name = "depositAmountDataGridViewTextBoxColumn";
            this.depositAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ActualPaidAmount
            // 
            this.ActualPaidAmount.DataPropertyName = "ActualPaidAmount";
            this.ActualPaidAmount.HeaderText = "实收金额";
            this.ActualPaidAmount.Name = "ActualPaidAmount";
            this.ActualPaidAmount.ReadOnly = true;
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
            this.courseSubtypeNameDataGridViewTextBoxColumn.HeaderText = "课程科目";
            this.courseSubtypeNameDataGridViewTextBoxColumn.Name = "courseSubtypeNameDataGridViewTextBoxColumn";
            this.courseSubtypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // chargeTypeNameDataGridViewTextBoxColumn
            // 
            this.chargeTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ChargeTypeName";
            this.chargeTypeNameDataGridViewTextBoxColumn.HeaderText = "课程收费类型";
            this.chargeTypeNameDataGridViewTextBoxColumn.Name = "chargeTypeNameDataGridViewTextBoxColumn";
            this.chargeTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.DataPropertyName = "Operator";
            this.OperatorColumn.HeaderText = "经办人";
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.ReadOnly = true;
            // 
            // studentDepositListBindingSource
            // 
            this.studentDepositListBindingSource.DataMember = "StudentDepositList";
            this.studentDepositListBindingSource.DataSource = this.depositListDataSet;
            this.studentDepositListBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.depositListBindingSource_ListChanged);
            // 
            // depositListDataSet
            // 
            this.depositListDataSet.DataSetName = "DepositListDataSet";
            this.depositListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(107, 42);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(120, 21);
            this.txtTotalPaid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "实收金额汇总：";
            // 
            // txtTotalDeposit
            // 
            this.txtTotalDeposit.Location = new System.Drawing.Point(107, 12);
            this.txtTotalDeposit.Name = "txtTotalDeposit";
            this.txtTotalDeposit.ReadOnly = true;
            this.txtTotalDeposit.Size = new System.Drawing.Size(120, 21);
            this.txtTotalDeposit.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "充值金额汇总：";
            // 
            // btnShowAllDeposit
            // 
            this.btnShowAllDeposit.Location = new System.Drawing.Point(349, 16);
            this.btnShowAllDeposit.Name = "btnShowAllDeposit";
            this.btnShowAllDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowAllDeposit.TabIndex = 7;
            this.btnShowAllDeposit.Text = "查看所有";
            this.btnShowAllDeposit.UseVisualStyleBackColor = true;
            this.btnShowAllDeposit.Click += new System.EventHandler(this.btnShowAllDeposit_Click);
            // 
            // btnShowThisMonthDeposit
            // 
            this.btnShowThisMonthDeposit.Location = new System.Drawing.Point(247, 16);
            this.btnShowThisMonthDeposit.Name = "btnShowThisMonthDeposit";
            this.btnShowThisMonthDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthDeposit.TabIndex = 7;
            this.btnShowThisMonthDeposit.Text = "查看本月";
            this.btnShowThisMonthDeposit.UseVisualStyleBackColor = true;
            this.btnShowThisMonthDeposit.Click += new System.EventHandler(this.btnShowThisMonthDeposit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(887, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "起始日期：";
            // 
            // btnShowFilterDeposit
            // 
            this.btnShowFilterDeposit.Location = new System.Drawing.Point(1093, 16);
            this.btnShowFilterDeposit.Name = "btnShowFilterDeposit";
            this.btnShowFilterDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterDeposit.TabIndex = 7;
            this.btnShowFilterDeposit.Text = "筛选";
            this.btnShowFilterDeposit.UseVisualStyleBackColor = true;
            this.btnShowFilterDeposit.Click += new System.EventHandler(this.btnShowFilterDeposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "终止日期：";
            // 
            // dtDepositBeginDate
            // 
            this.dtDepositBeginDate.Location = new System.Drawing.Point(958, 16);
            this.dtDepositBeginDate.Name = "dtDepositBeginDate";
            this.dtDepositBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositBeginDate.TabIndex = 9;
            // 
            // dtDepositEndDate
            // 
            this.dtDepositEndDate.Location = new System.Drawing.Point(958, 41);
            this.dtDepositEndDate.Name = "dtDepositEndDate";
            this.dtDepositEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositEndDate.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDepositCount);
            this.panel1.Controls.Add(this.txtShowRange);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 48);
            this.panel1.TabIndex = 28;
            // 
            // lblDepositCount
            // 
            this.lblDepositCount.AutoSize = true;
            this.lblDepositCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDepositCount.Location = new System.Drawing.Point(788, 11);
            this.lblDepositCount.Name = "lblDepositCount";
            this.lblDepositCount.Size = new System.Drawing.Size(25, 12);
            this.lblDepositCount.TabIndex = 25;
            this.lblDepositCount.Text = "0条";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "充值记录总数：";
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
            // studentDepositListTableAdapter
            // 
            this.studentDepositListTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearchByCourseType
            // 
            this.btnSearchByCourseType.Location = new System.Drawing.Point(451, 16);
            this.btnSearchByCourseType.Name = "btnSearchByCourseType";
            this.btnSearchByCourseType.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourseType.TabIndex = 30;
            this.btnSearchByCourseType.Text = "按分类查询";
            this.btnSearchByCourseType.UseVisualStyleBackColor = true;
            this.btnSearchByCourseType.Click += new System.EventHandler(this.btnSearchByCourseType_Click);
            // 
            // btnSearchByCourse
            // 
            this.btnSearchByCourse.Location = new System.Drawing.Point(553, 16);
            this.btnSearchByCourse.Name = "btnSearchByCourse";
            this.btnSearchByCourse.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourse.TabIndex = 29;
            this.btnSearchByCourse.Text = "按课程查询";
            this.btnSearchByCourse.UseVisualStyleBackColor = true;
            this.btnSearchByCourse.Click += new System.EventHandler(this.btnSearchByCourse_Click);
            // 
            // btnSearchByCourseTypeWithDate
            // 
            this.btnSearchByCourseTypeWithDate.Location = new System.Drawing.Point(655, 16);
            this.btnSearchByCourseTypeWithDate.Name = "btnSearchByCourseTypeWithDate";
            this.btnSearchByCourseTypeWithDate.Size = new System.Drawing.Size(106, 36);
            this.btnSearchByCourseTypeWithDate.TabIndex = 31;
            this.btnSearchByCourseTypeWithDate.Text = "按分类日期查询";
            this.btnSearchByCourseTypeWithDate.UseVisualStyleBackColor = true;
            this.btnSearchByCourseTypeWithDate.Click += new System.EventHandler(this.btnSearchByCourseTypeWithDate_Click);
            // 
            // btnSearchByCourseWithDate
            // 
            this.btnSearchByCourseWithDate.Location = new System.Drawing.Point(767, 16);
            this.btnSearchByCourseWithDate.Name = "btnSearchByCourseWithDate";
            this.btnSearchByCourseWithDate.Size = new System.Drawing.Size(102, 36);
            this.btnSearchByCourseWithDate.TabIndex = 32;
            this.btnSearchByCourseWithDate.Text = "按课程日期查询";
            this.btnSearchByCourseWithDate.UseVisualStyleBackColor = true;
            this.btnSearchByCourseWithDate.Click += new System.EventHandler(this.btnSearchByCourseWithDate_Click);
            // 
            // DepositListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 572);
            this.Controls.Add(this.btnSearchByCourseWithDate);
            this.Controls.Add(this.btnSearchByCourseTypeWithDate);
            this.Controls.Add(this.btnSearchByCourseType);
            this.Controls.Add(this.btnSearchByCourse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtDepositEndDate);
            this.Controls.Add(this.dtDepositBeginDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowThisMonthDeposit);
            this.Controls.Add(this.btnShowFilterDeposit);
            this.Controls.Add(this.btnShowAllDeposit);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDeposit);
            this.Name = "DepositListForm";
            this.Text = "充值汇总";
            this.Load += new System.EventHandler(this.DepositListForm_Load);
            this.Resize += new System.EventHandler(this.DepositListForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepositListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.BindingSource studentDepositListBindingSource;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAllDeposit;
        private System.Windows.Forms.Button btnShowThisMonthDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowFilterDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDepositBeginDate;
        private System.Windows.Forms.DateTimePicker dtDepositEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepositCount;
        private System.Windows.Forms.Label txtShowRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Common.DepositListDataSet depositListDataSet;
        private Common.DepositListDataSetTableAdapters.StudentDepositListTableAdapter studentDepositListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
        private System.Windows.Forms.Button btnSearchByCourseType;
        private System.Windows.Forms.Button btnSearchByCourse;
        private System.Windows.Forms.Button btnSearchByCourseTypeWithDate;
        private System.Windows.Forms.Button btnSearchByCourseWithDate;
    }
}