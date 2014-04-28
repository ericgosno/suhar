namespace StockApps
{
    partial class adminHistoryR
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
            this._bHistoryView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._tHistoryTo = new System.Windows.Forms.DateTimePicker();
            this._rptHistory = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._tHistoryFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bHistoryView
            // 
            this._bHistoryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bHistoryView.Location = new System.Drawing.Point(12, 122);
            this._bHistoryView.Name = "_bHistoryView";
            this._bHistoryView.Size = new System.Drawing.Size(550, 35);
            this._bHistoryView.TabIndex = 96;
            this._bHistoryView.Text = "VIEW REPORT";
            this._bHistoryView.UseVisualStyleBackColor = true;
            this._bHistoryView.Click += new System.EventHandler(this._bHistoryView_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 95;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 94;
            this.label7.Text = "To";
            // 
            // _tHistoryTo
            // 
            this._tHistoryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tHistoryTo.Location = new System.Drawing.Point(173, 81);
            this._tHistoryTo.Name = "_tHistoryTo";
            this._tHistoryTo.Size = new System.Drawing.Size(389, 35);
            this._tHistoryTo.TabIndex = 93;
            // 
            // _rptHistory
            // 
            this._rptHistory.ActiveViewIndex = -1;
            this._rptHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptHistory.Location = new System.Drawing.Point(12, 164);
            this._rptHistory.Name = "_rptHistory";
            this._rptHistory.Size = new System.Drawing.Size(756, 438);
            this._rptHistory.TabIndex = 87;
            this._rptHistory.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 91;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 90;
            this.label4.Text = "From";
            // 
            // _tHistoryFrom
            // 
            this._tHistoryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tHistoryFrom.Location = new System.Drawing.Point(173, 40);
            this._tHistoryFrom.Name = "_tHistoryFrom";
            this._tHistoryFrom.Size = new System.Drawing.Size(389, 35);
            this._tHistoryFrom.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 31);
            this.label5.TabIndex = 88;
            this.label5.Text = "Admin History Report";
            // 
            // adminHistoryR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 614);
            this.Controls.Add(this._bHistoryView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._tHistoryTo);
            this.Controls.Add(this._rptHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._tHistoryFrom);
            this.Controls.Add(this.label5);
            this.Name = "adminHistoryR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - HISTORY ADMIN";
            this.Load += new System.EventHandler(this.adminHistoryR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bHistoryView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _tHistoryTo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _tHistoryFrom;
        private System.Windows.Forms.Label label5;


    }
}