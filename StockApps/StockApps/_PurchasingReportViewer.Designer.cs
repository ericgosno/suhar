namespace StockApps
{
    partial class _PurchasingReportViewer
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
            this._rptPurchasing = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // _rptPurchasing
            // 
            this._rptPurchasing.ActiveViewIndex = -1;
            this._rptPurchasing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptPurchasing.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptPurchasing.Location = new System.Drawing.Point(12, 12);
            this._rptPurchasing.Name = "_rptPurchasing";
            this._rptPurchasing.Size = new System.Drawing.Size(1114, 463);
            this._rptPurchasing.TabIndex = 10;
            this._rptPurchasing.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // _PurchasingReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 483);
            this.Controls.Add(this._rptPurchasing);
            this.Name = "_PurchasingReportViewer";
            this.Text = "Purchasing Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptPurchasing;
    }
}