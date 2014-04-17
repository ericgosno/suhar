namespace StockApps
{
    partial class _insertBankTransaction
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
            this._tbtransDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._cbtransDate = new System.Windows.Forms.DateTimePicker();
            this._tbtransMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._cbtransBankName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._lbtransTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cbtransDebitCredit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbtransCode = new System.Windows.Forms.TextBox();
            this._lbtransCurrency = new System.Windows.Forms.Label();
            this._bbtransInsert = new System.Windows.Forms.Button();
            this._lbtransBankName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tbtransKurs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _tbtransDescription
            // 
            this._tbtransDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbtransDescription.Location = new System.Drawing.Point(177, 310);
            this._tbtransDescription.Multiline = true;
            this._tbtransDescription.Name = "_tbtransDescription";
            this._tbtransDescription.Size = new System.Drawing.Size(386, 94);
            this._tbtransDescription.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "Description  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Date              :";
            // 
            // _cbtransDate
            // 
            this._cbtransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbtransDate.Location = new System.Drawing.Point(177, 102);
            this._cbtransDate.Name = "_cbtransDate";
            this._cbtransDate.Size = new System.Drawing.Size(386, 35);
            this._cbtransDate.TabIndex = 2;
            // 
            // _tbtransMoney
            // 
            this._tbtransMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbtransMoney.Location = new System.Drawing.Point(177, 227);
            this._tbtransMoney.Name = "_tbtransMoney";
            this._tbtransMoney.Size = new System.Drawing.Size(268, 35);
            this._tbtransMoney.TabIndex = 5;
            this._tbtransMoney.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 55;
            this.label8.Text = "Nominal       :";
            // 
            // _cbtransBankName
            // 
            this._cbtransBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbtransBankName.FormattingEnabled = true;
            this._cbtransBankName.Location = new System.Drawing.Point(177, 59);
            this._cbtransBankName.Name = "_cbtransBankName";
            this._cbtransBankName.Size = new System.Drawing.Size(386, 37);
            this._cbtransBankName.TabIndex = 1;
            this._cbtransBankName.SelectedIndexChanged += new System.EventHandler(this._cbtransBankName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Bank/Cash   :";
            // 
            // _lbtransTitle
            // 
            this._lbtransTitle.AutoSize = true;
            this._lbtransTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbtransTitle.Location = new System.Drawing.Point(12, 13);
            this._lbtransTitle.Name = "_lbtransTitle";
            this._lbtransTitle.Size = new System.Drawing.Size(298, 31);
            this._lbtransTitle.TabIndex = 52;
            this._lbtransTitle.Text = "Bank/Cash Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 61;
            this.label2.Text = "Debit/Credit :";
            // 
            // _cbtransDebitCredit
            // 
            this._cbtransDebitCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbtransDebitCredit.FormattingEnabled = true;
            this._cbtransDebitCredit.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this._cbtransDebitCredit.Location = new System.Drawing.Point(177, 143);
            this._cbtransDebitCredit.Name = "_cbtransDebitCredit";
            this._cbtransDebitCredit.Size = new System.Drawing.Size(389, 37);
            this._cbtransDebitCredit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Trans Code :";
            // 
            // _tbtransCode
            // 
            this._tbtransCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbtransCode.Location = new System.Drawing.Point(177, 183);
            this._tbtransCode.Name = "_tbtransCode";
            this._tbtransCode.Size = new System.Drawing.Size(386, 35);
            this._tbtransCode.TabIndex = 4;
            // 
            // _lbtransCurrency
            // 
            this._lbtransCurrency.AutoSize = true;
            this._lbtransCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbtransCurrency.Location = new System.Drawing.Point(451, 227);
            this._lbtransCurrency.Name = "_lbtransCurrency";
            this._lbtransCurrency.Size = new System.Drawing.Size(124, 29);
            this._lbtransCurrency.TabIndex = 65;
            this._lbtransCurrency.Text = "IDR/Dollar";
            // 
            // _bbtransInsert
            // 
            this._bbtransInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbtransInsert.Location = new System.Drawing.Point(177, 421);
            this._bbtransInsert.Name = "_bbtransInsert";
            this._bbtransInsert.Size = new System.Drawing.Size(133, 35);
            this._bbtransInsert.TabIndex = 7;
            this._bbtransInsert.Text = "INSERT";
            this._bbtransInsert.UseVisualStyleBackColor = true;
            this._bbtransInsert.Click += new System.EventHandler(this._bbtransInsert_Click);
            // 
            // _lbtransBankName
            // 
            this._lbtransBankName.AutoSize = true;
            this._lbtransBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbtransBankName.Location = new System.Drawing.Point(175, 61);
            this._lbtransBankName.Name = "_lbtransBankName";
            this._lbtransBankName.Size = new System.Drawing.Size(85, 29);
            this._lbtransBankName.TabIndex = 66;
            this._lbtransBankName.Text = "Bank...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 67;
            this.label5.Text = "Kurs              :";
            // 
            // _tbtransKurs
            // 
            this._tbtransKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbtransKurs.Location = new System.Drawing.Point(177, 269);
            this._tbtransKurs.Name = "_tbtransKurs";
            this._tbtransKurs.Size = new System.Drawing.Size(386, 35);
            this._tbtransKurs.TabIndex = 68;
            this._tbtransKurs.Text = "0";
            // 
            // _insertBankTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 474);
            this.Controls.Add(this._tbtransKurs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._lbtransBankName);
            this.Controls.Add(this._bbtransInsert);
            this.Controls.Add(this._lbtransCurrency);
            this.Controls.Add(this._tbtransCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbtransDebitCredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tbtransDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._cbtransDate);
            this.Controls.Add(this._tbtransMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._cbtransBankName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lbtransTitle);
            this.Name = "_insertBankTransaction";
            this.Text = "_insertBankTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbtransDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _cbtransDate;
        private System.Windows.Forms.TextBox _tbtransMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox _cbtransBankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lbtransTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cbtransDebitCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbtransCode;
        private System.Windows.Forms.Label _lbtransCurrency;
        private System.Windows.Forms.Button _bbtransInsert;
        private System.Windows.Forms.Label _lbtransBankName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tbtransKurs;
    }
}