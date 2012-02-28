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
    public partial class AffairDetailForm : Form
    {
        private int affairId;

        public AffairDetailForm(int affairId = 0)
        {
            InitializeComponent();
            this.affairId = affairId;
        }

        private void AffairApplyForm_Load(object sender, EventArgs e)
        {
            if (affairId > 0)
            {
                // Fill the content
                affairApplyTableAdapter.FillByAffairId(affairDataSet.AffairApply, affairId);
                txtTitle.Text = affairDataSet.AffairApply.Rows[0].Field<string>("ApplyTitle");
                txtContent.Text = affairDataSet.AffairApply.Rows[0].Field<string>("ApplyContent");

                txtTitle.ReadOnly = true;
                txtContent.ReadOnly = true;
                btnApply.Visible = false;
                btnCancel.Visible = false;
                this.Text = "查看事务";
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("请输入申报的标题", "标题不可为空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (MessageBox.Show("确认申报吗？", "确认申报吗", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            affairApplyTableAdapter.Insert(User.CurrentUser.UserName, DateTime.Now, txtTitle.Text, txtContent.Text, 0, null, null);
            MessageBox.Show("申报成功！", "事务申报成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AffairDetailForm_Resize(object sender, EventArgs e)
        {
            txtTitle.Width = this.Width - 180;
            txtContent.Width = this.Width - 180;
            txtContent.Height = this.Height - 150;
        }
    }
}
