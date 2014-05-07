namespace StockApps
{
    partial class _CustomerDebtReportViewer
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
            this._bDebtView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._ttransDebtTo = new System.Windows.Forms.DateTimePicker();
            this._rptDebt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._ttransDebtFrom = new System.Windows.Forms.DateTimePicker();
            this._cbtransDebtName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bDebtView
            // 
            this._bDebtView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bDebtView.Location = new System.Drawing.Point(12, 174);
            this._bDebtView.Name = "_bDebtView";
            this._bDebtView.Size = new System.Drawing.Size(545, 35);
            this._bDebtView.TabIndex = 84;
            this._bDebtView.Text = "VIEW REPORT";
            this._bDebtView.UseVisualStyleBackColor = true;
            this._bDebtView.Click += new System.EventHandler(this._bDebtView_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 83;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 82;
            this.label7.Text = "To";
            // 
            // _ttransDebtTo
            // 
            this._ttransDebtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ttransDebtTo.Location = new System.Drawing.Point(168, 128);
            this._ttransDebtTo.Name = "_ttransDebtTo";
            this._ttransDebtTo.Size = new System.Drawing.Size(389, 35);
            this._ttransDebtTo.TabIndex = 81;
            // 
            // _rptDebt
            // 
            this._rptDebt.ActiveViewIndex = -1;
            this._rptDebt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptDebt.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptDebt.Location = new System.Drawing.Point(12, 215);
            this._rptDebt.Name = "_rptDebt";
            this._rptDebt.Size = new System.Drawing.Size(1114, 438);
            this._rptDebt.TabIndex = 75;
            this._rptDebt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 80;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 79;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 78;
            this.label4.Text = "From";
            // 
            // _ttransDebtFrom
            // 
            this._ttransDebtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ttransDebtFrom.Location = new System.Drawing.Point(168, 87);
            this._ttransDebtFrom.Name = "_ttransDebtFrom";
            this._ttransDebtFrom.Size = new System.Drawing.Size(389, 35);
            this._ttransDebtFrom.TabIndex = 74;
            // 
            // _cbtransDebtName
            // 
            this._cbtransDebtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbtransDebtName.FormattingEnabled = true;
            this._cbtransDebtName.Location = new System.Drawing.Point(168, 49);
            this._cbtransDebtName.Name = "_cbtransDebtName";
            this._cbtransDebtName.Size = new System.Drawing.Size(389, 37);
            this._cbtransDebtName.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 31);
            this.label5.TabIndex = 76;
            this.label5.Text = "Customer Debt Report";
            // 
            // _CustomerDebtReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 661);
            this.Controls.Add(this._bDebtView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._ttransDebtTo);
            this.Controls.Add(this._rptDebt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._ttransDebtFrom);
            this.Controls.Add(this._cbtransDebtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_CustomerDebtReportViewer";
            this.Text = "Customer Debt Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bDebtView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _ttransDebtTo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptDebt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _ttransDebtFrom;
        private System.Windows.Forms.ComboBox _cbtransDebtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}