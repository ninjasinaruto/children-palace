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
            this.dgvCost = new System.Windows.Forms.DataGridView();
            this.costListDataSet = new ShaoNianGong.CostListDataSet();
            this.costListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costListTableAdapter = new ShaoNianGong.CostListDataSetTableAdapters.CostListTableAdapter();
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
            this.dtDepositEndDate.Location = new System.Drawing.Point(547, 41);
            this.dtDepositEndDate.Name = "dtDepositEndDate";
            this.dtDepositEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositEndDate.TabIndex = 20;
            // 
            // dtDepositBeginDate
            // 
            this.dtDepositBeginDate.Location = new System.Drawing.Point(547, 16);
            this.dtDepositBeginDate.Name = "dtDepositBeginDate";
            this.dtDepositBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositBeginDate.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "终止日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 20);
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
            this.btnShowFilterDeposit.Location = new System.Drawing.Point(682, 16);
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
            this.dgvCost.Size = new System.Drawing.Size(1183, 481);
            this.dgvCost.TabIndex = 1;
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
            // CostListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 572);
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
    }
}