namespace BanGongPingTai
{
    partial class MaterialsManageForm
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMaterialList = new System.Windows.Forms.DataGridView();
            this.materialIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDataSet = new BanGongPingTai.Materials();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewMaterialPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewMaterialName = new System.Windows.Forms.TextBox();
            this.btnAddMaterialType = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaterialPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActualCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtBuyCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.materialsTableAdapter = new BanGongPingTai.MaterialsTableAdapters.MaterialsTableAdapter();
            this.materialsBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsBuyTableAdapter = new BanGongPingTai.MaterialsTableAdapters.MaterialsBuyTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.dtBuyTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBuyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(371, 245);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 31);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "购买";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaterialList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 400);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存信息：";
            // 
            // dgvMaterialList
            // 
            this.dgvMaterialList.AllowUserToAddRows = false;
            this.dgvMaterialList.AllowUserToDeleteRows = false;
            this.dgvMaterialList.AllowUserToResizeRows = false;
            this.dgvMaterialList.AutoGenerateColumns = false;
            this.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIDColumn,
            this.materialNameDataGridViewTextBoxColumn,
            this.materialPriceDataGridViewTextBoxColumn,
            this.materialCountColumn});
            this.dgvMaterialList.DataSource = this.materialsBindingSource;
            this.dgvMaterialList.Location = new System.Drawing.Point(6, 20);
            this.dgvMaterialList.MultiSelect = false;
            this.dgvMaterialList.Name = "dgvMaterialList";
            this.dgvMaterialList.ReadOnly = true;
            this.dgvMaterialList.RowHeadersVisible = false;
            this.dgvMaterialList.RowTemplate.Height = 23;
            this.dgvMaterialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialList.Size = new System.Drawing.Size(407, 374);
            this.dgvMaterialList.TabIndex = 0;
            // 
            // materialIDColumn
            // 
            this.materialIDColumn.DataPropertyName = "MaterialID";
            this.materialIDColumn.HeaderText = "材料ID";
            this.materialIDColumn.Name = "materialIDColumn";
            this.materialIDColumn.ReadOnly = true;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "材料名称";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialPriceDataGridViewTextBoxColumn
            // 
            this.materialPriceDataGridViewTextBoxColumn.DataPropertyName = "MaterialPrice";
            this.materialPriceDataGridViewTextBoxColumn.HeaderText = "材料单价";
            this.materialPriceDataGridViewTextBoxColumn.Name = "materialPriceDataGridViewTextBoxColumn";
            this.materialPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialCountColumn
            // 
            this.materialCountColumn.DataPropertyName = "MaterialCount";
            this.materialCountColumn.HeaderText = "库存数量";
            this.materialCountColumn.Name = "materialCountColumn";
            this.materialCountColumn.ReadOnly = true;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.materialsDataSet;
            this.materialsBindingSource.PositionChanged += new System.EventHandler(this.materialsBindingSource_PositionChanged);
            // 
            // materialsDataSet
            // 
            this.materialsDataSet.DataSetName = "Materials";
            this.materialsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNewMaterialPrice);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtNewMaterialName);
            this.groupBox4.Controls.Add(this.btnAddMaterialType);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(438, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 99);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加材料类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "元";
            // 
            // txtNewMaterialPrice
            // 
            this.txtNewMaterialPrice.Location = new System.Drawing.Point(325, 28);
            this.txtNewMaterialPrice.Name = "txtNewMaterialPrice";
            this.txtNewMaterialPrice.Size = new System.Drawing.Size(98, 21);
            this.txtNewMaterialPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "材料单价：";
            // 
            // txtNewMaterialName
            // 
            this.txtNewMaterialName.Location = new System.Drawing.Point(85, 28);
            this.txtNewMaterialName.Name = "txtNewMaterialName";
            this.txtNewMaterialName.Size = new System.Drawing.Size(121, 21);
            this.txtNewMaterialName.TabIndex = 0;
            // 
            // btnAddMaterialType
            // 
            this.btnAddMaterialType.Location = new System.Drawing.Point(371, 60);
            this.btnAddMaterialType.Name = "btnAddMaterialType";
            this.btnAddMaterialType.Size = new System.Drawing.Size(75, 31);
            this.btnAddMaterialType.TabIndex = 2;
            this.btnAddMaterialType.Text = "添加";
            this.btnAddMaterialType.UseVisualStyleBackColor = true;
            this.btnAddMaterialType.Click += new System.EventHandler(this.btnAddMaterialType_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "材料名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtBuyTime);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaterialPrice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMaterialName);
            this.groupBox2.Controls.Add(this.cmbMaterial);
            this.groupBox2.Controls.Add(this.btnBuy);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtActualCost);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRemark);
            this.groupBox2.Controls.Add(this.txtTotalPrice);
            this.groupBox2.Controls.Add(this.txtBuyCount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(438, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 286);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "购买材料：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "元";
            // 
            // txtMaterialPrice
            // 
            this.txtMaterialPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MaterialPrice", true));
            this.txtMaterialPrice.Location = new System.Drawing.Point(325, 58);
            this.txtMaterialPrice.Name = "txtMaterialPrice";
            this.txtMaterialPrice.ReadOnly = true;
            this.txtMaterialPrice.Size = new System.Drawing.Size(98, 21);
            this.txtMaterialPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "材料单价：";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "MaterialName", true));
            this.txtMaterialName.Location = new System.Drawing.Point(85, 58);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.ReadOnly = true;
            this.txtMaterialName.Size = new System.Drawing.Size(121, 21);
            this.txtMaterialName.TabIndex = 1;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialsBindingSource, "MaterialID", true));
            this.cmbMaterial.DataSource = this.materialsBindingSource;
            this.cmbMaterial.DisplayMember = "MaterialName";
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(86, 28);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(120, 20);
            this.cmbMaterial.TabIndex = 0;
            this.cmbMaterial.ValueMember = "MaterialID";
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "材料名称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "购买数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "实际费用：";
            // 
            // txtActualCost
            // 
            this.txtActualCost.Location = new System.Drawing.Point(326, 121);
            this.txtActualCost.Name = "txtActualCost";
            this.txtActualCost.Size = new System.Drawing.Size(97, 21);
            this.txtActualCost.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "预估费用：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(85, 157);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(361, 82);
            this.txtRemark.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(85, 121);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(97, 21);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // txtBuyCount
            // 
            this.txtBuyCount.Location = new System.Drawing.Point(85, 87);
            this.txtBuyCount.Name = "txtBuyCount";
            this.txtBuyCount.Size = new System.Drawing.Size(121, 21);
            this.txtBuyCount.TabIndex = 3;
            this.txtBuyCount.Text = "0";
            this.txtBuyCount.TextChanged += new System.EventHandler(this.txtBuyCount_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "材料类型：";
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsBuyBindingSource
            // 
            this.materialsBuyBindingSource.DataMember = "MaterialsBuy";
            this.materialsBuyBindingSource.DataSource = this.materialsDataSet;
            // 
            // materialsBuyTableAdapter
            // 
            this.materialsBuyTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "购买日期：";
            // 
            // dtBuyTime
            // 
            this.dtBuyTime.Location = new System.Drawing.Point(325, 87);
            this.dtBuyTime.Name = "dtBuyTime";
            this.dtBuyTime.Size = new System.Drawing.Size(121, 21);
            this.dtBuyTime.TabIndex = 8;
            // 
            // MaterialsManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "MaterialsManageForm";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.MaterialsManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBuyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMaterialList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewMaterialPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewMaterialName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddMaterialType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtBuyCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActualCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemark;
        private Materials materialsDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private MaterialsTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaterialPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCountColumn;
        private System.Windows.Forms.BindingSource materialsBuyBindingSource;
        private MaterialsTableAdapters.MaterialsBuyTableAdapter materialsBuyTableAdapter;
        private System.Windows.Forms.DateTimePicker dtBuyTime;
        private System.Windows.Forms.Label label14;
    }
}