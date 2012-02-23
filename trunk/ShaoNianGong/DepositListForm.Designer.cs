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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depositDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositListBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.depositListTableAdapter = new Common.DepositListDataSetTableAdapters.DepositListTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDepositCount = new System.Windows.Forms.Label();
            this.txtShowRange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.depositDateDataGridViewTextBoxColumn,
            this.DepositDate,
            this.depositAmountDataGridViewTextBoxColumn,
            this.ActualPaidAmount,
            this.nameDataGridViewTextBoxColumn,
            this.ExpireTimeColumn,
            this.CourseName,
            this.TeacherName,
            this.OperatorColumn});
            this.dataGridView1.DataSource = this.depositListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // depositDateDataGridViewTextBoxColumn
            // 
            this.depositDateDataGridViewTextBoxColumn.DataPropertyName = "DepositDate";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.depositDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.depositDateDataGridViewTextBoxColumn.HeaderText = "充值日期";
            this.depositDateDataGridViewTextBoxColumn.Name = "depositDateDataGridViewTextBoxColumn";
            this.depositDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DepositDate
            // 
            this.DepositDate.DataPropertyName = "DepositDate";
            dataGridViewCellStyle5.Format = "t";
            this.DepositDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.DepositDate.HeaderText = "充值时间";
            this.DepositDate.Name = "DepositDate";
            this.DepositDate.ReadOnly = true;
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
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            this.ExpireTimeColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExpireTimeColumn.HeaderText = "缴费到期时间";
            this.ExpireTimeColumn.Name = "ExpireTimeColumn";
            this.ExpireTimeColumn.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "所学课程";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "任课教师";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.DataPropertyName = "Operator";
            this.OperatorColumn.HeaderText = "经办人";
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.ReadOnly = true;
            // 
            // depositListBindingSource
            // 
            this.depositListBindingSource.DataMember = "DepositList";
            this.depositListBindingSource.DataSource = this.depositListDataSet;
            this.depositListBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.depositListBindingSource_ListChanged);
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
            this.label3.Location = new System.Drawing.Point(476, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "起始日期：";
            // 
            // btnShowFilterDeposit
            // 
            this.btnShowFilterDeposit.Location = new System.Drawing.Point(682, 16);
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
            this.label4.Location = new System.Drawing.Point(476, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "终止日期：";
            // 
            // dtDepositBeginDate
            // 
            this.dtDepositBeginDate.Location = new System.Drawing.Point(547, 16);
            this.dtDepositBeginDate.Name = "dtDepositBeginDate";
            this.dtDepositBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositBeginDate.TabIndex = 9;
            // 
            // dtDepositEndDate
            // 
            this.dtDepositEndDate.Location = new System.Drawing.Point(547, 41);
            this.dtDepositEndDate.Name = "dtDepositEndDate";
            this.dtDepositEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositEndDate.TabIndex = 9;
            // 
            // depositListTableAdapter
            // 
            this.depositListTableAdapter.ClearBeforeFill = true;
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
            this.lblDepositCount.Location = new System.Drawing.Point(476, 11);
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
            this.label7.Location = new System.Drawing.Point(380, 11);
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
            // DepositListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 572);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepositListForm";
            this.Text = "充值汇总";
            this.Load += new System.EventHandler(this.DepositListForm_Load);
            this.Resize += new System.EventHandler(this.DepositListForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Common.DepositListDataSet depositListDataSet;
        private System.Windows.Forms.BindingSource depositListBindingSource;
        private Common.DepositListDataSetTableAdapters.DepositListTableAdapter depositListTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepositCount;
        private System.Windows.Forms.Label txtShowRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}