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
    public partial class PreregManageForm : Form
    {
        public string studentName = "";

        public PreregManageForm()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            GetDepositAmountForm frmGetDepositAmount = new GetDepositAmountForm();
            frmGetDepositAmount.StudentName = txtName.Text;
            frmGetDepositAmount.CardNo = txtCardNo.Text;
            frmGetDepositAmount.CardType = txtCardType.Text;
            if (frmGetDepositAmount.ShowDialog() != DialogResult.OK)
                return;

            int depositAmount = frmGetDepositAmount.DepositAmount;
            int paidAmount = frmGetDepositAmount.PaidAmount;
            int tuitionAmount = frmGetDepositAmount.tuitionAmount;
            int materialsAmount = frmGetDepositAmount.materialsAmount;
            int otherAmount = frmGetDepositAmount.otherAmount;

            int studentId = int.Parse(txtID.Text);

            ConfirmDepositForm frmConfirmDeposit = new ConfirmDepositForm();
            frmConfirmDeposit.DepositAmount = depositAmount.ToString();
            frmConfirmDeposit.PaidAmount = paidAmount.ToString();
            frmConfirmDeposit.TuitionAmount = tuitionAmount.ToString();
            frmConfirmDeposit.MaterialsAmount = materialsAmount.ToString();
            frmConfirmDeposit.OtherAmount = otherAmount.ToString();
            frmConfirmDeposit.StudentName = txtName.Text;
            frmConfirmDeposit.StudentSex = txtSex.Text;
            frmConfirmDeposit.StudentBirthday = txtBirth.Text;
            frmConfirmDeposit.StudentAddress = txtAddress.Text;
            frmConfirmDeposit.StudentPhone = txtPhone.Text;
            frmConfirmDeposit.StudentFartherName = txtFartherName.Text;
            frmConfirmDeposit.StudentFartherPhone = txtFartherPhone.Text;
            frmConfirmDeposit.StudentFartherWork = txtFartherWork.Text;
            frmConfirmDeposit.StudentMotherName = txtMotherName.Text;
            frmConfirmDeposit.StudentMotherPhone = txtMotherPhone.Text;
            frmConfirmDeposit.StudentMotherWork = txtMotherWork.Text;
            frmConfirmDeposit.Text = "确定为“" + txtName.Text + "”充值" + depositAmount + "元吗？";
            if (frmConfirmDeposit.ShowDialog() != DialogResult.OK)
                return;

            depositListTableAdapter.Insert(studentId, depositAmount, DateTime.Now, paidAmount, User.CurrentUser.UserName);

            int newBalance = int.Parse(txtBalance.Text) + depositAmount;
            studentsPreregTableAdapter.UpdateBalance(newBalance, txtID.Text);

            txtBalance.Text = newBalance.ToString();
            if (dgvPreregStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPreregStudents.SelectedRows[0];
                row.Cells["Balance"].Value = txtBalance.Text;
            }

            if (MessageBox.Show("需要打印发票吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<PrintRecord> list = new List<PrintRecord>();
                if (tuitionAmount == 0 && materialsAmount == 0 && otherAmount == 0)
                {
                    PrintRecord prAmount = new PrintRecord();
                    prAmount.id = 1;
                    prAmount.name = "充值";
                    prAmount.num = "1";
                    prAmount.price = depositAmount.ToString();
                    prAmount.amount = depositAmount.ToString();
                    list.Add(prAmount);
                }
                else
                {
                    if (tuitionAmount != 0)
                    {
                        PrintRecord prTuition = new PrintRecord();
                        prTuition.id = 1;
                        prTuition.name = "学费";
                        prTuition.num = "1";
                        prTuition.price = tuitionAmount.ToString();
                        prTuition.amount = tuitionAmount.ToString();
                        list.Add(prTuition);
                    }

                    if (materialsAmount != 0)
                    {
                        PrintRecord prMaterials = new PrintRecord();
                        prMaterials.id = 2;
                        prMaterials.name = "材料费";
                        prMaterials.num = "1";
                        prMaterials.price = materialsAmount.ToString();
                        prMaterials.amount = materialsAmount.ToString();
                        list.Add(prMaterials);
                    }

                    if (otherAmount != 0)
                    {
                        PrintRecord prOther = new PrintRecord();
                        prOther.id = 3;
                        prOther.name = "其他";
                        prOther.num = "1";
                        prOther.price = otherAmount.ToString();
                        prOther.amount = otherAmount.ToString();
                        list.Add(prOther);
                    }
                }

                InvoicePrintingForm printForm = new InvoicePrintingForm();
                printForm.MdiParent = this.Owner;
                printForm.StartPosition = FormStartPosition.CenterScreen;
                printForm.isReadOnly = true;
                printForm.userName = txtName.Text;
                printForm.recordList = list;
                printForm.totalAmount = depositAmount;
                printForm.Show();
            }
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“preregisterDataset.CardList”中。您可以根据需要移动或删除它。
            this.cardListTableAdapter.Fill(this.preregisterDataset.CardList);
            // TODO: 这行代码将数据加载到表“preregisterDataset.CourseSubtypes”中。您可以根据需要移动或删除它。
            this.courseSubtypesTableAdapter.Fill(this.preregisterDataset.CourseSubtypes);
            RefreshData();
        }

        public void RefreshData()
        {
            this.studentsPreregTableAdapter.Fill(this.preregisterDataset.studentsPrereg);

            if (studentName != "")
            {
                studentsPreregBindingSource.MoveLast();

                while (dgvPreregStudents.SelectedRows[0].Cells["NameColumn"].Value.ToString() != studentName
                    && dgvPreregStudents.SelectedRows[0].Index > 0)
                {
                    studentsPreregBindingSource.MovePrevious();
                }
                studentName = "";
            }
        }

        private void btnConnectCard_Click(object sender, EventArgs e)
        {
            // 获取卡号
            CardConnectForm frmCardConnect = new CardConnectForm();
            frmCardConnect.ShowDialog();
            if (frmCardConnect.cardNo == "")
                return;

            // 查询是否有卡号冲突
            DataRow[] rows = preregisterDataset.CardList.Select("CardNo = '" + frmCardConnect.cardNo + "'");
            if (rows.Length > 0)
            {
                DataRow row = rows[0];
                MessageBox.Show("该卡片[" + frmCardConnect.cardNo + "]已被学生["
                    + row.Field<string>("Name") + "]所使用，请使用新卡片", "卡号已被使用",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };

            // 获取卡号的类型
            CardTypeSelectForm frmCardTypeSelect = new CardTypeSelectForm();
            if (frmCardTypeSelect.ShowDialog() != DialogResult.OK)
                return;
            int cardType = frmCardTypeSelect.CardType;
            string cardTypeName = "";
            switch (cardType)
            {
                case 0:
                    cardTypeName = "普通卡";
                    break;
                case 1:
                    cardTypeName = "VIP卡";
                    break;
            }

            // 显示确认对话框
            ConfirmCardConnectForm frmConfirmCardConnect = new ConfirmCardConnectForm();
            frmConfirmCardConnect.CardNo = frmCardConnect.cardNo;
            frmConfirmCardConnect.CardType = cardTypeName;
            frmConfirmCardConnect.StudentName = txtName.Text;
            frmConfirmCardConnect.StudentSex = txtSex.Text;
            frmConfirmCardConnect.StudentBirthday = txtBirth.Text;
            frmConfirmCardConnect.StudentAddress = txtAddress.Text;
            frmConfirmCardConnect.StudentPhone = txtPhone.Text;
            frmConfirmCardConnect.StudentFartherName = txtFartherName.Text;
            frmConfirmCardConnect.StudentFartherPhone = txtFartherPhone.Text;
            frmConfirmCardConnect.StudentFartherWork = txtFartherWork.Text;
            frmConfirmCardConnect.StudentMotherName = txtMotherName.Text;
            frmConfirmCardConnect.StudentMotherPhone = txtMotherPhone.Text;
            frmConfirmCardConnect.StudentMotherWork = txtMotherWork.Text;
            if (frmConfirmCardConnect.ShowDialog() != DialogResult.OK)
                return;

            // 更新卡号信息
            studentsPreregTableAdapter.UpdateCardInfo(frmCardConnect.cardNo, cardType, int.Parse(txtID.Text));

            // 刷新界面
            txtCardNo.Text = frmCardConnect.cardNo;
            txtCardType.Text = cardTypeName;
            if (dgvPreregStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPreregStudents.SelectedRows[0];
                row.Cells["CardNo"].Value = txtCardNo.Text;
                row.Cells["CardTypeNameColumn"].Value = cardTypeName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CardConnectForm frmCardConnect = new CardConnectForm();
            frmCardConnect.ShowDialog();

            if (frmCardConnect.cardNo == "")
                return;

            studentsPreregBindingSource.MoveFirst();
            while (txtCardNo.Text != frmCardConnect.cardNo 
                && dgvPreregStudents.SelectedRows[0].Index < dgvPreregStudents.Rows.Count - 1)
            {
                studentsPreregBindingSource.MoveNext();
            }
        }

        private void studentsPreregBindingSource_PositionChanged(object sender, EventArgs e)
        {
            txtPreregisterCourseSubtype.Text = "";
            if (studentsPreregBindingSource.Position < 0)
                return;

            // 更新预报名科目
            int? courseSubtypeID = this.preregisterDataset.studentsPrereg.Rows[studentsPreregBindingSource.Position].Field<int?>("PreregisterCourseSubtype");
            if (courseSubtypeID == null)
                return;
            DataRow row = preregisterDataset.CourseSubtypes.Select("ID = " + courseSubtypeID)[0];
            string courseSubtypeName = row.Field<string>("CourseSubtypeName");
            txtPreregisterCourseSubtype.Text = courseSubtypeName;
        }

        private void PreregManageForm_Resize(object sender, EventArgs e)
        {
            dgvPreregStudents.Width = this.Width - 40;
            dgvPreregStudents.Height = this.Height - 311;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除“" + txtName.Text + "”的资料吗？", "确认删除资料",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            studentsPreregTableAdapter.Delete(int.Parse(txtID.Text));
            MessageBox.Show("删除成功！", "删除资料成功",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.studentsPreregTableAdapter.Fill(this.preregisterDataset.studentsPrereg);
        }
    }
}
