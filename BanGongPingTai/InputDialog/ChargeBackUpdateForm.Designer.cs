namespace BanGongPingTai
{
    partial class ChargeBackUpdateForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtChargeBackAmount = new DevComponents.Editors.DoubleInput();
            this.txtChargeBackNum = new DevComponents.Editors.IntegerInput();
            this.txtStandardPrice = new DevComponents.Editors.DoubleInput();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtChargeBackType = new System.Windows.Forms.TextBox();
            this.cbChargeBackName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeBackAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeBackNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "确定";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtChargeBackAmount
            // 
            this.txtChargeBackAmount.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtChargeBackAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtChargeBackAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChargeBackAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtChargeBackAmount.Increment = 1D;
            this.txtChargeBackAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtChargeBackAmount.Location = new System.Drawing.Point(99, 137);
            this.txtChargeBackAmount.MinValue = 0D;
            this.txtChargeBackAmount.Name = "txtChargeBackAmount";
            this.txtChargeBackAmount.Size = new System.Drawing.Size(161, 21);
            this.txtChargeBackAmount.TabIndex = 5;
            this.txtChargeBackAmount.WatermarkText = "0";
            // 
            // txtChargeBackNum
            // 
            this.txtChargeBackNum.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtChargeBackNum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtChargeBackNum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChargeBackNum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtChargeBackNum.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtChargeBackNum.Location = new System.Drawing.Point(99, 107);
            this.txtChargeBackNum.MinValue = 0;
            this.txtChargeBackNum.Name = "txtChargeBackNum";
            this.txtChargeBackNum.Size = new System.Drawing.Size(80, 21);
            this.txtChargeBackNum.TabIndex = 4;
            this.txtChargeBackNum.WatermarkText = "0";
            this.txtChargeBackNum.ValueChanged += new System.EventHandler(this.txtChargeBackNum_ValueChanged);
            // 
            // txtStandardPrice
            // 
            this.txtStandardPrice.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtStandardPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtStandardPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStandardPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtStandardPrice.Increment = 1D;
            this.txtStandardPrice.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtStandardPrice.Location = new System.Drawing.Point(99, 75);
            this.txtStandardPrice.MinValue = 0D;
            this.txtStandardPrice.Name = "txtStandardPrice";
            this.txtStandardPrice.Size = new System.Drawing.Size(161, 21);
            this.txtStandardPrice.TabIndex = 3;
            this.txtStandardPrice.WatermarkText = "0";
            this.txtStandardPrice.ValueChanged += new System.EventHandler(this.txtStandardPrice_ValueChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(99, 169);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(161, 21);
            this.txtRemark.TabIndex = 6;
            // 
            // txtChargeBackType
            // 
            this.txtChargeBackType.Location = new System.Drawing.Point(99, 46);
            this.txtChargeBackType.Name = "txtChargeBackType";
            this.txtChargeBackType.Size = new System.Drawing.Size(161, 21);
            this.txtChargeBackType.TabIndex = 2;
            // 
            // cbChargeBackName
            // 
            this.cbChargeBackName.FormattingEnabled = true;
            this.cbChargeBackName.Items.AddRange(new object[] {
            "迟到处罚",
            "请假处罚",
            "旷工处罚",
            "代扣",
            "其他"});
            this.cbChargeBackName.Location = new System.Drawing.Point(99, 15);
            this.cbChargeBackName.Name = "cbChargeBackName";
            this.cbChargeBackName.Size = new System.Drawing.Size(121, 20);
            this.cbChargeBackName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "对应标准：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "扣款类别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "扣款项目：";
            // 
            // ChargeBackUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 246);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtChargeBackAmount);
            this.Controls.Add(this.txtChargeBackNum);
            this.Controls.Add(this.txtStandardPrice);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtChargeBackType);
            this.Controls.Add(this.cbChargeBackName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChargeBackUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改扣款项目";
            this.Load += new System.EventHandler(this.ChargeBackUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeBackAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeBackNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private DevComponents.Editors.DoubleInput txtChargeBackAmount;
        private DevComponents.Editors.IntegerInput txtChargeBackNum;
        private DevComponents.Editors.DoubleInput txtStandardPrice;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtChargeBackType;
        private System.Windows.Forms.ComboBox cbChargeBackName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}