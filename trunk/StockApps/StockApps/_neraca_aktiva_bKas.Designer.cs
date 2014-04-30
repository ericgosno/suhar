namespace StockApps
{
    partial class _neraca_aktiva_bKas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._txtrupiah = new System.Windows.Forms.TextBox();
            this._txtdollar = new System.Windows.Forms.TextBox();
            this._txtnama = new System.Windows.Forms.TextBox();
            this._idAktivakas = new System.Windows.Forms.TextBox();
            this._bbDelete = new System.Windows.Forms.Button();
            this._dataAktivaKas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._bbInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataAktivaKas)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtrupiah
            // 
            this._txtrupiah.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtrupiah.Location = new System.Drawing.Point(120, 220);
            this._txtrupiah.Name = "_txtrupiah";
            this._txtrupiah.Size = new System.Drawing.Size(519, 35);
            this._txtrupiah.TabIndex = 83;
            this._txtrupiah.Text = "0";
            // 
            // _txtdollar
            // 
            this._txtdollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtdollar.Location = new System.Drawing.Point(120, 186);
            this._txtdollar.Name = "_txtdollar";
            this._txtdollar.Size = new System.Drawing.Size(519, 35);
            this._txtdollar.TabIndex = 82;
            this._txtdollar.Text = "0";
            // 
            // _txtnama
            // 
            this._txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtnama.Location = new System.Drawing.Point(120, 148);
            this._txtnama.Name = "_txtnama";
            this._txtnama.Size = new System.Drawing.Size(519, 35);
            this._txtnama.TabIndex = 81;
            // 
            // _idAktivakas
            // 
            this._idAktivakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._idAktivakas.Location = new System.Drawing.Point(120, 111);
            this._idAktivakas.Name = "_idAktivakas";
            this._idAktivakas.Size = new System.Drawing.Size(519, 35);
            this._idAktivakas.TabIndex = 80;
            // 
            // _bbDelete
            // 
            this._bbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbDelete.Location = new System.Drawing.Point(367, 272);
            this._bbDelete.Name = "_bbDelete";
            this._bbDelete.Size = new System.Drawing.Size(133, 35);
            this._bbDelete.TabIndex = 79;
            this._bbDelete.Text = "DELETE";
            this._bbDelete.UseVisualStyleBackColor = true;
            this._bbDelete.Click += new System.EventHandler(this._bbDelete_Click);
            // 
            // _dataAktivaKas
            // 
            this._dataAktivaKas.AllowUserToAddRows = false;
            this._dataAktivaKas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataAktivaKas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataAktivaKas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataAktivaKas.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataAktivaKas.Location = new System.Drawing.Point(12, 313);
            this._dataAktivaKas.MultiSelect = false;
            this._dataAktivaKas.Name = "_dataAktivaKas";
            this._dataAktivaKas.Size = new System.Drawing.Size(627, 201);
            this._dataAktivaKas.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 77;
            this.label6.Text = "Rupiah :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 76;
            this.label4.Text = "Dollar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nama :";
            // 
            // _bbInsert
            // 
            this._bbInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbInsert.Location = new System.Drawing.Point(506, 272);
            this._bbInsert.Name = "_bbInsert";
            this._bbInsert.Size = new System.Drawing.Size(133, 35);
            this._bbInsert.TabIndex = 71;
            this._bbInsert.Text = "INSERT";
            this._bbInsert.UseVisualStyleBackColor = true;
            this._bbInsert.Click += new System.EventHandler(this._bbInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 74;
            this.label5.Text = "Aktiva_Kas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 73;
            this.label2.Text = "No. :";
            // 
            // _txtYear
            // 
            this._txtYear.Enabled = false;
            this._txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtYear.Location = new System.Drawing.Point(120, 70);
            this._txtYear.Name = "_txtYear";
            this._txtYear.Size = new System.Drawing.Size(519, 35);
            this._txtYear.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "Date :";
            // 
            // _neraca_aktiva_bKas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 542);
            this.Controls.Add(this._txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtrupiah);
            this.Controls.Add(this._txtdollar);
            this.Controls.Add(this._txtnama);
            this.Controls.Add(this._idAktivakas);
            this.Controls.Add(this._bbDelete);
            this.Controls.Add(this._dataAktivaKas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._bbInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "_neraca_aktiva_bKas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_neraca_aktiva_bKas";
            this.Load += new System.EventHandler(this._neraca_aktiva_bKas_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataAktivaKas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtrupiah;
        private System.Windows.Forms.TextBox _txtdollar;
        private System.Windows.Forms.TextBox _txtnama;
        private System.Windows.Forms.TextBox _idAktivakas;
        private System.Windows.Forms.Button _bbDelete;
        private System.Windows.Forms.DataGridView _dataAktivaKas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _bbInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtYear;
        private System.Windows.Forms.Label label1;
    }
}