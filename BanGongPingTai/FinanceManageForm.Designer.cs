namespace BanGongPingTai
{
    partial class FinanceManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDepositEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtDepositBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowThisMonthDeposit = new System.Windows.Forms.Button();
            this.btnShowFilterDeposit = new System.Windows.Forms.Button();
            this.btnShowAllDeposit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.txtTotalDeposit = new System.Windows.Forms.TextBox();
            this.financeManageDataSet = new BanGongPingTai.FinanceManageDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtBuyEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtOriginalCost = new System.Windows.Forms.TextBox();
            this.dtBuyBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterialsCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowThisMonthBuy = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowFilterBuy = new System.Windows.Forms.Button();
            this.btnShowAllBuy = new System.Windows.Forms.Button();
            this.materialsBuyTableAdapter = new BanGongPingTai.FinanceManageDataSetTableAdapters.MaterialsBuyTableAdapter();
            this.depositListTableAdapter = new Common.DepositListDataSetTableAdapters.DepositListTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeManageDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBuyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(117, 53);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(120, 21);
            this.txtTotalPaid.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDepositEndDate);
            this.groupBox1.Controls.Add(this.dtDepositBeginDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnShowThisMonthDeposit);
            this.groupBox1.Controls.Add(this.btnShowFilterDeposit);
            this.groupBox1.Controls.Add(this.btnShowAllDeposit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtTotalDeposit);
            this.groupBox1.Controls.Add(this.txtTotalPaid);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 345);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收入汇总";
            // 
            // dtDepositEndDate
            // 
            this.dtDepositEndDate.Location = new System.Drawing.Point(557, 51);
            this.dtDepositEndDate.Name = "dtDepositEndDate";
            this.dtDepositEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositEndDate.TabIndex = 24;
            // 
            // dtDepositBeginDate
            // 
            this.dtDepositBeginDate.Location = new System.Drawing.Point(557, 26);
            this.dtDepositBeginDate.Name = "dtDepositBeginDate";
            this.dtDepositBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositBeginDate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "终止日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "起始日期：";
            // 
            // btnShowThisMonthDeposit
            // 
            this.btnShowThisMonthDeposit.Location = new System.Drawing.Point(257, 26);
            this.btnShowThisMonthDeposit.Name = "btnShowThisMonthDeposit";
            this.btnShowThisMonthDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthDeposit.TabIndex = 21;
            this.btnShowThisMonthDeposit.Text = "查看本月";
            this.btnShowThisMonthDeposit.UseVisualStyleBackColor = true;
            this.btnShowThisMonthDeposit.Click += new System.EventHandler(this.btnShowThisMonthDeposit_Click);
            // 
            // btnShowFilterDeposit
            // 
            this.btnShowFilterDeposit.Location = new System.Drawing.Point(692, 26);
            this.btnShowFilterDeposit.Name = "btnShowFilterDeposit";
            this.btnShowFilterDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterDeposit.TabIndex = 20;
            this.btnShowFilterDeposit.Text = "筛选";
            this.btnShowFilterDeposit.UseVisualStyleBackColor = true;
            this.btnShowFilterDeposit.Click += new System.EventHandler(this.btnShowFilterDeposit_Click);
            // 
            // btnShowAllDeposit
            // 
            this.btnShowAllDeposit.Location = new System.Drawing.Point(359, 26);
            this.btnShowAllDeposit.Name = "btnShowAllDeposit";
            this.btnShowAllDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowAllDeposit.TabIndex = 19;
            this.btnShowAllDeposit.Text = "查看所有";
            this.btnShowAllDeposit.UseVisualStyleBackColor = true;
            this.btnShowAllDeposit.Click += new System.EventHandler(this.btnShowAllDeposit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "实收金额汇总：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "充值金额汇总：";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(896, 257);
            this.dataGridView1.TabIndex = 14;
            // 
            // depositDateDataGridViewTextBoxColumn
            // 
            this.depositDateDataGridViewTextBoxColumn.DataPropertyName = "DepositDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.depositDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.depositDateDataGridViewTextBoxColumn.HeaderText = "充值日期";
            this.depositDateDataGridViewTextBoxColumn.Name = "depositDateDataGridViewTextBoxColumn";
            this.depositDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DepositDate
            // 
            this.DepositDate.DataPropertyName = "DepositDate";
            dataGridViewCellStyle2.Format = "t";
            this.DepositDate.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.ExpireTimeColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            // txtTotalDeposit
            // 
            this.txtTotalDeposit.Location = new System.Drawing.Point(117, 23);
            this.txtTotalDeposit.Name = "txtTotalDeposit";
            this.txtTotalDeposit.ReadOnly = true;
            this.txtTotalDeposit.Size = new System.Drawing.Size(120, 21);
            this.txtTotalDeposit.TabIndex = 13;
            // 
            // financeManageDataSet
            // 
            this.financeManageDataSet.DataSetName = "FinanceManageDataSet";
            this.financeManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtBuyEndDate);
            this.groupBox3.Controls.Add(this.txtOriginalCost);
            this.groupBox3.Controls.Add(this.dtBuyBeginDate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMaterialsCost);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnShowThisMonthBuy);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.btnShowFilterBuy);
            this.groupBox3.Controls.Add(this.btnShowAllBuy);
            this.groupBox3.Location = new System.Drawing.Point(10, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(911, 289);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "支出汇总";
            // 
            // dtBuyEndDate
            // 
            this.dtBuyEndDate.Location = new System.Drawing.Point(557, 53);
            this.dtBuyEndDate.Name = "dtBuyEndDate";
            this.dtBuyEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtBuyEndDate.TabIndex = 31;
            // 
            // txtOriginalCost
            // 
            this.txtOriginalCost.Location = new System.Drawing.Point(117, 52);
            this.txtOriginalCost.Name = "txtOriginalCost";
            this.txtOriginalCost.ReadOnly = true;
            this.txtOriginalCost.Size = new System.Drawing.Size(120, 21);
            this.txtOriginalCost.TabIndex = 10;
            // 
            // dtBuyBeginDate
            // 
            this.dtBuyBeginDate.Location = new System.Drawing.Point(557, 28);
            this.dtBuyBeginDate.Name = "dtBuyBeginDate";
            this.dtBuyBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtBuyBeginDate.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "原价汇总：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "终止日期：";
            // 
            // txtMaterialsCost
            // 
            this.txtMaterialsCost.Location = new System.Drawing.Point(117, 25);
            this.txtMaterialsCost.Name = "txtMaterialsCost";
            this.txtMaterialsCost.ReadOnly = true;
            this.txtMaterialsCost.Size = new System.Drawing.Size(120, 21);
            this.txtMaterialsCost.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "起始日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "材料购买汇总：";
            // 
            // btnShowThisMonthBuy
            // 
            this.btnShowThisMonthBuy.Location = new System.Drawing.Point(257, 28);
            this.btnShowThisMonthBuy.Name = "btnShowThisMonthBuy";
            this.btnShowThisMonthBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthBuy.TabIndex = 28;
            this.btnShowThisMonthBuy.Text = "查看本月";
            this.btnShowThisMonthBuy.UseVisualStyleBackColor = true;
            this.btnShowThisMonthBuy.Click += new System.EventHandler(this.btnShowThisMonthBuy_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyDateDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.actualPayDataGridViewTextBoxColumn,
            this.materialPriceDataGridViewTextBoxColumn,
            this.buyAmountDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.Operator});
            this.dataGridView3.DataSource = this.materialsBuyBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(9, 83);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(896, 200);
            this.dataGridView3.TabIndex = 7;
            // 
            // buyDateDataGridViewTextBoxColumn
            // 
            this.buyDateDataGridViewTextBoxColumn.DataPropertyName = "BuyDate";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.buyDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.buyDateDataGridViewTextBoxColumn.HeaderText = "购买日期";
            this.buyDateDataGridViewTextBoxColumn.Name = "buyDateDataGridViewTextBoxColumn";
            this.buyDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "材料名称";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "材料总价";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualPayDataGridViewTextBoxColumn
            // 
            this.actualPayDataGridViewTextBoxColumn.DataPropertyName = "ActualPay";
            this.actualPayDataGridViewTextBoxColumn.HeaderText = "实际价格";
            this.actualPayDataGridViewTextBoxColumn.Name = "actualPayDataGridViewTextBoxColumn";
            this.actualPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialPriceDataGridViewTextBoxColumn
            // 
            this.materialPriceDataGridViewTextBoxColumn.DataPropertyName = "MaterialPrice";
            this.materialPriceDataGridViewTextBoxColumn.HeaderText = "材料单价";
            this.materialPriceDataGridViewTextBoxColumn.Name = "materialPriceDataGridViewTextBoxColumn";
            this.materialPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyAmountDataGridViewTextBoxColumn
            // 
            this.buyAmountDataGridViewTextBoxColumn.DataPropertyName = "BuyAmount";
            this.buyAmountDataGridViewTextBoxColumn.HeaderText = "购买数量";
            this.buyAmountDataGridViewTextBoxColumn.Name = "buyAmountDataGridViewTextBoxColumn";
            this.buyAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "Operator";
            this.Operator.HeaderText = "经办人";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // materialsBuyBindingSource
            // 
            this.materialsBuyBindingSource.DataMember = "MaterialsBuy";
            this.materialsBuyBindingSource.DataSource = this.financeManageDataSet;
            this.materialsBuyBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.materialsBuyBindingSource_ListChanged);
            // 
            // btnShowFilterBuy
            // 
            this.btnShowFilterBuy.Location = new System.Drawing.Point(692, 28);
            this.btnShowFilterBuy.Name = "btnShowFilterBuy";
            this.btnShowFilterBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterBuy.TabIndex = 27;
            this.btnShowFilterBuy.Text = "筛选";
            this.btnShowFilterBuy.UseVisualStyleBackColor = true;
            this.btnShowFilterBuy.Click += new System.EventHandler(this.btnShowFilterBuy_Click);
            // 
            // btnShowAllBuy
            // 
            this.btnShowAllBuy.Location = new System.Drawing.Point(359, 28);
            this.btnShowAllBuy.Name = "btnShowAllBuy";
            this.btnShowAllBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowAllBuy.TabIndex = 26;
            this.btnShowAllBuy.Text = "查看所有";
            this.btnShowAllBuy.UseVisualStyleBackColor = true;
            this.btnShowAllBuy.Click += new System.EventHandler(this.btnShowAllBuy_Click);
            // 
            // materialsBuyTableAdapter
            // 
            this.materialsBuyTableAdapter.ClearBeforeFill = true;
            // 
            // depositListTableAdapter
            // 
            this.depositListTableAdapter.ClearBeforeFill = true;
            // 
            // FinanceManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 676);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FinanceManageForm";
            this.Text = "账目汇总";
            this.Load += new System.EventHandler(this.FinanceManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeManageDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBuyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaterialsCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private FinanceManageDataSet financeManageDataSet;
        private System.Windows.Forms.TextBox txtTotalDeposit;
        private System.Windows.Forms.BindingSource materialsBuyBindingSource;
        private FinanceManageDataSetTableAdapters.MaterialsBuyTableAdapter materialsBuyTableAdapter;
        private System.Windows.Forms.TextBox txtOriginalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource depositListBindingSource;
        private Common.DepositListDataSet depositListDataSet;
        private Common.DepositListDataSetTableAdapters.DepositListTableAdapter depositListTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtDepositEndDate;
        private System.Windows.Forms.DateTimePicker dtDepositBeginDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowThisMonthDeposit;
        private System.Windows.Forms.Button btnShowFilterDeposit;
        private System.Windows.Forms.Button btnShowAllDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DateTimePicker dtBuyEndDate;
        private System.Windows.Forms.DateTimePicker dtBuyBeginDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowThisMonthBuy;
        private System.Windows.Forms.Button btnShowFilterBuy;
        private System.Windows.Forms.Button btnShowAllBuy;

    }
}