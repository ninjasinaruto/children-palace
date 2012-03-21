namespace BanGongPingTai
{
    partial class TeacherSigninManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStime = new System.Windows.Forms.DateTimePicker();
            this.dtEtime = new System.Windows.Forms.DateTimePicker();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.btnSearchByMonth = new System.Windows.Forms.Button();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.dgvSigninReport = new System.Windows.Forms.DataGridView();
            this.teacherSigninReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersDataSet = new BanGongPingTai.TeachersDataSet();
            this.teacherSigninReportTableAdapter = new BanGongPingTai.TeachersDataSetTableAdapters.TeacherSigninReportTableAdapter();
            this.btnSearchByDay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSigninCount = new System.Windows.Forms.Label();
            this.txtShowRange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemark = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.ReportSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTimeOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTimeOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTimeTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTimeTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTimeThreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTimeThreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sickLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beLateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveEarlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSigninReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSigninReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "结束日期：";
            // 
            // dtStime
            // 
            this.dtStime.CustomFormat = "";
            this.dtStime.Location = new System.Drawing.Point(275, 10);
            this.dtStime.Name = "dtStime";
            this.dtStime.Size = new System.Drawing.Size(119, 21);
            this.dtStime.TabIndex = 2;
            // 
            // dtEtime
            // 
            this.dtEtime.CustomFormat = "";
            this.dtEtime.Location = new System.Drawing.Point(475, 10);
            this.dtEtime.Name = "dtEtime";
            this.dtEtime.Size = new System.Drawing.Size(119, 21);
            this.dtEtime.TabIndex = 3;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(603, 9);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByDate.TabIndex = 4;
            this.btnSearchByDate.Text = "筛选";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // btnSearchByMonth
            // 
            this.btnSearchByMonth.Location = new System.Drawing.Point(765, 9);
            this.btnSearchByMonth.Name = "btnSearchByMonth";
            this.btnSearchByMonth.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByMonth.TabIndex = 6;
            this.btnSearchByMonth.Text = "查看本月";
            this.btnSearchByMonth.UseVisualStyleBackColor = true;
            this.btnSearchByMonth.Click += new System.EventHandler(this.btnSearchByMonth_Click);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(846, 9);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAll.TabIndex = 7;
            this.btnSearchAll.Text = "查看所有";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // dgvSigninReport
            // 
            this.dgvSigninReport.AllowUserToAddRows = false;
            this.dgvSigninReport.AllowUserToDeleteRows = false;
            this.dgvSigninReport.AllowUserToResizeRows = false;
            this.dgvSigninReport.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSigninReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSigninReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSigninReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportSeq,
            this.teacherNameDataGridViewTextBoxColumn,
            this.signinDateDataGridViewTextBoxColumn,
            this.dayOfWeekDataGridViewTextBoxColumn,
            this.sTimeOneDataGridViewTextBoxColumn,
            this.eTimeOneDataGridViewTextBoxColumn,
            this.sTimeTwoDataGridViewTextBoxColumn,
            this.eTimeTwoDataGridViewTextBoxColumn,
            this.sTimeThreeDataGridViewTextBoxColumn,
            this.eTimeThreeDataGridViewTextBoxColumn,
            this.leaveDataGridViewTextBoxColumn,
            this.sickLeaveDataGridViewTextBoxColumn,
            this.goOutDataGridViewTextBoxColumn,
            this.beLateDataGridViewTextBoxColumn,
            this.leaveEarlyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn});
            this.dgvSigninReport.DataSource = this.teacherSigninReportBindingSource;
            this.dgvSigninReport.Location = new System.Drawing.Point(12, 40);
            this.dgvSigninReport.MultiSelect = false;
            this.dgvSigninReport.Name = "dgvSigninReport";
            this.dgvSigninReport.ReadOnly = true;
            this.dgvSigninReport.RowHeadersVisible = false;
            this.dgvSigninReport.RowTemplate.Height = 23;
            this.dgvSigninReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSigninReport.Size = new System.Drawing.Size(1104, 182);
            this.dgvSigninReport.TabIndex = 51;
            this.dgvSigninReport.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSigninReport_DataBindingComplete);
            // 
            // teacherSigninReportBindingSource
            // 
            this.teacherSigninReportBindingSource.DataMember = "TeacherSigninReport";
            this.teacherSigninReportBindingSource.DataSource = this.teachersDataSet;
            this.teacherSigninReportBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.teacherSigninReportBindingSource_ListChanged);
            // 
            // teachersDataSet
            // 
            this.teachersDataSet.DataSetName = "TeachersDataSet";
            this.teachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherSigninReportTableAdapter
            // 
            this.teacherSigninReportTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearchByDay
            // 
            this.btnSearchByDay.Location = new System.Drawing.Point(684, 9);
            this.btnSearchByDay.Name = "btnSearchByDay";
            this.btnSearchByDay.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByDay.TabIndex = 5;
            this.btnSearchByDay.Text = "查看今天";
            this.btnSearchByDay.UseVisualStyleBackColor = true;
            this.btnSearchByDay.Click += new System.EventHandler(this.btnSearchByDay_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSigninCount);
            this.panel1.Controls.Add(this.txtShowRange);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 34);
            this.panel1.TabIndex = 53;
            // 
            // lblSigninCount
            // 
            this.lblSigninCount.AutoSize = true;
            this.lblSigninCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSigninCount.Location = new System.Drawing.Point(594, 11);
            this.lblSigninCount.Name = "lblSigninCount";
            this.lblSigninCount.Size = new System.Drawing.Size(25, 12);
            this.lblSigninCount.TabIndex = 28;
            this.lblSigninCount.Text = "0条";
            // 
            // txtShowRange
            // 
            this.txtShowRange.AutoSize = true;
            this.txtShowRange.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShowRange.Location = new System.Drawing.Point(107, 11);
            this.txtShowRange.Name = "txtShowRange";
            this.txtShowRange.Size = new System.Drawing.Size(31, 12);
            this.txtShowRange.TabIndex = 29;
            this.txtShowRange.Text = "今天";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "考勤记录总数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "当前显示范围：";
            // 
            // btnRemark
            // 
            this.btnRemark.Location = new System.Drawing.Point(927, 9);
            this.btnRemark.Name = "btnRemark";
            this.btnRemark.Size = new System.Drawing.Size(75, 23);
            this.btnRemark.TabIndex = 8;
            this.btnRemark.Text = "备注";
            this.btnRemark.UseVisualStyleBackColor = true;
            this.btnRemark.Click += new System.EventHandler(this.btnRemark_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "教师姓名：";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(95, 9);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(100, 21);
            this.txtTeacherName.TabIndex = 1;
            // 
            // ReportSeq
            // 
            this.ReportSeq.HeaderText = "序号";
            this.ReportSeq.Name = "ReportSeq";
            this.ReportSeq.ReadOnly = true;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.teacherNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // signinDateDataGridViewTextBoxColumn
            // 
            this.signinDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.signinDateDataGridViewTextBoxColumn.DataPropertyName = "SigninDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.signinDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.signinDateDataGridViewTextBoxColumn.HeaderText = "考勤日期";
            this.signinDateDataGridViewTextBoxColumn.Name = "signinDateDataGridViewTextBoxColumn";
            this.signinDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.signinDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // dayOfWeekDataGridViewTextBoxColumn
            // 
            this.dayOfWeekDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dayOfWeekDataGridViewTextBoxColumn.DataPropertyName = "DayOfWeek";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dayOfWeekDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dayOfWeekDataGridViewTextBoxColumn.HeaderText = "星期";
            this.dayOfWeekDataGridViewTextBoxColumn.Name = "dayOfWeekDataGridViewTextBoxColumn";
            this.dayOfWeekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTimeOneDataGridViewTextBoxColumn
            // 
            this.sTimeOneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sTimeOneDataGridViewTextBoxColumn.DataPropertyName = "STimeOne";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "T";
            dataGridViewCellStyle5.NullValue = null;
            this.sTimeOneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sTimeOneDataGridViewTextBoxColumn.HeaderText = "上班1";
            this.sTimeOneDataGridViewTextBoxColumn.Name = "sTimeOneDataGridViewTextBoxColumn";
            this.sTimeOneDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTimeOneDataGridViewTextBoxColumn.Width = 80;
            // 
            // eTimeOneDataGridViewTextBoxColumn
            // 
            this.eTimeOneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eTimeOneDataGridViewTextBoxColumn.DataPropertyName = "ETimeOne";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "T";
            dataGridViewCellStyle6.NullValue = null;
            this.eTimeOneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.eTimeOneDataGridViewTextBoxColumn.HeaderText = "下班1";
            this.eTimeOneDataGridViewTextBoxColumn.Name = "eTimeOneDataGridViewTextBoxColumn";
            this.eTimeOneDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTimeOneDataGridViewTextBoxColumn.Width = 80;
            // 
            // sTimeTwoDataGridViewTextBoxColumn
            // 
            this.sTimeTwoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sTimeTwoDataGridViewTextBoxColumn.DataPropertyName = "STimeTwo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "T";
            dataGridViewCellStyle7.NullValue = null;
            this.sTimeTwoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.sTimeTwoDataGridViewTextBoxColumn.HeaderText = "上班2";
            this.sTimeTwoDataGridViewTextBoxColumn.Name = "sTimeTwoDataGridViewTextBoxColumn";
            this.sTimeTwoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTimeTwoDataGridViewTextBoxColumn.Width = 80;
            // 
            // eTimeTwoDataGridViewTextBoxColumn
            // 
            this.eTimeTwoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eTimeTwoDataGridViewTextBoxColumn.DataPropertyName = "ETimeTwo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "T";
            dataGridViewCellStyle8.NullValue = null;
            this.eTimeTwoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.eTimeTwoDataGridViewTextBoxColumn.HeaderText = "下班2";
            this.eTimeTwoDataGridViewTextBoxColumn.Name = "eTimeTwoDataGridViewTextBoxColumn";
            this.eTimeTwoDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTimeTwoDataGridViewTextBoxColumn.Width = 80;
            // 
            // sTimeThreeDataGridViewTextBoxColumn
            // 
            this.sTimeThreeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sTimeThreeDataGridViewTextBoxColumn.DataPropertyName = "STimeThree";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "T";
            dataGridViewCellStyle9.NullValue = null;
            this.sTimeThreeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.sTimeThreeDataGridViewTextBoxColumn.HeaderText = "上班3";
            this.sTimeThreeDataGridViewTextBoxColumn.Name = "sTimeThreeDataGridViewTextBoxColumn";
            this.sTimeThreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTimeThreeDataGridViewTextBoxColumn.Width = 80;
            // 
            // eTimeThreeDataGridViewTextBoxColumn
            // 
            this.eTimeThreeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eTimeThreeDataGridViewTextBoxColumn.DataPropertyName = "ETimeThree";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "T";
            dataGridViewCellStyle10.NullValue = null;
            this.eTimeThreeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.eTimeThreeDataGridViewTextBoxColumn.HeaderText = "下班3";
            this.eTimeThreeDataGridViewTextBoxColumn.Name = "eTimeThreeDataGridViewTextBoxColumn";
            this.eTimeThreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTimeThreeDataGridViewTextBoxColumn.Width = 80;
            // 
            // leaveDataGridViewTextBoxColumn
            // 
            this.leaveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.leaveDataGridViewTextBoxColumn.DataPropertyName = "Leave";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Format = "N1";
            dataGridViewCellStyle11.NullValue = null;
            this.leaveDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.leaveDataGridViewTextBoxColumn.HeaderText = "事假（天）";
            this.leaveDataGridViewTextBoxColumn.Name = "leaveDataGridViewTextBoxColumn";
            this.leaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaveDataGridViewTextBoxColumn.Width = 90;
            // 
            // sickLeaveDataGridViewTextBoxColumn
            // 
            this.sickLeaveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sickLeaveDataGridViewTextBoxColumn.DataPropertyName = "SickLeave";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "N1";
            dataGridViewCellStyle12.NullValue = null;
            this.sickLeaveDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.sickLeaveDataGridViewTextBoxColumn.HeaderText = "病假（天）";
            this.sickLeaveDataGridViewTextBoxColumn.Name = "sickLeaveDataGridViewTextBoxColumn";
            this.sickLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.sickLeaveDataGridViewTextBoxColumn.Width = 90;
            // 
            // goOutDataGridViewTextBoxColumn
            // 
            this.goOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.goOutDataGridViewTextBoxColumn.DataPropertyName = "GoOut";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N1";
            dataGridViewCellStyle13.NullValue = null;
            this.goOutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.goOutDataGridViewTextBoxColumn.HeaderText = "外出（时）";
            this.goOutDataGridViewTextBoxColumn.Name = "goOutDataGridViewTextBoxColumn";
            this.goOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.goOutDataGridViewTextBoxColumn.Width = 90;
            // 
            // beLateDataGridViewTextBoxColumn
            // 
            this.beLateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.beLateDataGridViewTextBoxColumn.DataPropertyName = "BeLate";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            this.beLateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.beLateDataGridViewTextBoxColumn.HeaderText = "迟到（分）";
            this.beLateDataGridViewTextBoxColumn.Name = "beLateDataGridViewTextBoxColumn";
            this.beLateDataGridViewTextBoxColumn.ReadOnly = true;
            this.beLateDataGridViewTextBoxColumn.Width = 90;
            // 
            // leaveEarlyDataGridViewTextBoxColumn
            // 
            this.leaveEarlyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.leaveEarlyDataGridViewTextBoxColumn.DataPropertyName = "LeaveEarly";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = null;
            this.leaveEarlyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.leaveEarlyDataGridViewTextBoxColumn.HeaderText = "早退（分）";
            this.leaveEarlyDataGridViewTextBoxColumn.Name = "leaveEarlyDataGridViewTextBoxColumn";
            this.leaveEarlyDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaveEarlyDataGridViewTextBoxColumn.Width = 90;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarkDataGridViewTextBoxColumn.Width = 300;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "经办人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 80;
            // 
            // TeacherSigninManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 508);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemark);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchByDay);
            this.Controls.Add(this.dgvSigninReport);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.btnSearchByMonth);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.dtEtime);
            this.Controls.Add(this.dtStime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherSigninManageForm";
            this.Text = "教师考勤汇总";
            this.Load += new System.EventHandler(this.TeacherSigninManageForm_Load);
            this.Resize += new System.EventHandler(this.TeacherSigninManageForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSigninReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSigninReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStime;
        private System.Windows.Forms.DateTimePicker dtEtime;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Button btnSearchByMonth;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.DataGridView dgvSigninReport;
        private System.Windows.Forms.BindingSource teacherSigninReportBindingSource;
        private TeachersDataSet teachersDataSet;
        private TeachersDataSetTableAdapters.TeacherSigninReportTableAdapter teacherSigninReportTableAdapter;
        private System.Windows.Forms.Button btnSearchByDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSigninCount;
        private System.Windows.Forms.Label txtShowRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTimeOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTimeOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTimeTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTimeTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTimeThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTimeThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beLateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveEarlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
    }
}