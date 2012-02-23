namespace ShaoNianGong
{
    partial class CostListForm
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
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDepositEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtDepositBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowThisMonthDeposit = new System.Windows.Forms.Button();
            this.btnShowFilterDeposit = new System.Windows.Forms.Button();
            this.btnShowAllDeposit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchByCourse = new System.Windows.Forms.Button();
            this.btnSearchByCourseType = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCostCount = new System.Windows.Forms.Label();
            this.txtShowRange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCost = new System.Windows.Forms.DataGridView();
            this.costDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualCostAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costListDataSet = new ShaoNianGong.CostListDataSet();
            this.costListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costListTableAdapter = new ShaoNianGong.CostListDataSetTableAdapters.CostListTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(107, 43);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(120, 21);
            this.txtTotalPaid.TabIndex = 9;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(107, 12);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(120, 21);
            this.txtTotalCost.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "拟收金额汇总：";
            // 
            // dtDepositEndDate
            // 
            this.dtDepositEndDate.Location = new System.Drawing.Point(746, 41);
            this.dtDepositEndDate.Name = "dtDepositEndDate";
            this.dtDepositEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositEndDate.TabIndex = 20;
            // 
            // dtDepositBeginDate
            // 
            this.dtDepositBeginDate.Location = new System.Drawing.Point(746, 16);
            this.dtDepositBeginDate.Name = "dtDepositBeginDate";
            this.dtDepositBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositBeginDate.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "终止日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "起始日期：";
            // 
            // btnShowThisMonthDeposit
            // 
            this.btnShowThisMonthDeposit.Location = new System.Drawing.Point(247, 16);
            this.btnShowThisMonthDeposit.Name = "btnShowThisMonthDeposit";
            this.btnShowThisMonthDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthDeposit.TabIndex = 17;
            this.btnShowThisMonthDeposit.Text = "查看本月";
            this.btnShowThisMonthDeposit.UseVisualStyleBackColor = true;
            this.btnShowThisMonthDeposit.Click += new System.EventHandler(this.btnShowThisMonthDeposit_Click);
            // 
            // btnShowFilterDeposit
            // 
            this.btnShowFilterDeposit.Location = new System.Drawing.Point(881, 16);
            this.btnShowFilterDeposit.Name = "btnShowFilterDeposit";
            this.btnShowFilterDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterDeposit.TabIndex = 16;
            this.btnShowFilterDeposit.Text = "筛选";
            this.btnShowFilterDeposit.UseVisualStyleBackColor = true;
            this.btnShowFilterDeposit.Click += new System.EventHandler(this.btnShowFilterDeposit_Click);
            // 
            // btnShowAllDeposit
            // 
            this.btnShowAllDeposit.Location = new System.Drawing.Point(349, 16);
            this.btnShowAllDeposit.Name = "btnShowAllDeposit";
            this.btnShowAllDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowAllDeposit.TabIndex = 15;
            this.btnShowAllDeposit.Text = "查看所有";
            this.btnShowAllDeposit.UseVisualStyleBackColor = true;
            this.btnShowAllDeposit.Click += new System.EventHandler(this.btnShowAllDeposit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "实收金额汇总：";
            // 
            // btnSearchByCourse
            // 
            this.btnSearchByCourse.Location = new System.Drawing.Point(553, 16);
            this.btnSearchByCourse.Name = "btnSearchByCourse";
            this.btnSearchByCourse.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourse.TabIndex = 22;
            this.btnSearchByCourse.Text = "按课程查询";
            this.btnSearchByCourse.UseVisualStyleBackColor = true;
            this.btnSearchByCourse.Click += new System.EventHandler(this.btnSearchByCourse_Click);
            // 
            // btnSearchByCourseType
            // 
            this.btnSearchByCourseType.Location = new System.Drawing.Point(451, 16);
            this.btnSearchByCourseType.Name = "btnSearchByCourseType";
            this.btnSearchByCourseType.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourseType.TabIndex = 23;
            this.btnSearchByCourseType.Text = "按分类查询";
            this.btnSearchByCourseType.UseVisualStyleBackColor = true;
            this.btnSearchByCourseType.Click += new System.EventHandler(this.btnSearchByCourseType_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCostCount);
            this.panel1.Controls.Add(this.txtShowRange);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 48);
            this.panel1.TabIndex = 29;
            // 
            // lblCostCount
            // 
            this.lblCostCount.AutoSize = true;
            this.lblCostCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCostCount.Location = new System.Drawing.Point(484, 11);
            this.lblCostCount.Name = "lblCostCount";
            this.lblCostCount.Size = new System.Drawing.Size(25, 12);
            this.lblCostCount.TabIndex = 25;
            this.lblCostCount.Text = "0条";
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
            this.label7.Location = new System.Drawing.Point(380, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "收费记录总数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前显示范围：";
            // 
            // dgvCost
            // 
            this.dgvCost.AllowUserToAddRows = false;
            this.dgvCost.AllowUserToDeleteRows = false;
            this.dgvCost.AllowUserToResizeRows = false;
            this.dgvCost.AutoGenerateColumns = false;
            this.dgvCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ExpireTimeColumn,
            this.costAmountDataGridViewTextBoxColumn,
            this.ActualCostAmount,
            this.chargeAmountDataGridViewTextBoxColumn,
            this.DiscountLevelName,
            this.DiscountReason,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.courseSubtypeNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.chargeTypeNameDataGridViewTextBoxColumn,
            this.OperatorColumn});
            this.dgvCost.DataMember = "CostList";
            this.dgvCost.DataSource = this.costListDataSet;
            this.dgvCost.Location = new System.Drawing.Point(10, 79);
            this.dgvCost.MultiSelect = false;
            this.dgvCost.Name = "dgvCost";
            this.dgvCost.ReadOnly = true;
            this.dgvCost.RowHeadersVisible = false;
            this.dgvCost.RowTemplate.Height = 23;
            this.dgvCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCost.Size = new System.Drawing.Size(1183, 439);
            this.dgvCost.TabIndex = 1;
            // 
            // costDateDataGridViewTextBoxColumn
            // 
            this.costDateDataGridViewTextBoxColumn.DataPropertyName = "CostDate";
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.costDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.costDateDataGridViewTextBoxColumn.HeaderText = "收费日期";
            this.costDateDataGridViewTextBoxColumn.Name = "costDateDataGridViewTextBoxColumn";
            this.costDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDateDataGridViewTextBoxColumn.Width = 150;
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
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.ExpireTimeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExpireTimeColumn.HeaderText = "缴费到期时间";
            this.ExpireTimeColumn.Name = "ExpireTimeColumn";
            this.ExpireTimeColumn.ReadOnly = true;
            // 
            // costAmountDataGridViewTextBoxColumn
            // 
            this.costAmountDataGridViewTextBoxColumn.DataPropertyName = "CostAmount";
            this.costAmountDataGridViewTextBoxColumn.HeaderText = "拟收金额";
            this.costAmountDataGridViewTextBoxColumn.Name = "costAmountDataGridViewTextBoxColumn";
            this.costAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ActualCostAmount
            // 
            this.ActualCostAmount.DataPropertyName = "ActualCostAmount";
            this.ActualCostAmount.HeaderText = "实收金额";
            this.ActualCostAmount.Name = "ActualCostAmount";
            this.ActualCostAmount.ReadOnly = true;
            // 
            // chargeAmountDataGridViewTextBoxColumn
            // 
            this.chargeAmountDataGridViewTextBoxColumn.DataPropertyName = "ChargeAmount";
            this.chargeAmountDataGridViewTextBoxColumn.HeaderText = "课程收费金额";
            this.chargeAmountDataGridViewTextBoxColumn.Name = "chargeAmountDataGridViewTextBoxColumn";
            this.chargeAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.chargeAmountDataGridViewTextBoxColumn.Width = 130;
            // 
            // DiscountLevelName
            // 
            this.DiscountLevelName.DataPropertyName = "DiscountLevelName";
            this.DiscountLevelName.HeaderText = "折扣";
            this.DiscountLevelName.Name = "DiscountLevelName";
            this.DiscountLevelName.ReadOnly = true;
            // 
            // DiscountReason
            // 
            this.DiscountReason.DataPropertyName = "DiscountReason";
            this.DiscountReason.HeaderText = "折扣原因";
            this.DiscountReason.Name = "DiscountReason";
            this.DiscountReason.ReadOnly = true;
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
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chargeTypeNameDataGridViewTextBoxColumn
            // 
            this.chargeTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ChargeTypeName";
            this.chargeTypeNameDataGridViewTextBoxColumn.HeaderText = "课程收费类型";
            this.chargeTypeNameDataGridViewTextBoxColumn.Name = "chargeTypeNameDataGridViewTextBoxColumn";
            this.chargeTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.chargeTypeNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.DataPropertyName = "Operator";
            this.OperatorColumn.HeaderText = "经办人";
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.ReadOnly = true;
            // 
            // costListDataSet
            // 
            this.costListDataSet.DataSetName = "CostListDataSet";
            this.costListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costListBindingSource
            // 
            this.costListBindingSource.DataMember = "CostList";
            this.costListBindingSource.DataSource = this.costListDataSet;
            this.costListBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.costListBindingSource_ListChanged);
            // 
            // costListTableAdapter
            // 
            this.costListTableAdapter.ClearBeforeFill = true;
            // 
            // CostListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchByCourseType);
            this.Controls.Add(this.btnSearchByCourse);
            this.Controls.Add(this.dtDepositEndDate);
            this.Controls.Add(this.dtDepositBeginDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowThisMonthDeposit);
            this.Controls.Add(this.btnShowFilterDeposit);
            this.Controls.Add(this.btnShowAllDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCost);
            this.Name = "CostListForm";
            this.Text = "收费汇总";
            this.Load += new System.EventHandler(this.CostListForm_Load);
            this.Resize += new System.EventHandler(this.CostListForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CostListDataSet costListDataSet;
        private System.Windows.Forms.BindingSource costListBindingSource;
        private CostListDataSetTableAdapters.CostListTableAdapter costListTableAdapter;
        private System.Windows.Forms.DataGridView dgvCost;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDepositEndDate;
        private System.Windows.Forms.DateTimePicker dtDepositBeginDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowThisMonthDeposit;
        private System.Windows.Forms.Button btnShowFilterDeposit;
        private System.Windows.Forms.Button btnShowAllDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualCostAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
        private System.Windows.Forms.Button btnSearchByCourse;
        private System.Windows.Forms.Button btnSearchByCourseType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCostCount;
        private System.Windows.Forms.Label txtShowRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}