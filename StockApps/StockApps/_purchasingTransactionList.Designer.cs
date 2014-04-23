namespace StockApps
{
    partial class _purchasingTransactionList
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
            this._lShowAll = new System.Windows.Forms.CheckBox();
            this._bPurTransPrint = new System.Windows.Forms.Button();
            this._dataPriceHistory = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cbPurTransTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._cbPurTransFrom = new System.Windows.Forms.DateTimePicker();
            this._cbPurTransNama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataPriceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // _lShowAll
            // 
            this._lShowAll.AutoSize = true;
            this._lShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lShowAll.Location = new System.Drawing.Point(155, 53);
            this._lShowAll.Name = "_lShowAll";
            this._lShowAll.Size = new System.Drawing.Size(126, 33);
            this._lShowAll.TabIndex = 91;
            this._lShowAll.Text = "Show All";
            this._lShowAll.UseVisualStyleBackColor = true;
            this._lShowAll.CheckedChanged += new System.EventHandler(this._lShowAll_CheckedChanged);
            // 
            // _bPurTransPrint
            // 
            this._bPurTransPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bPurTransPrint.Location = new System.Drawing.Point(12, 446);
            this._bPurTransPrint.Name = "_bPurTransPrint";
            this._bPurTransPrint.Size = new System.Drawing.Size(105, 70);
            this._bPurTransPrint.TabIndex = 89;
            this._bPurTransPrint.Text = "PRINT";
            this._bPurTransPrint.UseVisualStyleBackColor = true;
            this._bPurTransPrint.Click += new System.EventHandler(this._bPurTransPrint_Click);
            // 
            // _dataPriceHistory
            // 
            this._dataPriceHistory.AllowUserToAddRows = false;
            this._dataPriceHistory.AllowUserToDeleteRows = false;
            this._dataPriceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataPriceHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataPriceHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataPriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataPriceHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataPriceHistory.Location = new System.Drawing.Point(12, 210);
            this._dataPriceHistory.MultiSelect = false;
            this._dataPriceHistory.Name = "_dataPriceHistory";
            this._dataPriceHistory.ReadOnly = true;
            this._dataPriceHistory.Size = new System.Drawing.Size(588, 230);
            this._dataPriceHistory.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 87;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 86;
            this.label7.Text = "To";
            // 
            // _cbPurTransTo
            // 
            this._cbPurTransTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbPurTransTo.Location = new System.Drawing.Point(155, 133);
            this._cbPurTransTo.Name = "_cbPurTransTo";
            this._cbPurTransTo.Size = new System.Drawing.Size(445, 35);
            this._cbPurTransTo.TabIndex = 85;
            this._cbPurTransTo.ValueChanged += new System.EventHandler(this._cbPurTransTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 84;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 83;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 82;
            this.label4.Text = "From";
            // 
            // _cbPurTransFrom
            // 
            this._cbPurTransFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbPurTransFrom.Location = new System.Drawing.Point(155, 94);
            this._cbPurTransFrom.Name = "_cbPurTransFrom";
            this._cbPurTransFrom.Size = new System.Drawing.Size(445, 35);
            this._cbPurTransFrom.TabIndex = 79;
            this._cbPurTransFrom.ValueChanged += new System.EventHandler(this._cbPurTransFrom_ValueChanged);
            // 
            // _cbPurTransNama
            // 
            this._cbPurTransNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbPurTransNama.FormattingEnabled = true;
            this._cbPurTransNama.Location = new System.Drawing.Point(287, 51);
            this._cbPurTransNama.Name = "_cbPurTransNama";
            this._cbPurTransNama.Size = new System.Drawing.Size(313, 37);
            this._cbPurTransNama.TabIndex = 78;
            this._cbPurTransNama.SelectedIndexChanged += new System.EventHandler(this._cbPurTransNama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 31);
            this.label5.TabIndex = 80;
            this.label5.Text = "Purchasing Transaction Archive";
            // 
            // _purchasingTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 526);
            this.Controls.Add(this._lShowAll);
            this.Controls.Add(this._bPurTransPrint);
            this.Controls.Add(this._dataPriceHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._cbPurTransTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._cbPurTransFrom);
            this.Controls.Add(this._cbPurTransNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_purchasingTransactionList";
            this.Text = "Purchasing Transaction Archive";
            ((System.ComponentModel.ISupportInitialize)(this._dataPriceHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _lShowAll;
        private System.Windows.Forms.Button _bPurTransPrint;
        private System.Windows.Forms.DataGridView _dataPriceHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _cbPurTransTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _cbPurTransFrom;
        private System.Windows.Forms.ComboBox _cbPurTransNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}