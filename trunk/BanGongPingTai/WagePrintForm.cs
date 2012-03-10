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
    public partial class WagePrintForm : Form
    {
        public string printTitle;
        public DataGridView dataGridView;
        public TreeView treeView;
        public decimal totalWages;

        public WagePrintForm()
        {
            InitializeComponent();
        }

        private void WagePrintForm_Load(object sender, EventArgs e)
        {
            vbPrint.InvalidatePreview();
        }

        private void vbPrint_PrintDocument()
        {
            vbPrint.NewPage();
            dataGridView.Columns["CreateDate"].Visible = false;
            vbPrint.PrintDGV(dataGridView, printTitle, new Font("黑体", 18), "", null, StringAlignment.Center, "1111",
                true, true, new Font("黑体", 10, FontStyle.Bold), "", "", "打印时间：" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString(), null, null, Color.Black, Color.WhiteSmoke, 
                "shouldWagesDataGridViewTextBoxColumn;MinusWagesDataGridViewTextBoxColumn;RealWagesDataGridViewTextBoxColumn",
                false, false, "", System.ComponentModel.ListSortDirection.Ascending, "", false, "",
                "", "", 6, true, true, true, 0, 0, treeView);
            
            vbPrint.DrawCell("本页共计(大写)："+vbPrint.SmallToBig(ref totalWages), vbPrint.PaperPrintWidth, vbPrint.LastDrawTextHeight, null, Color.Black, "1111", StringAlignment.Near, StringAlignment.Center, false, true, true, false, 6, Color.WhiteSmoke, Color.Gray, 0);
            vbPrint.NewRow(vbPrint.LastDrawTextHeight);
            vbPrint.NewRow(20);
            vbPrint.DrawText("主管: 高世峰               会计: 许雪峰               核对: 郑文静", vbPrint.PaperPrintWidth, vbPrint.LastDrawTextHeight, new Font("黑体", 10, FontStyle.Bold), Color.Black, StringAlignment.Center, StringAlignment.Center, true, true, false, false, 6, 0);
            vbPrint.NewRow(40);
            
        }

        private void vbPrint_EndPreView()
        {
            dataGridView.Columns["CreateDate"].Visible = true;
        }

        private void vbPrint_HeaderFooterOut(int pages, int curpage)
        {
            vbPrint.PrintHeader(null, Image.FromFile(Application.StartupPath + "\\app.ico"), null);
            vbPrint.NewRow(40);
            vbPrint.PrintFooter("", "第" + curpage + "页 共" + pages + "页", "", new Font("宋体", 12), Color.Black, 0);
        }

        private void WagePrintForm_Resize(object sender, EventArgs e)
        {
            this.lblMask.Width = this.Width - 540;
        }
    }
}
