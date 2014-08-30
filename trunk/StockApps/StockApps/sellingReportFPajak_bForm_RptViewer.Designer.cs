namespace StockApps
{
    partial class sellingReportFPajak_bForm_RptViewer
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
            this._rptSRFakturPajak = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // _rptSRFakturPajak
            // 
            this._rptSRFakturPajak.ActiveViewIndex = -1;
            this._rptSRFakturPajak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptSRFakturPajak.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptSRFakturPajak.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rptSRFakturPajak.Location = new System.Drawing.Point(0, 0);
            this._rptSRFakturPajak.Name = "_rptSRFakturPajak";
            this._rptSRFakturPajak.Size = new System.Drawing.Size(1008, 730);
            this._rptSRFakturPajak.TabIndex = 0;
            this._rptSRFakturPajak.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this._rptSRFakturPajak.Load += new System.EventHandler(this._rptSRFakturPajak_Load);
            // 
            // sellingReportFPajak_bForm_RptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this._rptSRFakturPajak);
            this.Name = "sellingReportFPajak_bForm_RptViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellingReportFPajak_bForm_RptViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sellingReportFPajak_bForm_RptViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptSRFakturPajak;
    }
}