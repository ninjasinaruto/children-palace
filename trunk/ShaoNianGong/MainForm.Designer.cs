namespace ShaoNianGong
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPreregister = new System.Windows.Forms.ToolStripButton();
            this.tsbPreregManage = new System.Windows.Forms.ToolStripButton();
            this.tsbPreregSignUpCourses = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStudentSignin = new System.Windows.Forms.ToolStripButton();
            this.tsbStudentsManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDepositList = new System.Windows.Forms.ToolStripButton();
            this.tsbCostList = new System.Windows.Forms.ToolStripButton();
            this.tsbMaterialBuyList = new System.Windows.Forms.ToolStripButton();
            this.tsbLeftCourse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCoursesManage = new System.Windows.Forms.ToolStripButton();
            this.tsbClassroomManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInvoicePrinting = new System.Windows.Forms.ToolStripButton();
            this.toolBtnWelcome = new System.Windows.Forms.ToolStripButton();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.versionDataSet = new Common.VersionDataSet();
            this.softwareVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareVersionTableAdapter = new Common.VersionDataSetTableAdapters.SoftwareVersionTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareVersionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPreregister,
            this.tsbPreregManage,
            this.tsbPreregSignUpCourses,
            this.toolStripSeparator1,
            this.tsbStudentSignin,
            this.tsbStudentsManage,
            this.toolStripSeparator4,
            this.tsbDepositList,
            this.tsbCostList,
            this.tsbMaterialBuyList,
            this.tsbLeftCourse,
            this.toolStripSeparator3,
            this.tsbCoursesManage,
            this.tsbClassroomManage,
            this.toolStripSeparator2,
            this.tsbInvoicePrinting,
            this.toolBtnWelcome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1166, 60);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPreregister
            // 
            this.tsbPreregister.Image = ((System.Drawing.Image)(resources.GetObject("tsbPreregister.Image")));
            this.tsbPreregister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreregister.Name = "tsbPreregister";
            this.tsbPreregister.Size = new System.Drawing.Size(80, 57);
            this.tsbPreregister.Text = "预报名";
            this.tsbPreregister.Click += new System.EventHandler(this.预报名ToolStripMenuItem_Click);
            // 
            // tsbPreregManage
            // 
            this.tsbPreregManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbPreregManage.Image")));
            this.tsbPreregManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreregManage.Name = "tsbPreregManage";
            this.tsbPreregManage.Size = new System.Drawing.Size(92, 57);
            this.tsbPreregManage.Text = "新生管理";
            this.tsbPreregManage.Click += new System.EventHandler(this.新生管理ToolStripMenuItem_Click);
            // 
            // tsbPreregSignUpCourses
            // 
            this.tsbPreregSignUpCourses.Image = ((System.Drawing.Image)(resources.GetObject("tsbPreregSignUpCourses.Image")));
            this.tsbPreregSignUpCourses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreregSignUpCourses.Name = "tsbPreregSignUpCourses";
            this.tsbPreregSignUpCourses.Size = new System.Drawing.Size(92, 57);
            this.tsbPreregSignUpCourses.Text = "新生排班";
            this.tsbPreregSignUpCourses.Click += new System.EventHandler(this.排班ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbStudentSignin
            // 
            this.tsbStudentSignin.Image = ((System.Drawing.Image)(resources.GetObject("tsbStudentSignin.Image")));
            this.tsbStudentSignin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStudentSignin.Name = "tsbStudentSignin";
            this.tsbStudentSignin.Size = new System.Drawing.Size(116, 57);
            this.tsbStudentSignin.Text = "学生签到汇总";
            this.tsbStudentSignin.Click += new System.EventHandler(this.tsbStudentSignin_Click);
            // 
            // tsbStudentsManage
            // 
            this.tsbStudentsManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbStudentsManage.Image")));
            this.tsbStudentsManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStudentsManage.Name = "tsbStudentsManage";
            this.tsbStudentsManage.Size = new System.Drawing.Size(116, 57);
            this.tsbStudentsManage.Text = "学生资料管理";
            this.tsbStudentsManage.Click += new System.EventHandler(this.学生资料管理ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbDepositList
            // 
            this.tsbDepositList.Image = ((System.Drawing.Image)(resources.GetObject("tsbDepositList.Image")));
            this.tsbDepositList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDepositList.Name = "tsbDepositList";
            this.tsbDepositList.Size = new System.Drawing.Size(92, 57);
            this.tsbDepositList.Text = "充值汇总";
            this.tsbDepositList.Click += new System.EventHandler(this.充值汇总ToolStripMenuItem_Click);
            // 
            // tsbCostList
            // 
            this.tsbCostList.Image = ((System.Drawing.Image)(resources.GetObject("tsbCostList.Image")));
            this.tsbCostList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCostList.Name = "tsbCostList";
            this.tsbCostList.Size = new System.Drawing.Size(92, 57);
            this.tsbCostList.Text = "收费汇总";
            this.tsbCostList.Click += new System.EventHandler(this.收费汇总ToolStripMenuItem_Click);
            // 
            // tsbMaterialBuyList
            // 
            this.tsbMaterialBuyList.Image = ((System.Drawing.Image)(resources.GetObject("tsbMaterialBuyList.Image")));
            this.tsbMaterialBuyList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMaterialBuyList.Name = "tsbMaterialBuyList";
            this.tsbMaterialBuyList.Size = new System.Drawing.Size(116, 57);
            this.tsbMaterialBuyList.Text = "材料购买汇总";
            this.tsbMaterialBuyList.Click += new System.EventHandler(this.材料购买汇总ToolStripMenuItem_Click);
            // 
            // tsbLeftCourse
            // 
            this.tsbLeftCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsbLeftCourse.Image")));
            this.tsbLeftCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLeftCourse.Name = "tsbLeftCourse";
            this.tsbLeftCourse.Size = new System.Drawing.Size(116, 57);
            this.tsbLeftCourse.Text = "离班记录汇总";
            this.tsbLeftCourse.Click += new System.EventHandler(this.tsbLeftCourse_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbCoursesManage
            // 
            this.tsbCoursesManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbCoursesManage.Image")));
            this.tsbCoursesManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCoursesManage.Name = "tsbCoursesManage";
            this.tsbCoursesManage.Size = new System.Drawing.Size(92, 57);
            this.tsbCoursesManage.Text = "课程管理";
            this.tsbCoursesManage.Click += new System.EventHandler(this.课程管理ToolStripMenuItem_Click);
            // 
            // tsbClassroomManage
            // 
            this.tsbClassroomManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbClassroomManage.Image")));
            this.tsbClassroomManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClassroomManage.Name = "tsbClassroomManage";
            this.tsbClassroomManage.Size = new System.Drawing.Size(92, 57);
            this.tsbClassroomManage.Text = "教室管理";
            this.tsbClassroomManage.Click += new System.EventHandler(this.教室管理ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbInvoicePrinting
            // 
            this.tsbInvoicePrinting.Image = ((System.Drawing.Image)(resources.GetObject("tsbInvoicePrinting.Image")));
            this.tsbInvoicePrinting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoicePrinting.Name = "tsbInvoicePrinting";
            this.tsbInvoicePrinting.Size = new System.Drawing.Size(92, 36);
            this.tsbInvoicePrinting.Text = "发票打印";
            this.tsbInvoicePrinting.ToolTipText = "发票打印";
            this.tsbInvoicePrinting.Click += new System.EventHandler(this.tsbInvoicePrinting_Click);
            // 
            // toolBtnWelcome
            // 
            this.toolBtnWelcome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnWelcome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnWelcome.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnWelcome.Image")));
            this.toolBtnWelcome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnWelcome.Name = "toolBtnWelcome";
            this.toolBtnWelcome.Size = new System.Drawing.Size(60, 21);
            this.toolBtnWelcome.Text = "欢迎您：";
            this.toolBtnWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolBtnWelcome.Click += new System.EventHandler(this.toolBtnWelcome_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // versionDataSet
            // 
            this.versionDataSet.DataSetName = "VersionDataSet";
            this.versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareVersionBindingSource
            // 
            this.softwareVersionBindingSource.DataMember = "SoftwareVersion";
            this.softwareVersionBindingSource.DataSource = this.versionDataSet;
            // 
            // softwareVersionTableAdapter
            // 
            this.softwareVersionTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 715);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareVersionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPreregister;
        private System.Windows.Forms.ToolStripButton tsbPreregManage;
        private System.Windows.Forms.ToolStripButton tsbPreregSignUpCourses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCoursesManage;
        private System.Windows.Forms.ToolStripButton tsbClassroomManage;
        private System.Windows.Forms.ToolStripButton tsbStudentsManage;
        private System.Windows.Forms.ToolStripButton tsbMaterialBuyList;
        private System.Windows.Forms.ToolStripButton tsbDepositList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolBtnWelcome;
        private System.Windows.Forms.ToolStripButton tsbCostList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Common.VersionDataSet versionDataSet;
        private System.Windows.Forms.BindingSource softwareVersionBindingSource;
        private Common.VersionDataSetTableAdapters.SoftwareVersionTableAdapter softwareVersionTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbLeftCourse;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripButton tsbStudentSignin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbInvoicePrinting;
    }
}