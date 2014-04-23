namespace StockApps
{
    partial class supplierReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this._bsellView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._lbsellNama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._radioLocal = new System.Windows.Forms.RadioButton();
            this._radioImport = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(18, 201);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(846, 460);
            this.crystalReportViewer1.TabIndex = 61;
            // 
            // _bsellView
            // 
            this._bsellView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bsellView.Location = new System.Drawing.Point(18, 126);
            this._bsellView.Name = "_bsellView";
            this._bsellView.Size = new System.Drawing.Size(500, 35);
            this._bsellView.TabIndex = 60;
            this._bsellView.Text = "VIEW REPORT";
            this._bsellView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = ":";
            // 
            // _lbsellNama
            // 
            this._lbsellNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbsellNama.FormattingEnabled = true;
            this._lbsellNama.Location = new System.Drawing.Point(129, 55);
            this._lbsellNama.Name = "_lbsellNama";
            this._lbsellNama.Size = new System.Drawing.Size(389, 37);
            this._lbsellNama.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 31);
            this.label5.TabIndex = 62;
            this.label5.Text = "Supplier Report";
            // 
            // _radioLocal
            // 
            this._radioLocal.AutoSize = true;
            this._radioLocal.Checked = true;
            this._radioLocal.Location = new System.Drawing.Point(17, 27);
            this._radioLocal.Name = "_radioLocal";
            this._radioLocal.Size = new System.Drawing.Size(73, 28);
            this._radioLocal.TabIndex = 4;
            this._radioLocal.TabStop = true;
            this._radioLocal.Text = "Local";
            this._radioLocal.UseVisualStyleBackColor = true;
            // 
            // _radioImport
            // 
            this._radioImport.AutoSize = true;
            this._radioImport.Location = new System.Drawing.Point(17, 53);
            this._radioImport.Name = "_radioImport";
            this._radioImport.Size = new System.Drawing.Size(80, 28);
            this._radioImport.TabIndex = 5;
            this._radioImport.Text = "Import";
            this._radioImport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this._radioLocal);
            this.groupBox1.Controls.Add(this._radioImport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(530, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 106);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Report";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 28);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Local / Import";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(129, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 67;
            this.checkBox1.Text = "View All";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // supplierReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 673);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this._bsellView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lbsellNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "supplierReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "supplierReport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button _bsellView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _lbsellNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton _radioLocal;
        private System.Windows.Forms.RadioButton _radioImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}