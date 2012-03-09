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
            //首先要用NewPage函数创建一个新面，可以带参数的，也可以不带参数的
            vbPrint.NewPage();
            //vbPrint.PrintDGV(dataGridView, "aaa", new Font("黑体", 18), StringAlignment.Center, "1111", true, true, 6, true, true, 0, 0, true, treeView);
            dataGridView.Columns["CreateDate"].Visible = false;
            vbPrint.PrintDGV(dataGridView, "aa", new Font("黑体", 18), "", new Font("黑体", 1), StringAlignment.Center, "1111", true, true, new Font("黑体", 18), "", "", "", new Font("黑体", 18), "", "", "", 6, true, true, 0, 0, true, treeView);
            //输出文本
            vbPrint.NewRow(40);//增加一点间距，请注意控件的PageUnits属性哦
            vbPrint.DrawText("复核：", 1000);
            vbPrint.DrawText("出纳：", 1400);
            vbPrint.DrawText("制表：", 1800);
            vbPrint.NewRow(vbPrint.LastDrawTextHeight);//这条语句很重要哦
            vbPrint.NewRow(40);//再增加一点间距，请注意控件的PageUnits属性哦
        }

        private void vbPrint_EndPreView()
        {
            dataGridView.Columns["CreateDate"].Visible = true;
        }

        private void vbPrint_HeaderFooterOut(int pages, int curpage)
        {
            vbPrint.PrintHeader(null, Image.FromFile(Application.StartupPath + "\\app.ico"), null);
            //vbPrint.PrintHeader(null, printTitle, null, new Font("黑体", 18));
            vbPrint.NewRow(40);
            vbPrint.PrintFooter("", "第" + curpage + "页 共" + pages + "页", "", new Font("宋体", 12), Color.Black, 0);
        }

        private void WagePrintForm_Resize(object sender, EventArgs e)
        {
            this.lblMask.Width = this.Width - 540;
        }
    }
}
