namespace StockApps
{
    partial class _StockList
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
            this._dataDetailSupplier = new System.Windows.Forms.DataGridView();
            this._cbproSCategory = new System.Windows.Forms.ComboBox();
            this._cbProSValue2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._bProSUpdate = new System.Windows.Forms.Button();
            this._bProSDelete = new System.Windows.Forms.Button();
            this._txtProSName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cbProSSup = new System.Windows.Forms.ComboBox();
            this._tproSStock = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._tproSPrice = new System.Windows.Forms.TextBox();
            this._cbproSTypePrice = new System.Windows.Forms.ComboBox();
            this._cbProSValue = new System.Windows.Forms.ComboBox();
            this._bProSInsert = new System.Windows.Forms.Button();
            this._bProSPriceHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tproSStock)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataDetailSupplier
            // 
            this._dataDetailSupplier.AllowUserToAddRows = false;
            this._dataDetailSupplier.AllowUserToDeleteRows = false;
            this._dataDetailSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataDetailSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataDetailSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataDetailSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataDetailSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataDetailSupplier.Location = new System.Drawing.Point(12, 264);
            this._dataDetailSupplier.Name = "_dataDetailSupplier";
            this._dataDetailSupplier.Size = new System.Drawing.Size(707, 294);
            this._dataDetailSupplier.TabIndex = 35;
            // 
            // _cbproSCategory
            // 
            this._cbproSCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbproSCategory.FormattingEnabled = true;
            this._cbproSCategory.Location = new System.Drawing.Point(129, 212);
            this._cbproSCategory.Name = "_cbproSCategory";
            this._cbproSCategory.Size = new System.Drawing.Size(413, 37);
            this._cbproSCategory.TabIndex = 32;
            this._cbproSCategory.SelectedIndexChanged += new System.EventHandler(this._cbproSCategory_SelectedIndexChanged);
            // 
            // _cbProSValue2
            // 
            this._cbProSValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbProSValue2.FormattingEnabled = true;
            this._cbProSValue2.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this._cbProSValue2.Location = new System.Drawing.Point(129, 171);
            this._cbProSValue2.Name = "_cbProSValue2";
            this._cbProSValue2.Size = new System.Drawing.Size(122, 37);
            this._cbProSValue2.TabIndex = 30;
            this._cbProSValue2.SelectedIndexChanged += new System.EventHandler(this._cbProSValue2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Stock :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Supplier :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Product List";
            // 
            // _bProSUpdate
            // 
            this._bProSUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bProSUpdate.Location = new System.Drawing.Point(554, 606);
            this._bProSUpdate.Name = "_bProSUpdate";
            this._bProSUpdate.Size = new System.Drawing.Size(165, 35);
            this._bProSUpdate.TabIndex = 39;
            this._bProSUpdate.Text = "UPDATE";
            this._bProSUpdate.UseVisualStyleBackColor = true;
            this._bProSUpdate.Click += new System.EventHandler(this._bProSUpdate_Click);
            // 
            // _bProSDelete
            // 
            this._bProSDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bProSDelete.Location = new System.Drawing.Point(554, 647);
            this._bProSDelete.Name = "_bProSDelete";
            this._bProSDelete.Size = new System.Drawing.Size(165, 35);
            this._bProSDelete.TabIndex = 40;
            this._bProSDelete.Text = "DELETE";
            this._bProSDelete.UseVisualStyleBackColor = true;
            this._bProSDelete.Click += new System.EventHandler(this._bProSDelete_Click);
            // 
            // _txtProSName
            // 
            this._txtProSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtProSName.Location = new System.Drawing.Point(129, 89);
            this._txtProSName.Name = "_txtProSName";
            this._txtProSName.Size = new System.Drawing.Size(413, 35);
            this._txtProSName.TabIndex = 41;
            this._txtProSName.TextChanged += new System.EventHandler(this._txtProSName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Kg";
            // 
            // _cbProSSup
            // 
            this._cbProSSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbProSSup.FormattingEnabled = true;
            this._cbProSSup.Location = new System.Drawing.Point(129, 46);
            this._cbProSSup.Name = "_cbProSSup";
            this._cbProSSup.Size = new System.Drawing.Size(413, 37);
            this._cbProSSup.TabIndex = 45;
            this._cbProSSup.SelectedIndexChanged += new System.EventHandler(this._cbProSSup_SelectedIndexChanged);
            // 
            // _tproSStock
            // 
            this._tproSStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tproSStock.Location = new System.Drawing.Point(257, 171);
            this._tproSStock.Name = "_tproSStock";
            this._tproSStock.Size = new System.Drawing.Size(120, 35);
            this._tproSStock.TabIndex = 46;
            this._tproSStock.ValueChanged += new System.EventHandler(this._tproSStock_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Price :";
            // 
            // _tproSPrice
            // 
            this._tproSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tproSPrice.Location = new System.Drawing.Point(257, 130);
            this._tproSPrice.Name = "_tproSPrice";
            this._tproSPrice.Size = new System.Drawing.Size(120, 35);
            this._tproSPrice.TabIndex = 27;
            this._tproSPrice.TextChanged += new System.EventHandler(this._tproSPrice_TextChanged);
            // 
            // _cbproSTypePrice
            // 
            this._cbproSTypePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbproSTypePrice.FormattingEnabled = true;
            this._cbproSTypePrice.Items.AddRange(new object[] {
            "Rupiah",
            "Dollar"});
            this._cbproSTypePrice.Location = new System.Drawing.Point(383, 130);
            this._cbproSTypePrice.Name = "_cbproSTypePrice";
            this._cbproSTypePrice.Size = new System.Drawing.Size(159, 37);
            this._cbproSTypePrice.TabIndex = 28;
            this._cbproSTypePrice.SelectedIndexChanged += new System.EventHandler(this._cbproSTypePrice_SelectedIndexChanged);
            // 
            // _cbProSValue
            // 
            this._cbProSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbProSValue.FormattingEnabled = true;
            this._cbProSValue.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this._cbProSValue.Location = new System.Drawing.Point(129, 130);
            this._cbProSValue.Name = "_cbProSValue";
            this._cbProSValue.Size = new System.Drawing.Size(122, 37);
            this._cbProSValue.TabIndex = 44;
            this._cbProSValue.SelectedIndexChanged += new System.EventHandler(this._cbProSValue_SelectedIndexChanged);
            // 
            // _bProSInsert
            // 
            this._bProSInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bProSInsert.Location = new System.Drawing.Point(554, 564);
            this._bProSInsert.Name = "_bProSInsert";
            this._bProSInsert.Size = new System.Drawing.Size(165, 35);
            this._bProSInsert.TabIndex = 47;
            this._bProSInsert.Text = "INSERT";
            this._bProSInsert.UseVisualStyleBackColor = true;
            this._bProSInsert.Click += new System.EventHandler(this._bProSInsert_Click);
            // 
            // _bProSPriceHistory
            // 
            this._bProSPriceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bProSPriceHistory.Location = new System.Drawing.Point(6, 564);
            this._bProSPriceHistory.Name = "_bProSPriceHistory";
            this._bProSPriceHistory.Size = new System.Drawing.Size(165, 66);
            this._bProSPriceHistory.TabIndex = 48;
            this._bProSPriceHistory.Text = "PRICE HISTORY";
            this._bProSPriceHistory.UseVisualStyleBackColor = true;
            this._bProSPriceHistory.Click += new System.EventHandler(this._bProSPriceHistory_Click);
            // 
            // _StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 685);
            this.Controls.Add(this._bProSPriceHistory);
            this.Controls.Add(this._bProSInsert);
            this.Controls.Add(this._tproSStock);
            this.Controls.Add(this._cbProSSup);
            this.Controls.Add(this._cbProSValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtProSName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._bProSDelete);
            this.Controls.Add(this._bProSUpdate);
            this.Controls.Add(this._dataDetailSupplier);
            this.Controls.Add(this._cbproSCategory);
            this.Controls.Add(this._cbProSValue2);
            this.Controls.Add(this._cbproSTypePrice);
            this.Controls.Add(this._tproSPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_StockList";
            this.Text = "Product List";
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tproSStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataDetailSupplier;
        private System.Windows.Forms.ComboBox _cbproSCategory;
        private System.Windows.Forms.ComboBox _cbProSValue2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _bProSUpdate;
        private System.Windows.Forms.Button _bProSDelete;
        private System.Windows.Forms.TextBox _txtProSName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cbProSSup;
        private System.Windows.Forms.NumericUpDown _tproSStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tproSPrice;
        private System.Windows.Forms.ComboBox _cbproSTypePrice;
        private System.Windows.Forms.ComboBox _cbProSValue;
        private System.Windows.Forms.Button _bProSInsert;
        private System.Windows.Forms.Button _bProSPriceHistory;

    }
}