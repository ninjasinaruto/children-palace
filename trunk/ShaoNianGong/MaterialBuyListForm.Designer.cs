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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseSubtypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDataSet = new ShaoNianGong.MaterialsDataSet();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBuyCount = new System.Windows.Forms.Label();
            this.txtShowRange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchByCourseType = new System.Windows.Forms.Button();
            this.btnSearchByCourse = new System.Windows.Forms.Button();
            this.studentMaterialsTableAdapter = new ShaoNianGong.MaterialsDataSetTableAdapters.StudentMaterialsTableAdapter();
            this.btnSearchByCourseWithDate = new System.Windows.Forms.Button();
            this.btnSearchByCourseTypeWithDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.AllowUserToResizeRows = false;
            this.dgvMaterials.AutoGenerateColumns = false;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.BuyTime,
            this.Column1,
            this.ExpireTime,
            this.MaterialName,
            this.MaterialPrice,
            this.BuyCount,
            this.TotalCost,
            this.CourseTypeName,
            this.CourseSubtypeName,
            this.CourseName,
            this.ChargeTypeName,
            this.operatorDataGridViewTextBoxColumn});
            this.dgvMaterials.DataSource = this.materialsBindingSource;
            this.dgvMaterials.Location = new System.Drawing.Point(10, 79);
            this.dgvMaterials.MultiSelect = false;
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.RowHeadersVisible = false;
            this.dgvMaterials.RowTemplate.Height = 23;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(1183, 439);
            this.dgvMaterials.TabIndex = 0;
            this.dgvMaterials.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMaterials_DataBindingComplete);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // BuyTime
            // 
            this.BuyTime.DataPropertyName = "BuyTime";
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.BuyTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.BuyTime.HeaderText = "购买日期";
            this.BuyTime.Name = "BuyTime";
            this.BuyTime.ReadOnly = true;
            this.BuyTime.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "学生姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ExpireTime
            // 
            this.ExpireTime.DataPropertyName = "ExpireTime";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.ExpireTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExpireTime.HeaderText = "缴费到期日期";
            this.ExpireTime.Name = "ExpireTime";
            this.ExpireTime.ReadOnly = true;
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
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "TotalCost";
            this.TotalCost.HeaderText = "总金额";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // CourseTypeName
            // 
            this.CourseTypeName.DataPropertyName = "CourseTypeName";
            this.CourseTypeName.HeaderText = "课程类别";
            this.CourseTypeName.Name = "CourseTypeName";
            this.CourseTypeName.ReadOnly = true;
            // 
            // CourseSubtypeName
            // 
            this.CourseSubtypeName.DataPropertyName = "CourseSubtypeName";
            this.CourseSubtypeName.HeaderText = "课程科目";
            this.CourseSubtypeName.Name = "CourseSubtypeName";
            this.CourseSubtypeName.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // ChargeTypeName
            // 
            this.ChargeTypeName.DataPropertyName = "ChargeTypeName";
            this.ChargeTypeName.HeaderText = "课程收费类型";
            this.ChargeTypeName.Name = "ChargeTypeName";
            this.ChargeTypeName.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "经办人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "StudentMaterials";
            this.materialsBindingSource.DataSource = this.materialsDataSet;
            this.materialsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.materialsBindingSource_ListChanged);
            // 
            // materialsDataSet
            // 
            this.materialsDataSet.DataSetName = "MaterialsDataSet";
            this.materialsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtBuyEndDate
            // 
            this.dtBuyEndDate.Location = new System.Drawing.Point(958, 41);
            this.dtBuyEndDate.Name = "dtBuyEndDate";
            this.dtBuyEndDate.Size = new System.Drawing.Size(119, 21);
            this.dtBuyEndDate.TabIndex = 19;
            // 
            // dtBuyBeginDate
            // 
            this.dtBuyBeginDate.Location = new System.Drawing.Point(958, 16);
            this.dtBuyBeginDate.Name = "dtBuyBeginDate";
            this.dtBuyBeginDate.Size = new System.Drawing.Size(119, 21);
            this.dtBuyBeginDate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "终止日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(887, 20);
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
            this.btnShowFilterBuy.Location = new System.Drawing.Point(1093, 16);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBuyCount);
            this.panel1.Controls.Add(this.txtShowRange);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 48);
            this.panel1.TabIndex = 29;
            // 
            // lblBuyCount
            // 
            this.lblBuyCount.AutoSize = true;
            this.lblBuyCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyCount.Location = new System.Drawing.Point(789, 11);
            this.lblBuyCount.Name = "lblBuyCount";
            this.lblBuyCount.Size = new System.Drawing.Size(25, 12);
            this.lblBuyCount.TabIndex = 25;
            this.lblBuyCount.Text = "0条";
            // 
            // txtShowRange
            // 
            this.txtShowRange.AutoSize = true;
            this.txtShowRange.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShowRange.Location = new System.Drawing.Point(111, 11);
            this.txtShowRange.Name = "txtShowRange";
            this.txtShowRange.Size = new System.Drawing.Size(31, 12);
            this.txtShowRange.TabIndex = 25;
            this.txtShowRange.Text = "所有";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "购买记录总数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "当前显示范围：";
            // 
            // btnSearchByCourseType
            // 
            this.btnSearchByCourseType.Location = new System.Drawing.Point(451, 16);
            this.btnSearchByCourseType.Name = "btnSearchByCourseType";
            this.btnSearchByCourseType.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourseType.TabIndex = 32;
            this.btnSearchByCourseType.Text = "按分类查询";
            this.btnSearchByCourseType.UseVisualStyleBackColor = true;
            this.btnSearchByCourseType.Click += new System.EventHandler(this.btnSearchByCourseType_Click);
            // 
            // btnSearchByCourse
            // 
            this.btnSearchByCourse.Location = new System.Drawing.Point(553, 16);
            this.btnSearchByCourse.Name = "btnSearchByCourse";
            this.btnSearchByCourse.Size = new System.Drawing.Size(96, 36);
            this.btnSearchByCourse.TabIndex = 31;
            this.btnSearchByCourse.Text = "按课程查询";
            this.btnSearchByCourse.UseVisualStyleBackColor = true;
            this.btnSearchByCourse.Click += new System.EventHandler(this.btnSearchByCourse_Click);
            // 
            // studentMaterialsTableAdapter
            // 
            this.studentMaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearchByCourseWithDate
            // 
            this.btnSearchByCourseWithDate.Location = new System.Drawing.Point(767, 16);
            this.btnSearchByCourseWithDate.Name = "btnSearchByCourseWithDate";
            this.btnSearchByCourseWithDate.Size = new System.Drawing.Size(102, 36);
            this.btnSearchByCourseWithDate.TabIndex = 36;
            this.btnSearchByCourseWithDate.Text = "按课程日期查询";
            this.btnSearchByCourseWithDate.UseVisualStyleBackColor = true;
            this.btnSearchByCourseWithDate.Click += new System.EventHandler(this.btnSearchByCourseWithDate_Click);
            // 
            // btnSearchByCourseTypeWithDate
            // 
            this.btnSearchByCourseTypeWithDate.Location = new System.Drawing.Point(655, 16);
            this.btnSearchByCourseTypeWithDate.Name = "btnSearchByCourseTypeWithDate";
            this.btnSearchByCourseTypeWithDate.Size = new System.Drawing.Size(106, 36);
            this.btnSearchByCourseTypeWithDate.TabIndex = 35;
            this.btnSearchByCourseTypeWithDate.Text = "按分类日期查询";
            this.btnSearchByCourseTypeWithDate.UseVisualStyleBackColor = true;
            this.btnSearchByCourseTypeWithDate.Click += new System.EventHandler(this.btnSearchByCourseTypeWithDate_Click);
            // 
            // MaterialBuyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 572);
            this.Controls.Add(this.btnSearchByCourseWithDate);
            this.Controls.Add(this.btnSearchByCourseTypeWithDate);
            this.Controls.Add(this.btnSearchByCourseType);
            this.Controls.Add(this.btnSearchByCourse);
            this.Controls.Add(this.panel1);
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
            this.Controls.Add(this.dgvMaterials);
            this.Name = "MaterialBuyListForm";
            this.Text = "材料购买汇总";
            this.Load += new System.EventHandler(this.MaterialBuyListForm_Load);
            this.Resize += new System.EventHandler(this.MaterialBuyListForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterials;
        private MaterialsDataSet materialsDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private MaterialsDataSetTableAdapters.StudentMaterialsTableAdapter studentMaterialsTableAdapter;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBuyCount;
        private System.Windows.Forms.Label txtShowRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchByCourseType;
        private System.Windows.Forms.Button btnSearchByCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSubtypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChargeTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearchByCourseWithDate;
        private System.Windows.Forms.Button btnSearchByCourseTypeWithDate;
    }
}