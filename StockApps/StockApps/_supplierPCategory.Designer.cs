namespace StockApps
{
    partial class _supplierPCategory
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
            this.label5 = new System.Windows.Forms.Label();
            this._tspPCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._bspPCInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._bspPCUpdate = new System.Windows.Forms.Button();
            this._bspPCDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Create Product Category";
            // 
            // _tspPCName
            // 
            this._tspPCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspPCName.Location = new System.Drawing.Point(118, 53);
            this._tspPCName.Name = "_tspPCName";
            this._tspPCName.Size = new System.Drawing.Size(302, 35);
            this._tspPCName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // _bspPCInsert
            // 
            this._bspPCInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspPCInsert.Location = new System.Drawing.Point(426, 53);
            this._bspPCInsert.Name = "_bspPCInsert";
            this._bspPCInsert.Size = new System.Drawing.Size(165, 35);
            this._bspPCInsert.TabIndex = 2;
            this._bspPCInsert.Text = "INSERT";
            this._bspPCInsert.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 202);
            this.dataGridView1.TabIndex = 3;
            // 
            // _bspPCUpdate
            // 
            this._bspPCUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspPCUpdate.Location = new System.Drawing.Point(350, 315);
            this._bspPCUpdate.Name = "_bspPCUpdate";
            this._bspPCUpdate.Size = new System.Drawing.Size(121, 35);
            this._bspPCUpdate.TabIndex = 4;
            this._bspPCUpdate.Text = "UPDATE";
            this._bspPCUpdate.UseVisualStyleBackColor = true;
            // 
            // _bspPCDelete
            // 
            this._bspPCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspPCDelete.Location = new System.Drawing.Point(477, 315);
            this._bspPCDelete.Name = "_bspPCDelete";
            this._bspPCDelete.Size = new System.Drawing.Size(115, 35);
            this._bspPCDelete.TabIndex = 5;
            this._bspPCDelete.Text = "DELETE";
            this._bspPCDelete.UseVisualStyleBackColor = true;
            // 
            // _supplierPCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 360);
            this.Controls.Add(this._bspPCUpdate);
            this.Controls.Add(this._bspPCDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._bspPCInsert);
            this.Controls.Add(this._tspPCName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_supplierPCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_supplierPCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tspPCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _bspPCInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button _bspPCUpdate;
        private System.Windows.Forms.Button _bspPCDelete;
    }
}