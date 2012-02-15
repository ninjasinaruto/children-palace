using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShaoNianGong
{
    public partial class MainForm : Form
    {
        private const string currentVersion = "1.0.8";
        private Form currentForm = null;
        private ToolStripButton currentButton = null;

        private string UserName = "";
        private int UserType = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            softwareVersionTableAdapter.Fill(versionDataSet.SoftwareVersion);
            DataRow[] rows = versionDataSet.SoftwareVersion.Select("SoftwareName = 'ShaoNianGong'");
            if (rows.Length <= 0)
            {
                MessageBox.Show("数据库配置错误，无法找到版本信息！", "数据库配置错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            string latestVersion = rows[0].Field<string>("SoftwareVersion");
            if (latestVersion != currentVersion)
            {
                MessageBox.Show("软件版本过期，当前版本为" + currentVersion + "，请更新至" + latestVersion + "版",
                    "软件版本过期", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            LoginForm frmLogin = new LoginForm();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }

            this.UserName = frmLogin.UserName;
            this.UserType = frmLogin.UserType;
            if (UserType == 0)
            {
                tsbClassroomManage.Enabled = false;
                tsbCoursesManage.Enabled = false;
                tsbDepositList.Enabled = false;
                tsbMaterialBuyList.Enabled = false;
                tsbPreregister.Enabled = false;
                tsbPreregManage.Enabled = false;
                tsbPreregSignUpCourses.Enabled = false;
                tsbLeftCourse.Enabled = false;
            }

            toolBtnWelcome.Text = "欢迎您：" + this.UserName;

            currentForm = new StudentsManageForm();
            (currentForm as StudentsManageForm).UserType = this.UserType;
            (currentForm as StudentsManageForm).UserName = this.UserName;
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);
            currentForm.WindowState = FormWindowState.Maximized;

            currentButton = tsbStudentsManage;
            currentButton.Checked = true;
        }

        private void 学生资料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new StudentsManageForm();
            (currentForm as StudentsManageForm).UserType = this.UserType;
            (currentForm as StudentsManageForm).UserName = this.UserName;
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbStudentsManage;
            currentButton.Checked = true;
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new CoursesManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbCoursesManage;
            currentButton.Checked = true;
        }

        private void 教室管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new ClassroomManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbClassroomManage;
            currentButton.Checked = true;
        }

        private void 预报名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreregisterForm frmPreregister = new PreregisterForm();
            DialogResult result = frmPreregister.ShowDialog();
            if(result != DialogResult.OK)
                return;

            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            PreregManageForm frmPreregManage = new PreregManageForm();
            frmPreregManage.studentName = frmPreregister.studentName;
            currentForm = frmPreregManage;
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbPreregManage;
            currentButton.Checked = true;
        }

        private void 新生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new PreregManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbPreregManage;
            currentButton.Checked = true;
        }

        private void 排班ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new PreregSignUpCoursesForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbPreregSignUpCourses;
            currentButton.Checked = true;
        }

        private void 充值汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new DepositListForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbDepositList;
            currentButton.Checked = true;
        }

        private void 材料购买汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new MaterialBuyListForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbMaterialBuyList;
            currentButton.Checked = true;
        }

        private void 收费汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new CostListForm();
            (currentForm as CostListForm).UserType = this.UserType;
            (currentForm as CostListForm).UserName = this.UserName;
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbCostList;
            currentButton.Checked = true;
        }

        private void tsbLeftCourse_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new LeftCourseForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbLeftCourse;
            currentButton.Checked = true;
        }

        private void tsbInvoicePrinting_Click(object sender, EventArgs e)
        {
            if (currentForm != null) {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new InvoicePrintingForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbInvoicePrinting;
            currentButton.Checked = true;
        }

        private void tsbStudentSignin_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            currentForm = new StudentSigninManageForm();
            currentForm.MdiParent = this;
            currentForm.Show();
            currentForm.Location = new Point(0, 0);

            if (currentButton != null)
                currentButton.Checked = false;
            currentButton = tsbStudentSignin;
            currentButton.Checked = true;
        }
    }
}
