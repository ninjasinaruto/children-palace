namespace BanGongPingTai
{
    partial class AffairManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAffair = new System.Windows.Forms.DataGridView();
            this.affairApplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.affairDataSet = new BanGongPingTai.Affair();
            this.btnApplyNewAffair = new System.Windows.Forms.Button();
            this.affairApplyTableAdapter = new BanGongPingTai.AffairTableAdapters.AffairApplyTableAdapter();
            this.noticeDataSet = new BanGongPingTai.NoticeDataSet();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.NoticeSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noticesTableAdapter = new BanGongPingTai.NoticeDataSetTableAdapters.NoticesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAffairDetail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowNoticeDetail = new System.Windows.Forms.Button();
            this.ApplySeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproverUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.签收时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.btnReplyDate = new System.Windows.Forms.Button();
            this.btnSearchByCheckDate = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchByApplyDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairApplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAffair
            // 
            this.dgvAffair.AllowUserToAddRows = false;
            this.dgvAffair.AllowUserToDeleteRows = false;
            this.dgvAffair.AllowUserToResizeRows = false;
            this.dgvAffair.AutoGenerateColumns = false;
            this.dgvAffair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAffair.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvAffair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAffair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplySeq,
            this.UserName,
            this.applyTitleDataGridViewTextBoxColumn,
            this.applyDateDataGridViewTextBoxColumn,
            this.applyContentDataGridViewTextBoxColumn,
            this.ApprovalStatusColumn,
            this.ApproverUserName,
            this.签收时间,
            this.ApplyDate,
            this.ApprovalContent});
            this.dgvAffair.DataSource = this.affairApplyBindingSource;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAffair.DefaultCellStyle = dataGridViewCellStyle53;
            this.dgvAffair.Location = new System.Drawing.Point(10, 49);
            this.dgvAffair.MultiSelect = false;
            this.dgvAffair.Name = "dgvAffair";
            this.dgvAffair.ReadOnly = true;
            this.dgvAffair.RowHeadersVisible = false;
            this.dgvAffair.RowTemplate.Height = 23;
            this.dgvAffair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAffair.Size = new System.Drawing.Size(1072, 312);
            this.dgvAffair.TabIndex = 0;
            this.dgvAffair.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAffair_DataBindingComplete);
            // 
            // affairApplyBindingSource
            // 
            this.affairApplyBindingSource.DataMember = "AffairApply";
            this.affairApplyBindingSource.DataSource = this.affairDataSet;
            // 
            // affairDataSet
            // 
            this.affairDataSet.DataSetName = "Affair";
            this.affairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnApplyNewAffair
            // 
            this.btnApplyNewAffair.Location = new System.Drawing.Point(10, 17);
            this.btnApplyNewAffair.Name = "btnApplyNewAffair";
            this.btnApplyNewAffair.Size = new System.Drawing.Size(104, 26);
            this.btnApplyNewAffair.TabIndex = 1;
            this.btnApplyNewAffair.Text = "申报新事务";
            this.btnApplyNewAffair.UseVisualStyleBackColor = true;
            this.btnApplyNewAffair.Click += new System.EventHandler(this.btnApplyNewAffair_Click);
            // 
            // affairApplyTableAdapter
            // 
            this.affairApplyTableAdapter.ClearBeforeFill = true;
            // 
            // noticeDataSet
            // 
            this.noticeDataSet.DataSetName = "NoticeDataSet";
            this.noticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvNotices
            // 
            this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.AllowUserToDeleteRows = false;
            this.dgvNotices.AllowUserToResizeRows = false;
            this.dgvNotices.AutoGenerateColumns = false;
            this.dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoticeSeq,
            this.userNameDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn,
            this.noticeTitleDataGridViewTextBoxColumn,
            this.noticeContentDataGridViewTextBoxColumn});
            this.dgvNotices.DataSource = this.noticesBindingSource;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotices.DefaultCellStyle = dataGridViewCellStyle54;
            this.dgvNotices.Location = new System.Drawing.Point(10, 20);
            this.dgvNotices.MultiSelect = false;
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowTemplate.Height = 23;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(941, 156);
            this.dgvNotices.TabIndex = 3;
            this.dgvNotices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNotices_DataBindingComplete);
            // 
            // NoticeSeq
            // 
            this.NoticeSeq.HeaderText = "序号";
            this.NoticeSeq.Name = "NoticeSeq";
            this.NoticeSeq.ReadOnly = true;
            this.NoticeSeq.Width = 54;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "发布人";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "发布日期";
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.publishDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // noticeTitleDataGridViewTextBoxColumn
            // 
            this.noticeTitleDataGridViewTextBoxColumn.DataPropertyName = "NoticeTitle";
            this.noticeTitleDataGridViewTextBoxColumn.HeaderText = "标题";
            this.noticeTitleDataGridViewTextBoxColumn.Name = "noticeTitleDataGridViewTextBoxColumn";
            this.noticeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.noticeTitleDataGridViewTextBoxColumn.Width = 54;
            // 
            // noticeContentDataGridViewTextBoxColumn
            // 
            this.noticeContentDataGridViewTextBoxColumn.DataPropertyName = "NoticeContent";
            this.noticeContentDataGridViewTextBoxColumn.HeaderText = "内容";
            this.noticeContentDataGridViewTextBoxColumn.Name = "noticeContentDataGridViewTextBoxColumn";
            this.noticeContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.noticeContentDataGridViewTextBoxColumn.Width = 54;
            // 
            // noticesBindingSource
            // 
            this.noticesBindingSource.DataMember = "Notices";
            this.noticesBindingSource.DataSource = this.noticeDataSet;
            // 
            // noticesTableAdapter
            // 
            this.noticesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchAll);
            this.groupBox1.Controls.Add(this.btnReplyDate);
            this.groupBox1.Controls.Add(this.btnApplyNewAffair);
            this.groupBox1.Controls.Add(this.btnSearchByCheckDate);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.dtBeginDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSearchByApplyDate);
            this.groupBox1.Controls.Add(this.btnShowAffairDetail);
            this.groupBox1.Controls.Add(this.dgvAffair);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 367);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "事务申报";
            // 
            // btnShowAffairDetail
            // 
            this.btnShowAffairDetail.Location = new System.Drawing.Point(978, 17);
            this.btnShowAffairDetail.Name = "btnShowAffairDetail";
            this.btnShowAffairDetail.Size = new System.Drawing.Size(104, 26);
            this.btnShowAffairDetail.TabIndex = 4;
            this.btnShowAffairDetail.Text = "查看详情";
            this.btnShowAffairDetail.UseVisualStyleBackColor = true;
            this.btnShowAffairDetail.Click += new System.EventHandler(this.btnShowAffairDetail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowNoticeDetail);
            this.groupBox2.Controls.Add(this.dgvNotices);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1091, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "公告列表";
            // 
            // btnShowNoticeDetail
            // 
            this.btnShowNoticeDetail.Location = new System.Drawing.Point(978, 20);
            this.btnShowNoticeDetail.Name = "btnShowNoticeDetail";
            this.btnShowNoticeDetail.Size = new System.Drawing.Size(91, 43);
            this.btnShowNoticeDetail.TabIndex = 5;
            this.btnShowNoticeDetail.Text = "查看详情";
            this.btnShowNoticeDetail.UseVisualStyleBackColor = true;
            this.btnShowNoticeDetail.Click += new System.EventHandler(this.btnShowNoticeDetail_Click);
            // 
            // ApplySeq
            // 
            this.ApplySeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ApplySeq.HeaderText = "序号";
            this.ApplySeq.Name = "ApplySeq";
            this.ApplySeq.ReadOnly = true;
            this.ApplySeq.Width = 65;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.DataPropertyName = "UserName";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UserName.DefaultCellStyle = dataGridViewCellStyle47;
            this.UserName.HeaderText = "申报人";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 65;
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
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.Format = "f";
            dataGridViewCellStyle48.NullValue = null;
            this.applyDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle48;
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
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ApprovalStatusColumn.DefaultCellStyle = dataGridViewCellStyle49;
            this.ApprovalStatusColumn.HeaderText = "状态";
            this.ApprovalStatusColumn.Name = "ApprovalStatusColumn";
            this.ApprovalStatusColumn.ReadOnly = true;
            this.ApprovalStatusColumn.Width = 60;
            // 
            // ApproverUserName
            // 
            this.ApproverUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ApproverUserName.DataPropertyName = "ApproverUserName";
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ApproverUserName.DefaultCellStyle = dataGridViewCellStyle50;
            this.ApproverUserName.HeaderText = "回复人";
            this.ApproverUserName.Name = "ApproverUserName";
            this.ApproverUserName.ReadOnly = true;
            this.ApproverUserName.Width = 65;
            // 
            // 签收时间
            // 
            this.签收时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.签收时间.DataPropertyName = "CheckDate";
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle51.Format = "f";
            dataGridViewCellStyle51.NullValue = null;
            this.签收时间.DefaultCellStyle = dataGridViewCellStyle51;
            this.签收时间.HeaderText = "签收时间";
            this.签收时间.Name = "签收时间";
            this.签收时间.ReadOnly = true;
            this.签收时间.Width = 150;
            // 
            // ApplyDate
            // 
            this.ApplyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ApplyDate.DataPropertyName = "ApprovalDate";
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle52.Format = "f";
            dataGridViewCellStyle52.NullValue = null;
            this.ApplyDate.DefaultCellStyle = dataGridViewCellStyle52;
            this.ApplyDate.HeaderText = "回复时间";
            this.ApplyDate.Name = "ApplyDate";
            this.ApplyDate.ReadOnly = true;
            this.ApplyDate.Width = 150;
            // 
            // ApprovalContent
            // 
            this.ApprovalContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ApprovalContent.DataPropertyName = "ApprovalContent";
            this.ApprovalContent.HeaderText = "回复内容";
            this.ApprovalContent.Name = "ApprovalContent";
            this.ApprovalContent.ReadOnly = true;
            this.ApprovalContent.Width = 400;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(868, 17);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(104, 26);
            this.btnSearchAll.TabIndex = 41;
            this.btnSearchAll.Text = "查看所有";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // btnReplyDate
            // 
            this.btnReplyDate.Location = new System.Drawing.Point(758, 17);
            this.btnReplyDate.Name = "btnReplyDate";
            this.btnReplyDate.Size = new System.Drawing.Size(104, 26);
            this.btnReplyDate.TabIndex = 40;
            this.btnReplyDate.Text = "按回复时间查询";
            this.btnReplyDate.UseVisualStyleBackColor = true;
            this.btnReplyDate.Click += new System.EventHandler(this.btnReplyDate_Click);
            // 
            // btnSearchByCheckDate
            // 
            this.btnSearchByCheckDate.Location = new System.Drawing.Point(648, 17);
            this.btnSearchByCheckDate.Name = "btnSearchByCheckDate";
            this.btnSearchByCheckDate.Size = new System.Drawing.Size(104, 26);
            this.btnSearchByCheckDate.TabIndex = 39;
            this.btnSearchByCheckDate.Text = "按签收时间查询";
            this.btnSearchByCheckDate.UseVisualStyleBackColor = true;
            this.btnSearchByCheckDate.Click += new System.EventHandler(this.btnSearchByCheckDate_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(404, 20);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtEndDate.TabIndex = 37;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.Location = new System.Drawing.Point(194, 20);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtBeginDate.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "终止日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "起始日期：";
            // 
            // btnSearchByApplyDate
            // 
            this.btnSearchByApplyDate.Location = new System.Drawing.Point(538, 17);
            this.btnSearchByApplyDate.Name = "btnSearchByApplyDate";
            this.btnSearchByApplyDate.Size = new System.Drawing.Size(104, 26);
            this.btnSearchByApplyDate.TabIndex = 34;
            this.btnSearchByApplyDate.Text = "按申报时间查询";
            this.btnSearchByApplyDate.UseVisualStyleBackColor = true;
            this.btnSearchByApplyDate.Click += new System.EventHandler(this.btnSearchByApplyDate_Click);
            // 
            // AffairManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AffairManageForm";
            this.Text = "事务管理";
            this.Load += new System.EventHandler(this.AffairApplyListForm_Load);
            this.Resize += new System.EventHandler(this.AffairManageForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairApplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAffair;
        private System.Windows.Forms.Button btnApplyNewAffair;
        private Affair affairDataSet;
        private System.Windows.Forms.BindingSource affairApplyBindingSource;
        private AffairTableAdapters.AffairApplyTableAdapter affairApplyTableAdapter;
        private NoticeDataSet noticeDataSet;
        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.BindingSource noticesBindingSource;
        private NoticeDataSetTableAdapters.NoticesTableAdapter noticesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowAffairDetail;
        private System.Windows.Forms.Button btnShowNoticeDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplySeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproverUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 签收时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalContent;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Button btnReplyDate;
        private System.Windows.Forms.Button btnSearchByCheckDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchByApplyDate;
    }
}