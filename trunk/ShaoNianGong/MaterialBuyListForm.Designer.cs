namespace ShaoNianGong
{
    partial class MaterialBuyListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDataSet1 = new ShaoNianGong.MaterialsDataSet();
            this.studentMaterialsTableAdapter = new ShaoNianGong.MaterialsDataSetTableAdapters.StudentMaterialsTableAdapter();
            this.dtBuyEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBuyBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowThisMonthBuy = new System.Windows.Forms.Button();
            this.btnShowFilterBuy = new System.Windows.Forms.Button();
            this.btnShowAllBuy = new System.Windows.Forms.Button();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBuy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaterialName,
            this.MaterialPrice,
            this.BuyCount,
            this.BuyTime,
            this.TotalCost,
            this.operatorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 481);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "学生姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "材料名称";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // MaterialPrice
            // 
            this.MaterialPrice.DataPropertyName = "MaterialPrice";
            this.MaterialPrice.HeaderText = "材料价格";
            this.MaterialPrice.Name = "MaterialPrice";
            this.MaterialPrice.ReadOnly = true;
            // 
            // BuyCount
            // 
            this.BuyCount.DataPropertyName = "BuyCount";
            this.BuyCount.HeaderText = "购买数量";
            this.BuyCount.Name = "BuyCount";
            this.BuyCount.ReadOnly = true;
            // 
            // BuyTime
            // 
            this.BuyTime.DataPropertyName = "BuyTime";
            this.BuyTime.HeaderText = "购买时间";
            this.BuyTime.Name = "BuyTime";
            this.BuyTime.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "TotalCost";
            this.TotalCost.HeaderText = "总价格";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "经办人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "StudentMaterials";
            this.bindingSource1.DataSource = this.materialsDataSet1;
            this.bindingSource1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource1_ListChanged);
            // 
            // materialsDataSet1
            // 
            this.materialsDataSet1.DataSetName = "MaterialsDataSet";
            this.materialsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentMaterialsTableAdapter
            // 
            this.studentMaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // dtBuyEndDate
            // 
            this.dtBuyEndDate.Location = new System.Drawing.Point(547, 41);
            this.dtBuyEndDate.Name = "dtBuyEndDate";
            this.dtBuyEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtBuyEndDate.TabIndex = 19;
            // 
            // dtBuyBeginDate
            // 
            this.dtBuyBeginDate.Location = new System.Drawing.Point(547, 16);
            this.dtBuyBeginDate.Name = "dtBuyBeginDate";
            this.dtBuyBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtBuyBeginDate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "终止日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "起始日期：";
            // 
            // btnShowThisMonthBuy
            // 
            this.btnShowThisMonthBuy.Location = new System.Drawing.Point(247, 16);
            this.btnShowThisMonthBuy.Name = "btnShowThisMonthBuy";
            this.btnShowThisMonthBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowThisMonthBuy.TabIndex = 16;
            this.btnShowThisMonthBuy.Text = "查看本月";
            this.btnShowThisMonthBuy.UseVisualStyleBackColor = true;
            this.btnShowThisMonthBuy.Click += new System.EventHandler(this.btnShowThisMonthBuy_Click);
            // 
            // btnShowFilterBuy
            // 
            this.btnShowFilterBuy.Location = new System.Drawing.Point(682, 16);
            this.btnShowFilterBuy.Name = "btnShowFilterBuy";
            this.btnShowFilterBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowFilterBuy.TabIndex = 15;
            this.btnShowFilterBuy.Text = "筛选";
            this.btnShowFilterBuy.UseVisualStyleBackColor = true;
            this.btnShowFilterBuy.Click += new System.EventHandler(this.btnShowFilterBuy_Click);
            // 
            // btnShowAllBuy
            // 
            this.btnShowAllBuy.Location = new System.Drawing.Point(349, 16);
            this.btnShowAllBuy.Name = "btnShowAllBuy";
            this.btnShowAllBuy.Size = new System.Drawing.Size(96, 36);
            this.btnShowAllBuy.TabIndex = 14;
            this.btnShowAllBuy.Text = "查看所有";
            this.btnShowAllBuy.UseVisualStyleBackColor = true;
            this.btnShowAllBuy.Click += new System.EventHandler(this.btnShowAllBuy_Click);
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(107, 42);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(120, 21);
            this.txtTotalPaid.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "实收金额汇总：";
            // 
            // txtTotalBuy
            // 
            this.txtTotalBuy.Location = new System.Drawing.Point(107, 12);
            this.txtTotalBuy.Name = "txtTotalBuy";
            this.txtTotalBuy.ReadOnly = true;
            this.txtTotalBuy.Size = new System.Drawing.Size(120, 21);
            this.txtTotalBuy.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "购买金额汇总：";
            // 
            // MaterialBuyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 572);
            this.Controls.Add(this.dtBuyEndDate);
            this.Controls.Add(this.dtBuyBeginDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowThisMonthBuy);
            this.Controls.Add(this.btnShowFilterBuy);
            this.Controls.Add(this.btnShowAllBuy);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaterialBuyListForm";
            this.Text = "材料购买汇总";
            this.Load += new System.EventHandler(this.MaterialBuyListForm_Load);
            this.Resize += new System.EventHandler(this.MaterialBuyListForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialsDataSet materialsDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MaterialsDataSetTableAdapters.StudentMaterialsTableAdapter studentMaterialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtBuyEndDate;
        private System.Windows.Forms.DateTimePicker dtBuyBeginDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowThisMonthBuy;
        private System.Windows.Forms.Button btnShowFilterBuy;
        private System.Windows.Forms.Button btnShowAllBuy;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalBuy;
        private System.Windows.Forms.Label label1;
    }
}