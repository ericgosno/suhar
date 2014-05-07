namespace StockApps
{
    partial class _sellingReportViewer
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
            this._rptSelling = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // _rptSelling
            // 
            this._rptSelling.ActiveViewIndex = -1;
            this._rptSelling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptSelling.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptSelling.Location = new System.Drawing.Point(12, 12);
            this._rptSelling.Name = "_rptSelling";
            this._rptSelling.Size = new System.Drawing.Size(1114, 463);
            this._rptSelling.TabIndex = 9;
            this._rptSelling.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // _sellingReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 479);
            this.Controls.Add(this._rptSelling);
            this.Name = "_sellingReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptSelling;

    }
}