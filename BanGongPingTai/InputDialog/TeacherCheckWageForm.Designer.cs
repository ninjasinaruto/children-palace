namespace BanGongPingTai
{
    partial class TeacherCheckWageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblWageTime = new System.Windows.Forms.Label();
            this.lblTeacherWage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacherPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "工资月份：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "当月实发工资：";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTeacherName.Location = new System.Drawing.Point(100, 64);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(69, 19);
            this.lblTeacherName.TabIndex = 3;
            this.lblTeacherName.Text = "某某莫";
            // 
            // lblWageTime
            // 
            this.lblWageTime.AutoSize = true;
            this.lblWageTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWageTime.Location = new System.Drawing.Point(271, 66);
            this.lblWageTime.Name = "lblWageTime";
            this.lblWageTime.Size = new System.Drawing.Size(87, 16);
            this.lblWageTime.TabIndex = 4;
            this.lblWageTime.Text = "2012年2月";
            // 
            // lblTeacherWage
            // 
            this.lblTeacherWage.AutoSize = true;
            this.lblTeacherWage.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTeacherWage.ForeColor = System.Drawing.Color.Red;
            this.lblTeacherWage.Location = new System.Drawing.Point(101, 92);
            this.lblTeacherWage.Name = "lblTeacherWage";
            this.lblTeacherWage.Size = new System.Drawing.Size(74, 20);
            this.lblTeacherWage.TabIndex = 5;
            this.lblTeacherWage.Text = "2000元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "核实密码：";
            // 
            // txtTeacherPwd
            // 
            this.txtTeacherPwd.Location = new System.Drawing.Point(274, 91);
            this.txtTeacherPwd.Name = "txtTeacherPwd";
            this.txtTeacherPwd.PasswordChar = '*';
            this.txtTeacherPwd.Size = new System.Drawing.Size(118, 21);
            this.txtTeacherPwd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 54);
            this.label7.TabIndex = 8;
            this.label7.Text = "请核实以下信息是否正确，若正确请输入您的密码完成核实操作。";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(114, 126);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 33);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "确定";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TeacherCheckWageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 171);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTeacherPwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTeacherWage);
            this.Controls.Add(this.lblWageTime);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TeacherCheckWageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师核实";
            this.Load += new System.EventHandler(this.TeacherCheckWageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblWageTime;
        private System.Windows.Forms.Label lblTeacherWage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeacherPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCancel;
    }
}