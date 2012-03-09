namespace BanGongPingTai
{
    partial class WagePrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WagePrintForm));
            this.vbPrint = new VBprinter40.VB2008Print();
            this.lblMask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vbPrint
            // 
            this.vbPrint.CanOpenReport = false;
            this.vbPrint.CanSaveReport = false;
            this.vbPrint.CellMargin = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.vbPrint.Currentx = 0F;
            this.vbPrint.Currenty = 0F;
            this.vbPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vbPrint.DocumentName = "工资汇总打印";
            this.vbPrint.EnabledPageSetting = false;
            this.vbPrint.IsAutoAddEmptyRow = false;
            this.vbPrint.IsDGVCellValignmentCenter = true;
            this.vbPrint.IsDrawmargin = true;
            this.vbPrint.IsDrawPageFooterLine = false;
            this.vbPrint.IsDrawPageHeaderLine = false;
            this.vbPrint.IsImmediatePrintNotPreview = false;
            this.vbPrint.IsImmediatePrintNotPreviewShowPrintDialog = false;
            this.vbPrint.IsNeedCheckNewPage = true;
            this.vbPrint.IsShowContextMenu = false;
            this.vbPrint.IsShowErrorMSG = true;
            this.vbPrint.IsShowMessageIfPrinterNotSupportPaper = true;
            this.vbPrint.IsShowPrintStatusDialog = true;
            this.vbPrint.IsShowProgess = true;
            this.vbPrint.IsUseAPIprintDialog = false;
            this.vbPrint.IsUseDGVPadding = true;
            this.vbPrint.Location = new System.Drawing.Point(0, 0);
            this.vbPrint.Name = "vbPrint";
            this.vbPrint.PageUnits = VBprinter40.VB2008Print.PageExportUnit.CentiMeter;
            this.vbPrint.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.vbPrint.PaperLandscape = true;
            this.vbPrint.PaperMargins = new System.Drawing.Printing.Margins(254, 254, 254, 254);
            this.vbPrint.PaperSize = ((System.Drawing.Printing.PaperSize)(resources.GetObject("vbPrint.PaperSize")));
            this.vbPrint.ShapeDepth = 20;
            this.vbPrint.Size = new System.Drawing.Size(1148, 553);
            this.vbPrint.TabIndex = 0;
            this.vbPrint.TextColor = System.Drawing.Color.Black;
            this.vbPrint.TextFont = new System.Drawing.Font("宋体", 9F);
            this.vbPrint.ToolBarVisible = true;
            this.vbPrint.UseAntiAlias = true;
            this.vbPrint.WaterMarkColor = System.Drawing.Color.Red;
            this.vbPrint.WaterMarkFont = new System.Drawing.Font("华文行楷", 80F, System.Drawing.FontStyle.Bold);
            this.vbPrint.WaterMarkLandscape = true;
            this.vbPrint.WaterMarkOpacity = ((byte)(128));
            this.vbPrint.WaterMarkText = "";
            this.vbPrint.ZDYButtonText = "";
            this.vbPrint.ZDYButtonToolTipText = "";
            this.vbPrint.ZDYButtonVisible = true;
            this.vbPrint.PrintDocument += new VBprinter40.VB2008Print.PrintDocumentEventHandler(this.vbPrint_PrintDocument);
            this.vbPrint.HeaderFooterOut += new VBprinter40.VB2008Print.HeaderFooterOutEventHandler(this.vbPrint_HeaderFooterOut);
            this.vbPrint.EndPreView += new VBprinter40.VB2008Print.EndPreViewEventHandler(this.vbPrint_EndPreView);
            // 
            // lblMask
            // 
            this.lblMask.Location = new System.Drawing.Point(529, 0);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(469, 25);
            this.lblMask.TabIndex = 1;
            // 
            // WagePrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 553);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.vbPrint);
            this.Name = "WagePrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工资汇总打印";
            this.Load += new System.EventHandler(this.WagePrintForm_Load);
            this.Resize += new System.EventHandler(this.WagePrintForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private VBprinter40.VB2008Print vbPrint;
        private System.Windows.Forms.Label lblMask;
    }
}