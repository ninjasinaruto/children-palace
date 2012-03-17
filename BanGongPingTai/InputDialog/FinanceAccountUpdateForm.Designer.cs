namespace BanGongPingTai
{
    partial class FinanceAccountUpdateForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPay = new DevComponents.Editors.DoubleInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncome = new DevComponents.Editors.DoubleInput();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(87, 181);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(64, 143);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(277, 21);
            this.txtRemark.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 46;
            this.label5.Text = "备注：";
            // 
            // txtPay
            // 
            this.txtPay.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtPay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPay.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPay.Increment = 1D;
            this.txtPay.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtPay.Location = new System.Drawing.Point(64, 108);
            this.txtPay.MinValue = 0D;
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(166, 21);
            this.txtPay.TabIndex = 39;
            this.txtPay.WatermarkText = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 45;
            this.label4.Text = "支出：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 44;
            this.label3.Text = "收入：";
            // 
            // txtIncome
            // 
            this.txtIncome.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtIncome.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtIncome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIncome.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtIncome.Increment = 1D;
            this.txtIncome.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtIncome.Location = new System.Drawing.Point(64, 74);
            this.txtIncome.MinValue = 0D;
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(166, 21);
            this.txtIncome.TabIndex = 38;
            this.txtIncome.WatermarkText = "0.00";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(64, 43);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(277, 21);
            this.txtSummary.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "摘要：";
            // 
            // dtCreateDate
            // 
            this.dtCreateDate.Location = new System.Drawing.Point(64, 11);
            this.dtCreateDate.Name = "dtCreateDate";
            this.dtCreateDate.Size = new System.Drawing.Size(119, 21);
            this.dtCreateDate.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "日期：";
            // 
            // FinanceAccountUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCreateDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FinanceAccountUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改明细";
            this.Load += new System.EventHandler(this.FinanceAccountUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.DoubleInput txtPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DoubleInput txtIncome;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtCreateDate;
        private System.Windows.Forms.Label label1;
    }
}