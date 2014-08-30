namespace StockApps
{
    partial class sellingReportFP_bForm_RptViewer
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
            this._rptSRFakturPenjualan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // _rptSRFakturPenjualan
            // 
            this._rptSRFakturPenjualan.ActiveViewIndex = -1;
            this._rptSRFakturPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptSRFakturPenjualan.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptSRFakturPenjualan.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rptSRFakturPenjualan.Location = new System.Drawing.Point(0, 0);
            this._rptSRFakturPenjualan.Name = "_rptSRFakturPenjualan";
            this._rptSRFakturPenjualan.Size = new System.Drawing.Size(1008, 730);
            this._rptSRFakturPenjualan.TabIndex = 0;
            this._rptSRFakturPenjualan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this._rptSRFakturPenjualan.Load += new System.EventHandler(this._rptSRFakturPenjualan_Load);
            // 
            // sellingReportFP_bForm_RptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this._rptSRFakturPenjualan);
            this.Name = "sellingReportFP_bForm_RptViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellingReportFP";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptSRFakturPenjualan;
    }
}