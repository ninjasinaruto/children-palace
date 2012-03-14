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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDepositCount = new System.Windows.Forms.Label();
            this.txtShowDepositRange = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchDepositByCourseWithDate = new System.Windows.Forms.Button();
            this.btnSearchDepositByCourseTypeWithDate = new System.Windows.Forms.Button();
            this.btnSearchDepositByCourseType = new System.Windows.Forms.Button();
            this.btnSearchDepositByCourse = new System.Windows.Forms.Button();
            this.dtDepositEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtDepositBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowThisMonthDeposit = new System.Windows.Forms.Button();
            this.btnShowFilterDeposit = new System.Windows.Forms.Button();
            this.btnShowAllDeposit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDeposit = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseSubtypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositListDataSet = new Common.DepositListDataSet();
            this.txtTotalDeposit = new System.Windows.Forms.TextBox();
            this.depositListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeManageDataSet = new BanGongPingTai.FinanceManageDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchBuyByMaterialNameWithDate = new System.Windows.Forms.Button();
            this.btnSearchBuyByMaterialName = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuyCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtShowBuyRange = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtBuyEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtOriginalCost = new System.Windows.Forms.TextBox();
            this.dtBuyBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterialsCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowThisMonthBuy = new System.Windows.Forms.Button();
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowFilterBuy = new System.Windows.Forms.Button();
            this.btnShowAllBuy = new System.Windows.Forms.Button();
            this.materialsBuyTableAdapter = new BanGongPingTai.FinanceManageDataSetTableAdapters.MaterialsBuyTableAdapter();
            this.depositListTableAdapter = new Common.DepositListDataSetTableAdapters.DepositListTableAdapter();
            this.studentDepositListTableAdapter = new Common.DepositListDataSetTableAdapters.StudentDepositListTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeManageDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
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
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnSearchDepositByCourseWithDate);
            this.groupBox1.Controls.Add(this.btnSearchDepositByCourseTypeWithDate);
            this.groupBox1.Controls.Add(this.btnSearchDepositByCourseType);
            this.groupBox1.Controls.Add(this.btnSearchDepositByCourse);
            this.groupBox1.Controls.Add(this.dtDepositEndDate);
            this.groupBox1.Controls.Add(this.dtDepositBeginDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnShowThisMonthDeposit);
            this.groupBox1.Controls.Add(this.btnShowFilterDeposit);
            this.groupBox1.Controls.Add(this.btnShowAllDeposit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvDeposit);
            this.groupBox1.Controls.Add(this.txtTotalDeposit);
            this.groupBox1.Controls.Add(this.txtTotalPaid);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 345);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收入汇总";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDepositCount);
            this.panel1.Controls.Add(this.txtShowDepositRange);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(6, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 33);
            this.panel1.TabIndex = 37;
            // 
            // lblDepositCount
            // 
            this.lblDepositCount.AutoSize = true;
            this.lblDepositCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDepositCount.Location = new System.Drawing.Point(793, 11);
            this.lblDepositCount.Name = "lblDepositCount";
            this.lblDepositCount.Size = new System.Drawing.Size(25, 12);
            this.lblDepositCount.TabIndex = 28;
            this.lblDepositCount.Text = "0条";
            // 
            // txtShowDepositRange
            // 
            this.txtShowDepositRange.AutoSize = true;
            this.txtShowDepositRange.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShowDepositRange.Location = new System.Drawing.Point(105, 11);
            this.txtShowDepositRange.Name = "txtShowDepositRange";
            this.txtShowDepositRange.Size = new System.Drawing.Size(31, 12);
            this.txtShowDepositRange.TabIndex = 29;
            this.txtShowDepositRange.Text = "所有";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(697, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "充值记录总数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "当前显示范围：";
            // 
            // btnSearchDepositByCourseWithDate
            // 
            this.btnSearchDepositByCourseWithDate.Location = new System.Drawing.Point(763, 26);
            this.btnSearchDepositByCourseWithDate.Name = "btnSearchDepositByCourseWithDate";
            this.btnSearchDepositByCourseWithDate.Size = new System.Drawing.Size(102, 36);
            this.btnSearchDepositByCourseWithDate.TabIndex = 36;
            this.btnSearchDepositByCourseWithDate.Text = "按课程日期查询";
            this.btnSearchDepositByCourseWithDate.UseVisualStyleBackColor = true;
            this.btnSearchDepositByCourseWithDate.Click += new System.EventHandler(this.btnSearchDepositByCourseWithDate_Click);
            // 
            // btnSearchDepositByCourseTypeWithDate
            // 
            this.btnSearchDepositByCourseTypeWithDate.Location = new System.Drawing.Point(651, 26);
            this.btnSearchDepositByCourseTypeWithDate.Name = "btnSearchDepositByCourseTypeWithDate";
            this.btnSearchDepositByCourseTypeWithDate.Size = new System.Drawing.Size(106, 36);
            this.btnSearchDepositByCourseTypeWithDate.TabIndex = 35;
            this.btnSearchDepositByCourseTypeWithDate.Text = "按分类日期查询";
            this.btnSearchDepositByCourseTypeWithDate.UseVisualStyleBackColor = true;
            this.btnSearchDepositByCourseTypeWithDate.Click += new System.EventHandler(this.btnSearchDepositByCourseTypeWithDate_Click);
            // 
            // btnSearchDepositByCourseType
            // 
            this.btnSearchDepositByCourseType.Location = new System.Drawing.Point(447, 26);
            this.btnSearchDepositByCourseType.Name = "btnSearchDepositByCourseType";
            this.btnSearchDepositByCourseType.Size = new System.Drawing.Size(96, 36);
            this.btnSearchDepositByCourseType.TabIndex = 34;
            this.btnSearchDepositByCourseType.Text = "按分类查询";
            this.btnSearchDepositByCourseType.UseVisualStyleBackColor = true;
            this.btnSearchDepositByCourseType.Click += new System.EventHandler(this.btnSearchDepositByCourseType_Click);
            // 
            // btnSearchDepositByCourse
            // 
            this.btnSearchDepositByCourse.Location = new System.Drawing.Point(549, 26);
            this.btnSearchDepositByCourse.Name = "btnSearchDepositByCourse";
            this.btnSearchDepositByCourse.Size = new System.Drawing.Size(96, 36);
            this.btnSearchDepositByCourse.TabIndex = 33;
            this.btnSearchDepositByCourse.Text = "按课程查询";
            this.btnSearchDepositByCourse.UseVisualStyleBackColor = true;
            this.btnSearchDepositByCourse.Click += new System.EventHandler(this.btnSearchDepositByCourse_Click);
            // 
            // dtDepositEndDate
            // 
            this.dtDepositEndDate.Location = new System.Drawing.Point(946, 47);
            this.dtDepositEndDate.Name = "dtDepositEndDate";
            this.dtDepositEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositEndDate.TabIndex = 24;
            // 
            // dtDepositBeginDate
            // 
            this.dtDepositBeginDate.Location = new System.Drawing.Point(946, 22);
            this.dtDepositBeginDate.Name = "dtDepositBeginDate";
            this.dtDepositBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtDepositBeginDate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "终止日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(875, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "起始日期：";
            // 
            // btnShowThisMonthDeposit
            // 
            this.btnShowThisMonthDeposit.Location = new System.Drawing.Point(243, 26);
            this.btnShowThisMonthDeposit.Name = "btnShowThisMonthDeposit";
            this.btnShowThisMonthDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthDeposit.TabIndex = 21;
            this.btnShowThisMonthDeposit.Text = "查看本月";
            this.btnShowThisMonthDeposit.UseVisualStyleBackColor = true;
            this.btnShowThisMonthDeposit.Click += new System.EventHandler(this.btnShowThisMonthDeposit_Click);
            // 
            // btnShowFilterDeposit
            // 
            this.btnShowFilterDeposit.Location = new System.Drawing.Point(1081, 26);
            this.btnShowFilterDeposit.Name = "btnShowFilterDeposit";
            this.btnShowFilterDeposit.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterDeposit.TabIndex = 20;
            this.btnShowFilterDeposit.Text = "筛选";
            this.btnShowFilterDeposit.UseVisualStyleBackColor = true;
            this.btnShowFilterDeposit.Click += new System.EventHandler(this.btnShowFilterDeposit_Click);
            // 
            // btnShowAllDeposit
            // 
            this.btnShowAllDeposit.Location = new System.Drawing.Point(345, 26);
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
            this.CourseTypeName,
            this.CourseSubtypeName,
            this.CourseName,
            this.ChargeTypeName,
            this.TeacherName,
            this.OperatorColumn});
            this.dgvDeposit.DataSource = this.studentDepositBindingSource;
            this.dgvDeposit.Location = new System.Drawing.Point(6, 82);
            this.dgvDeposit.MultiSelect = false;
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.ReadOnly = true;
            this.dgvDeposit.RowHeadersVisible = false;
            this.dgvDeposit.RowTemplate.Height = 23;
            this.dgvDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeposit.Size = new System.Drawing.Size(1171, 218);
            this.dgvDeposit.TabIndex = 14;
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
            dataGridViewCellStyle10.Format = "F";
            dataGridViewCellStyle10.NullValue = null;
            this.depositDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Format = "D";
            dataGridViewCellStyle11.NullValue = null;
            this.ExpireTimeColumn.DefaultCellStyle = dataGridViewCellStyle11;
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
            // CourseTypeName
            // 
            this.CourseTypeName.DataPropertyName = "CourseTypeName";
            this.CourseTypeName.HeaderText = "课程类别";
            this.CourseTypeName.Name = "CourseTypeName";
            this.CourseTypeName.ReadOnly = true;
            // 
            // CourseSubtypeName
            // 
            this.CourseSubtypeName.DataPropertyName = "CourseSubtypeName";
            this.CourseSubtypeName.HeaderText = "课程科目";
            this.CourseSubtypeName.Name = "CourseSubtypeName";
            this.CourseSubtypeName.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // ChargeTypeName
            // 
            this.ChargeTypeName.DataPropertyName = "ChargeTypeName";
            this.ChargeTypeName.HeaderText = "课程收费类型";
            this.ChargeTypeName.Name = "ChargeTypeName";
            this.ChargeTypeName.ReadOnly = true;
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
            // studentDepositBindingSource
            // 
            this.studentDepositBindingSource.DataMember = "StudentDepositList";
            this.studentDepositBindingSource.DataSource = this.depositListDataSet;
            this.studentDepositBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.studentDepositBindingSource_ListChanged);
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
            // depositListBindingSource
            // 
            this.depositListBindingSource.DataMember = "DepositList";
            this.depositListBindingSource.DataSource = this.depositListDataSet;
            this.depositListBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.depositListBindingSource_ListChanged);
            // 
            // financeManageDataSet
            // 
            this.financeManageDataSet.DataSetName = "FinanceManageDataSet";
            this.financeManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchBuyByMaterialNameWithDate);
            this.groupBox3.Controls.Add(this.btnSearchBuyByMaterialName);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.dtBuyEndDate);
            this.groupBox3.Controls.Add(this.txtOriginalCost);
            this.groupBox3.Controls.Add(this.dtBuyBeginDate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMaterialsCost);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnShowThisMonthBuy);
            this.groupBox3.Controls.Add(this.dgvBuy);
            this.groupBox3.Controls.Add(this.btnShowFilterBuy);
            this.groupBox3.Controls.Add(this.btnShowAllBuy);
            this.groupBox3.Location = new System.Drawing.Point(10, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1183, 332);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "支出汇总";
            // 
            // btnSearchBuyByMaterialNameWithDate
            // 
            this.btnSearchBuyByMaterialNameWithDate.Location = new System.Drawing.Point(555, 28);
            this.btnSearchBuyByMaterialNameWithDate.Name = "btnSearchBuyByMaterialNameWithDate";
            this.btnSearchBuyByMaterialNameWithDate.Size = new System.Drawing.Size(124, 36);
            this.btnSearchBuyByMaterialNameWithDate.TabIndex = 40;
            this.btnSearchBuyByMaterialNameWithDate.Text = "按材料名称日期查询";
            this.btnSearchBuyByMaterialNameWithDate.UseVisualStyleBackColor = true;
            this.btnSearchBuyByMaterialNameWithDate.Click += new System.EventHandler(this.btnSearchBuyByMaterialNameWithDate_Click);
            // 
            // btnSearchBuyByMaterialName
            // 
            this.btnSearchBuyByMaterialName.Location = new System.Drawing.Point(447, 28);
            this.btnSearchBuyByMaterialName.Name = "btnSearchBuyByMaterialName";
            this.btnSearchBuyByMaterialName.Size = new System.Drawing.Size(102, 36);
            this.btnSearchBuyByMaterialName.TabIndex = 38;
            this.btnSearchBuyByMaterialName.Text = "按材料名称查询";
            this.btnSearchBuyByMaterialName.UseVisualStyleBackColor = true;
            this.btnSearchBuyByMaterialName.Click += new System.EventHandler(this.btnSearchBuyByMaterialName_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBuyCount);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtShowBuyRange);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(9, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 34);
            this.panel2.TabIndex = 33;
            // 
            // lblBuyCount
            // 
            this.lblBuyCount.AutoSize = true;
            this.lblBuyCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyCount.Location = new System.Drawing.Point(781, 12);
            this.lblBuyCount.Name = "lblBuyCount";
            this.lblBuyCount.Size = new System.Drawing.Size(25, 12);
            this.lblBuyCount.TabIndex = 28;
            this.lblBuyCount.Text = "0条";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "当前显示范围：";
            // 
            // txtShowBuyRange
            // 
            this.txtShowBuyRange.AutoSize = true;
            this.txtShowBuyRange.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShowBuyRange.Location = new System.Drawing.Point(103, 12);
            this.txtShowBuyRange.Name = "txtShowBuyRange";
            this.txtShowBuyRange.Size = new System.Drawing.Size(31, 12);
            this.txtShowBuyRange.TabIndex = 29;
            this.txtShowBuyRange.Text = "所有";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(685, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "购买记录总数：";
            // 
            // dtBuyEndDate
            // 
            this.dtBuyEndDate.Location = new System.Drawing.Point(774, 49);
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
            this.dtBuyBeginDate.Location = new System.Drawing.Point(774, 24);
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
            this.label2.Location = new System.Drawing.Point(703, 54);
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
            this.label4.Location = new System.Drawing.Point(703, 28);
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
            this.btnShowThisMonthBuy.Location = new System.Drawing.Point(243, 28);
            this.btnShowThisMonthBuy.Name = "btnShowThisMonthBuy";
            this.btnShowThisMonthBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthBuy.TabIndex = 28;
            this.btnShowThisMonthBuy.Text = "查看本月";
            this.btnShowThisMonthBuy.UseVisualStyleBackColor = true;
            this.btnShowThisMonthBuy.Click += new System.EventHandler(this.btnShowThisMonthBuy_Click);
            // 
            // dgvBuy
            // 
            this.dgvBuy.AllowUserToAddRows = false;
            this.dgvBuy.AllowUserToDeleteRows = false;
            this.dgvBuy.AllowUserToResizeRows = false;
            this.dgvBuy.AutoGenerateColumns = false;
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.buyDateDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn,
            this.materialPriceDataGridViewTextBoxColumn,
            this.actualPayDataGridViewTextBoxColumn,
            this.buyAmountDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.Operator});
            this.dgvBuy.DataSource = this.materialsBuyBindingSource;
            this.dgvBuy.Location = new System.Drawing.Point(9, 83);
            this.dgvBuy.MultiSelect = false;
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.ReadOnly = true;
            this.dgvBuy.RowHeadersVisible = false;
            this.dgvBuy.RowTemplate.Height = 23;
            this.dgvBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuy.Size = new System.Drawing.Size(1168, 200);
            this.dgvBuy.TabIndex = 7;
            this.dgvBuy.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBuy_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // buyDateDataGridViewTextBoxColumn
            // 
            this.buyDateDataGridViewTextBoxColumn.DataPropertyName = "BuyDate";
            dataGridViewCellStyle12.Format = "F";
            dataGridViewCellStyle12.NullValue = null;
            this.buyDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.buyDateDataGridViewTextBoxColumn.HeaderText = "购买日期";
            this.buyDateDataGridViewTextBoxColumn.Name = "buyDateDataGridViewTextBoxColumn";
            this.buyDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "材料名称";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialPriceDataGridViewTextBoxColumn
            // 
            this.materialPriceDataGridViewTextBoxColumn.DataPropertyName = "MaterialPrice";
            this.materialPriceDataGridViewTextBoxColumn.HeaderText = "材料单价";
            this.materialPriceDataGridViewTextBoxColumn.Name = "materialPriceDataGridViewTextBoxColumn";
            this.materialPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualPayDataGridViewTextBoxColumn
            // 
            this.actualPayDataGridViewTextBoxColumn.DataPropertyName = "ActualPay";
            this.actualPayDataGridViewTextBoxColumn.HeaderText = "实际价格";
            this.actualPayDataGridViewTextBoxColumn.Name = "actualPayDataGridViewTextBoxColumn";
            this.actualPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyAmountDataGridViewTextBoxColumn
            // 
            this.buyAmountDataGridViewTextBoxColumn.DataPropertyName = "BuyAmount";
            this.buyAmountDataGridViewTextBoxColumn.HeaderText = "购买数量";
            this.buyAmountDataGridViewTextBoxColumn.Name = "buyAmountDataGridViewTextBoxColumn";
            this.buyAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "材料总价";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.btnShowFilterBuy.Location = new System.Drawing.Point(909, 24);
            this.btnShowFilterBuy.Name = "btnShowFilterBuy";
            this.btnShowFilterBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterBuy.TabIndex = 27;
            this.btnShowFilterBuy.Text = "筛选";
            this.btnShowFilterBuy.UseVisualStyleBackColor = true;
            this.btnShowFilterBuy.Click += new System.EventHandler(this.btnShowFilterBuy_Click);
            // 
            // btnShowAllBuy
            // 
            this.btnShowAllBuy.Location = new System.Drawing.Point(345, 28);
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
            // studentDepositListTableAdapter
            // 
            this.studentDepositListTableAdapter.ClearBeforeFill = true;
            // 
            // FinanceManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 713);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FinanceManageForm";
            this.Text = "账目汇总";
            this.Load += new System.EventHandler(this.FinanceManageForm_Load);
            this.Resize += new System.EventHandler(this.FinanceManageForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeManageDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBuyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaterialsCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBuy;
        private FinanceManageDataSet financeManageDataSet;
        private System.Windows.Forms.TextBox txtTotalDeposit;
        private System.Windows.Forms.BindingSource materialsBuyBindingSource;
        private FinanceManageDataSetTableAdapters.MaterialsBuyTableAdapter materialsBuyTableAdapter;
        private System.Windows.Forms.TextBox txtOriginalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource depositListBindingSource;
        private Common.DepositListDataSet depositListDataSet;
        private Common.DepositListDataSetTableAdapters.DepositListTableAdapter depositListTableAdapter;
        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.DateTimePicker dtDepositEndDate;
        private System.Windows.Forms.DateTimePicker dtDepositBeginDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowThisMonthDeposit;
        private System.Windows.Forms.Button btnShowFilterDeposit;
        private System.Windows.Forms.Button btnShowAllDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtBuyEndDate;
        private System.Windows.Forms.DateTimePicker dtBuyBeginDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowThisMonthBuy;
        private System.Windows.Forms.Button btnShowFilterBuy;
        private System.Windows.Forms.Button btnShowAllBuy;
        private System.Windows.Forms.Button btnSearchDepositByCourseWithDate;
        private System.Windows.Forms.Button btnSearchDepositByCourseTypeWithDate;
        private System.Windows.Forms.Button btnSearchDepositByCourseType;
        private System.Windows.Forms.Button btnSearchDepositByCourse;
        private System.Windows.Forms.BindingSource studentDepositBindingSource;
        private Common.DepositListDataSetTableAdapters.StudentDepositListTableAdapter studentDepositListTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepositCount;
        private System.Windows.Forms.Label txtShowDepositRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBuyCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtShowBuyRange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearchBuyByMaterialNameWithDate;
        private System.Windows.Forms.Button btnSearchBuyByMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSubtypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChargeTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;

    }
}