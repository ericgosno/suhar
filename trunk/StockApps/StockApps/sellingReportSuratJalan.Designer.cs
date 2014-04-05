namespace StockApps
{
    partial class sellingReportSuratJalan
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
            this._rptSellingSJ = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // _rptSellingSJ
            // 
            this._rptSellingSJ.ActiveViewIndex = -1;
            this._rptSellingSJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptSellingSJ.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptSellingSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rptSellingSJ.Location = new System.Drawing.Point(0, 0);
            this._rptSellingSJ.Name = "_rptSellingSJ";
            this._rptSellingSJ.Size = new System.Drawing.Size(889, 548);
            this._rptSellingSJ.TabIndex = 0;
            //this._rptSellingSJ.Load += new System.EventHandler(this._rptSellingSJ_Load);
            // 
            // sellingReportSuratJalan
            // 
            this.ClientSize = new System.Drawing.Size(889, 548);
            this.Controls.Add(this._rptSellingSJ);
            this.Name = "sellingReportSuratJalan";
            this.Text = "CV. WARNA MURNI - SJ";
            this.Load += new System.EventHandler(this.sellingReportSuratJalan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptSellingSJ;
    }
}