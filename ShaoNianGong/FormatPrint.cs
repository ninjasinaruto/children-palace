using System.Collections;
using System.Xml;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace ShaoNianGong
{
    class FormatPrint
    {
        public SortedList topList { get; set; }
        public SortedList record1List { get; set; }
        public SortedList record2List { get; set; }
        public SortedList record3List { get; set; }
        public SortedList record4List { get; set; }
        public SortedList totalList { get; set; }
        public SortedList bottomList { get; set; }

        /// <summary>
        /// 从打印模版文件中读取点阵数据，并保存到Hash表中
        /// </summary>
        /// <param name="templateFile"></param>
        public void loadPrintTemplate(string templateFile) 
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(templateFile);
            XmlNode xn = xd.SelectSingleNode("Points");
            XmlNodeList xnl = xn.ChildNodes;

            topList = new SortedList();
            record1List = new SortedList();
            record2List = new SortedList();
            record3List = new SortedList();
            record4List = new SortedList();
            totalList = new SortedList();
            bottomList = new SortedList();

            foreach (XmlNode node in xnl) {
                XmlElement xe = (XmlElement) node;
                XmlNodeList nodeList = xe.ChildNodes;
                switch (xe.Name) { 
                    case "Top":
                        AddPrintPoint(nodeList, topList);
                        break;
                    case "Record1":
                        AddPrintPoint(nodeList, record1List);
                        break;
                    case "Record2":
                        AddPrintPoint(nodeList, record2List);
                        break;
                    case "Record3":
                        AddPrintPoint(nodeList, record3List);
                        break;
                    case "Record4":
                        AddPrintPoint(nodeList, record4List);
                        break;
                    case "Total":
                        AddPrintPoint(nodeList, totalList);
                        break;
                    case "Bottom":
                        AddPrintPoint(nodeList, bottomList);
                        break;
                    default:
                        break;
                }
            }
        }

        private PrintPoint GetPrintPoint(XmlElement el) 
        {
            PrintPoint pp = new PrintPoint();
            pp.FontName = el.Attributes["FontName"].InnerText;
            pp.FontSize = float.Parse(el.Attributes["FontSize"].InnerText);
            pp.X = float.Parse(el.Attributes["X"].InnerText);
            pp.Y = float.Parse(el.Attributes["Y"].InnerText);
            pp.Key = el.Attributes["Key"].InnerText;
            return pp;
        }

        private void AddPrintPoint(XmlNodeList nodeList, SortedList list)
        {
            foreach (XmlElement elemnet in nodeList)
            {
                PrintPoint pp = GetPrintPoint(elemnet);
                list.Add(pp.Key, pp);
            }
        }

        public void setValue(SortedList list, string key, string value) {
            if (list.Contains(key))
            {
                PrintPoint printPoint = (PrintPoint) list[key];
                printPoint.Value = value;
            }
            else
            {
                throw new Exception("打印模版中不存在Key为" + key + "的节点！");
            }
        }

        public void SetPrintPointValue(string key, string value, SortedList list, int index) {
            switch (index) { 
                case 0:
                    setValue(list, key, value);
                    break;
                case 1:
                    setValue(record1List, key, value);
                    break;
                case 2:
                    setValue(record2List, key, value);
                    break;
                case 3:
                    setValue(record3List, key, value);
                    break;
                case 4:
                    setValue(record4List, key, value);
                    break;
                default:
                    break;
            }
        }

        public void Print() {
            Print(true);
        }

        public void Print(bool blnShowPrintDialog) {
            try {
                PrintDocument pd = new PrintDocument();

                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                if (blnShowPrintDialog) {
                    PrintDialog pdlg = new PrintDialog();
                    pdlg.Document = pd;

                    DialogResult res = pdlg.ShowDialog();
                    if (res == DialogResult.OK) {
                        pd.Print();
                    }
                } else {
                    pd.Print();
                }
            } finally  {}
        }

        public void Preview() {
            Preview(false);
        }

        public void Preview(bool blnShowPageSetup) {
            try {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 728, 394);
                pd.DefaultPageSettings.Landscape = false;
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                if (blnShowPageSetup) {
                    PageSetupDialog pageSetup = new PageSetupDialog();
                    pageSetup.Document = pd;
                    DialogResult Rc = pageSetup.ShowDialog();
                    if (Rc == DialogResult.Cancel) {
                        return;
                    }
                }
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = pd;
                previewDialog.ShowInTaskbar = true;
                previewDialog.StartPosition = FormStartPosition.CenterScreen;
                previewDialog.ShowDialog();
            } finally {}
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev) {
            Graphics g = ev.Graphics;
            PrintList(topList, g);
            PrintList(record1List, g);
            PrintList(record2List, g);
            PrintList(record3List, g);
            PrintList(record4List, g);
            PrintList(totalList, g);
            PrintList(bottomList, g);
            g.Dispose();
        }

        private void PrintList(SortedList list, Graphics g)
        {
            for (int i = 0, j = list.Count; i < j; i++)
            {
                DrawString((PrintPoint) list.GetByIndex(i), g);
            }
        }

        private void DrawString(PrintPoint pp, Graphics g){
            Font drawFont = new Font(pp.FontName, pp.FontSize);
            Brush drawBrush = new SolidBrush(Color.Black);
            //StringFormat drawFormat = new StringFormat();
            g.DrawString(pp.Value, drawFont, drawBrush, pp.X, pp.Y);
        }
    }

    class PrintPoint {
        public string FontName;
        public float FontSize;
        public float X;
        public float Y;
        public string Key;
        public string Value;
    }
}
