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
            this._dataDetailSupplier = new System.Windows.Forms.DataGridView();
            this._cbproSCategory = new System.Windows.Forms.ComboBox();
            this._cbProSValue2 = new System.Windows.Forms.ComboBox();
            this._cbproSTypePrice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._txtProSName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._tproSPrice = new System.Windows.Forms.TextBox();
            this._cbProSValue = new System.Windows.Forms.ComboBox();
            this._cbProSSup = new System.Windows.Forms.ComboBox();
            this._tproSStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tproSStock)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataDetailSupplier
            // 
            this._dataDetailSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataDetailSupplier.Location = new System.Drawing.Point(18, 290);
            this._dataDetailSupplier.Name = "_dataDetailSupplier";
            this._dataDetailSupplier.Size = new System.Drawing.Size(707, 394);
            this._dataDetailSupplier.TabIndex = 35;
            // 
            // _cbproSCategory
            // 
            this._cbproSCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbproSCategory.FormattingEnabled = true;
            this._cbproSCategory.Location = new System.Drawing.Point(141, 229);
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
            this._cbProSValue2.Location = new System.Drawing.Point(141, 188);
            this._cbProSValue2.Name = "_cbProSValue2";
            this._cbProSValue2.Size = new System.Drawing.Size(122, 37);
            this._cbProSValue2.TabIndex = 30;
            this._cbProSValue2.SelectedIndexChanged += new System.EventHandler(this._cbProSValue2_SelectedIndexChanged);
            // 
            // _cbproSTypePrice
            // 
            this._cbproSTypePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbproSTypePrice.FormattingEnabled = true;
            this._cbproSTypePrice.Items.AddRange(new object[] {
            "Rupiah",
            "Dollar"});
            this._cbproSTypePrice.Location = new System.Drawing.Point(395, 147);
            this._cbproSTypePrice.Name = "_cbproSTypePrice";
            this._cbproSTypePrice.Size = new System.Drawing.Size(159, 37);
            this._cbproSTypePrice.TabIndex = 28;
            this._cbproSTypePrice.SelectedIndexChanged += new System.EventHandler(this._cbproSTypePrice_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Stock :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 71);
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
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stock Product";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 703);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 35);
            this.button1.TabIndex = 39;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(560, 703);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 35);
            this.button2.TabIndex = 40;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // _txtProSName
            // 
            this._txtProSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtProSName.Location = new System.Drawing.Point(141, 106);
            this._txtProSName.Name = "_txtProSName";
            this._txtProSName.Size = new System.Drawing.Size(413, 35);
            this._txtProSName.TabIndex = 41;
            this._txtProSName.TextChanged += new System.EventHandler(this._txtProSName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Kg";
            // 
            // _tproSPrice
            // 
            this._tproSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tproSPrice.Location = new System.Drawing.Point(269, 147);
            this._tproSPrice.Name = "_tproSPrice";
            this._tproSPrice.Size = new System.Drawing.Size(120, 35);
            this._tproSPrice.TabIndex = 27;
            this._tproSPrice.TextChanged += new System.EventHandler(this._tproSPrice_TextChanged);
            // 
            // _cbProSValue
            // 
            this._cbProSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbProSValue.FormattingEnabled = true;
            this._cbProSValue.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this._cbProSValue.Location = new System.Drawing.Point(141, 147);
            this._cbProSValue.Name = "_cbProSValue";
            this._cbProSValue.Size = new System.Drawing.Size(122, 37);
            this._cbProSValue.TabIndex = 44;
            this._cbProSValue.SelectedIndexChanged += new System.EventHandler(this._cbProSValue_SelectedIndexChanged);
            // 
            // _cbProSSup
            // 
            this._cbProSSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbProSSup.FormattingEnabled = true;
            this._cbProSSup.Location = new System.Drawing.Point(141, 63);
            this._cbProSSup.Name = "_cbProSSup";
            this._cbProSSup.Size = new System.Drawing.Size(413, 37);
            this._cbProSSup.TabIndex = 45;
            this._cbProSSup.SelectedIndexChanged += new System.EventHandler(this._cbProSSup_SelectedIndexChanged);
            // 
            // _tproSStock
            // 
            this._tproSStock.Location = new System.Drawing.Point(269, 200);
            this._tproSStock.Name = "_tproSStock";
            this._tproSStock.Size = new System.Drawing.Size(120, 20);
            this._tproSStock.TabIndex = 46;
            this._tproSStock.ValueChanged += new System.EventHandler(this._tproSStock_ValueChanged);
            // 
            // _StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 750);
            this.Controls.Add(this._tproSStock);
            this.Controls.Add(this._cbProSSup);
            this.Controls.Add(this._cbProSValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtProSName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Text = "_StockList";
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tproSStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataDetailSupplier;
        private System.Windows.Forms.ComboBox _cbproSCategory;
        private System.Windows.Forms.ComboBox _cbProSValue2;
        private System.Windows.Forms.ComboBox _cbproSTypePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox _txtProSName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _tproSPrice;
        private System.Windows.Forms.ComboBox _cbProSValue;
        private System.Windows.Forms.ComboBox _cbProSSup;
        private System.Windows.Forms.NumericUpDown _tproSStock;

    }
}