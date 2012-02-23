namespace ShaoNianGong
{
    partial class CourseUpdateForm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourseSubtype = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbChargeMethod = new System.Windows.Forms.ComboBox();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
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
            this.groupBox5.Controls.Add(this.cmbChargeMethod);
            this.groupBox5.Controls.Add(this.txtChargeAmount);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 154);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "课程信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 23);
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
            this.txtCourseSubtype.Location = new System.Drawing.Point(326, 20);
            this.txtCourseSubtype.Name = "txtCourseSubtype";
            this.txtCourseSubtype.ReadOnly = true;
            this.txtCourseSubtype.Size = new System.Drawing.Size(115, 21);
            this.txtCourseSubtype.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "元";
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(90, 20);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.ReadOnly = true;
            this.txtCourseType.Size = new System.Drawing.Size(115, 21);
            this.txtCourseType.TabIndex = 0;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(90, 63);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(351, 21);
            this.txtCourseName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "收取费用：";
            // 
            // cmbChargeMethod
            // 
            this.cmbChargeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChargeMethod.Enabled = false;
            this.cmbChargeMethod.FormattingEnabled = true;
            this.cmbChargeMethod.Items.AddRange(new object[] {
            "按季度收费",
            "按月份收费",
            "按课次收费"});
            this.cmbChargeMethod.Location = new System.Drawing.Point(90, 106);
            this.cmbChargeMethod.Name = "cmbChargeMethod";
            this.cmbChargeMethod.Size = new System.Drawing.Size(115, 20);
            this.cmbChargeMethod.TabIndex = 19;
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(328, 105);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.ReadOnly = true;
            this.txtChargeAmount.Size = new System.Drawing.Size(94, 21);
            this.txtChargeAmount.TabIndex = 0;
            this.txtChargeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "收费方式：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(396, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(306, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CourseUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 231);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "CourseUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改课程";
            this.Load += new System.EventHandler(this.CourseUpdateForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbChargeMethod;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}