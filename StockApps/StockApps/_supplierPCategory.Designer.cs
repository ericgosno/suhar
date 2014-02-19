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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._tspPCListCategory = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Create Product Category";
            // 
            // _tspPCName
            // 
            this._tspPCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspPCName.Location = new System.Drawing.Point(109, 63);
            this._tspPCName.Name = "_tspPCName";
            this._tspPCName.Size = new System.Drawing.Size(302, 35);
            this._tspPCName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // _bspPCInsert
            // 
            this._bspPCInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspPCInsert.Location = new System.Drawing.Point(18, 107);
            this._bspPCInsert.Name = "_bspPCInsert";
            this._bspPCInsert.Size = new System.Drawing.Size(165, 35);
            this._bspPCInsert.TabIndex = 2;
            this._bspPCInsert.Text = "INSERT";
            this._bspPCInsert.UseVisualStyleBackColor = true;
            this._bspPCInsert.Click += new System.EventHandler(this._bspPCInsert_Click);
            // 
            // _bspPCDelete
            // 
            this._bspPCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspPCDelete.Location = new System.Drawing.Point(312, 175);
            this._bspPCDelete.Name = "_bspPCDelete";
            this._bspPCDelete.Size = new System.Drawing.Size(133, 35);
            this._bspPCDelete.TabIndex = 5;
            this._bspPCDelete.Text = "DELETE";
            this._bspPCDelete.UseVisualStyleBackColor = true;
            this._bspPCDelete.Click += new System.EventHandler(this._bspPCDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._bspPCInsert);
            this.groupBox1.Controls.Add(this._tspPCName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // _tspPCListCategory
            // 
            this._tspPCListCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspPCListCategory.FullRowSelect = true;
            this._tspPCListCategory.HideSelection = false;
            this._tspPCListCategory.LabelEdit = true;
            this._tspPCListCategory.Location = new System.Drawing.Point(16, 175);
            this._tspPCListCategory.MultiSelect = false;
            this._tspPCListCategory.Name = "_tspPCListCategory";
            this._tspPCListCategory.Size = new System.Drawing.Size(290, 215);
            this._tspPCListCategory.TabIndex = 12;
            this._tspPCListCategory.UseCompatibleStateImageBehavior = false;
            this._tspPCListCategory.View = System.Windows.Forms.View.List;
            this._tspPCListCategory.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this._tspPCListCategory_AfterLabelEdit);
            // 
            // _supplierPCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 412);
            this.Controls.Add(this._tspPCListCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._bspPCDelete);
            this.Name = "_supplierPCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - PRODUCT CATEGORY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tspPCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _bspPCInsert;
        private System.Windows.Forms.Button _bspPCDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView _tspPCListCategory;
    }
}