namespace StockApps
{
    partial class _neraca_aktiva_aProduk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._bbInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._bbDelete = new System.Windows.Forms.Button();
            this._dataAktivaProduk = new System.Windows.Forms.DataGridView();
            this._idAktiva = new System.Windows.Forms.TextBox();
            this._txtnama = new System.Windows.Forms.TextBox();
            this._txtbg = new System.Windows.Forms.TextBox();
            this._txtjumlah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataAktivaProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 64;
            this.label6.Text = "Jumlah :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "BG :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nama :";
            // 
            // _bbInsert
            // 
            this._bbInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbInsert.Location = new System.Drawing.Point(526, 275);
            this._bbInsert.Name = "_bbInsert";
            this._bbInsert.Size = new System.Drawing.Size(133, 35);
            this._bbInsert.TabIndex = 53;
            this._bbInsert.Text = "INSERT";
            this._bbInsert.UseVisualStyleBackColor = true;
            this._bbInsert.Click += new System.EventHandler(this._bbInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 31);
            this.label5.TabIndex = 57;
            this.label5.Text = "Aktiva_Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "No. :";
            // 
            // _bbDelete
            // 
            this._bbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbDelete.Location = new System.Drawing.Point(387, 275);
            this._bbDelete.Name = "_bbDelete";
            this._bbDelete.Size = new System.Drawing.Size(133, 35);
            this._bbDelete.TabIndex = 66;
            this._bbDelete.Text = "DELETE";
            this._bbDelete.UseVisualStyleBackColor = true;
            this._bbDelete.Click += new System.EventHandler(this._bbDelete_Click);
            // 
            // _dataAktivaProduk
            // 
            this._dataAktivaProduk.AllowUserToAddRows = false;
            this._dataAktivaProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataAktivaProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dataAktivaProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataAktivaProduk.DefaultCellStyle = dataGridViewCellStyle4;
            this._dataAktivaProduk.Location = new System.Drawing.Point(17, 316);
            this._dataAktivaProduk.MultiSelect = false;
            this._dataAktivaProduk.Name = "_dataAktivaProduk";
            this._dataAktivaProduk.Size = new System.Drawing.Size(642, 201);
            this._dataAktivaProduk.TabIndex = 65;
            // 
            // _idAktiva
            // 
            this._idAktiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._idAktiva.Location = new System.Drawing.Point(140, 111);
            this._idAktiva.Name = "_idAktiva";
            this._idAktiva.Size = new System.Drawing.Size(519, 35);
            this._idAktiva.TabIndex = 67;
            // 
            // _txtnama
            // 
            this._txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtnama.Location = new System.Drawing.Point(140, 148);
            this._txtnama.Name = "_txtnama";
            this._txtnama.Size = new System.Drawing.Size(519, 35);
            this._txtnama.TabIndex = 68;
            // 
            // _txtbg
            // 
            this._txtbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtbg.Location = new System.Drawing.Point(140, 186);
            this._txtbg.Name = "_txtbg";
            this._txtbg.Size = new System.Drawing.Size(519, 35);
            this._txtbg.TabIndex = 69;
            // 
            // _txtjumlah
            // 
            this._txtjumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtjumlah.Location = new System.Drawing.Point(140, 220);
            this._txtjumlah.Name = "_txtjumlah";
            this._txtjumlah.Size = new System.Drawing.Size(519, 35);
            this._txtjumlah.TabIndex = 70;
            this._txtjumlah.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 71;
            this.label1.Text = "Date :";
            // 
            // _txtYear
            // 
            this._txtYear.Enabled = false;
            this._txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtYear.Location = new System.Drawing.Point(140, 73);
            this._txtYear.Name = "_txtYear";
            this._txtYear.Size = new System.Drawing.Size(519, 35);
            this._txtYear.TabIndex = 72;
            // 
            // _neraca_aktiva_aProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 570);
            this.Controls.Add(this._txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtjumlah);
            this.Controls.Add(this._txtbg);
            this.Controls.Add(this._txtnama);
            this.Controls.Add(this._idAktiva);
            this.Controls.Add(this._bbDelete);
            this.Controls.Add(this._dataAktivaProduk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._bbInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "_neraca_aktiva_aProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - Neraca_aktiva_produk";
            this.Load += new System.EventHandler(this._neraca_aktiva_aProduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataAktivaProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _bbInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _bbDelete;
        private System.Windows.Forms.DataGridView _dataAktivaProduk;
        private System.Windows.Forms.TextBox _idAktiva;
        private System.Windows.Forms.TextBox _txtnama;
        private System.Windows.Forms.TextBox _txtbg;
        private System.Windows.Forms.TextBox _txtjumlah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtYear;
    }
}