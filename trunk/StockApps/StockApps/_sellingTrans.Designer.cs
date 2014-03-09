namespace StockApps
{
    partial class _sellingTrans
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
            this._lsellDollar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lsellRp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cbsellNama = new System.Windows.Forms.ComboBox();
            this._dataCusTransaction = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity_Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_Dollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_Rupiah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bsellPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tsellDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._dtTransDate = new System.Windows.Forms.DateTimePicker();
            this._tsellKurs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._bsellDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataCusTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // _lsellDollar
            // 
            this._lsellDollar.AutoSize = true;
            this._lsellDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lsellDollar.Location = new System.Drawing.Point(174, 540);
            this._lsellDollar.Name = "_lsellDollar";
            this._lsellDollar.Size = new System.Drawing.Size(26, 29);
            this._lsellDollar.TabIndex = 45;
            this._lsellDollar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total - Rp :";
            // 
            // _lsellRp
            // 
            this._lsellRp.AutoSize = true;
            this._lsellRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lsellRp.Location = new System.Drawing.Point(174, 569);
            this._lsellRp.Name = "_lsellRp";
            this._lsellRp.Size = new System.Drawing.Size(26, 29);
            this._lsellRp.TabIndex = 43;
            this._lsellRp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total - $ :";
            // 
            // _cbsellNama
            // 
            this._cbsellNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbsellNama.FormattingEnabled = true;
            this._cbsellNama.Location = new System.Drawing.Point(177, 55);
            this._cbsellNama.Name = "_cbsellNama";
            this._cbsellNama.Size = new System.Drawing.Size(389, 37);
            this._cbsellNama.TabIndex = 39;
            // 
            // _dataCusTransaction
            // 
            this._dataCusTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataCusTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity_Kg,
            this.Price_Kg,
            this.Package_Quantity,
            this.Stock,
            this.Subtotal_Dollar,
            this.Subtotal_Rupiah});
            this._dataCusTransaction.Location = new System.Drawing.Point(12, 246);
            this._dataCusTransaction.Name = "_dataCusTransaction";
            this._dataCusTransaction.Size = new System.Drawing.Size(751, 270);
            this._dataCusTransaction.TabIndex = 38;
            this._dataCusTransaction.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataCusTransaction_CellEndEdit);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Quantity_Kg
            // 
            this.Quantity_Kg.HeaderText = "Quantity(Kgs)";
            this.Quantity_Kg.Name = "Quantity_Kg";
            // 
            // Price_Kg
            // 
            this.Price_Kg.HeaderText = "Price Per Kgs(Dollar)";
            this.Price_Kg.Name = "Price_Kg";
            // 
            // Package_Quantity
            // 
            this.Package_Quantity.HeaderText = "Package Quantity";
            this.Package_Quantity.Name = "Package_Quantity";
            this.Package_Quantity.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Subtotal_Dollar
            // 
            this.Subtotal_Dollar.HeaderText = "Subtotal(Dollar)";
            this.Subtotal_Dollar.Name = "Subtotal_Dollar";
            this.Subtotal_Dollar.ReadOnly = true;
            // 
            // Subtotal_Rupiah
            // 
            this.Subtotal_Rupiah.HeaderText = "Subtotal(Rupiah)";
            this.Subtotal_Rupiah.Name = "Subtotal_Rupiah";
            this.Subtotal_Rupiah.ReadOnly = true;
            // 
            // _bsellPay
            // 
            this._bsellPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bsellPay.Location = new System.Drawing.Point(601, 561);
            this._bsellPay.Name = "_bsellPay";
            this._bsellPay.Size = new System.Drawing.Size(162, 35);
            this._bsellPay.TabIndex = 37;
            this._bsellPay.Text = "PROCESS";
            this._bsellPay.UseVisualStyleBackColor = true;
            this._bsellPay.Click += new System.EventHandler(this._bsellPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name           :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "Customer Transaction";
            // 
            // _tsellDescription
            // 
            this._tsellDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tsellDescription.Location = new System.Drawing.Point(180, 180);
            this._tsellDescription.Multiline = true;
            this._tsellDescription.Name = "_tsellDescription";
            this._tsellDescription.Size = new System.Drawing.Size(386, 56);
            this._tsellDescription.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 50;
            this.label7.Text = "Description   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Date              :";
            // 
            // _dtTransDate
            // 
            this._dtTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtTransDate.Location = new System.Drawing.Point(177, 98);
            this._dtTransDate.Name = "_dtTransDate";
            this._dtTransDate.Size = new System.Drawing.Size(386, 35);
            this._dtTransDate.TabIndex = 48;
            // 
            // _tsellKurs
            // 
            this._tsellKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tsellKurs.Location = new System.Drawing.Point(180, 139);
            this._tsellKurs.Name = "_tsellKurs";
            this._tsellKurs.Size = new System.Drawing.Size(386, 35);
            this._tsellKurs.TabIndex = 47;
            this._tsellKurs.Text = "0";
            this._tsellKurs.TextChanged += new System.EventHandler(this._tsellKurs_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 29);
            this.label8.TabIndex = 46;
            this.label8.Text = "Kurs Rupiah :";
            // 
            // _bsellDelete
            // 
            this._bsellDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bsellDelete.Location = new System.Drawing.Point(601, 522);
            this._bsellDelete.Name = "_bsellDelete";
            this._bsellDelete.Size = new System.Drawing.Size(162, 35);
            this._bsellDelete.TabIndex = 52;
            this._bsellDelete.Text = "DELETE";
            this._bsellDelete.UseVisualStyleBackColor = true;
            this._bsellDelete.Click += new System.EventHandler(this._bsellDelete_Click);
            // 
            // _sellingTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 608);
            this.Controls.Add(this._bsellDelete);
            this.Controls.Add(this._tsellDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dtTransDate);
            this.Controls.Add(this._tsellKurs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._lsellDollar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._lsellRp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbsellNama);
            this.Controls.Add(this._dataCusTransaction);
            this.Controls.Add(this._bsellPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_sellingTrans";
            this.Text = "CV. WARNA MURNI - SELLING";
            this.Load += new System.EventHandler(this._sellingTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataCusTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lsellDollar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lsellRp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbsellNama;
        private System.Windows.Forms.DataGridView _dataCusTransaction;
        private System.Windows.Forms.Button _bsellPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tsellDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _dtTransDate;
        private System.Windows.Forms.TextBox _tsellKurs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_Dollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_Rupiah;
        private System.Windows.Forms.Button _bsellDelete;
    }
}