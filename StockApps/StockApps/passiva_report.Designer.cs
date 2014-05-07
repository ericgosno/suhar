namespace StockApps
{
    partial class passiva_report
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
            this.crystalReportPassiva = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportPassiva
            // 
            this.crystalReportPassiva.ActiveViewIndex = -1;
            this.crystalReportPassiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPassiva.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPassiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportPassiva.Location = new System.Drawing.Point(0, 0);
            this.crystalReportPassiva.Name = "crystalReportPassiva";
            this.crystalReportPassiva.Size = new System.Drawing.Size(698, 507);
            this.crystalReportPassiva.TabIndex = 0;
            this.crystalReportPassiva.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // passiva_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 507);
            this.Controls.Add(this.crystalReportPassiva);
            this.Name = "passiva_report";
            this.Text = "CV. WARNA MURNI - Report Neraca Passiva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.passiva_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPassiva;
    }
}