namespace StockApps
{
    partial class sellingReport
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
            this.label4 = new System.Windows.Forms.Label();
            this._dtTransDate = new System.Windows.Forms.DateTimePicker();
            this._lbsellNama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._bsellView = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this._radioSJ = new System.Windows.Forms.RadioButton();
            this._radioFPenjualan = new System.Windows.Forms.RadioButton();
            this._radioFPajak = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "Date";
            // 
            // _dtTransDate
            // 
            this._dtTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtTransDate.Location = new System.Drawing.Point(129, 93);
            this._dtTransDate.Name = "_dtTransDate";
            this._dtTransDate.Size = new System.Drawing.Size(389, 35);
            this._dtTransDate.TabIndex = 2;
            // 
            // _lbsellNama
            // 
            this._lbsellNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbsellNama.FormattingEnabled = true;
            this._lbsellNama.Location = new System.Drawing.Point(129, 55);
            this._lbsellNama.Name = "_lbsellNama";
            this._lbsellNama.Size = new System.Drawing.Size(389, 37);
            this._lbsellNama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 50;
            this.label5.Text = "Selling Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = ":";
            // 
            // _bsellView
            // 
            this._bsellView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bsellView.Location = new System.Drawing.Point(18, 146);
            this._bsellView.Name = "_bsellView";
            this._bsellView.Size = new System.Drawing.Size(500, 35);
            this._bsellView.TabIndex = 7;
            this._bsellView.Text = "VIEW REPORT";
            this._bsellView.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(18, 202);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(846, 460);
            this.crystalReportViewer1.TabIndex = 8;
            // 
            // _radioSJ
            // 
            this._radioSJ.AutoSize = true;
            this._radioSJ.Checked = true;
            this._radioSJ.Location = new System.Drawing.Point(17, 27);
            this._radioSJ.Name = "_radioSJ";
            this._radioSJ.Size = new System.Drawing.Size(120, 28);
            this._radioSJ.TabIndex = 4;
            this._radioSJ.TabStop = true;
            this._radioSJ.Text = "Surat Jalan";
            this._radioSJ.UseVisualStyleBackColor = true;
            // 
            // _radioFPenjualan
            // 
            this._radioFPenjualan.AutoSize = true;
            this._radioFPenjualan.Location = new System.Drawing.Point(17, 53);
            this._radioFPenjualan.Name = "_radioFPenjualan";
            this._radioFPenjualan.Size = new System.Drawing.Size(169, 28);
            this._radioFPenjualan.TabIndex = 5;
            this._radioFPenjualan.Text = "Faktur Penjualan";
            this._radioFPenjualan.UseVisualStyleBackColor = true;
            // 
            // _radioFPajak
            // 
            this._radioFPajak.AutoSize = true;
            this._radioFPajak.Location = new System.Drawing.Point(17, 80);
            this._radioFPajak.Name = "_radioFPajak";
            this._radioFPajak.Size = new System.Drawing.Size(130, 28);
            this._radioFPajak.TabIndex = 6;
            this._radioFPajak.Text = "Faktur Pajak";
            this._radioFPajak.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._radioSJ);
            this.groupBox1.Controls.Add(this._radioFPajak);
            this.groupBox1.Controls.Add(this._radioFPenjualan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(530, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Report";
            // 
            // sellingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this._bsellView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dtTransDate);
            this.Controls.Add(this._lbsellNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "sellingReport";
            this.Text = "sellingReport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _dtTransDate;
        private System.Windows.Forms.ComboBox _lbsellNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _bsellView;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton _radioSJ;
        private System.Windows.Forms.RadioButton _radioFPenjualan;
        private System.Windows.Forms.RadioButton _radioFPajak;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}