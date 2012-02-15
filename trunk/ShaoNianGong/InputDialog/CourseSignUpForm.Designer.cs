namespace ShaoNianGong
{
    partial class CourseSignUpForm
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
            this.courseSubTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chargeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staticDataSet = new ShaoNianGong.StaticDataSet();
            this.coursesTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CoursesTableAdapter();
            this.courseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTypesTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.CourseTypesTableAdapter();
            this.chargeTypeTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.ChargeTypeTableAdapter();
            this.courseSubtypesTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CourseSubtypesTableAdapter();
            this.discountLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountLevelTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.DiscountLevelTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.dtSignUpDate = new System.Windows.Forms.DateTimePicker();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.txtDiscountReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSignupTimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActualCostAmount = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCostType = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.cmbChargeMethod = new System.Windows.Forms.ComboBox();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstCourseSubtypes = new System.Windows.Forms.ListBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lstCourseType = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountLevelBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseSubTypesBindingSource
            // 
            this.courseSubTypesBindingSource.DataMember = "CourseSubtypes";
            this.courseSubTypesBindingSource.DataSource = this.coursesDataSet;
            this.courseSubTypesBindingSource.PositionChanged += new System.EventHandler(this.courseSubTypesBindingSource_PositionChanged);
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.coursesDataSet;
            this.coursesBindingSource.PositionChanged += new System.EventHandler(this.coursesBindingSource_PositionChanged);
            // 
            // chargeTypeBindingSource
            // 
            this.chargeTypeBindingSource.DataMember = "ChargeType";
            this.chargeTypeBindingSource.DataSource = this.staticDataSet;
            // 
            // staticDataSet
            // 
            this.staticDataSet.DataSetName = "StaticDataSet";
            this.staticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // courseTypesBindingSource
            // 
            this.courseTypesBindingSource.DataMember = "CourseTypes";
            this.courseTypesBindingSource.DataSource = this.staticDataSet;
            this.courseTypesBindingSource.PositionChanged += new System.EventHandler(this.courseTypesBindingSource_PositionChanged);
            // 
            // courseTypesTableAdapter
            // 
            this.courseTypesTableAdapter.ClearBeforeFill = true;
            // 
            // chargeTypeTableAdapter
            // 
            this.chargeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // courseSubtypesTableAdapter
            // 
            this.courseSubtypesTableAdapter.ClearBeforeFill = true;
            // 
            // discountLevelBindingSource
            // 
            this.discountLevelBindingSource.DataMember = "DiscountLevel";
            this.discountLevelBindingSource.DataSource = this.staticDataSet;
            // 
            // discountLevelTableAdapter
            // 
            this.discountLevelTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDiscount);
            this.groupBox3.Controls.Add(this.dtSignUpDate);
            this.groupBox3.Controls.Add(this.txtDiscountReason);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSignupTimes);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtActualCostAmount);
            this.groupBox3.Controls.Add(this.txtTotalCost);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtExpireDate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblCostType);
            this.groupBox3.Controls.Add(this.dtExpireDate);
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 175);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "缴费报名";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.DataSource = this.discountLevelBindingSource;
            this.cmbDiscount.DisplayMember = "DiscountLevelName";
            this.cmbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Location = new System.Drawing.Point(168, 76);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(115, 20);
            this.cmbDiscount.TabIndex = 22;
            this.cmbDiscount.ValueMember = "DiscountLevel";
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
            // 
            // dtSignUpDate
            // 
            this.dtSignUpDate.Location = new System.Drawing.Point(168, 48);
            this.dtSignUpDate.Name = "dtSignUpDate";
            this.dtSignUpDate.Size = new System.Drawing.Size(115, 21);
            this.dtSignUpDate.TabIndex = 21;
            this.dtSignUpDate.ValueChanged += new System.EventHandler(this.dtSignUpDate_ValueChanged);
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.Location = new System.Drawing.Point(374, 49);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(115, 21);
            this.dtExpireDate.TabIndex = 21;
            this.dtExpireDate.Visible = false;
            // 
            // txtDiscountReason
            // 
            this.txtDiscountReason.Location = new System.Drawing.Point(168, 103);
            this.txtDiscountReason.Multiline = true;
            this.txtDiscountReason.Name = "txtDiscountReason";
            this.txtDiscountReason.Size = new System.Drawing.Size(321, 51);
            this.txtDiscountReason.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "折扣：";
            // 
            // txtSignupTimes
            // 
            this.txtSignupTimes.Location = new System.Drawing.Point(168, 22);
            this.txtSignupTimes.Name = "txtSignupTimes";
            this.txtSignupTimes.Size = new System.Drawing.Size(80, 21);
            this.txtSignupTimes.TabIndex = 20;
            this.txtSignupTimes.Text = "1";
            this.txtSignupTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSignupTimes.TextChanged += new System.EventHandler(this.txtSignupTimes_TextChanged);
            this.txtSignupTimes.Leave += new System.EventHandler(this.txtSignupTimes_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "折扣原因：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "报名：";
            // 
            // txtActualCostAmount
            // 
            this.txtActualCostAmount.Location = new System.Drawing.Point(374, 76);
            this.txtActualCostAmount.Name = "txtActualCostAmount";
            this.txtActualCostAmount.ReadOnly = true;
            this.txtActualCostAmount.Size = new System.Drawing.Size(92, 21);
            this.txtActualCostAmount.TabIndex = 20;
            this.txtActualCostAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(374, 21);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(92, 21);
            this.txtTotalCost.TabIndex = 20;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCost.TextChanged += new System.EventHandler(this.txtTotalCost_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "到期时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "报名时间：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(472, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "折后费用：";
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.Location = new System.Drawing.Point(374, 49);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.ReadOnly = true;
            this.txtExpireDate.Size = new System.Drawing.Size(115, 21);
            this.txtExpireDate.TabIndex = 20;
            this.txtExpireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "共须费用：";
            // 
            // lblCostType
            // 
            this.lblCostType.AutoSize = true;
            this.lblCostType.Location = new System.Drawing.Point(254, 26);
            this.lblCostType.Name = "lblCostType";
            this.lblCostType.Size = new System.Drawing.Size(29, 12);
            this.lblCostType.TabIndex = 1;
            this.lblCostType.Text = "季度";
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(504, 588);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(94, 36);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "报名";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCourseName);
            this.groupBox5.Controls.Add(this.cmbChargeMethod);
            this.groupBox5.Controls.Add(this.txtCourseId);
            this.groupBox5.Controls.Add(this.txtCost);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(12, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(586, 82);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "课程信息";
            // 
            // txtCourseName
            // 
            this.txtCourseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseName", true));
            this.txtCourseName.Location = new System.Drawing.Point(168, 20);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(321, 21);
            this.txtCourseName.TabIndex = 21;
            // 
            // cmbChargeMethod
            // 
            this.cmbChargeMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "ChargeType", true));
            this.cmbChargeMethod.DataSource = this.chargeTypeBindingSource;
            this.cmbChargeMethod.DisplayMember = "ChargeTypeName";
            this.cmbChargeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChargeMethod.Enabled = false;
            this.cmbChargeMethod.FormattingEnabled = true;
            this.cmbChargeMethod.Location = new System.Drawing.Point(168, 52);
            this.cmbChargeMethod.Name = "cmbChargeMethod";
            this.cmbChargeMethod.Size = new System.Drawing.Size(115, 20);
            this.cmbChargeMethod.TabIndex = 22;
            this.cmbChargeMethod.ValueMember = "ChargeTypeID";
            this.cmbChargeMethod.TextChanged += new System.EventHandler(this.cmbChargeMethod_TextChanged);
            // 
            // txtCourseId
            // 
            this.txtCourseId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseID", true));
            this.txtCourseId.Location = new System.Drawing.Point(178, 20);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.ReadOnly = true;
            this.txtCourseId.Size = new System.Drawing.Size(92, 21);
            this.txtCourseId.TabIndex = 20;
            this.txtCourseId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "ChargeAmount", true));
            this.txtCost.Location = new System.Drawing.Point(374, 52);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(92, 21);
            this.txtCost.TabIndex = 20;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(97, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "课程名称：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(472, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "元";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(303, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "收取费用：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(97, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "收费方式：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstCourseSubtypes);
            this.groupBox4.Controls.Add(this.lstCourses);
            this.groupBox4.Controls.Add(this.lstCourseType);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(12, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 218);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "课程选择";
            // 
            // lstCourseSubtypes
            // 
            this.lstCourseSubtypes.DataSource = this.courseSubTypesBindingSource;
            this.lstCourseSubtypes.DisplayMember = "CourseSubtypeName";
            this.lstCourseSubtypes.FormattingEnabled = true;
            this.lstCourseSubtypes.ItemHeight = 12;
            this.lstCourseSubtypes.Location = new System.Drawing.Point(209, 66);
            this.lstCourseSubtypes.Name = "lstCourseSubtypes";
            this.lstCourseSubtypes.Size = new System.Drawing.Size(165, 136);
            this.lstCourseSubtypes.TabIndex = 29;
            this.lstCourseSubtypes.ValueMember = "ID";
            // 
            // lstCourses
            // 
            this.lstCourses.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "CourseID", true));
            this.lstCourses.DataSource = this.coursesBindingSource;
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 12;
            this.lstCourses.Location = new System.Drawing.Point(403, 66);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(166, 136);
            this.lstCourses.TabIndex = 28;
            this.lstCourses.ValueMember = "CourseID";
            // 
            // lstCourseType
            // 
            this.lstCourseType.FormattingEnabled = true;
            this.lstCourseType.ItemHeight = 12;
            this.lstCourseType.Location = new System.Drawing.Point(20, 66);
            this.lstCourseType.Name = "lstCourseType";
            this.lstCourseType.Size = new System.Drawing.Size(165, 136);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 58);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本资料";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(448, 23);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(97, 21);
            this.txtBalance.TabIndex = 2;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(551, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "余额：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(65, 23);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(120, 21);
            this.txtCardNo.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(254, 23);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(120, 21);
            this.txtName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "卡号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // CourseSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSignup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CourseSignUpForm";
            this.Text = "报名新课程";
            this.Load += new System.EventHandler(this.CourseSignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseSubTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountLevelBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource courseSubTypesBindingSource;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.BindingSource chargeTypeBindingSource;
        private StaticDataSet staticDataSet;
        private CoursesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource courseTypesBindingSource;
        private StaticDataSetTableAdapters.CourseTypesTableAdapter courseTypesTableAdapter;
        private StaticDataSetTableAdapters.ChargeTypeTableAdapter chargeTypeTableAdapter;
        private CoursesDataSetTableAdapters.CourseSubtypesTableAdapter courseSubtypesTableAdapter;
        private System.Windows.Forms.BindingSource discountLevelBindingSource;
        private StaticDataSetTableAdapters.DiscountLevelTableAdapter discountLevelTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.TextBox txtDiscountReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSignupTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActualCostAmount;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCostType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.ComboBox cmbChargeMethod;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstCourseSubtypes;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.ListBox lstCourseType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtSignUpDate;

    }
}