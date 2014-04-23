namespace StockApps
{
    partial class _bankList
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
            this._bbankDelete = new System.Windows.Forms.Button();
            this._bbankInsert = new System.Windows.Forms.Button();
            this._dataBank = new System.Windows.Forms.DataGridView();
            this._tbankName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cbankCurrency = new System.Windows.Forms.ComboBox();
            this._bbankReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataBank)).BeginInit();
            this.SuspendLayout();
            // 
            // _bbankDelete
            // 
            this._bbankDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbankDelete.Location = new System.Drawing.Point(483, 413);
            this._bbankDelete.Name = "_bbankDelete";
            this._bbankDelete.Size = new System.Drawing.Size(115, 35);
            this._bbankDelete.TabIndex = 35;
            this._bbankDelete.Text = "DELETE";
            this._bbankDelete.UseVisualStyleBackColor = true;
            this._bbankDelete.Click += new System.EventHandler(this._bbankDelete_Click);
            // 
            // _bbankInsert
            // 
            this._bbankInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbankInsert.Location = new System.Drawing.Point(465, 142);
            this._bbankInsert.Name = "_bbankInsert";
            this._bbankInsert.Size = new System.Drawing.Size(133, 35);
            this._bbankInsert.TabIndex = 3;
            this._bbankInsert.Text = "INSERT";
            this._bbankInsert.UseVisualStyleBackColor = true;
            this._bbankInsert.Click += new System.EventHandler(this._bbankInsert_Click);
            // 
            // _dataBank
            // 
            this._dataBank.AllowUserToAddRows = false;
            this._dataBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataBank.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataBank.Location = new System.Drawing.Point(20, 183);
            this._dataBank.MultiSelect = false;
            this._dataBank.Name = "_dataBank";
            this._dataBank.Size = new System.Drawing.Size(578, 224);
            this._dataBank.TabIndex = 34;
            this._dataBank.SelectionChanged += new System.EventHandler(this._dataBank_SelectionChanged);
            // 
            // _tbankName
            // 
            this._tbankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbankName.Location = new System.Drawing.Point(135, 52);
            this._tbankName.Name = "_tbankName";
            this._tbankName.Size = new System.Drawing.Size(463, 35);
            this._tbankName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Currency :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name :";
            // 
            // _cbankCurrency
            // 
            this._cbankCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbankCurrency.FormattingEnabled = true;
            this._cbankCurrency.Location = new System.Drawing.Point(135, 93);
            this._cbankCurrency.Name = "_cbankCurrency";
            this._cbankCurrency.Size = new System.Drawing.Size(463, 37);
            this._cbankCurrency.TabIndex = 2;
            // 
            // _bbankReset
            // 
            this._bbankReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bbankReset.Location = new System.Drawing.Point(331, 142);
            this._bbankReset.Name = "_bbankReset";
            this._bbankReset.Size = new System.Drawing.Size(128, 35);
            this._bbankReset.TabIndex = 4;
            this._bbankReset.Text = "RESET";
            this._bbankReset.UseVisualStyleBackColor = true;
            this._bbankReset.Click += new System.EventHandler(this._bbankReset_Click);
            // 
            // _bankList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 464);
            this.Controls.Add(this._bbankReset);
            this.Controls.Add(this._cbankCurrency);
            this.Controls.Add(this._bbankDelete);
            this.Controls.Add(this._bbankInsert);
            this.Controls.Add(this._dataBank);
            this.Controls.Add(this._tbankName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_bankList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - Bank";
            this.Load += new System.EventHandler(this._bankList_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bbankDelete;
        private System.Windows.Forms.Button _bbankInsert;
        private System.Windows.Forms.DataGridView _dataBank;
        private System.Windows.Forms.TextBox _tbankName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbankCurrency;
        private System.Windows.Forms.Button _bbankReset;
    }
}