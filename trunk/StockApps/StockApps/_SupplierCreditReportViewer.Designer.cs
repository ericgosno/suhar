namespace StockApps
{
    partial class _SupplierCreditReportViewer
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
            this._bCreditView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._ttransCreditTo = new System.Windows.Forms.DateTimePicker();
            this._rptCredit = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._ttransCreditFrom = new System.Windows.Forms.DateTimePicker();
            this._cbtransCreditName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bCreditView
            // 
            this._bCreditView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bCreditView.Location = new System.Drawing.Point(12, 176);
            this._bCreditView.Name = "_bCreditView";
            this._bCreditView.Size = new System.Drawing.Size(500, 35);
            this._bCreditView.TabIndex = 84;
            this._bCreditView.Text = "VIEW REPORT";
            this._bCreditView.UseVisualStyleBackColor = true;
            this._bCreditView.Click += new System.EventHandler(this._bCreditView_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 83;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 82;
            this.label7.Text = "To";
            // 
            // _ttransCreditTo
            // 
            this._ttransCreditTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ttransCreditTo.Location = new System.Drawing.Point(182, 133);
            this._ttransCreditTo.Name = "_ttransCreditTo";
            this._ttransCreditTo.Size = new System.Drawing.Size(389, 35);
            this._ttransCreditTo.TabIndex = 81;
            // 
            // _rptCredit
            // 
            this._rptCredit.ActiveViewIndex = -1;
            this._rptCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptCredit.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptCredit.Location = new System.Drawing.Point(12, 217);
            this._rptCredit.Name = "_rptCredit";
            this._rptCredit.Size = new System.Drawing.Size(1114, 438);
            this._rptCredit.TabIndex = 75;
            this._rptCredit.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 80;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 79;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 78;
            this.label4.Text = "From";
            // 
            // _ttransCreditFrom
            // 
            this._ttransCreditFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ttransCreditFrom.Location = new System.Drawing.Point(182, 92);
            this._ttransCreditFrom.Name = "_ttransCreditFrom";
            this._ttransCreditFrom.Size = new System.Drawing.Size(389, 35);
            this._ttransCreditFrom.TabIndex = 74;
            // 
            // _cbtransCreditName
            // 
            this._cbtransCreditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbtransCreditName.FormattingEnabled = true;
            this._cbtransCreditName.Location = new System.Drawing.Point(182, 54);
            this._cbtransCreditName.Name = "_cbtransCreditName";
            this._cbtransCreditName.Size = new System.Drawing.Size(389, 37);
            this._cbtransCreditName.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 31);
            this.label5.TabIndex = 76;
            this.label5.Text = "Supplier Credit Report";
            // 
            // _SupplierCreditReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 662);
            this.Controls.Add(this._bCreditView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._ttransCreditTo);
            this.Controls.Add(this._rptCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._ttransCreditFrom);
            this.Controls.Add(this._cbtransCreditName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_SupplierCreditReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Credit Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bCreditView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _ttransCreditTo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _ttransCreditFrom;
        private System.Windows.Forms.ComboBox _cbtransCreditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}