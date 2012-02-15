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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstUnprocessed = new System.Windows.Forms.ListBox();
            this.unprocessedAffairApplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.affairDataSet = new BanGongPingTai.Affair();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approverUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affairApplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApplier = new System.Windows.Forms.TextBox();
            this.txtApplyTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtApprovalContent = new System.Windows.Forms.TextBox();
            this.btnDeny = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.affairApplyTableAdapter = new BanGongPingTai.AffairTableAdapters.AffairApplyTableAdapter();
            this.unprocessedAffairApplyTableAdapter = new BanGongPingTai.AffairTableAdapters.UnprocessedAffairApplyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.unprocessedAffairApplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairApplyBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUnprocessed
            // 
            this.lstUnprocessed.DataSource = this.unprocessedAffairApplyBindingSource;
            this.lstUnprocessed.DisplayMember = "ApplyTitle";
            this.lstUnprocessed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstUnprocessed.FormattingEnabled = true;
            this.lstUnprocessed.ItemHeight = 16;
            this.lstUnprocessed.Location = new System.Drawing.Point(14, 47);
            this.lstUnprocessed.Name = "lstUnprocessed";
            this.lstUnprocessed.Size = new System.Drawing.Size(155, 260);
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
            this.btnApprove.Location = new System.Drawing.Point(22, 223);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(87, 31);
            this.btnApprove.TabIndex = 14;
            this.btnApprove.Text = "通过审批";
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
            this.txtContent.Size = new System.Drawing.Size(379, 135);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "待审批事务：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.applyDateDataGridViewTextBoxColumn,
            this.applyTitleDataGridViewTextBoxColumn,
            this.approvalContentDataGridViewTextBoxColumn,
            this.StatusColumn,
            this.approverUserNameDataGridViewTextBoxColumn,
            this.applyContentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.affairApplyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(14, 358);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(896, 304);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "申请人";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 66;
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
            // applyTitleDataGridViewTextBoxColumn
            // 
            this.applyTitleDataGridViewTextBoxColumn.DataPropertyName = "ApplyTitle";
            this.applyTitleDataGridViewTextBoxColumn.HeaderText = "标题";
            this.applyTitleDataGridViewTextBoxColumn.Name = "applyTitleDataGridViewTextBoxColumn";
            this.applyTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyTitleDataGridViewTextBoxColumn.Width = 54;
            // 
            // approvalContentDataGridViewTextBoxColumn
            // 
            this.approvalContentDataGridViewTextBoxColumn.DataPropertyName = "ApprovalContent";
            this.approvalContentDataGridViewTextBoxColumn.HeaderText = "批复内容";
            this.approvalContentDataGridViewTextBoxColumn.Name = "approvalContentDataGridViewTextBoxColumn";
            this.approvalContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.approvalContentDataGridViewTextBoxColumn.Width = 78;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "审批结果";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 78;
            // 
            // approverUserNameDataGridViewTextBoxColumn
            // 
            this.approverUserNameDataGridViewTextBoxColumn.DataPropertyName = "ApproverUserName";
            this.approverUserNameDataGridViewTextBoxColumn.HeaderText = "审批人";
            this.approverUserNameDataGridViewTextBoxColumn.Name = "approverUserNameDataGridViewTextBoxColumn";
            this.approverUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.approverUserNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // applyContentDataGridViewTextBoxColumn
            // 
            this.applyContentDataGridViewTextBoxColumn.DataPropertyName = "ApplyContent";
            this.applyContentDataGridViewTextBoxColumn.HeaderText = "内容";
            this.applyContentDataGridViewTextBoxColumn.Name = "applyContentDataGridViewTextBoxColumn";
            this.applyContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.applyContentDataGridViewTextBoxColumn.Width = 54;
            // 
            // affairApplyBindingSource
            // 
            this.affairApplyBindingSource.DataMember = "AffairApply";
            this.affairApplyBindingSource.DataSource = this.affairDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "已审批事务：";
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
            this.groupBox1.Location = new System.Drawing.Point(175, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 279);
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
            this.label6.Location = new System.Drawing.Point(25, 93);
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
            this.groupBox2.Controls.Add(this.btnDeny);
            this.groupBox2.Controls.Add(this.btnApprove);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(688, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 273);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "审批相关";
            // 
            // txtApprovalContent
            // 
            this.txtApprovalContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApprovalContent.Location = new System.Drawing.Point(22, 51);
            this.txtApprovalContent.Multiline = true;
            this.txtApprovalContent.Name = "txtApprovalContent";
            this.txtApprovalContent.Size = new System.Drawing.Size(165, 156);
            this.txtApprovalContent.TabIndex = 13;
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(115, 223);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(87, 31);
            this.btnDeny.TabIndex = 14;
            this.btnDeny.Text = "拒绝审批";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "批复内容：";
            // 
            // affairApplyTableAdapter
            // 
            this.affairApplyTableAdapter.ClearBeforeFill = true;
            // 
            // unprocessedAffairApplyTableAdapter
            // 
            this.unprocessedAffairApplyTableAdapter.ClearBeforeFill = true;
            // 
            // AffairApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 677);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUnprocessed);
            this.Name = "AffairApprovalForm";
            this.Text = "事务审批";
            this.Load += new System.EventHandler(this.AffairApprovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unprocessedAffairApplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affairApplyBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApplier;
        private System.Windows.Forms.TextBox txtApplyTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.TextBox txtApprovalContent;
        private System.Windows.Forms.Label label7;
        private Affair affairDataSet;
        private System.Windows.Forms.BindingSource affairApplyBindingSource;
        private AffairTableAdapters.AffairApplyTableAdapter affairApplyTableAdapter;
        private System.Windows.Forms.BindingSource unprocessedAffairApplyBindingSource;
        private AffairTableAdapters.UnprocessedAffairApplyTableAdapter unprocessedAffairApplyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approverUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyContentDataGridViewTextBoxColumn;
    }
}