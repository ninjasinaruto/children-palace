using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanGongPingTai
{
    public partial class UsersManageForm : Form
    {
        public UsersManageForm()
        {
            InitializeComponent();
        }

        private void UsersManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“usersDataSet.Users”中。您可以根据需要移动或删除它。
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

            // TODO: 这行代码将数据加载到表“usersDataSet.CourseTypes”中。您可以根据需要移动或删除它。
            this.courseTypesTableAdapter.Fill(this.usersDataSet.CourseTypes);

            // 获取CourseTypes列表，填充对应列表
            this.courseTypesTableAdapter.Fill(this.usersDataSet.CourseTypes);
            lstCourseType.DataSource = courseTypesBindingSource;
            lstCourseType.DisplayMember = "CourseTypeName";
            lstCourseType.ValueMember = "CourseTypeID";

            chkLstCourses.DataSource = coursesBindingSource;
            chkLstCourses.DisplayMember = "CourseName";
            chkLstCourses.ValueMember = "ID";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名不可为空", "用户名错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("密码不可为空", "密码输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("两次输入的密码不相同", "密码输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
                return;
            }

            if(usersDataSet.Users.FindByUserName(txtUserName.Text) != null)
            {
                MessageBox.Show("该用户名已经被使用", "用户名冲突", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if(MessageBox.Show("确认添加用户“" + txtUserName.Text + "”吗？", "确认添加用户", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) !=
                DialogResult.OK)
                return;

            // 添加用户
            usersTableAdapter.Insert(txtUserName.Text, txtPassword.Text, 0);
            // 刷新数据
            this.usersTableAdapter.Fill(this.usersDataSet.Users);
            // 清空输入
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void usersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (usersBindingSource.Position < 0)
                return;
            string userName = usersDataSet.Users.Rows[usersBindingSource.Position].Field<string>("UserName");
            userCoursesTableAdapter.Fill(usersDataSet.UserCourses, userName);

            // 刷新课程列表
            this.courseTypesTableAdapter.Fill(this.usersDataSet.CourseTypes);
        }

        private void userCoursesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lstUserCourses.Items.Clear();

            foreach(DataRow row in usersDataSet.UserCourses.Rows)
            {
                string completeCourseName = row.Field<string>("CourseTypeName") + "，" + row.Field<string>("CourseSubtypeName") + "，" + row.Field<string>("CourseName");
                lstUserCourses.Items.Add(completeCourseName);
            }
        }

        private void courseTypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseTypesBindingSource.Position < 0)
                return;
            int courseTypeID = this.usersDataSet.CourseTypes.Rows[courseTypesBindingSource.Position].Field<int>("CourseTypeID");
            this.courseSubtypesTableAdapter.Fill(usersDataSet.CourseSubtypes, courseTypeID);
        }

        private void courseSubtypesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (courseSubtypesBindingSource.Position < 0)
            {
                usersDataSet.Courses.Clear();
                return;
            }
            int courseSubtypeId = usersDataSet.CourseSubtypes.Rows[courseSubtypesBindingSource.Position].Field<int>("ID");
            coursesTableAdapter.Fill(usersDataSet.Courses, courseSubtypeId);

            if (chkLstCourses.Items.Count == 0)
            {
                chkLstCourses.DataSource = coursesBindingSource;
                chkLstCourses.DisplayMember = "CourseName";
                chkLstCourses.ValueMember = "ID";
            }

            for (int i = 0; i < usersDataSet.Courses.Rows.Count; ++i)
            {
                DataRow row = usersDataSet.Courses.Rows[i];

                if (usersDataSet.UserCourses.Select("CourseId = " + row.Field<int>("ID")).Length <= 0)
                    chkLstCourses.SetItemChecked(i, false);
                else
                    chkLstCourses.SetItemChecked(i, true);
            }
        }

        private void chkLstCourses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int courseId = usersDataSet.Courses.Rows[e.Index].Field<int>("ID");

            if (e.NewValue == CheckState.Checked)
            {
                if (usersDataSet.UserCourses.Select("CourseId = " + courseId).Length <= 0)
                {
                    userCoursesTableAdapter.InsertUserCourse(lstUsers.Text, courseId);
                    userCoursesTableAdapter.Fill(usersDataSet.UserCourses, lstUsers.Text);
                }
            }
            else
            {
                DataRow[] rows = usersDataSet.UserCourses.Select("CourseId = " + courseId);
                if (rows.Length > 0)
                {
                    int userCourseId = rows[0].Field<int>("UserCourseId");
                    userCoursesTableAdapter.DeleteUserCourse(userCourseId);
                    userCoursesTableAdapter.Fill(usersDataSet.UserCourses, lstUsers.Text);
                }
            }
        }

        private void coursesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
        }

        private void coursesBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
        }
    }
}
