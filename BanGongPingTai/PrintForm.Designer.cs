namespace BanGongPingTai
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.vB2008Print1 = new VBprinter40.VB2008Print();
            this.SuspendLayout();
            // 
            // vB2008Print1
            // 
            this.vB2008Print1.CanOpenReport = false;
            this.vB2008Print1.CanSaveReport = false;
            this.vB2008Print1.CellMargin = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.vB2008Print1.Currentx = 0F;
            this.vB2008Print1.Currenty = 0F;
            this.vB2008Print1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vB2008Print1.DocumentName = "VB2008打印控件";
            this.vB2008Print1.EnabledPageSetting = false;
            this.vB2008Print1.IsAutoAddEmptyRow = false;
            this.vB2008Print1.IsDGVCellValignmentCenter = true;
            this.vB2008Print1.IsDrawmargin = true;
            this.vB2008Print1.IsDrawPageFooterLine = false;
            this.vB2008Print1.IsDrawPageHeaderLine = false;
            this.vB2008Print1.IsImmediatePrintNotPreview = false;
            this.vB2008Print1.IsImmediatePrintNotPreviewShowPrintDialog = false;
            this.vB2008Print1.IsNeedCheckNewPage = true;
            this.vB2008Print1.IsShowContextMenu = true;
            this.vB2008Print1.IsShowErrorMSG = true;
            this.vB2008Print1.IsShowMessageIfPrinterNotSupportPaper = true;
            this.vB2008Print1.IsShowPrintStatusDialog = true;
            this.vB2008Print1.IsShowProgess = true;
            this.vB2008Print1.IsUseAPIprintDialog = true;
            this.vB2008Print1.IsUseDGVPadding = true;
            this.vB2008Print1.Location = new System.Drawing.Point(0, 0);
            this.vB2008Print1.Name = "vB2008Print1";
            this.vB2008Print1.PageUnits = VBprinter40.VB2008Print.PageExportUnit.CentiMeter;
            this.vB2008Print1.PaperKind = System.Drawing.Printing.PaperKind.A3;
            this.vB2008Print1.PaperLandscape = true;
            this.vB2008Print1.PaperMargins = new System.Drawing.Printing.Margins(254, 254, 254, 254);
            this.vB2008Print1.PaperSize = ((System.Drawing.Printing.PaperSize)(resources.GetObject("vB2008Print1.PaperSize")));
            this.vB2008Print1.ShapeDepth = 20;
            this.vB2008Print1.Size = new System.Drawing.Size(1148, 553);
            this.vB2008Print1.TabIndex = 0;
            this.vB2008Print1.TextColor = System.Drawing.Color.Black;
            this.vB2008Print1.TextFont = new System.Drawing.Font("宋体", 10F);
            this.vB2008Print1.ToolBarVisible = true;
            this.vB2008Print1.UseAntiAlias = true;
            this.vB2008Print1.WaterMarkColor = System.Drawing.Color.Red;
            this.vB2008Print1.WaterMarkFont = new System.Drawing.Font("华文行楷", 80F, System.Drawing.FontStyle.Bold);
            this.vB2008Print1.WaterMarkLandscape = true;
            this.vB2008Print1.WaterMarkOpacity = ((byte)(128));
            this.vB2008Print1.WaterMarkText = "";
            this.vB2008Print1.ZDYButtonText = "";
            this.vB2008Print1.ZDYButtonToolTipText = "";
            this.vB2008Print1.ZDYButtonVisible = true;
            this.vB2008Print1.PrintDocument += new VBprinter40.VB2008Print.PrintDocumentEventHandler(this.vB2008Print1_PrintDocument);
            this.vB2008Print1.HeaderFooterOut += new VBprinter40.VB2008Print.HeaderFooterOutEventHandler(this.vB2008Print1_HeaderFooterOut);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 553);
            this.Controls.Add(this.vB2008Print1);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VBprinter40.VB2008Print vB2008Print1;
    }
}