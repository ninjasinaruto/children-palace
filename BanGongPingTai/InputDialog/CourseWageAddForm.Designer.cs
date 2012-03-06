namespace BanGongPingTai
{
    partial class CourseWageAddForm
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
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourseNum = new DevComponents.Editors.IntegerInput();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtStandardPrice = new DevComponents.Editors.DoubleInput();
            this.txtActualPrice = new DevComponents.Editors.DoubleInput();
            this.txtAmount = new DevComponents.Editors.DoubleInput();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程类型：";
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(162, 13);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.Size = new System.Drawing.Size(174, 21);
            this.txtCourseType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "月实际上课次数（人数）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "对应单价（标准）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "对应单价（实际）：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "课量工资（标准）：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "备注：";
            // 
            // txtCourseNum
            // 
            this.txtCourseNum.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtCourseNum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCourseNum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCourseNum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCourseNum.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtCourseNum.Location = new System.Drawing.Point(162, 40);
            this.txtCourseNum.MinValue = 0;
            this.txtCourseNum.Name = "txtCourseNum";
            this.txtCourseNum.Size = new System.Drawing.Size(174, 21);
            this.txtCourseNum.TabIndex = 2;
            this.txtCourseNum.WatermarkText = "0";
            this.txtCourseNum.ValueChanged += new System.EventHandler(this.txtCourseNum_ValueChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(162, 160);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(174, 21);
            this.txtRemark.TabIndex = 6;
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
            this.txtStandardPrice.Location = new System.Drawing.Point(162, 69);
            this.txtStandardPrice.MinValue = 0D;
            this.txtStandardPrice.Name = "txtStandardPrice";
            this.txtStandardPrice.Size = new System.Drawing.Size(174, 21);
            this.txtStandardPrice.TabIndex = 3;
            this.txtStandardPrice.WatermarkText = "0";
            // 
            // txtActualPrice
            // 
            this.txtActualPrice.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtActualPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtActualPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtActualPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtActualPrice.Increment = 1D;
            this.txtActualPrice.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtActualPrice.Location = new System.Drawing.Point(162, 97);
            this.txtActualPrice.MinValue = 0D;
            this.txtActualPrice.Name = "txtActualPrice";
            this.txtActualPrice.Size = new System.Drawing.Size(174, 21);
            this.txtActualPrice.TabIndex = 4;
            this.txtActualPrice.WatermarkText = "0";
            this.txtActualPrice.ValueChanged += new System.EventHandler(this.txtActualPrice_ValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.AllowEmptyState = false;
            // 
            // 
            // 
            this.txtAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtAmount.Increment = 1D;
            this.txtAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.txtAmount.Location = new System.Drawing.Point(162, 129);
            this.txtAmount.MinValue = 0D;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(174, 21);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.WatermarkText = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "确定";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CourseWageAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 238);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtActualPrice);
            this.Controls.Add(this.txtStandardPrice);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtCourseNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCourseType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CourseWageAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课量工资";
            this.Load += new System.EventHandler(this.CourseWageAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.IntegerInput txtCourseNum;
        private System.Windows.Forms.TextBox txtRemark;
        private DevComponents.Editors.DoubleInput txtStandardPrice;
        private DevComponents.Editors.DoubleInput txtActualPrice;
        private DevComponents.Editors.DoubleInput txtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}