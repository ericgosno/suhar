namespace StockApps
{
    partial class _supplierListPopUp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tspDName = new System.Windows.Forms.Label();
            this._dataDetailSupplier = new System.Windows.Forms.DataGridView();
            this._bspDUpdate = new System.Windows.Forms.Button();
            this._bspDDelete = new System.Windows.Forms.Button();
            this._bspDInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Detail Supplier";
            // 
            // _tspDName
            // 
            this._tspDName.AutoSize = true;
            this._tspDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspDName.Location = new System.Drawing.Point(98, 61);
            this._tspDName.Name = "_tspDName";
            this._tspDName.Size = new System.Drawing.Size(123, 29);
            this._tspDName.TabIndex = 12;
            this._tspDName.Text = "Supplier 1";
            // 
            // _dataDetailSupplier
            // 
            this._dataDetailSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataDetailSupplier.Location = new System.Drawing.Point(18, 105);
            this._dataDetailSupplier.Name = "_dataDetailSupplier";
            this._dataDetailSupplier.Size = new System.Drawing.Size(576, 260);
            this._dataDetailSupplier.TabIndex = 13;
            // 
            // _bspDUpdate
            // 
            this._bspDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspDUpdate.Location = new System.Drawing.Point(354, 381);
            this._bspDUpdate.Name = "_bspDUpdate";
            this._bspDUpdate.Size = new System.Drawing.Size(121, 35);
            this._bspDUpdate.TabIndex = 14;
            this._bspDUpdate.Text = "UPDATE";
            this._bspDUpdate.UseVisualStyleBackColor = true;
            // 
            // _bspDDelete
            // 
            this._bspDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspDDelete.Location = new System.Drawing.Point(481, 381);
            this._bspDDelete.Name = "_bspDDelete";
            this._bspDDelete.Size = new System.Drawing.Size(115, 35);
            this._bspDDelete.TabIndex = 15;
            this._bspDDelete.Text = "DELETE";
            this._bspDDelete.UseVisualStyleBackColor = true;
            // 
            // _bspDInsert
            // 
            this._bspDInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspDInsert.Location = new System.Drawing.Point(227, 381);
            this._bspDInsert.Name = "_bspDInsert";
            this._bspDInsert.Size = new System.Drawing.Size(121, 35);
            this._bspDInsert.TabIndex = 16;
            this._bspDInsert.Text = "INSERT";
            this._bspDInsert.UseVisualStyleBackColor = true;
            this._bspDInsert.Click += new System.EventHandler(this._bspDInsert_Click);
            // 
            // _supplierListPopUp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 432);
            this.Controls.Add(this._bspDInsert);
            this.Controls.Add(this._bspDUpdate);
            this.Controls.Add(this._bspDDelete);
            this.Controls.Add(this._dataDetailSupplier);
            this.Controls.Add(this._tspDName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "_supplierListPopUp1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - DETAIL SUPPLIER";
            ((System.ComponentModel.ISupportInitialize)(this._dataDetailSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _tspDName;
        private System.Windows.Forms.DataGridView _dataDetailSupplier;
        private System.Windows.Forms.Button _bspDUpdate;
        private System.Windows.Forms.Button _bspDDelete;
        private System.Windows.Forms.Button _bspDInsert;
    }
}