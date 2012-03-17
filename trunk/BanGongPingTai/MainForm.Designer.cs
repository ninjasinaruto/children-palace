namespace BanGongPingTai
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsbTeachersManage = new System.Windows.Forms.ToolStripButton();
            this.tsbMaterialsManage = new System.Windows.Forms.ToolStripButton();
            this.tsbFinanceManage = new System.Windows.Forms.ToolStripButton();
            this.tsbAffairManage = new System.Windows.Forms.ToolStripButton();
            this.tsbAffairApproval = new System.Windows.Forms.ToolStripButton();
            this.tsbUsersManage = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFinanceAccounts = new System.Windows.Forms.ToolStripButton();
            this.tsbPublishNotice = new System.Windows.Forms.ToolStripButton();
            this.tsbPasswordUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolBtnWelcome = new System.Windows.Forms.ToolStripButton();
            this.softwareVersionTableAdapter = new Common.VersionDataSetTableAdapters.SoftwareVersionTableAdapter();
            this.softwareVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionDataSet = new Common.VersionDataSet();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwareVersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbTeachersManage
            // 
            this.tsbTeachersManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbTeachersManage.Image")));
            this.tsbTeachersManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTeachersManage.Name = "tsbTeachersManage";
            this.tsbTeachersManage.Size = new System.Drawing.Size(92, 57);
            this.tsbTeachersManage.Text = "教师管理";
            this.tsbTeachersManage.Click += new System.EventHandler(this.tsbTeachersManage_Click);
            // 
            // tsbMaterialsManage
            // 
            this.tsbMaterialsManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbMaterialsManage.Image")));
            this.tsbMaterialsManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMaterialsManage.Name = "tsbMaterialsManage";
            this.tsbMaterialsManage.Size = new System.Drawing.Size(92, 57);
            this.tsbMaterialsManage.Text = "库存管理";
            this.tsbMaterialsManage.Click += new System.EventHandler(this.tsbMaterialsManage_Click);
            // 
            // tsbFinanceManage
            // 
            this.tsbFinanceManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbFinanceManage.Image")));
            this.tsbFinanceManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFinanceManage.Name = "tsbFinanceManage";
            this.tsbFinanceManage.Size = new System.Drawing.Size(92, 57);
            this.tsbFinanceManage.Text = "账目汇总";
            this.tsbFinanceManage.Click += new System.EventHandler(this.tsbFinanceManage_Click);
            // 
            // tsbAffairManage
            // 
            this.tsbAffairManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbAffairManage.Image")));
            this.tsbAffairManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAffairManage.Name = "tsbAffairManage";
            this.tsbAffairManage.Size = new System.Drawing.Size(92, 57);
            this.tsbAffairManage.Text = "事务管理";
            this.tsbAffairManage.Click += new System.EventHandler(this.tsbAffairManage_Click);
            // 
            // tsbAffairApproval
            // 
            this.tsbAffairApproval.Image = ((System.Drawing.Image)(resources.GetObject("tsbAffairApproval.Image")));
            this.tsbAffairApproval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAffairApproval.Name = "tsbAffairApproval";
            this.tsbAffairApproval.Size = new System.Drawing.Size(92, 57);
            this.tsbAffairApproval.Text = "事务审批";
            this.tsbAffairApproval.Click += new System.EventHandler(this.tsbAffairApproval_Click);
            // 
            // tsbUsersManage
            // 
            this.tsbUsersManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsersManage.Image")));
            this.tsbUsersManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsersManage.Name = "tsbUsersManage";
            this.tsbUsersManage.Size = new System.Drawing.Size(116, 57);
            this.tsbUsersManage.Text = "合作用户管理";
            this.tsbUsersManage.Click += new System.EventHandler(this.tsbUsersManage_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTeachersManage,
            this.tsbMaterialsManage,
            this.tsbFinanceAccounts,
            this.tsbFinanceManage,
            this.tsbAffairManage,
            this.tsbAffairApproval,
            this.tsbPublishNotice,
            this.tsbUsersManage,
            this.tsbPasswordUpdate,
            this.toolBtnWelcome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 60);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFinanceAccounts
            // 
            this.tsbFinanceAccounts.Image = ((System.Drawing.Image)(resources.GetObject("tsbFinanceAccounts.Image")));
            this.tsbFinanceAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFinanceAccounts.Name = "tsbFinanceAccounts";
            this.tsbFinanceAccounts.Size = new System.Drawing.Size(92, 57);
            this.tsbFinanceAccounts.Text = "账目管理";
            this.tsbFinanceAccounts.Click += new System.EventHandler(this.tsbFinanceAccounts_Click);
            // 
            // tsbPublishNotice
            // 
            this.tsbPublishNotice.Image = ((System.Drawing.Image)(resources.GetObject("tsbPublishNotice.Image")));
            this.tsbPublishNotice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPublishNotice.Name = "tsbPublishNotice";
            this.tsbPublishNotice.Size = new System.Drawing.Size(92, 57);
            this.tsbPublishNotice.Text = "公告发布";
            this.tsbPublishNotice.Click += new System.EventHandler(this.tsbPublishNotice_Click);
            // 
            // tsbPasswordUpdate
            // 
            this.tsbPasswordUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbPasswordUpdate.Image")));
            this.tsbPasswordUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPasswordUpdate.Name = "tsbPasswordUpdate";
            this.tsbPasswordUpdate.Size = new System.Drawing.Size(92, 57);
            this.tsbPasswordUpdate.Text = "密码更改";
            this.tsbPasswordUpdate.Click += new System.EventHandler(this.tsbPasswordUpdate_Click);
            // 
            // toolBtnWelcome
            // 
            this.toolBtnWelcome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnWelcome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnWelcome.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnWelcome.Image")));
            this.toolBtnWelcome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnWelcome.Name = "toolBtnWelcome";
            this.toolBtnWelcome.Size = new System.Drawing.Size(60, 57);
            this.toolBtnWelcome.Text = "欢迎您：";
            this.toolBtnWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // softwareVersionTableAdapter
            // 
            this.softwareVersionTableAdapter.ClearBeforeFill = true;
            // 
            // softwareVersionBindingSource
            // 
            this.softwareVersionBindingSource.DataMember = "SoftwareVersion";
            this.softwareVersionBindingSource.DataSource = this.versionDataSet;
            // 
            // versionDataSet
            // 
            this.versionDataSet.DataSetName = "VersionDataSet";
            this.versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 596);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "“海鹰教育”福鼎市青少年宫培训服务中心办公管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwareVersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbTeachersManage;
        private System.Windows.Forms.ToolStripButton tsbMaterialsManage;
        private System.Windows.Forms.ToolStripButton tsbFinanceManage;
        private System.Windows.Forms.ToolStripButton tsbAffairManage;
        private System.Windows.Forms.ToolStripButton tsbAffairApproval;
        private System.Windows.Forms.ToolStripButton tsbUsersManage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Common.VersionDataSetTableAdapters.SoftwareVersionTableAdapter softwareVersionTableAdapter;
        private System.Windows.Forms.BindingSource softwareVersionBindingSource;
        private Common.VersionDataSet versionDataSet;
        private System.Windows.Forms.ToolStripButton tsbPasswordUpdate;
        private System.Windows.Forms.ToolStripButton toolBtnWelcome;
        private System.Windows.Forms.ToolStripButton tsbPublishNotice;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripButton tsbFinanceAccounts;

    }
}

