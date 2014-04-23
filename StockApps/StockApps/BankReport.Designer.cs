namespace StockApps
{
    partial class BankReport
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
            this._rptBank = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._ttransBankFrom = new System.Windows.Forms.DateTimePicker();
            this._cbtransBankName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._ttransBankTo = new System.Windows.Forms.DateTimePicker();
            this._bbankView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _rptBank
            // 
            this._rptBank.ActiveViewIndex = -1;
            this._rptBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rptBank.Cursor = System.Windows.Forms.Cursors.Default;
            this._rptBank.Location = new System.Drawing.Point(12, 220);
            this._rptBank.Name = "_rptBank";
            this._rptBank.Size = new System.Drawing.Size(1114, 438);
            this._rptBank.TabIndex = 63;
            this._rptBank.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 68;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "From";
            // 
            // _ttransBankFrom
            // 
            this._ttransBankFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ttransBankFrom.Location = new System.Drawing.Point(123, 95);
            this._ttransBankFrom.Name = "_ttransBankFrom";
            this._ttransBankFrom.Size = new System.Drawing.Size(389, 35);
            this._ttransBankFrom.TabIndex = 60;
            this._ttransBankFrom.ValueChanged += new System.EventHandler(this._ttransBankFrom_ValueChanged);
            // 
            // _cbtransBankName
            // 
            this._cbtransBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbtransBankName.FormattingEnabled = true;
            this._cbtransBankName.Location = new System.Drawing.Point(123, 57);
            this._cbtransBankName.Name = "_cbtransBankName";
            this._cbtransBankName.Size = new System.Drawing.Size(389, 37);
            this._cbtransBankName.TabIndex = 59;
            this._cbtransBankName.SelectedIndexChanged += new System.EventHandler(this._cbtransBankName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 31);
            this.label5.TabIndex = 64;
            this.label5.Text = "Bank Transaction Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 71;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 70;
            this.label7.Text = "To";
            // 
            // _ttransBankTo
            // 
            this._ttransBankTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ttransBankTo.Location = new System.Drawing.Point(123, 136);
            this._ttransBankTo.Name = "_ttransBankTo";
            this._ttransBankTo.Size = new System.Drawing.Size(389, 35);
            this._ttransBankTo.TabIndex = 69;
            this._ttransBankTo.ValueChanged += new System.EventHandler(this._ttransBankTo_ValueChanged);
            // 
            // _bbankView
            // 
            this._bbankView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbankView.Location = new System.Drawing.Point(12, 179);
            this._bbankView.Name = "_bbankView";
            this._bbankView.Size = new System.Drawing.Size(500, 35);
            this._bbankView.TabIndex = 72;
            this._bbankView.Text = "VIEW REPORT";
            this._bbankView.UseVisualStyleBackColor = true;
            this._bbankView.Click += new System.EventHandler(this._bbankView_Click);
            // 
            // BankReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 670);
            this.Controls.Add(this._bbankView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._ttransBankTo);
            this.Controls.Add(this._rptBank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._ttransBankFrom);
            this.Controls.Add(this._cbtransBankName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "BankReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Transaction Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _rptBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _ttransBankFrom;
        private System.Windows.Forms.ComboBox _cbtransBankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _ttransBankTo;
        private System.Windows.Forms.Button _bbankView;
    }
}