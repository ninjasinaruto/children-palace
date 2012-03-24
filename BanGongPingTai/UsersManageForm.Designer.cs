namespace BanGongPingTai
{
    partial class UsersManageForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkLstCourses = new System.Windows.Forms.CheckedListBox();
            this.lstCourseSubtypes = new System.Windows.Forms.ListBox();
            this.courseSubtypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new BanGongPingTai.UsersDataSet();
            this.lstCourseType = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstUserCourses = new System.Windows.Forms.ListBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new BanGongPingTai.UsersDataSetTableAdapters.UsersTableAdapter();
            this.userCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCoursesTableAdapter = new BanGongPingTai.UsersDataSetTableAdapters.UserCoursesTableAdapter();
            this.courseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTypesTableAdapter = new BanGongPingTai.UsersDataSetTableAdapters.CourseTypesTableAdapter();
            this.courseSubtypesTableAdapter = new BanGongPingTai.UsersDataSetTableAdapters.CourseSubtypesTableAdapter();
            this.coursesTableAdapter = new BanGongPingTai.UsersDataSetTableAdapters.CoursesTableAdapter();
            this.chkboxAll = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubtypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkboxAll);
            this.groupBox4.Controls.Add(this.chkLstCourses);
            this.groupBox4.Controls.Add(this.lstCourseSubtypes);
            this.groupBox4.Controls.Add(this.lstCourseType);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(213, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 296);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "权限设置";
            // 
            // chkLstCourses
            // 
            this.chkLstCourses.CheckOnClick = true;
            this.chkLstCourses.FormattingEnabled = true;
            this.chkLstCourses.Location = new System.Drawing.Point(403, 62);
            this.chkLstCourses.Name = "chkLstCourses";
            this.chkLstCourses.Size = new System.Drawing.Size(165, 212);
            this.chkLstCourses.TabIndex = 37;
            this.chkLstCourses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkLstCourses_ItemCheck);
            // 
            // lstCourseSubtypes
            // 
            this.lstCourseSubtypes.DataSource = this.courseSubtypesBindingSource;
            this.lstCourseSubtypes.DisplayMember = "CourseSubtypeName";
            this.lstCourseSubtypes.FormattingEnabled = true;
            this.lstCourseSubtypes.ItemHeight = 12;
            this.lstCourseSubtypes.Location = new System.Drawing.Point(209, 66);
            this.lstCourseSubtypes.Name = "lstCourseSubtypes";
            this.lstCourseSubtypes.Size = new System.Drawing.Size(165, 208);
            this.lstCourseSubtypes.TabIndex = 29;
            this.lstCourseSubtypes.ValueMember = "ID";
            // 
            // courseSubtypesBindingSource
            // 
            this.courseSubtypesBindingSource.DataMember = "CourseSubtypes";
            this.courseSubtypesBindingSource.DataSource = this.usersDataSet;
            this.courseSubtypesBindingSource.PositionChanged += new System.EventHandler(this.courseSubtypesBindingSource_PositionChanged);
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstCourseType
            // 
            this.lstCourseType.FormattingEnabled = true;
            this.lstCourseType.ItemHeight = 12;
            this.lstCourseType.Location = new System.Drawing.Point(20, 66);
            this.lstCourseType.Name = "lstCourseType";
            this.lstCourseType.Size = new System.Drawing.Size(165, 208);
            this.lstCourseType.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(207, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "科目选择：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(401, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "课程列表：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "类别选择：";
            // 
            // lstUsers
            // 
            this.lstUsers.DataSource = this.usersBindingSource;
            this.lstUsers.DisplayMember = "UserName";
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 12;
            this.lstUsers.Location = new System.Drawing.Point(14, 32);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(166, 364);
            this.lstUsers.TabIndex = 26;
            this.lstUsers.ValueMember = "UserName";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            this.usersBindingSource.PositionChanged += new System.EventHandler(this.usersBindingSource_PositionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 410);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合作用户列表";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(430, 59);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(86, 33);
            this.btnAddUser.TabIndex = 38;
            this.btnAddUser.Text = "添加用户";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(79, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(92, 21);
            this.txtUserName.TabIndex = 40;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "用户名：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(241, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(92, 21);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "密码：";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(424, 32);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(92, 21);
            this.txtConfirmPassword.TabIndex = 44;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "确认密码：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConfirmPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 108);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加合作用户";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstUserCourses);
            this.groupBox3.Location = new System.Drawing.Point(794, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 410);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "已授权课程列表";
            // 
            // lstUserCourses
            // 
            this.lstUserCourses.FormattingEnabled = true;
            this.lstUserCourses.ItemHeight = 12;
            this.lstUserCourses.Location = new System.Drawing.Point(14, 32);
            this.lstUserCourses.Name = "lstUserCourses";
            this.lstUserCourses.Size = new System.Drawing.Size(259, 364);
            this.lstUserCourses.TabIndex = 26;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.usersDataSet;
            this.coursesBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.coursesBindingSource_BindingComplete);
            this.coursesBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.coursesBindingSource_ListChanged);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userCoursesBindingSource
            // 
            this.userCoursesBindingSource.DataMember = "UserCourses";
            this.userCoursesBindingSource.DataSource = this.usersDataSet;
            this.userCoursesBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.userCoursesBindingSource_ListChanged);
            // 
            // userCoursesTableAdapter
            // 
            this.userCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // courseTypesBindingSource
            // 
            this.courseTypesBindingSource.DataMember = "CourseTypes";
            this.courseTypesBindingSource.DataSource = this.usersDataSet;
            this.courseTypesBindingSource.PositionChanged += new System.EventHandler(this.courseTypesBindingSource_PositionChanged);
            // 
            // courseTypesTableAdapter
            // 
            this.courseTypesTableAdapter.ClearBeforeFill = true;
            // 
            // courseSubtypesTableAdapter
            // 
            this.courseSubtypesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // chkboxAll
            // 
            this.chkboxAll.AutoSize = true;
            this.chkboxAll.Location = new System.Drawing.Point(466, 33);
            this.chkboxAll.Name = "chkboxAll";
            this.chkboxAll.Size = new System.Drawing.Size(48, 16);
            this.chkboxAll.TabIndex = 38;
            this.chkboxAll.Text = "全选";
            this.chkboxAll.UseVisualStyleBackColor = true;
            this.chkboxAll.Click += new System.EventHandler(this.chkboxAll_Click);
            // 
            // UsersManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "UsersManageForm";
            this.Text = "合作用户管理";
            this.Load += new System.EventHandler(this.UsersManageForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubtypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox chkLstCourses;
        private System.Windows.Forms.ListBox lstCourseSubtypes;
        private System.Windows.Forms.ListBox lstCourseType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstUserCourses;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource userCoursesBindingSource;
        private UsersDataSetTableAdapters.UserCoursesTableAdapter userCoursesTableAdapter;
        private System.Windows.Forms.BindingSource courseTypesBindingSource;
        private UsersDataSetTableAdapters.CourseTypesTableAdapter courseTypesTableAdapter;
        private System.Windows.Forms.BindingSource courseSubtypesBindingSource;
        private UsersDataSetTableAdapters.CourseSubtypesTableAdapter courseSubtypesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private UsersDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.CheckBox chkboxAll;
    }
}