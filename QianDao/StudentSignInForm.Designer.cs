namespace QianDao
{
    partial class StudentSignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSignInForm));
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentSignInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signInDataSet = new QianDao.SignInDataSet();
            this.studentSignInTableAdapter = new QianDao.SignInDataSetTableAdapters.StudentSignInTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new QianDao.SignInDataSetTableAdapters.StudentsTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new QianDao.SignInDataSetTableAdapters.CoursesTableAdapter();
            this.studentCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCostTableAdapter = new QianDao.SignInDataSetTableAdapters.StudentCostTableAdapter();
            this.studentCourseTableAdapter = new QianDao.SignInDataSetTableAdapters.StudentCourseTableAdapter();
            this.studentCoursesCostbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCoursesCostTableAdapter = new QianDao.SignInDataSetTableAdapters.studentCoursesCostTableAdapter();
            this.vCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCardsTableAdapter = new QianDao.SignInDataSetTableAdapters.VCardsTableAdapter();
            this.teacherSigninBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherSigninTableAdapter = new QianDao.SignInDataSetTableAdapters.TeacherSigninTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentSignInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesCostbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSigninBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardNo.Location = new System.Drawing.Point(407, 68);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(406, 71);
            this.txtCardNo.TabIndex = 1;
            this.txtCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNo_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStatus.Location = new System.Drawing.Point(397, 645);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(252, 56);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "刷卡成功";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(76)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(196, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(76)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(196, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(397, 223);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(997, 56);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "陈先文（到期时间：2012年03月31日）";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.BackColor = System.Drawing.Color.Transparent;
            this.lblCardType.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCardType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCardType.Location = new System.Drawing.Point(397, 366);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(195, 56);
            this.lblCardType.TabIndex = 0;
            this.lblCardType.Text = "普通卡";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(76)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(82, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 56);
            this.label6.TabIndex = 0;
            this.label6.Text = "卡片类型：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTime.Location = new System.Drawing.Point(397, 509);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(256, 56);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "20:55:41";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(76)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(82, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 56);
            this.label8.TabIndex = 0;
            this.label8.Text = "刷卡时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(76)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(82, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "刷卡结果：";
            // 
            // studentSignInBindingSource
            // 
            this.studentSignInBindingSource.DataMember = "StudentSignIn";
            this.studentSignInBindingSource.DataSource = this.signInDataSet;
            // 
            // signInDataSet
            // 
            this.signInDataSet.DataSetName = "SignInDataSet";
            this.signInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentSignInTableAdapter
            // 
            this.studentSignInTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.signInDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.signInDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // studentCoursesBindingSource
            // 
            this.studentCoursesBindingSource.DataMember = "StudentCourse";
            this.studentCoursesBindingSource.DataSource = this.signInDataSet;
            // 
            // studentCostBindingSource
            // 
            this.studentCostBindingSource.DataMember = "StudentCost";
            this.studentCostBindingSource.DataSource = this.signInDataSet;
            // 
            // studentCostTableAdapter
            // 
            this.studentCostTableAdapter.ClearBeforeFill = true;
            // 
            // studentCourseTableAdapter
            // 
            this.studentCourseTableAdapter.ClearBeforeFill = true;
            // 
            // studentCoursesCostbindingSource
            // 
            this.studentCoursesCostbindingSource.DataMember = "studentCoursesCost";
            this.studentCoursesCostbindingSource.DataSource = this.signInDataSet;
            // 
            // studentCoursesCostTableAdapter
            // 
            this.studentCoursesCostTableAdapter.ClearBeforeFill = true;
            // 
            // vCardsBindingSource
            // 
            this.vCardsBindingSource.DataMember = "VCards";
            this.vCardsBindingSource.DataSource = this.signInDataSet;
            // 
            // vCardsTableAdapter
            // 
            this.vCardsTableAdapter.ClearBeforeFill = true;
            // 
            // teacherSigninBindingSource
            // 
            this.teacherSigninBindingSource.DataMember = "TeacherSignin";
            this.teacherSigninBindingSource.DataSource = this.signInDataSet;
            // 
            // teacherSigninTableAdapter
            // 
            this.teacherSigninTableAdapter.ClearBeforeFill = true;
            // 
            // StudentSignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1390, 768);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentSignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "签到平台";
            this.Activated += new System.EventHandler(this.StudentSignInForm_Activated);
            this.Deactivate += new System.EventHandler(this.StudentSignInForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentSignInForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentSignInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentSignInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesCostbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSigninBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblStatus;
        private SignInDataSet signInDataSet;
        private System.Windows.Forms.BindingSource studentSignInBindingSource;
        private SignInDataSetTableAdapters.StudentSignInTableAdapter studentSignInTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private SignInDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private SignInDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource studentCoursesBindingSource;
        private SignInDataSetTableAdapters.StudentCourseTableAdapter studentCourseTableAdapter;
        private System.Windows.Forms.BindingSource studentCostBindingSource;
        private SignInDataSetTableAdapters.StudentCostTableAdapter studentCostTableAdapter;
        private System.Windows.Forms.BindingSource studentCoursesCostbindingSource;
        private SignInDataSetTableAdapters.studentCoursesCostTableAdapter studentCoursesCostTableAdapter;
        private System.Windows.Forms.BindingSource vCardsBindingSource;
        private SignInDataSetTableAdapters.VCardsTableAdapter vCardsTableAdapter;
        private System.Windows.Forms.BindingSource teacherSigninBindingSource;
        private SignInDataSetTableAdapters.TeacherSigninTableAdapter teacherSigninTableAdapter;
    }
}

