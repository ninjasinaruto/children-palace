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
            vB2008Print1.PrintDGV(dataGridView, "工资表", new Font("黑体", 18), StringAlignment.Center, "1111", true, true, 6, true, true, 0, 0, true, treeView);

            //输出文本
            vB2008Print1.NewRow(20);//增加一点间距，请注意控件的PageUnits属性哦
            vB2008Print1.DrawText("测试", 0);
            vB2008Print1.NewRow(vB2008Print1.LastDrawTextHeight);//这条语句很重要哦
            vB2008Print1.NewRow(40);//再增加一点间距，请注意控件的PageUnits属性哦
        }

        private void vB2008Print1_HeaderFooterOut(int pages, int curpage)
        {
            //在这里输出页眉与页脚
            vB2008Print1.PrintFooter("", "第" + curpage + "页 共" + pages + "页", "", new Font("宋体", 12), Color.Red, 0);
        }
    }
}
