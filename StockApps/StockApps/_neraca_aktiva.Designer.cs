namespace StockApps
{
    partial class _neraca_aktiva
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._dateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._btnAddProduk = new System.Windows.Forms.Button();
            this._btnAddKas = new System.Windows.Forms.Button();
            this._btnAddPiutang = new System.Windows.Forms.Button();
            this._btnAddInvetaris = new System.Windows.Forms.Button();
            this._bbSReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 31);
            this.label5.TabIndex = 42;
            this.label5.Text = "Neraca_Aktiva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Produk :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tahun Berakhir :";
            // 
            // _dateTime
            // 
            this._dateTime.CustomFormat = "dd-MMM-yyyy";
            this._dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dateTime.Location = new System.Drawing.Point(196, 53);
            this._dateTime.Name = "_dateTime";
            this._dateTime.Size = new System.Drawing.Size(229, 31);
            this._dateTime.TabIndex = 1;
            this._dateTime.Value = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Kas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Piutang :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Inventaris :";
            // 
            // _btnAddProduk
            // 
            this._btnAddProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddProduk.Location = new System.Drawing.Point(196, 98);
            this._btnAddProduk.Name = "_btnAddProduk";
            this._btnAddProduk.Size = new System.Drawing.Size(229, 37);
            this._btnAddProduk.TabIndex = 2;
            this._btnAddProduk.Text = "ADD";
            this._btnAddProduk.UseVisualStyleBackColor = true;
            this._btnAddProduk.Click += new System.EventHandler(this._btnAddProduk_Click);
            // 
            // _btnAddKas
            // 
            this._btnAddKas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddKas.Location = new System.Drawing.Point(196, 140);
            this._btnAddKas.Name = "_btnAddKas";
            this._btnAddKas.Size = new System.Drawing.Size(229, 37);
            this._btnAddKas.TabIndex = 3;
            this._btnAddKas.Text = "ADD";
            this._btnAddKas.UseVisualStyleBackColor = true;
            this._btnAddKas.Click += new System.EventHandler(this._btnAddKas_Click);
            // 
            // _btnAddPiutang
            // 
            this._btnAddPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddPiutang.Location = new System.Drawing.Point(196, 183);
            this._btnAddPiutang.Name = "_btnAddPiutang";
            this._btnAddPiutang.Size = new System.Drawing.Size(229, 37);
            this._btnAddPiutang.TabIndex = 4;
            this._btnAddPiutang.Text = "ADD";
            this._btnAddPiutang.UseVisualStyleBackColor = true;
            this._btnAddPiutang.Click += new System.EventHandler(this._btnAddPiutang_Click);
            // 
            // _btnAddInvetaris
            // 
            this._btnAddInvetaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddInvetaris.Location = new System.Drawing.Point(196, 226);
            this._btnAddInvetaris.Name = "_btnAddInvetaris";
            this._btnAddInvetaris.Size = new System.Drawing.Size(229, 37);
            this._btnAddInvetaris.TabIndex = 5;
            this._btnAddInvetaris.Text = "ADD";
            this._btnAddInvetaris.UseVisualStyleBackColor = true;
            this._btnAddInvetaris.Click += new System.EventHandler(this._btnAddInvetaris_Click);
            // 
            // _bbSReport
            // 
            this._bbSReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbSReport.Location = new System.Drawing.Point(18, 269);
            this._bbSReport.Name = "_bbSReport";
            this._bbSReport.Size = new System.Drawing.Size(407, 35);
            this._bbSReport.TabIndex = 6;
            this._bbSReport.Text = "SHOW REPORT";
            this._bbSReport.UseVisualStyleBackColor = true;
            this._bbSReport.Click += new System.EventHandler(this._bbSReport_Click);
            // 
            // _neraca_aktiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 314);
            this.Controls.Add(this._bbSReport);
            this.Controls.Add(this._btnAddInvetaris);
            this.Controls.Add(this._btnAddPiutang);
            this.Controls.Add(this._btnAddKas);
            this.Controls.Add(this._btnAddProduk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._dateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_neraca_aktiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - Neraca_aktiva";
            this.Load += new System.EventHandler(this._neraca_aktiva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker _dateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _btnAddProduk;
        private System.Windows.Forms.Button _btnAddKas;
        private System.Windows.Forms.Button _btnAddPiutang;
        private System.Windows.Forms.Button _btnAddInvetaris;
        private System.Windows.Forms.Button _bbSReport;
    }
}