﻿namespace StockApps
{
    partial class _supplierList
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tspName = new System.Windows.Forms.TextBox();
            this._tspAddress = new System.Windows.Forms.TextBox();
            this._tspPhone = new System.Windows.Forms.TextBox();
            this._tspEmail = new System.Windows.Forms.TextBox();
            this._dgvspListSupplier = new System.Windows.Forms.DataGridView();
            this._bspInsert = new System.Windows.Forms.Button();
            this._bspDelete = new System.Windows.Forms.Button();
            this._bspDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvspListSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Create Supplier";
            // 
            // _tspName
            // 
            this._tspName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspName.Location = new System.Drawing.Point(133, 57);
            this._tspName.Name = "_tspName";
            this._tspName.Size = new System.Drawing.Size(463, 35);
            this._tspName.TabIndex = 1;
            // 
            // _tspAddress
            // 
            this._tspAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspAddress.Location = new System.Drawing.Point(133, 98);
            this._tspAddress.Name = "_tspAddress";
            this._tspAddress.Size = new System.Drawing.Size(463, 35);
            this._tspAddress.TabIndex = 2;
            // 
            // _tspPhone
            // 
            this._tspPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspPhone.Location = new System.Drawing.Point(133, 186);
            this._tspPhone.Name = "_tspPhone";
            this._tspPhone.Size = new System.Drawing.Size(463, 35);
            this._tspPhone.TabIndex = 4;
            // 
            // _tspEmail
            // 
            this._tspEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tspEmail.Location = new System.Drawing.Point(133, 141);
            this._tspEmail.Name = "_tspEmail";
            this._tspEmail.Size = new System.Drawing.Size(463, 35);
            this._tspEmail.TabIndex = 3;
            // 
            // _dgvspListSupplier
            // 
            this._dgvspListSupplier.Location = new System.Drawing.Point(18, 241);
            this._dgvspListSupplier.MultiSelect = false;
            this._dgvspListSupplier.Name = "_dgvspListSupplier";
            this._dgvspListSupplier.Size = new System.Drawing.Size(722, 239);
            this._dgvspListSupplier.TabIndex = 9;
            this._dgvspListSupplier.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvspListSupplier_CellEndEdit);
            // 
            // _bspInsert
            // 
            this._bspInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspInsert.Location = new System.Drawing.Point(625, 186);
            this._bspInsert.Name = "_bspInsert";
            this._bspInsert.Size = new System.Drawing.Size(115, 35);
            this._bspInsert.TabIndex = 5;
            this._bspInsert.Text = "INSERT";
            this._bspInsert.UseVisualStyleBackColor = true;
            this._bspInsert.Click += new System.EventHandler(this._bspInsert_Click);
            // 
            // _bspDelete
            // 
            this._bspDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspDelete.Location = new System.Drawing.Point(625, 486);
            this._bspDelete.Name = "_bspDelete";
            this._bspDelete.Size = new System.Drawing.Size(115, 35);
            this._bspDelete.TabIndex = 8;
            this._bspDelete.Text = "DELETE";
            this._bspDelete.UseVisualStyleBackColor = true;
            this._bspDelete.Click += new System.EventHandler(this._bspDelete_Click);
            // 
            // _bspDetail
            // 
            this._bspDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bspDetail.Location = new System.Drawing.Point(504, 486);
            this._bspDetail.Name = "_bspDetail";
            this._bspDetail.Size = new System.Drawing.Size(115, 35);
            this._bspDetail.TabIndex = 10;
            this._bspDetail.Text = "DETAIL";
            this._bspDetail.UseVisualStyleBackColor = true;
            this._bspDetail.Click += new System.EventHandler(this._bspDetail_Click);
            // 
            // _supplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 529);
            this.Controls.Add(this._bspDetail);
            this.Controls.Add(this._bspDelete);
            this.Controls.Add(this._bspInsert);
            this.Controls.Add(this._dgvspListSupplier);
            this.Controls.Add(this._tspEmail);
            this.Controls.Add(this._tspPhone);
            this.Controls.Add(this._tspAddress);
            this.Controls.Add(this._tspName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_supplierList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - SUPPLIER";
            ((System.ComponentModel.ISupportInitialize)(this._dgvspListSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tspName;
        private System.Windows.Forms.TextBox _tspAddress;
        private System.Windows.Forms.TextBox _tspPhone;
        private System.Windows.Forms.TextBox _tspEmail;
        private System.Windows.Forms.DataGridView _dgvspListSupplier;
        private System.Windows.Forms.Button _bspInsert;
        private System.Windows.Forms.Button _bspDelete;
        private System.Windows.Forms.Button _bspDetail;

    }
}