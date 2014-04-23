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
            this._bspPCDelete = new System.Windows.Forms.Button();
            this._tspPCListCategory = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
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
            this._tspPCName.Location = new System.Drawing.Point(98, 67);
            this._tspPCName.Name = "_tspPCName";
            this._tspPCName.Size = new System.Drawing.Size(320, 35);
            this._tspPCName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // _bspPCInsert
            // 
            this._bspPCInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspPCInsert.Location = new System.Drawing.Point(424, 67);
            this._bspPCInsert.Name = "_bspPCInsert";
            this._bspPCInsert.Size = new System.Drawing.Size(133, 35);
            this._bspPCInsert.TabIndex = 2;
            this._bspPCInsert.Text = "INSERT";
            this._bspPCInsert.UseVisualStyleBackColor = true;
            this._bspPCInsert.Click += new System.EventHandler(this._bspPCInsert_Click);
            // 
            // _bspPCDelete
            // 
            this._bspPCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspPCDelete.Location = new System.Drawing.Point(424, 362);
            this._bspPCDelete.Name = "_bspPCDelete";
            this._bspPCDelete.Size = new System.Drawing.Size(133, 35);
            this._bspPCDelete.TabIndex = 5;
            this._bspPCDelete.Text = "DELETE";
            this._bspPCDelete.UseVisualStyleBackColor = true;
            this._bspPCDelete.Click += new System.EventHandler(this._bspPCDelete_Click);
            // 
            // _tspPCListCategory
            // 
            this._tspPCListCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspPCListCategory.FullRowSelect = true;
            this._tspPCListCategory.HideSelection = false;
            this._tspPCListCategory.LabelEdit = true;
            this._tspPCListCategory.Location = new System.Drawing.Point(18, 141);
            this._tspPCListCategory.MultiSelect = false;
            this._tspPCListCategory.Name = "_tspPCListCategory";
            this._tspPCListCategory.Size = new System.Drawing.Size(539, 215);
            this._tspPCListCategory.TabIndex = 12;
            this._tspPCListCategory.UseCompatibleStateImageBehavior = false;
            this._tspPCListCategory.View = System.Windows.Forms.View.List;
            this._tspPCListCategory.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this._tspPCListCategory_AfterLabelEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "List Category";
            // 
            // _supplierPCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._bspPCInsert);
            this.Controls.Add(this._tspPCListCategory);
            this.Controls.Add(this._tspPCName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._bspPCDelete);
            this.Controls.Add(this.label5);
            this.Name = "_supplierPCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - PRODUCT CATEGORY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tspPCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _bspPCInsert;
        private System.Windows.Forms.Button _bspPCDelete;
        private System.Windows.Forms.ListView _tspPCListCategory;
        private System.Windows.Forms.Label label2;
    }
}