﻿namespace StockApps
{
    partial class sellingReportSJ_bForm_RptViewer
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
            this._rptSRSuratJalan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // _rptSRSuratJalan
            // 
            this._rptSRSuratJalan.ActiveViewIndex = -1;
            this._rptSRSuratJalan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptSRSuratJalan.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptSRSuratJalan.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rptSRSuratJalan.Location = new System.Drawing.Point(0, 0);
            this._rptSRSuratJalan.Name = "_rptSRSuratJalan";
            this._rptSRSuratJalan.Size = new System.Drawing.Size(1008, 730);
            this._rptSRSuratJalan.TabIndex = 0;
            // 
            // sellingReportSJ_bForm_RptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this._rptSRSuratJalan);
            this.Name = "sellingReportSJ_bForm_RptViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "sellingReportSJ_Form_RptViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sellingReportSJ_bForm_RptViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptSRSuratJalan;
    }
}