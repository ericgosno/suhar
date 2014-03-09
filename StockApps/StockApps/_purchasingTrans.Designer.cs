namespace StockApps
{
    partial class _purchasingTrans
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
            this._dataSupTransaction = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity_Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_Dollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_Rupiah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bpurPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._cbpurNama = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._lpurRp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lpurDollar = new System.Windows.Forms.Label();
            this._tpurKurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._dtTransDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._tpurDescription = new System.Windows.Forms.TextBox();
            this._bpurDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataSupTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataSupTransaction
            // 
            this._dataSupTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataSupTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity_Kg,
            this.Package_Quantity,
            this.Price_Kg,
            this.Subtotal_Dollar,
            this.Subtotal_Rupiah});
            this._dataSupTransaction.Location = new System.Drawing.Point(18, 230);
            this._dataSupTransaction.Name = "_dataSupTransaction";
            this._dataSupTransaction.Size = new System.Drawing.Size(707, 224);
            this._dataSupTransaction.TabIndex = 22;
            this._dataSupTransaction.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataSupTransaction_CellEndEdit);
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
            // Package_Quantity
            // 
            this.Package_Quantity.HeaderText = "Package Quantity";
            this.Package_Quantity.Name = "Package_Quantity";
            this.Package_Quantity.ReadOnly = true;
            // 
            // Price_Kg
            // 
            this.Price_Kg.HeaderText = "Price Per Kg";
            this.Price_Kg.Name = "Price_Kg";
            this.Price_Kg.ReadOnly = true;
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
            // _bpurPay
            // 
            this._bpurPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bpurPay.Location = new System.Drawing.Point(563, 506);
            this._bpurPay.Name = "_bpurPay";
            this._bpurPay.Size = new System.Drawing.Size(162, 35);
            this._bpurPay.TabIndex = 21;
            this._bpurPay.Text = "PROCESS";
            this._bpurPay.UseVisualStyleBackColor = true;
            this._bpurPay.Click += new System.EventHandler(this._bpurPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Supplier        :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Supplier Transaction";
            // 
            // _cbpurNama
            // 
            this._cbpurNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbpurNama.FormattingEnabled = true;
            this._cbpurNama.Location = new System.Drawing.Point(176, 43);
            this._cbpurNama.Name = "_cbpurNama";
            this._cbpurNama.Size = new System.Drawing.Size(389, 37);
            this._cbpurNama.TabIndex = 28;
            this._cbpurNama.SelectedIndexChanged += new System.EventHandler(this._cbpurNama_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total - $ :";
            // 
            // _lpurRp
            // 
            this._lpurRp.AutoSize = true;
            this._lpurRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurRp.Location = new System.Drawing.Point(151, 506);
            this._lpurRp.Name = "_lpurRp";
            this._lpurRp.Size = new System.Drawing.Size(26, 29);
            this._lpurRp.TabIndex = 32;
            this._lpurRp.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total - Rp :";
            // 
            // _lpurDollar
            // 
            this._lpurDollar.AutoSize = true;
            this._lpurDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lpurDollar.Location = new System.Drawing.Point(151, 474);
            this._lpurDollar.Name = "_lpurDollar";
            this._lpurDollar.Size = new System.Drawing.Size(26, 29);
            this._lpurDollar.TabIndex = 34;
            this._lpurDollar.Text = "0";
            // 
            // _tpurKurs
            // 
            this._tpurKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpurKurs.Location = new System.Drawing.Point(179, 127);
            this._tpurKurs.Name = "_tpurKurs";
            this._tpurKurs.Size = new System.Drawing.Size(386, 35);
            this._tpurKurs.TabIndex = 36;
            this._tpurKurs.Text = "0";
            this._tpurKurs.TextChanged += new System.EventHandler(this._tpurKurs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kurs Rupiah :";
            // 
            // _dtTransDate
            // 
            this._dtTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtTransDate.Location = new System.Drawing.Point(176, 86);
            this._dtTransDate.Name = "_dtTransDate";
            this._dtTransDate.Size = new System.Drawing.Size(386, 35);
            this._dtTransDate.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Date              :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "Description   :";
            // 
            // _tpurDescription
            // 
            this._tpurDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpurDescription.Location = new System.Drawing.Point(179, 168);
            this._tpurDescription.Multiline = true;
            this._tpurDescription.Name = "_tpurDescription";
            this._tpurDescription.Size = new System.Drawing.Size(386, 56);
            this._tpurDescription.TabIndex = 40;
            // 
            // _bpurDelete
            // 
            this._bpurDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bpurDelete.Location = new System.Drawing.Point(563, 465);
            this._bpurDelete.Name = "_bpurDelete";
            this._bpurDelete.Size = new System.Drawing.Size(162, 35);
            this._bpurDelete.TabIndex = 41;
            this._bpurDelete.Text = "DELETE";
            this._bpurDelete.UseVisualStyleBackColor = true;
            this._bpurDelete.Click += new System.EventHandler(this._bpurDelete_Click);
            // 
            // _purchasingTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 553);
            this.Controls.Add(this._bpurDelete);
            this.Controls.Add(this._tpurDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dtTransDate);
            this.Controls.Add(this._tpurKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._lpurDollar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._lpurRp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbpurNama);
            this.Controls.Add(this._dataSupTransaction);
            this.Controls.Add(this._bpurPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_purchasingTrans";
            this.Text = "CV. WARNA MURNI - PURCHASING";
            this.Load += new System.EventHandler(this._purchasingTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataSupTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataSupTransaction;
        private System.Windows.Forms.Button _bpurPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbpurNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lpurRp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lpurDollar;
        private System.Windows.Forms.TextBox _tpurKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker _dtTransDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _tpurDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_Dollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_Rupiah;
        public System.Windows.Forms.Button _bpurDelete;

    }
}