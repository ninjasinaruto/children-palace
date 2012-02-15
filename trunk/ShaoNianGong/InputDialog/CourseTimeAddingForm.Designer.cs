namespace ShaoNianGong
{
    partial class CourseTimeAddingForm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourseSubtype = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChargeType = new System.Windows.Forms.TextBox();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtCourseEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtCourseBeginTime = new System.Windows.Forms.DateTimePicker();
            this.cmbClassroom = new System.Windows.Forms.ComboBox();
            this.cmbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.staticDataSet = new ShaoNianGong.StaticDataSet();
            this.dayOfWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayOfWeekTableAdapter = new ShaoNianGong.StaticDataSetTableAdapters.DayOfWeekTableAdapter();
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.classroomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classroomsTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.ClassroomsTableAdapter();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtCourseSubtype);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtCourseType);
            this.groupBox5.Controls.Add(this.txtCourseName);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtChargeType);
            this.groupBox5.Controls.Add(this.txtChargeAmount);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(479, 146);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "课程信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "所属科目：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "所属类别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "课程名称：";
            // 
            // txtCourseSubtype
            // 
            this.txtCourseSubtype.Location = new System.Drawing.Point(314, 20);
            this.txtCourseSubtype.Name = "txtCourseSubtype";
            this.txtCourseSubtype.ReadOnly = true;
            this.txtCourseSubtype.Size = new System.Drawing.Size(115, 21);
            this.txtCourseSubtype.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "元";
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(91, 20);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.ReadOnly = true;
            this.txtCourseType.Size = new System.Drawing.Size(115, 21);
            this.txtCourseType.TabIndex = 0;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(91, 63);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(338, 21);
            this.txtCourseName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "收取费用：";
            // 
            // txtChargeType
            // 
            this.txtChargeType.Location = new System.Drawing.Point(91, 106);
            this.txtChargeType.Name = "txtChargeType";
            this.txtChargeType.ReadOnly = true;
            this.txtChargeType.Size = new System.Drawing.Size(115, 21);
            this.txtChargeType.TabIndex = 0;
            this.txtChargeType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(314, 105);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.ReadOnly = true;
            this.txtChargeAmount.Size = new System.Drawing.Size(94, 21);
            this.txtChargeAmount.TabIndex = 0;
            this.txtChargeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "收费方式：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(426, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(340, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtCourseEndTime
            // 
            this.dtCourseEndTime.CustomFormat = "        HH:mm";
            this.dtCourseEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCourseEndTime.Location = new System.Drawing.Point(316, 73);
            this.dtCourseEndTime.Name = "dtCourseEndTime";
            this.dtCourseEndTime.ShowUpDown = true;
            this.dtCourseEndTime.Size = new System.Drawing.Size(115, 21);
            this.dtCourseEndTime.TabIndex = 31;
            // 
            // dtCourseBeginTime
            // 
            this.dtCourseBeginTime.CustomFormat = "        HH:mm";
            this.dtCourseBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCourseBeginTime.Location = new System.Drawing.Point(93, 73);
            this.dtCourseBeginTime.Name = "dtCourseBeginTime";
            this.dtCourseBeginTime.ShowUpDown = true;
            this.dtCourseBeginTime.Size = new System.Drawing.Size(115, 21);
            this.dtCourseBeginTime.TabIndex = 32;
            // 
            // cmbClassroom
            // 
            this.cmbClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassroom.FormattingEnabled = true;
            this.cmbClassroom.Location = new System.Drawing.Point(316, 29);
            this.cmbClassroom.Name = "cmbClassroom";
            this.cmbClassroom.Size = new System.Drawing.Size(115, 20);
            this.cmbClassroom.TabIndex = 29;
            // 
            // cmbDayOfWeek
            // 
            this.cmbDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayOfWeek.FormattingEnabled = true;
            this.cmbDayOfWeek.Location = new System.Drawing.Point(93, 29);
            this.cmbDayOfWeek.Name = "cmbDayOfWeek";
            this.cmbDayOfWeek.Size = new System.Drawing.Size(115, 20);
            this.cmbDayOfWeek.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "上课日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "开课时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "下课时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "上课教室：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtCourseEndTime);
            this.groupBox1.Controls.Add(this.dtCourseBeginTime);
            this.groupBox1.Controls.Add(this.cmbClassroom);
            this.groupBox1.Controls.Add(this.cmbDayOfWeek);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(10, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 119);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课时信息";
            // 
            // staticDataSet
            // 
            this.staticDataSet.DataSetName = "StaticDataSet";
            this.staticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dayOfWeekBindingSource
            // 
            this.dayOfWeekBindingSource.DataMember = "DayOfWeek";
            this.dayOfWeekBindingSource.DataSource = this.staticDataSet;
            // 
            // dayOfWeekTableAdapter
            // 
            this.dayOfWeekTableAdapter.ClearBeforeFill = true;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classroomsBindingSource
            // 
            this.classroomsBindingSource.DataMember = "Classrooms";
            this.classroomsBindingSource.DataSource = this.coursesDataSet;
            // 
            // classroomsTableAdapter
            // 
            this.classroomsTableAdapter.ClearBeforeFill = true;
            // 
            // CourseTimeAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CourseTimeAddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课程时间";
            this.Load += new System.EventHandler(this.CourseTimeAddingForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOfWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourseSubtype;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtChargeType;
        private System.Windows.Forms.DateTimePicker dtCourseEndTime;
        private System.Windows.Forms.DateTimePicker dtCourseBeginTime;
        private System.Windows.Forms.ComboBox cmbClassroom;
        private System.Windows.Forms.ComboBox cmbDayOfWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private StaticDataSet staticDataSet;
        private System.Windows.Forms.BindingSource dayOfWeekBindingSource;
        private StaticDataSetTableAdapters.DayOfWeekTableAdapter dayOfWeekTableAdapter;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource classroomsBindingSource;
        private CoursesDataSetTableAdapters.ClassroomsTableAdapter classroomsTableAdapter;
    }
}