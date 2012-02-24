﻿namespace ShaoNianGong
{
    partial class ChangeCourseForm
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
            this.dtSignUpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDiscountReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSignupTimes = new System.Windows.Forms.TextBox();
            this.lstCourseSubtypes = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lstCourseType = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActualCostAmount = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbChargeMethod = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtChangeCourseName = new System.Windows.Forms.TextBox();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCostType = new System.Windows.Forms.Label();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtCourseSubtype = new System.Windows.Forms.TextBox();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtChargeType = new System.Windows.Forms.TextBox();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.chargeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staticDataSet = new ShaoNianGong.StaticDataSet();
            this.chargeTypeTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.ChargeTypeTableAdapter();
            this.discountLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountLevelTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.DiscountLevelTableAdapter();
            this.courseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTypesTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.CourseTypesTableAdapter();
            this.courseSubtypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.courseSubtypesTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CourseSubtypesTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.CoursesTableAdapter();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubtypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSignUpDate
            // 
            this.dtSignUpDate.Location = new System.Drawing.Point(167, 48);
            this.dtSignUpDate.Name = "dtSignUpDate";
            this.dtSignUpDate.Size = new System.Drawing.Size(115, 21);
            this.dtSignUpDate.TabIndex = 21;
            // 
            // txtDiscountReason
            // 
            this.txtDiscountReason.Location = new System.Drawing.Point(167, 103);
            this.txtDiscountReason.Multiline = true;
            this.txtDiscountReason.Name = "txtDiscountReason";
            this.txtDiscountReason.Size = new System.Drawing.Size(321, 51);
            this.txtDiscountReason.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "折扣：";
            // 
            // txtSignupTimes
            // 
            this.txtSignupTimes.Location = new System.Drawing.Point(167, 22);
            this.txtSignupTimes.Name = "txtSignupTimes";
            this.txtSignupTimes.Size = new System.Drawing.Size(80, 21);
            this.txtSignupTimes.TabIndex = 20;
            this.txtSignupTimes.Text = "1";
            this.txtSignupTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstCourseSubtypes
            // 
            this.lstCourseSubtypes.DataSource = this.courseSubtypesBindingSource;
            this.lstCourseSubtypes.DisplayMember = "CourseSubtypeName";
            this.lstCourseSubtypes.FormattingEnabled = true;
            this.lstCourseSubtypes.ItemHeight = 12;
            this.lstCourseSubtypes.Location = new System.Drawing.Point(212, 50);
            this.lstCourseSubtypes.Name = "lstCourseSubtypes";
            this.lstCourseSubtypes.Size = new System.Drawing.Size(165, 136);
            this.lstCourseSubtypes.TabIndex = 29;
            this.lstCourseSubtypes.ValueMember = "ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstCourseSubtypes);
            this.groupBox4.Controls.Add(this.lstCourses);
            this.groupBox4.Controls.Add(this.lstCourseType);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(12, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 200);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "转入课程选择";
            // 
            // lstCourses
            // 
            this.lstCourses.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "CourseID", true));
            this.lstCourses.DataSource = this.coursesBindingSource;
            this.lstCourses.DisplayMember = "CourseName";
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 12;
            this.lstCourses.Location = new System.Drawing.Point(402, 50);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(166, 136);
            this.lstCourses.TabIndex = 28;
            this.lstCourses.ValueMember = "CourseID";
            // 
            // lstCourseType
            // 
            this.lstCourseType.FormattingEnabled = true;
            this.lstCourseType.ItemHeight = 12;
            this.lstCourseType.Location = new System.Drawing.Point(19, 50);
            this.lstCourseType.Name = "lstCourseType";
            this.lstCourseType.Size = new System.Drawing.Size(165, 136);
            this.lstCourseType.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(210, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "科目选择：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(400, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "课程列表：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "类别选择：";
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "ChargeAmount", true));
            this.txtCost.Location = new System.Drawing.Point(373, 52);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(92, 21);
            this.txtCost.TabIndex = 20;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(96, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "课程名称：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(471, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "元";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(302, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "收取费用：";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.DataSource = this.discountLevelBindingSource;
            this.cmbDiscount.DisplayMember = "DiscountLevelName";
            this.cmbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Location = new System.Drawing.Point(167, 76);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(115, 20);
            this.cmbDiscount.TabIndex = 22;
            this.cmbDiscount.ValueMember = "DiscountLevel";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(96, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "收费方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "报名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "折扣原因：";
            // 
            // txtActualCostAmount
            // 
            this.txtActualCostAmount.Location = new System.Drawing.Point(373, 76);
            this.txtActualCostAmount.Name = "txtActualCostAmount";
            this.txtActualCostAmount.ReadOnly = true;
            this.txtActualCostAmount.Size = new System.Drawing.Size(92, 21);
            this.txtActualCostAmount.TabIndex = 20;
            this.txtActualCostAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(373, 21);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(92, 21);
            this.txtTotalCost.TabIndex = 20;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "到期时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "折后费用：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "元";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(177, 20);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.ReadOnly = true;
            this.txtCourseId.Size = new System.Drawing.Size(92, 21);
            this.txtCourseId.TabIndex = 20;
            this.txtCourseId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "报名时间：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "元";
            // 
            // cmbChargeMethod
            // 
            this.cmbChargeMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "ChargeType", true));
            this.cmbChargeMethod.DataSource = this.chargeTypeBindingSource;
            this.cmbChargeMethod.DisplayMember = "ChargeTypeName";
            this.cmbChargeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChargeMethod.Enabled = false;
            this.cmbChargeMethod.FormattingEnabled = true;
            this.cmbChargeMethod.Location = new System.Drawing.Point(167, 52);
            this.cmbChargeMethod.Name = "cmbChargeMethod";
            this.cmbChargeMethod.Size = new System.Drawing.Size(115, 20);
            this.cmbChargeMethod.TabIndex = 22;
            this.cmbChargeMethod.ValueMember = "ChargeTypeID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtChangeCourseName);
            this.groupBox5.Controls.Add(this.cmbChargeMethod);
            this.groupBox5.Controls.Add(this.txtCourseId);
            this.groupBox5.Controls.Add(this.txtCost);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(12, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(586, 82);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "课程信息";
            // 
            // txtChangeCourseName
            // 
            this.txtChangeCourseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseName", true));
            this.txtChangeCourseName.Location = new System.Drawing.Point(167, 20);
            this.txtChangeCourseName.Name = "txtChangeCourseName";
            this.txtChangeCourseName.ReadOnly = true;
            this.txtChangeCourseName.Size = new System.Drawing.Size(321, 21);
            this.txtChangeCourseName.TabIndex = 21;
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.Location = new System.Drawing.Point(373, 49);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.ReadOnly = true;
            this.txtExpireDate.Size = new System.Drawing.Size(115, 21);
            this.txtExpireDate.TabIndex = 20;
            this.txtExpireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "共须费用：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(414, 647);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 36);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
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
            this.groupBox3.Location = new System.Drawing.Point(12, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 175);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "缴费报名";
            // 
            // lblCostType
            // 
            this.lblCostType.AutoSize = true;
            this.lblCostType.Location = new System.Drawing.Point(253, 26);
            this.lblCostType.Name = "lblCostType";
            this.lblCostType.Size = new System.Drawing.Size(29, 12);
            this.lblCostType.TabIndex = 1;
            this.lblCostType.Text = "季度";
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.Location = new System.Drawing.Point(373, 49);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(115, 21);
            this.dtExpireDate.TabIndex = 21;
            this.dtExpireDate.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(514, 647);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 36);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.txtCourseSubtype);
            this.groupBox1.Controls.Add(this.txtCourseType);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtChargeType);
            this.groupBox1.Controls.Add(this.txtChargeAmount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 151);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(452, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 12);
            this.label25.TabIndex = 26;
            this.label25.Text = "元";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "账户余额：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "所属科目：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "所属类别：";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(354, 24);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(92, 21);
            this.txtBalance.TabIndex = 22;
            // 
            // txtCourseSubtype
            // 
            this.txtCourseSubtype.Location = new System.Drawing.Point(354, 55);
            this.txtCourseSubtype.Name = "txtCourseSubtype";
            this.txtCourseSubtype.ReadOnly = true;
            this.txtCourseSubtype.Size = new System.Drawing.Size(203, 21);
            this.txtCourseSubtype.TabIndex = 22;
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(90, 55);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.ReadOnly = true;
            this.txtCourseType.Size = new System.Drawing.Size(148, 21);
            this.txtCourseType.TabIndex = 23;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(90, 83);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(467, 21);
            this.txtCourseName.TabIndex = 21;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(90, 24);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(148, 21);
            this.txtStudentName.TabIndex = 20;
            // 
            // txtChargeType
            // 
            this.txtChargeType.Location = new System.Drawing.Point(90, 113);
            this.txtChargeType.Name = "txtChargeType";
            this.txtChargeType.ReadOnly = true;
            this.txtChargeType.Size = new System.Drawing.Size(148, 21);
            this.txtChargeType.TabIndex = 20;
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(354, 113);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.ReadOnly = true;
            this.txtChargeAmount.Size = new System.Drawing.Size(92, 21);
            this.txtChargeAmount.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "课程名称：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "元";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "学生姓名：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(283, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "收取费用：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 116);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 1;
            this.label24.Text = "收费方式：";
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
            // chargeTypeTableAdapter
            // 
            this.chargeTypeTableAdapter.ClearBeforeFill = true;
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
            // courseSubtypesBindingSource
            // 
            this.courseSubtypesBindingSource.DataMember = "CourseSubtypes";
            this.courseSubtypesBindingSource.DataSource = this.coursesDataSet;
            this.courseSubtypesBindingSource.PositionChanged += new System.EventHandler(this.courseSubtypesBindingSource_PositionChanged);
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseSubtypesTableAdapter
            // 
            this.courseSubtypesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.coursesDataSet;
            this.coursesBindingSource.PositionChanged += new System.EventHandler(this.coursesBindingSource_PositionChanged);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // ChangeCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChangeCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生转班";
            this.Load += new System.EventHandler(this.ChangeCourseForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubtypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtSignUpDate;
        private System.Windows.Forms.TextBox txtDiscountReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSignupTimes;
        private System.Windows.Forms.ListBox lstCourseSubtypes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.ListBox lstCourseType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActualCostAmount;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbChargeMethod;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtChangeCourseName;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCostType;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtCourseSubtype;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtChargeType;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.BindingSource chargeTypeBindingSource;
        private StaticDataSet staticDataSet;
        private StaticDataSetTableAdapters.ChargeTypeTableAdapter chargeTypeTableAdapter;
        private System.Windows.Forms.BindingSource discountLevelBindingSource;
        private StaticDataSetTableAdapters.DiscountLevelTableAdapter discountLevelTableAdapter;
        private System.Windows.Forms.BindingSource courseTypesBindingSource;
        private StaticDataSetTableAdapters.CourseTypesTableAdapter courseTypesTableAdapter;
        private System.Windows.Forms.BindingSource courseSubtypesBindingSource;
        private CoursesDataSet coursesDataSet;
        private CoursesDataSetTableAdapters.CourseSubtypesTableAdapter courseSubtypesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CoursesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
    }
}