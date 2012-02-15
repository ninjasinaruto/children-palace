namespace ShaoNianGong
{
    partial class ClassroomManageForm
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
            this.coursesDataSet = new ShaoNianGong.CoursesDataSet();
            this.classroomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.classroomsTableAdapter = new ShaoNianGong.CoursesDataSetTableAdapters.ClassroomsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassroomName = new System.Windows.Forms.TextBox();
            this.btnAddClassroom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classroomsBindingSource
            // 
            this.classroomsBindingSource.DataMember = "Classrooms";
            this.classroomsBindingSource.DataSource = this.coursesDataSet;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classroomsBindingSource, "ClassroomID", true));
            this.listBox1.DataSource = this.classroomsBindingSource;
            this.listBox1.DisplayMember = "ClassroomName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(16, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 220);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "ClassroomID";
            // 
            // classroomsTableAdapter
            // 
            this.classroomsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "教室名称：";
            // 
            // txtClassroomName
            // 
            this.txtClassroomName.Location = new System.Drawing.Point(12, 86);
            this.txtClassroomName.Name = "txtClassroomName";
            this.txtClassroomName.Size = new System.Drawing.Size(160, 21);
            this.txtClassroomName.TabIndex = 3;
            // 
            // btnAddClassroom
            // 
            this.btnAddClassroom.Location = new System.Drawing.Point(97, 146);
            this.btnAddClassroom.Name = "btnAddClassroom";
            this.btnAddClassroom.Size = new System.Drawing.Size(75, 31);
            this.btnAddClassroom.TabIndex = 4;
            this.btnAddClassroom.Text = "添加";
            this.btnAddClassroom.UseVisualStyleBackColor = true;
            this.btnAddClassroom.Click += new System.EventHandler(this.btnAddClassroom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教室列表：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddClassroom);
            this.groupBox2.Controls.Add(this.txtClassroomName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(203, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 266);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加教室：";
            // 
            // ClassroomManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ClassroomManageForm";
            this.Text = "教室管理";
            this.Load += new System.EventHandler(this.ClassroomManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource classroomsBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private CoursesDataSetTableAdapters.ClassroomsTableAdapter classroomsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassroomName;
        private System.Windows.Forms.Button btnAddClassroom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}