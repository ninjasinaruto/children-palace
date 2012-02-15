namespace ShaoNianGong
{
    partial class BuyMaterialsForm
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
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDataSet = new ShaoNianGong.MaterialsDataSet();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtBuyCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialsTableAdapter = new ShaoNianGong.MaterialsDataSetTableAdapters.MaterialsTableAdapter();
            this.dgvMaterialList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.materialIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.materialsDataSet;
            // 
            // materialsDataSet
            // 
            this.materialsDataSet.DataSetName = "MaterialsDataSet";
            this.materialsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(8, 249);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 31);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "购买";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtBuyCount
            // 
            this.txtBuyCount.Location = new System.Drawing.Point(16, 99);
            this.txtBuyCount.Name = "txtBuyCount";
            this.txtBuyCount.Size = new System.Drawing.Size(106, 21);
            this.txtBuyCount.TabIndex = 3;
            this.txtBuyCount.TextChanged += new System.EventHandler(this.txtMaterialPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "购买数量：";
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMaterialList
            // 
            this.dgvMaterialList.AllowUserToAddRows = false;
            this.dgvMaterialList.AllowUserToDeleteRows = false;
            this.dgvMaterialList.AutoGenerateColumns = false;
            this.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIDColumn,
            this.materialNameColumn,
            this.materialPriceColumn,
            this.materialCountColumn});
            this.dgvMaterialList.DataSource = this.materialsBindingSource;
            this.dgvMaterialList.Location = new System.Drawing.Point(6, 20);
            this.dgvMaterialList.MultiSelect = false;
            this.dgvMaterialList.Name = "dgvMaterialList";
            this.dgvMaterialList.ReadOnly = true;
            this.dgvMaterialList.RowHeadersVisible = false;
            this.dgvMaterialList.RowTemplate.Height = 23;
            this.dgvMaterialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialList.Size = new System.Drawing.Size(411, 266);
            this.dgvMaterialList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaterialList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 292);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材料列表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "共需费用：";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(16, 153);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(106, 21);
            this.txtTotalCost.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtStudentName);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.txtBuyCount);
            this.groupBox2.Controls.Add(this.btnBuy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTotalCost);
            this.groupBox2.Location = new System.Drawing.Point(443, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 292);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "购买材料";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "学生姓名：";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(16, 45);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(106, 21);
            this.txtStudentName.TabIndex = 3;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtMaterialPrice_TextChanged);
            // 
            // materialIDColumn
            // 
            this.materialIDColumn.DataPropertyName = "MaterialID";
            this.materialIDColumn.HeaderText = "材料ID";
            this.materialIDColumn.Name = "materialIDColumn";
            this.materialIDColumn.ReadOnly = true;
            // 
            // materialNameColumn
            // 
            this.materialNameColumn.DataPropertyName = "MaterialName";
            this.materialNameColumn.HeaderText = "材料名称";
            this.materialNameColumn.Name = "materialNameColumn";
            this.materialNameColumn.ReadOnly = true;
            // 
            // materialPriceColumn
            // 
            this.materialPriceColumn.DataPropertyName = "MaterialPrice";
            this.materialPriceColumn.HeaderText = "材料价格";
            this.materialPriceColumn.Name = "materialPriceColumn";
            this.materialPriceColumn.ReadOnly = true;
            // 
            // materialCountColumn
            // 
            this.materialCountColumn.DataPropertyName = "MaterialCount";
            this.materialCountColumn.HeaderText = "库存数量";
            this.materialCountColumn.Name = "materialCountColumn";
            this.materialCountColumn.ReadOnly = true;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(16, 207);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(106, 21);
            this.txtBalance.TabIndex = 3;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtMaterialPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "账户余额：";
            // 
            // BuyMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BuyMaterialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料购买";
            this.Load += new System.EventHandler(this.BuyMaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource materialsBindingSource;
        private MaterialsDataSet materialsDataSet;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtBuyCount;
        private System.Windows.Forms.Label label1;
        private MaterialsDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridView dgvMaterialList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCountColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBalance;
    }
}