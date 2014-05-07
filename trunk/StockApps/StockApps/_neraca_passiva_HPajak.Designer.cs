namespace StockApps
{
    partial class _neraca_passiva_HPajak
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
            this.label5 = new System.Windows.Forms.Label();
            this._txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtjumlah = new System.Windows.Forms.TextBox();
            this._txtket = new System.Windows.Forms.TextBox();
            this._nourut = new System.Windows.Forms.TextBox();
            this._bbDelete = new System.Windows.Forms.Button();
            this._dataPassivaHutangPajak = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._bbInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataPassivaHutangPajak)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 31);
            this.label5.TabIndex = 140;
            this.label5.Text = "Passiva_Hutang_Pajak";
            // 
            // _txtYear
            // 
            this._txtYear.Enabled = false;
            this._txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtYear.Location = new System.Drawing.Point(160, 68);
            this._txtYear.Name = "_txtYear";
            this._txtYear.Size = new System.Drawing.Size(519, 35);
            this._txtYear.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 138;
            this.label1.Text = "Date :";
            // 
            // _txtjumlah
            // 
            this._txtjumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtjumlah.Location = new System.Drawing.Point(160, 187);
            this._txtjumlah.Name = "_txtjumlah";
            this._txtjumlah.Size = new System.Drawing.Size(519, 35);
            this._txtjumlah.TabIndex = 137;
            this._txtjumlah.Text = "0";
            // 
            // _txtket
            // 
            this._txtket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtket.Location = new System.Drawing.Point(160, 146);
            this._txtket.Name = "_txtket";
            this._txtket.Size = new System.Drawing.Size(519, 35);
            this._txtket.TabIndex = 136;
            // 
            // _nourut
            // 
            this._nourut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nourut.Location = new System.Drawing.Point(160, 109);
            this._nourut.Name = "_nourut";
            this._nourut.Size = new System.Drawing.Size(519, 35);
            this._nourut.TabIndex = 134;
            // 
            // _bbDelete
            // 
            this._bbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbDelete.Location = new System.Drawing.Point(407, 234);
            this._bbDelete.Name = "_bbDelete";
            this._bbDelete.Size = new System.Drawing.Size(133, 35);
            this._bbDelete.TabIndex = 133;
            this._bbDelete.Text = "DELETE";
            this._bbDelete.UseVisualStyleBackColor = true;
            this._bbDelete.Click += new System.EventHandler(this._bbDelete_Click);
            // 
            // _dataPassivaHutangPajak
            // 
            this._dataPassivaHutangPajak.AllowUserToAddRows = false;
            this._dataPassivaHutangPajak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataPassivaHutangPajak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataPassivaHutangPajak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataPassivaHutangPajak.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataPassivaHutangPajak.Location = new System.Drawing.Point(12, 281);
            this._dataPassivaHutangPajak.MultiSelect = false;
            this._dataPassivaHutangPajak.Name = "_dataPassivaHutangPajak";
            this._dataPassivaHutangPajak.Size = new System.Drawing.Size(667, 242);
            this._dataPassivaHutangPajak.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 131;
            this.label6.Text = "Jumlah :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 130;
            this.label4.Text = "Keterangan :";
            // 
            // _bbInsert
            // 
            this._bbInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbInsert.Location = new System.Drawing.Point(546, 234);
            this._bbInsert.Name = "_bbInsert";
            this._bbInsert.Size = new System.Drawing.Size(133, 35);
            this._bbInsert.TabIndex = 127;
            this._bbInsert.Text = "INSERT";
            this._bbInsert.UseVisualStyleBackColor = true;
            this._bbInsert.Click += new System.EventHandler(this._bbInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 128;
            this.label2.Text = "No. :";
            // 
            // _neraca_passiva_HPajak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtjumlah);
            this.Controls.Add(this._txtket);
            this.Controls.Add(this._nourut);
            this.Controls.Add(this._bbDelete);
            this.Controls.Add(this._dataPassivaHutangPajak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._bbInsert);
            this.Controls.Add(this.label2);
            this.Name = "_neraca_passiva_HPajak";
            this.Text = "CV. WARNA MURNI - Neraca_passiva_HPajak";
            this.Load += new System.EventHandler(this._neraca_passiva_HPajak_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataPassivaHutangPajak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtjumlah;
        private System.Windows.Forms.TextBox _txtket;
        private System.Windows.Forms.TextBox _nourut;
        private System.Windows.Forms.Button _bbDelete;
        private System.Windows.Forms.DataGridView _dataPassivaHutangPajak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _bbInsert;
        private System.Windows.Forms.Label label2;
    }
}