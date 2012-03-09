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
    public partial class PrintForm : Form
    {
        public DataGridView dataGridView;
        public TreeView treeView;
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            vB2008Print1.InvalidatePreview();
        }

        private void vB2008Print1_PrintDocument()
        {
            //所的有打印代码必须写在这个事件中哦
            //首先要用NewPage函数创建一个新面，可以带参数的，也可以不带参数的
            vB2008Print1.NewPage();
            //输出表格，注意是用PrintDGV（打印DataGridView表格），而不是 PrintDataGrid（用于打印古老的DataGrid表格）
            //vB2008Print1.PrintDGV(dataGridView, "福鼎市青少年宫培训中心2011年11月工资表", new Font("黑体", 18), StringAlignment.Center, "1111", true, true, 6, true, true, 0, 0, true, treeView);
            dataGridView.Columns["CreateDate"].Visible = false;
            //vB2008Print1.PrintDGV(dataGridView, "福鼎市青少年宫培训中心2011年11月工资表", new Font("黑体", 18), "   ", new Font("黑体", 28), StringAlignment.Center, "1111", true, true, new Font("黑体", 18), "", "", "", new Font("黑体", 18), "", "", "", 6, true, true, 0, 0, true, treeView);
            vB2008Print1.PrintDGV(dataGridView, "福鼎市青少年宫培训中心2011年11月工资表", new Font("黑体", 18), "子标题", null, StringAlignment.Center, "1111", true, true, new Font("隶书", 10), "制表:游平", "地址:湖南省株洲市215信箱", "", null, null, Color.Red, Color.Yellow, "shouldWagesDataGridViewTextBoxColumn;MinusWagesDataGridViewTextBoxColumn;RealWagesDataGridViewTextBoxColumn", false, false, "", System.ComponentModel.ListSortDirection.Ascending, "", false, "", "中国航空动力机械研究所", "", 5, true, true, true, 0, 0, treeView);
            vB2008Print1.DrawImage(Image.FromFile(Application.StartupPath + "\\app.ico"), 1800, 100, 120, 120);
            //输出文本
            vB2008Print1.NewRow(100);//增加一点间距，请注意控件的PageUnits属性哦
            vB2008Print1.DrawText("测试", 0);
            vB2008Print1.NewRow(vB2008Print1.LastDrawTextHeight);//这条语句很重要哦
            vB2008Print1.NewRow(40);//再增加一点间距，请注意控件的PageUnits属性哦
        }

        private void vB2008Print1_HeaderFooterOut(int pages, int curpage)
        {
            //在这里输出页眉与页脚
            vB2008Print1.PrintFooter("", "第" + curpage + "页 共" + pages + "页", "", new Font("宋体", 12), Color.Red, 0);
        }

        private void vB2008Print1_EndPreView()
        {
            dataGridView.Columns["CreateDate"].Visible = true;
        }

    }
}
