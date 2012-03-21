namespace BanGongPingTai
{
    partial class UpdateTeacherSigninReportForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLeave = new DevComponents.Editors.DoubleInput();
            this.txtSickLeave = new DevComponents.Editors.DoubleInput();
            this.txtGoOut = new DevComponents.Editors.DoubleInput();
            this.txtBeLate = new DevComponents.Editors.IntegerInput();
            this.txtLeaveEarly = new DevComponents.Editors.IntegerInput();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSickLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeLate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeaveEarly)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "事假（天）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "病假（天）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "外出（时）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "迟到（分）：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "早退（分）：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注：";
            // 
            // txtLeave
            // 
            this.txtLeave.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtLeave.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLeave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLeave.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLeave.DisplayFormat = "0.0";
            this.txtLeave.Increment = 1D;
            this.txtLeave.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtLeave.Location = new System.Drawing.Point(109, 12);
            this.txtLeave.MinValue = 0D;
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.Size = new System.Drawing.Size(258, 21);
            this.txtLeave.TabIndex = 6;
            this.txtLeave.WatermarkText = "0.0";
            // 
            // txtSickLeave
            // 
            this.txtSickLeave.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtSickLeave.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSickLeave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSickLeave.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtSickLeave.DisplayFormat = "0.0";
            this.txtSickLeave.Increment = 1D;
            this.txtSickLeave.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtSickLeave.Location = new System.Drawing.Point(109, 47);
            this.txtSickLeave.MinValue = 0D;
            this.txtSickLeave.Name = "txtSickLeave";
            this.txtSickLeave.Size = new System.Drawing.Size(258, 21);
            this.txtSickLeave.TabIndex = 7;
            this.txtSickLeave.WatermarkText = "0.0";
            // 
            // txtGoOut
            // 
            this.txtGoOut.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtGoOut.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtGoOut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGoOut.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtGoOut.DisplayFormat = "0.0";
            this.txtGoOut.Increment = 1D;
            this.txtGoOut.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtGoOut.Location = new System.Drawing.Point(109, 82);
            this.txtGoOut.MinValue = 0D;
            this.txtGoOut.Name = "txtGoOut";
            this.txtGoOut.Size = new System.Drawing.Size(258, 21);
            this.txtGoOut.TabIndex = 8;
            this.txtGoOut.WatermarkText = "0.0";
            // 
            // txtBeLate
            // 
            this.txtBeLate.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtBeLate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtBeLate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBeLate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtBeLate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtBeLate.Location = new System.Drawing.Point(109, 119);
            this.txtBeLate.MinValue = 0;
            this.txtBeLate.Name = "txtBeLate";
            this.txtBeLate.Size = new System.Drawing.Size(258, 21);
            this.txtBeLate.TabIndex = 9;
            this.txtBeLate.WatermarkText = "0";
            // 
            // txtLeaveEarly
            // 
            this.txtLeaveEarly.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtLeaveEarly.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLeaveEarly.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLeaveEarly.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLeaveEarly.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtLeaveEarly.Location = new System.Drawing.Point(109, 154);
            this.txtLeaveEarly.MinValue = 0;
            this.txtLeaveEarly.Name = "txtLeaveEarly";
            this.txtLeaveEarly.Size = new System.Drawing.Size(258, 21);
            this.txtLeaveEarly.TabIndex = 10;
            this.txtLeaveEarly.WatermarkText = "0";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(109, 190);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(258, 21);
            this.txtRemark.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(109, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 40);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateTeacherSigninReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtLeaveEarly);
            this.Controls.Add(this.txtBeLate);
            this.Controls.Add(this.txtGoOut);
            this.Controls.Add(this.txtSickLeave);
            this.Controls.Add(this.txtLeave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UpdateTeacherSigninReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "备注考勤信息";
            this.Load += new System.EventHandler(this.UpdateTeacherSigninReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSickLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeLate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeaveEarly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DoubleInput txtLeave;
        private DevComponents.Editors.DoubleInput txtSickLeave;
        private DevComponents.Editors.DoubleInput txtGoOut;
        private DevComponents.Editors.IntegerInput txtBeLate;
        private DevComponents.Editors.IntegerInput txtLeaveEarly;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}