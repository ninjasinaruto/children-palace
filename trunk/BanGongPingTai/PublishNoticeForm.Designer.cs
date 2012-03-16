namespace BanGongPingTai
{
    partial class PublishNoticeForm
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
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noticeDataSet = new BanGongPingTai.NoticeDataSet();
            this.btnPublishNewNotice = new System.Windows.Forms.Button();
            this.btnShowDetail = new System.Windows.Forms.Button();
            this.noticesTableAdapter = new BanGongPingTai.NoticeDataSetTableAdapters.NoticesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeDataSet)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotices.Location = new System.Drawing.Point(12, 83);
            this.dgvNotices.MultiSelect = false;
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowTemplate.Height = 23;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(933, 478);
            this.dgvNotices.TabIndex = 2;
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
            this.noticesBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.noticesBindingSource_ListChanged);
            this.noticesBindingSource.PositionChanged += new System.EventHandler(this.noticesBindingSource_PositionChanged);
            // 
            // noticeDataSet
            // 
            this.noticeDataSet.DataSetName = "NoticeDataSet";
            this.noticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPublishNewNotice
            // 
            this.btnPublishNewNotice.Location = new System.Drawing.Point(12, 22);
            this.btnPublishNewNotice.Name = "btnPublishNewNotice";
            this.btnPublishNewNotice.Size = new System.Drawing.Size(91, 43);
            this.btnPublishNewNotice.TabIndex = 3;
            this.btnPublishNewNotice.Text = "发布新公告";
            this.btnPublishNewNotice.UseVisualStyleBackColor = true;
            this.btnPublishNewNotice.Click += new System.EventHandler(this.btnPublishNewNotice_Click);
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Location = new System.Drawing.Point(109, 22);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(91, 43);
            this.btnShowDetail.TabIndex = 3;
            this.btnShowDetail.Text = "查看详情";
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // noticesTableAdapter
            // 
            this.noticesTableAdapter.ClearBeforeFill = true;
            // 
            // PublishNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.Controls.Add(this.dgvNotices);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.btnPublishNewNotice);
            this.Name = "PublishNoticeForm";
            this.Text = "公告发布";
            this.Load += new System.EventHandler(this.PublishNoticeForm_Load);
            this.Resize += new System.EventHandler(this.PublishNoticeForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.Button btnPublishNewNotice;
        private System.Windows.Forms.Button btnShowDetail;
        private NoticeDataSetTableAdapters.NoticesTableAdapter noticesTableAdapter;
        private NoticeDataSet noticeDataSet;
        private System.Windows.Forms.BindingSource noticesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeContentDataGridViewTextBoxColumn;
    }
}