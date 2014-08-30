namespace StockApps
{
    partial class sellingReportFPRangkap3
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
            this._rpvFPR3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // _rpvFPR3
            // 
            this._rpvFPR3.ActiveViewIndex = -1;
            this._rpvFPR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rpvFPR3.Cursor = System.Windows.Forms.Cursors.Default;
            this._rpvFPR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rpvFPR3.Location = new System.Drawing.Point(0, 0);
            this._rpvFPR3.Name = "_rpvFPR3";
            this._rpvFPR3.Size = new System.Drawing.Size(1008, 730);
            this._rpvFPR3.TabIndex = 0;
            this._rpvFPR3.Load += new System.EventHandler(this._rpvFPR3_Load);
            // 
            // sellingReportFPRangkap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this._rpvFPR3);
            this.Name = "sellingReportFPRangkap3";
            this.Text = "sellingReportFPRangkap3";
            this.Load += new System.EventHandler(this.sellingReportFPRangkap3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rpvFPR3;
    }
}