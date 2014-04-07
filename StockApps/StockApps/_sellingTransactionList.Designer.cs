namespace StockApps
{
    partial class _sellingTransactionList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._cbSellTransFrom = new System.Windows.Forms.DateTimePicker();
            this._cbSellTransNama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cbSellTransTo = new System.Windows.Forms.DateTimePicker();
            this._dataPriceHistory = new System.Windows.Forms.DataGridView();
            this._bSellTransPrint = new System.Windows.Forms.Button();
            this._bSellTransSJ = new System.Windows.Forms.Button();
            this._lShowAll = new System.Windows.Forms.CheckBox();
            this._bSellTransFP = new System.Windows.Forms.Button();
            this._bSellTransFPAJAK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataPriceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 61;
            this.label4.Text = "From";
            // 
            // _cbSellTransFrom
            // 
            this._cbSellTransFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbSellTransFrom.Location = new System.Drawing.Point(156, 94);
            this._cbSellTransFrom.Name = "_cbSellTransFrom";
            this._cbSellTransFrom.Size = new System.Drawing.Size(445, 35);
            this._cbSellTransFrom.TabIndex = 58;
            this._cbSellTransFrom.ValueChanged += new System.EventHandler(this._cbSellTransFrom_ValueChanged);
            // 
            // _cbSellTransNama
            // 
            this._cbSellTransNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbSellTransNama.FormattingEnabled = true;
            this._cbSellTransNama.Location = new System.Drawing.Point(288, 51);
            this._cbSellTransNama.Name = "_cbSellTransNama";
            this._cbSellTransNama.Size = new System.Drawing.Size(313, 37);
            this._cbSellTransNama.TabIndex = 57;
            this._cbSellTransNama.SelectedIndexChanged += new System.EventHandler(this._cbSellTransNama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 31);
            this.label5.TabIndex = 59;
            this.label5.Text = "Selling Transaction Archive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 66;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 65;
            this.label7.Text = "To";
            // 
            // _cbSellTransTo
            // 
            this._cbSellTransTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbSellTransTo.Location = new System.Drawing.Point(156, 133);
            this._cbSellTransTo.Name = "_cbSellTransTo";
            this._cbSellTransTo.Size = new System.Drawing.Size(445, 35);
            this._cbSellTransTo.TabIndex = 64;
            this._cbSellTransTo.ValueChanged += new System.EventHandler(this._cbSellTransTo_ValueChanged);
            // 
            // _dataPriceHistory
            // 
            this._dataPriceHistory.AllowUserToAddRows = false;
            this._dataPriceHistory.AllowUserToDeleteRows = false;
            this._dataPriceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataPriceHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._dataPriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataPriceHistory.Location = new System.Drawing.Point(13, 210);
            this._dataPriceHistory.MultiSelect = false;
            this._dataPriceHistory.Name = "_dataPriceHistory";
            this._dataPriceHistory.ReadOnly = true;
            this._dataPriceHistory.Size = new System.Drawing.Size(588, 230);
            this._dataPriceHistory.TabIndex = 68;
            // 
            // _bSellTransPrint
            // 
            this._bSellTransPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bSellTransPrint.Location = new System.Drawing.Point(13, 446);
            this._bSellTransPrint.Name = "_bSellTransPrint";
            this._bSellTransPrint.Size = new System.Drawing.Size(105, 70);
            this._bSellTransPrint.TabIndex = 73;
            this._bSellTransPrint.Text = "PRINT";
            this._bSellTransPrint.UseVisualStyleBackColor = true;
            this._bSellTransPrint.Click += new System.EventHandler(this._bSellTransPrint_Click);
            // 
            // _bSellTransSJ
            // 
            this._bSellTransSJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bSellTransSJ.Location = new System.Drawing.Point(124, 446);
            this._bSellTransSJ.Name = "_bSellTransSJ";
            this._bSellTransSJ.Size = new System.Drawing.Size(115, 70);
            this._bSellTransSJ.TabIndex = 74;
            this._bSellTransSJ.Text = "SURAT JALAN";
            this._bSellTransSJ.UseVisualStyleBackColor = true;
            this._bSellTransSJ.Click += new System.EventHandler(this._bSellTransSJ_Click);
            // 
            // _lShowAll
            // 
            this._lShowAll.AutoSize = true;
            this._lShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lShowAll.Location = new System.Drawing.Point(156, 53);
            this._lShowAll.Name = "_lShowAll";
            this._lShowAll.Size = new System.Drawing.Size(126, 33);
            this._lShowAll.TabIndex = 75;
            this._lShowAll.Text = "Show All";
            this._lShowAll.UseVisualStyleBackColor = true;
            this._lShowAll.CheckedChanged += new System.EventHandler(this._lShowAll_CheckedChanged);
            // 
            // _bSellTransFP
            // 
            this._bSellTransFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bSellTransFP.Location = new System.Drawing.Point(245, 446);
            this._bSellTransFP.Name = "_bSellTransFP";
            this._bSellTransFP.Size = new System.Drawing.Size(163, 70);
            this._bSellTransFP.TabIndex = 76;
            this._bSellTransFP.Text = "FAKTUR PENJUALAN";
            this._bSellTransFP.UseVisualStyleBackColor = true;
            this._bSellTransFP.Click += new System.EventHandler(this._bSellTransFP_Click);
            // 
            // _bSellTransFPAJAK
            // 
            this._bSellTransFPAJAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bSellTransFPAJAK.Location = new System.Drawing.Point(414, 446);
            this._bSellTransFPAJAK.Name = "_bSellTransFPAJAK";
            this._bSellTransFPAJAK.Size = new System.Drawing.Size(163, 70);
            this._bSellTransFPAJAK.TabIndex = 77;
            this._bSellTransFPAJAK.Text = "FAKTUR PAJAK";
            this._bSellTransFPAJAK.UseVisualStyleBackColor = true;
            this._bSellTransFPAJAK.Click += new System.EventHandler(this._bSellTransFPAJAK_Click);
            // 
            // _sellingTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 523);
            this.Controls.Add(this._bSellTransFPAJAK);
            this.Controls.Add(this._bSellTransFP);
            this.Controls.Add(this._lShowAll);
            this.Controls.Add(this._bSellTransSJ);
            this.Controls.Add(this._bSellTransPrint);
            this.Controls.Add(this._dataPriceHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._cbSellTransTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._cbSellTransFrom);
            this.Controls.Add(this._cbSellTransNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_sellingTransactionList";
            this.Text = "Selling Transaction Archive";
            ((System.ComponentModel.ISupportInitialize)(this._dataPriceHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _cbSellTransFrom;
        private System.Windows.Forms.ComboBox _cbSellTransNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _cbSellTransTo;
        private System.Windows.Forms.DataGridView _dataPriceHistory;
        private System.Windows.Forms.Button _bSellTransPrint;
        private System.Windows.Forms.Button _bSellTransSJ;
        private System.Windows.Forms.CheckBox _lShowAll;
        private System.Windows.Forms.Button _bSellTransFP;
        private System.Windows.Forms.Button _bSellTransFPAJAK;
    }
}