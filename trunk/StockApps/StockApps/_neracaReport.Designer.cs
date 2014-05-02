namespace StockApps
{
    partial class _neracaReport
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
            this.crystalReportViewerNeraca = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerNeraca
            // 
            this.crystalReportViewerNeraca.ActiveViewIndex = -1;
            this.crystalReportViewerNeraca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerNeraca.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerNeraca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerNeraca.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerNeraca.Name = "crystalReportViewerNeraca";
            this.crystalReportViewerNeraca.Size = new System.Drawing.Size(808, 591);
            this.crystalReportViewerNeraca.TabIndex = 0;
            this.crystalReportViewerNeraca.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // _neracaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 591);
            this.Controls.Add(this.crystalReportViewerNeraca);
            this.Name = "_neracaReport";
            this.Text = "_neracaReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._neracaReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerNeraca;

    }
}