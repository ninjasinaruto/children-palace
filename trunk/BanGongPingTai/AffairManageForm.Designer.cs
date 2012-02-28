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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAffair = new System.Windows.Forms.DataGridView();
            this.affairApplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.affairDataSet = new BanGongPingTai.Affair();
            this.btnApplyNewAffair = new System.Windows.Forms.Button();
            this.affairApplyTableAdapter = new BanGongPingTai.AffairTableAdapters.AffairApplyTableAdapter();
            this.noticeDataSet = new BanGongPingTai.NoticeDataSet();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
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
            this.applyTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvAffair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAffair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applyTitleDataGridViewTextBoxColumn,
            this.applyDateDataGridViewTextBoxColumn,
            this.ApprovalStatusColumn,
            this.ApprovalContent,
            this.ApplyDate,
            this.applyContentDataGridViewTextBoxColumn});
            this.dgvAffair.DataSource = this.affairApplyBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAffair.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAffair.Location = new System.Drawing.Point(10, 20);
            this.dgvAffair.MultiSelect = false;
            this.dgvAffair.Name = "dgvAffair";
            this.dgvAffair.ReadOnly = true;
            this.dgvAffair.RowHeadersVisible = false;
            this.dgvAffair.RowTemplate.Height = 23;
            this.dgvAffair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAffair.Size = new System.Drawing.Size(941, 341);
            this.dgvAffair.TabIndex = 0;
            this.dgvAffair.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
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
            this.btnApplyNewAffair.Location = new System.Drawing.Point(969, 20);
            this.btnApplyNewAffair.Name = "btnApplyNewAffair";
            this.btnApplyNewAffair.Size = new System.Drawing.Size(91, 43);
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
            this.userNameDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn,
            this.noticeTitleDataGridViewTextBoxColumn,
            this.noticeContentDataGridViewTextBoxColumn});
            this.dgvNotices.DataSource = this.noticesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotices.Location = new System.Drawing.Point(10, 20);
            this.dgvNotices.MultiSelect = false;
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowTemplate.Height = 23;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(941, 156);
            this.dgvNotices.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.btnShowAffairDetail);
            this.groupBox1.Controls.Add(this.btnApplyNewAffair);
            this.groupBox1.Controls.Add(this.dgvAffair);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 367);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "事务申报";
            // 
            // btnShowAffairDetail
            // 
            this.btnShowAffairDetail.Location = new System.Drawing.Point(969, 69);
            this.btnShowAffairDetail.Name = "btnShowAffairDetail";
            this.btnShowAffairDetail.Size = new System.Drawing.Size(91, 43);
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
            this.groupBox2.Size = new System.Drawing.Size(1082, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "公告列表";
            // 
            // btnShowNoticeDetail
            // 
            this.btnShowNoticeDetail.Location = new System.Drawing.Point(969, 20);
            this.btnShowNoticeDetail.Name = "btnShowNoticeDetail";
            this.btnShowNoticeDetail.Size = new System.Drawing.Size(91, 43);
            this.btnShowNoticeDetail.TabIndex = 5;
            this.btnShowNoticeDetail.Text = "查看详情";
            this.btnShowNoticeDetail.UseVisualStyleBackColor = true;
            this.btnShowNoticeDetail.Click += new System.EventHandler(this.btnShowNoticeDetail_Click);
            // 
            // applyTitleDataGridViewTextBoxColumn
            // 
            this.applyTitleDataGridViewTextBoxColumn.DataPropertyName = "ApplyTitle";
            this.applyTitleDataGridViewTextBoxColumn.HeaderText = "标题";
            this.applyTitleDataGridViewTextBoxColumn.Name = "applyTitleDataGridViewTextBoxColumn";
            this.applyTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyTitleDataGridViewTextBoxColumn.Width = 54;
            // 
            // applyDateDataGridViewTextBoxColumn
            // 
            this.applyDateDataGridViewTextBoxColumn.DataPropertyName = "ApplyDate";
            dataGridViewCellStyle1.Format = "f";
            dataGridViewCellStyle1.NullValue = null;
            this.applyDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.applyDateDataGridViewTextBoxColumn.HeaderText = "申请时间";
            this.applyDateDataGridViewTextBoxColumn.Name = "applyDateDataGridViewTextBoxColumn";
            this.applyDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // ApprovalStatusColumn
            // 
            this.ApprovalStatusColumn.HeaderText = "审批状态";
            this.ApprovalStatusColumn.Name = "ApprovalStatusColumn";
            this.ApprovalStatusColumn.ReadOnly = true;
            this.ApprovalStatusColumn.Width = 78;
            // 
            // ApprovalContent
            // 
            this.ApprovalContent.DataPropertyName = "ApprovalContent";
            this.ApprovalContent.HeaderText = "审批回复";
            this.ApprovalContent.Name = "ApprovalContent";
            this.ApprovalContent.ReadOnly = true;
            this.ApprovalContent.Width = 78;
            // 
            // ApplyDate
            // 
            this.ApplyDate.DataPropertyName = "ApplyDate";
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.ApplyDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ApplyDate.HeaderText = "审批时间";
            this.ApplyDate.Name = "ApplyDate";
            this.ApplyDate.ReadOnly = true;
            this.ApplyDate.Width = 78;
            // 
            // applyContentDataGridViewTextBoxColumn
            // 
            this.applyContentDataGridViewTextBoxColumn.DataPropertyName = "ApplyContent";
            this.applyContentDataGridViewTextBoxColumn.HeaderText = "内容";
            this.applyContentDataGridViewTextBoxColumn.Name = "applyContentDataGridViewTextBoxColumn";
            this.applyContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyContentDataGridViewTextBoxColumn.Width = 54;
            // 
            // AffairManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AffairManageForm";
            this.Text = "事务管理";
            this.Load += new System.EventHandler(this.AffairApplyListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairApplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource noticesBindingSource;
        private NoticeDataSetTableAdapters.NoticesTableAdapter noticesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowAffairDetail;
        private System.Windows.Forms.Button btnShowNoticeDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyContentDataGridViewTextBoxColumn;
    }
}