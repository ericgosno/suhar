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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tproSStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataDetailSupplier
            // 
            this._dataDetailSupplier.AllowUserToAddRows = false;
            this._dataDetailSupplier.AllowUserToDeleteRows = false;
            this._dataDetailSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataDetailSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataDetailSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this._dataDetailSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataDetailSupplier.DefaultCellStyle = dataGridViewCellStyle10;
            this._dataDetailSupplier.Location = new System.Drawing.Point(16, 339);
            this._dataDetailSupplier.Name = "_dataDetailSupplier";
            this._dataDetailSupplier.Size = new System.Drawing.Size(707, 294);
            this._dataDetailSupplier.TabIndex = 35;
            // 
            // _cbproSCategory
            // 
            this._cbproSCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbproSCategory.FormattingEnabled = true;
            this._cbproSCategory.Location = new System.Drawing.Point(128, 187);
            this._cbproSCategory.Name = "_cbproSCategory";
            this._cbproSCategory.Size = new System.Drawing.Size(467, 37);
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
            this._cbProSValue2.Location = new System.Drawing.Point(128, 146);
            this._cbProSValue2.Name = "_cbProSValue2";
            this._cbProSValue2.Size = new System.Drawing.Size(122, 37);
            this._cbProSValue2.TabIndex = 30;
            this._cbProSValue2.SelectedIndexChanged += new System.EventHandler(this._cbProSValue2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Stock :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
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
            this._bProSUpdate.Location = new System.Drawing.Point(187, 289);
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
            this._bProSDelete.Location = new System.Drawing.Point(358, 289);
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
            this._txtProSName.Location = new System.Drawing.Point(128, 64);
            this._txtProSName.Name = "_txtProSName";
            this._txtProSName.Size = new System.Drawing.Size(467, 35);
            this._txtProSName.TabIndex = 41;
            this._txtProSName.TextChanged += new System.EventHandler(this._txtProSName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Kg";
            // 
            // _cbProSSup
            // 
            this._cbProSSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbProSSup.FormattingEnabled = true;
            this._cbProSSup.Location = new System.Drawing.Point(128, 21);
            this._cbProSSup.Name = "_cbProSSup";
            this._cbProSSup.Size = new System.Drawing.Size(467, 37);
            this._cbProSSup.TabIndex = 45;
            this._cbProSSup.SelectedIndexChanged += new System.EventHandler(this._cbProSSup_SelectedIndexChanged);
            // 
            // _tproSStock
            // 
            this._tproSStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tproSStock.Location = new System.Drawing.Point(256, 146);
            this._tproSStock.Name = "_tproSStock";
            this._tproSStock.Size = new System.Drawing.Size(120, 35);
            this._tproSStock.TabIndex = 46;
            this._tproSStock.ValueChanged += new System.EventHandler(this._tproSStock_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Price :";
            // 
            // _tproSPrice
            // 
            this._tproSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tproSPrice.Location = new System.Drawing.Point(310, 105);
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
            this._cbproSTypePrice.Location = new System.Drawing.Point(436, 105);
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
            this._cbProSValue.Location = new System.Drawing.Point(128, 105);
            this._cbProSValue.Name = "_cbProSValue";
            this._cbProSValue.Size = new System.Drawing.Size(176, 37);
            this._cbProSValue.TabIndex = 44;
            this._cbProSValue.SelectedIndexChanged += new System.EventHandler(this._cbProSValue_SelectedIndexChanged);
            // 
            // _bProSInsert
            // 
            this._bProSInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bProSInsert.Location = new System.Drawing.Point(16, 289);
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
            this._bProSPriceHistory.Location = new System.Drawing.Point(496, 639);
            this._bProSPriceHistory.Name = "_bProSPriceHistory";
            this._bProSPriceHistory.Size = new System.Drawing.Size(223, 35);
            this._bProSPriceHistory.TabIndex = 48;
            this._bProSPriceHistory.Text = "PRICE HISTORY";
            this._bProSPriceHistory.UseVisualStyleBackColor = true;
            this._bProSPriceHistory.Click += new System.EventHandler(this._bProSPriceHistory_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(640, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 291);
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(631, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 99);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._cbproSCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._tproSPrice);
            this.groupBox1.Controls.Add(this._tproSStock);
            this.groupBox1.Controls.Add(this._cbproSTypePrice);
            this.groupBox1.Controls.Add(this._cbProSSup);
            this.groupBox1.Controls.Add(this._cbProSValue2);
            this.groupBox1.Controls.Add(this._cbProSValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._txtProSName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 230);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // _StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dataDetailSupplier);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._bProSPriceHistory);
            this.Controls.Add(this._bProSInsert);
            this.Controls.Add(this._bProSDelete);
            this.Controls.Add(this._bProSUpdate);
            this.Controls.Add(this.label5);
            this.Name = "_StockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.Load += new System.EventHandler(this._StockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tproSStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}