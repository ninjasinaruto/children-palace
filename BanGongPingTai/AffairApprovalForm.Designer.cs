namespace BanGongPingTai
{
    partial class AffairApprovalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstUnprocessed = new System.Windows.Forms.ListBox();
            this.unprocessedAffairApplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.affairDataSet = new BanGongPingTai.Affair();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAffair = new System.Windows.Forms.DataGridView();
            this.affairApplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApplier = new System.Windows.Forms.TextBox();
            this.txtApplyTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtApprovalContent = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.affairApplyTableAdapter = new BanGongPingTai.AffairTableAdapters.AffairApplyTableAdapter();
            this.unprocessedAffairApplyTableAdapter = new BanGongPingTai.AffairTableAdapters.UnprocessedAffairApplyTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowAffairDetail = new System.Windows.Forms.Button();
            this.AffairSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approverUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchByApplyDate = new System.Windows.Forms.Button();
            this.btnSearchByCheckDate = new System.Windows.Forms.Button();
            this.btnReplyDate = new System.Windows.Forms.Button();
            this.btnSearchAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unprocessedAffairApplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairApplyBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUnprocessed
            // 
            this.lstUnprocessed.DataSource = this.unprocessedAffairApplyBindingSource;
            this.lstUnprocessed.DisplayMember = "ApplyTitle";
            this.lstUnprocessed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstUnprocessed.FormattingEnabled = true;
            this.lstUnprocessed.ItemHeight = 16;
            this.lstUnprocessed.Location = new System.Drawing.Point(15, 20);
            this.lstUnprocessed.Name = "lstUnprocessed";
            this.lstUnprocessed.Size = new System.Drawing.Size(158, 260);
            this.lstUnprocessed.TabIndex = 0;
            this.lstUnprocessed.ValueMember = "ID";
            // 
            // unprocessedAffairApplyBindingSource
            // 
            this.unprocessedAffairApplyBindingSource.DataMember = "UnprocessedAffairApply";
            this.unprocessedAffairApplyBindingSource.DataSource = this.affairDataSet;
            this.unprocessedAffairApplyBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.unprocessedAffairApplyBindingSource_ListChanged);
            this.unprocessedAffairApplyBindingSource.PositionChanged += new System.EventHandler(this.unprocessedAffairApplyBindingSource_PositionChanged);
            // 
            // affairDataSet
            // 
            this.affairDataSet.DataSetName = "Affair";
            this.affairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(152, 248);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(108, 31);
            this.btnApprove.TabIndex = 14;
            this.btnApprove.Text = "事务回复";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtContent
            // 
            this.txtContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unprocessedAffairApplyBindingSource, "ApplyContent", true));
            this.txtContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(96, 124);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(379, 155);
            this.txtContent.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unprocessedAffairApplyBindingSource, "ApplyTitle", true));
            this.txtTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(96, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(379, 26);
            this.txtTitle.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "事务内容：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "事务标题：";
            // 
            // dgvAffair
            // 
            this.dgvAffair.AllowUserToAddRows = false;
            this.dgvAffair.AllowUserToDeleteRows = false;
            this.dgvAffair.AllowUserToResizeRows = false;
            this.dgvAffair.AutoGenerateColumns = false;
            this.dgvAffair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAffair.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvAffair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAffair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AffairSeq,
            this.userNameDataGridViewTextBoxColumn,
            this.applyTitleDataGridViewTextBoxColumn,
            this.applyDateDataGridViewTextBoxColumn,
            this.applyContentDataGridViewTextBoxColumn,
            this.ApprovalStatusColumn,
            this.approverUserNameDataGridViewTextBoxColumn,
            this.CheckDate,
            this.ApprovalDate,
            this.approvalContentDataGridViewTextBoxColumn});
            this.dgvAffair.DataSource = this.affairApplyBindingSource;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAffair.DefaultCellStyle = dataGridViewCellStyle40;
            this.dgvAffair.Location = new System.Drawing.Point(12, 374);
            this.dgvAffair.MultiSelect = false;
            this.dgvAffair.Name = "dgvAffair";
            this.dgvAffair.ReadOnly = true;
            this.dgvAffair.RowHeadersVisible = false;
            this.dgvAffair.RowTemplate.Height = 23;
            this.dgvAffair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAffair.Size = new System.Drawing.Size(982, 291);
            this.dgvAffair.TabIndex = 17;
            this.dgvAffair.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAffair_DataBindingComplete);
            // 
            // affairApplyBindingSource
            // 
            this.affairApplyBindingSource.DataMember = "AffairApply";
            this.affairApplyBindingSource.DataSource = this.affairDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "已处理事务：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.txtApplier);
            this.groupBox1.Controls.Add(this.txtApplyTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(210, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 291);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // txtApplier
            // 
            this.txtApplier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unprocessedAffairApplyBindingSource, "UserName", true));
            this.txtApplier.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApplier.Location = new System.Drawing.Point(96, 90);
            this.txtApplier.Name = "txtApplier";
            this.txtApplier.ReadOnly = true;
            this.txtApplier.Size = new System.Drawing.Size(379, 26);
            this.txtApplier.TabIndex = 12;
            // 
            // txtApplyTime
            // 
            this.txtApplyTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unprocessedAffairApplyBindingSource, "ApplyDate", true));
            this.txtApplyTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApplyTime.Location = new System.Drawing.Point(96, 56);
            this.txtApplyTime.Name = "txtApplyTime";
            this.txtApplyTime.ReadOnly = true;
            this.txtApplyTime.Size = new System.Drawing.Size(379, 26);
            this.txtApplyTime.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(29, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "申请人：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "申请时间：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtApprovalContent);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.btnApprove);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(714, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 291);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "审批相关";
            // 
            // txtApprovalContent
            // 
            this.txtApprovalContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApprovalContent.Location = new System.Drawing.Point(22, 41);
            this.txtApprovalContent.Multiline = true;
            this.txtApprovalContent.Name = "txtApprovalContent";
            this.txtApprovalContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtApprovalContent.Size = new System.Drawing.Size(238, 201);
            this.txtApprovalContent.TabIndex = 13;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(22, 248);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(108, 31);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "事务签收";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "回复内容：";
            // 
            // affairApplyTableAdapter
            // 
            this.affairApplyTableAdapter.ClearBeforeFill = true;
            // 
            // unprocessedAffairApplyTableAdapter
            // 
            this.unprocessedAffairApplyTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstUnprocessed);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 292);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "待处理事务";
            // 
            // btnShowAffairDetail
            // 
            this.btnShowAffairDetail.Location = new System.Drawing.Point(869, 337);
            this.btnShowAffairDetail.Name = "btnShowAffairDetail";
            this.btnShowAffairDetail.Size = new System.Drawing.Size(104, 26);
            this.btnShowAffairDetail.TabIndex = 21;
            this.btnShowAffairDetail.Text = "查看详情";
            this.btnShowAffairDetail.UseVisualStyleBackColor = true;
            this.btnShowAffairDetail.Click += new System.EventHandler(this.btnShowAffairDetail_Click);
            // 
            // AffairSeq
            // 
            this.AffairSeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AffairSeq.HeaderText = "序号";
            this.AffairSeq.Name = "AffairSeq";
            this.AffairSeq.ReadOnly = true;
            this.AffairSeq.Width = 65;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle34;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "申报人";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 65;
            // 
            // applyTitleDataGridViewTextBoxColumn
            // 
            this.applyTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.applyTitleDataGridViewTextBoxColumn.DataPropertyName = "ApplyTitle";
            this.applyTitleDataGridViewTextBoxColumn.HeaderText = "申报标题";
            this.applyTitleDataGridViewTextBoxColumn.Name = "applyTitleDataGridViewTextBoxColumn";
            this.applyTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyTitleDataGridViewTextBoxColumn.Width = 350;
            // 
            // applyDateDataGridViewTextBoxColumn
            // 
            this.applyDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.applyDateDataGridViewTextBoxColumn.DataPropertyName = "ApplyDate";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.Format = "f";
            dataGridViewCellStyle35.NullValue = null;
            this.applyDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle35;
            this.applyDateDataGridViewTextBoxColumn.HeaderText = "申报时间";
            this.applyDateDataGridViewTextBoxColumn.Name = "applyDateDataGridViewTextBoxColumn";
            this.applyDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // applyContentDataGridViewTextBoxColumn
            // 
            this.applyContentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.applyContentDataGridViewTextBoxColumn.DataPropertyName = "ApplyContent";
            this.applyContentDataGridViewTextBoxColumn.HeaderText = "申报内容";
            this.applyContentDataGridViewTextBoxColumn.Name = "applyContentDataGridViewTextBoxColumn";
            this.applyContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyContentDataGridViewTextBoxColumn.Width = 400;
            // 
            // ApprovalStatusColumn
            // 
            this.ApprovalStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ApprovalStatusColumn.DefaultCellStyle = dataGridViewCellStyle36;
            this.ApprovalStatusColumn.HeaderText = "状态";
            this.ApprovalStatusColumn.Name = "ApprovalStatusColumn";
            this.ApprovalStatusColumn.ReadOnly = true;
            this.ApprovalStatusColumn.Width = 65;
            // 
            // approverUserNameDataGridViewTextBoxColumn
            // 
            this.approverUserNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.approverUserNameDataGridViewTextBoxColumn.DataPropertyName = "ApproverUserName";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.approverUserNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.approverUserNameDataGridViewTextBoxColumn.HeaderText = "回复人";
            this.approverUserNameDataGridViewTextBoxColumn.Name = "approverUserNameDataGridViewTextBoxColumn";
            this.approverUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.approverUserNameDataGridViewTextBoxColumn.Width = 65;
            // 
            // CheckDate
            // 
            this.CheckDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckDate.DataPropertyName = "CheckDate";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Format = "f";
            dataGridViewCellStyle38.NullValue = null;
            this.CheckDate.DefaultCellStyle = dataGridViewCellStyle38;
            this.CheckDate.HeaderText = "签收时间";
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.ReadOnly = true;
            this.CheckDate.Width = 150;
            // 
            // ApprovalDate
            // 
            this.ApprovalDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ApprovalDate.DataPropertyName = "ApprovalDate";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Format = "f";
            dataGridViewCellStyle39.NullValue = null;
            this.ApprovalDate.DefaultCellStyle = dataGridViewCellStyle39;
            this.ApprovalDate.HeaderText = "回复时间";
            this.ApprovalDate.Name = "ApprovalDate";
            this.ApprovalDate.ReadOnly = true;
            this.ApprovalDate.Width = 150;
            // 
            // approvalContentDataGridViewTextBoxColumn
            // 
            this.approvalContentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.approvalContentDataGridViewTextBoxColumn.DataPropertyName = "ApprovalContent";
            this.approvalContentDataGridViewTextBoxColumn.HeaderText = "回复内容";
            this.approvalContentDataGridViewTextBoxColumn.Name = "approvalContentDataGridViewTextBoxColumn";
            this.approvalContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.approvalContentDataGridViewTextBoxColumn.Width = 400;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(295, 340);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtEndDate.TabIndex = 29;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.Location = new System.Drawing.Point(85, 340);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtBeginDate.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "终止日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "起始日期：";
            // 
            // btnSearchByApplyDate
            // 
            this.btnSearchByApplyDate.Location = new System.Drawing.Point(429, 337);
            this.btnSearchByApplyDate.Name = "btnSearchByApplyDate";
            this.btnSearchByApplyDate.Size = new System.Drawing.Size(104, 26);
            this.btnSearchByApplyDate.TabIndex = 26;
            this.btnSearchByApplyDate.Text = "按申报时间查询";
            this.btnSearchByApplyDate.UseVisualStyleBackColor = true;
            this.btnSearchByApplyDate.Click += new System.EventHandler(this.btnSearchByApplyDate_Click);
            // 
            // btnSearchByCheckDate
            // 
            this.btnSearchByCheckDate.Location = new System.Drawing.Point(539, 337);
            this.btnSearchByCheckDate.Name = "btnSearchByCheckDate";
            this.btnSearchByCheckDate.Size = new System.Drawing.Size(104, 26);
            this.btnSearchByCheckDate.TabIndex = 31;
            this.btnSearchByCheckDate.Text = "按签收时间查询";
            this.btnSearchByCheckDate.UseVisualStyleBackColor = true;
            this.btnSearchByCheckDate.Click += new System.EventHandler(this.btnSearchByCheckDate_Click);
            // 
            // btnReplyDate
            // 
            this.btnReplyDate.Location = new System.Drawing.Point(649, 337);
            this.btnReplyDate.Name = "btnReplyDate";
            this.btnReplyDate.Size = new System.Drawing.Size(104, 26);
            this.btnReplyDate.TabIndex = 32;
            this.btnReplyDate.Text = "按回复时间查询";
            this.btnReplyDate.UseVisualStyleBackColor = true;
            this.btnReplyDate.Click += new System.EventHandler(this.btnReplyDate_Click);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(759, 337);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(104, 26);
            this.btnSearchAll.TabIndex = 33;
            this.btnSearchAll.Text = "查看所有";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // AffairApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 677);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.btnReplyDate);
            this.Controls.Add(this.btnSearchByCheckDate);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtBeginDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearchByApplyDate);
            this.Controls.Add(this.btnShowAffairDetail);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAffair);
            this.Controls.Add(this.label4);
            this.Name = "AffairApprovalForm";
            this.Text = "事务审批";
            this.Load += new System.EventHandler(this.AffairApprovalForm_Load);
            this.Resize += new System.EventHandler(this.AffairApprovalForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.unprocessedAffairApplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairApplyBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnprocessed;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAffair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApplier;
        private System.Windows.Forms.TextBox txtApplyTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtApprovalContent;
        private System.Windows.Forms.Label label7;
        private Affair affairDataSet;
        private System.Windows.Forms.BindingSource affairApplyBindingSource;
        private AffairTableAdapters.AffairApplyTableAdapter affairApplyTableAdapter;
        private System.Windows.Forms.BindingSource unprocessedAffairApplyBindingSource;
        private AffairTableAdapters.UnprocessedAffairApplyTableAdapter unprocessedAffairApplyTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowAffairDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AffairSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchByApplyDate;
        private System.Windows.Forms.Button btnSearchByCheckDate;
        private System.Windows.Forms.Button btnReplyDate;
        private System.Windows.Forms.Button btnSearchAll;
    }
}