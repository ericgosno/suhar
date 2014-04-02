namespace StockApps
{
    partial class _customerList
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
            this._bcusDelete = new System.Windows.Forms.Button();
            this._bcusInsert = new System.Windows.Forms.Button();
            this._dataCustomer = new System.Windows.Forms.DataGridView();
            this._tcusPhone = new System.Windows.Forms.TextBox();
            this._tcusEmail = new System.Windows.Forms.TextBox();
            this._tcusAddress = new System.Windows.Forms.TextBox();
            this._tcusName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._tcusNPWP = new System.Windows.Forms.TextBox();
            this._tcusCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // _bcusDelete
            // 
            this._bcusDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bcusDelete.Location = new System.Drawing.Point(611, 537);
            this._bcusDelete.Name = "_bcusDelete";
            this._bcusDelete.Size = new System.Drawing.Size(115, 35);
            this._bcusDelete.TabIndex = 21;
            this._bcusDelete.Text = "DELETE";
            this._bcusDelete.UseVisualStyleBackColor = true;
            this._bcusDelete.Click += new System.EventHandler(this._bcusDelete_Click);
            // 
            // _bcusInsert
            // 
            this._bcusInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bcusInsert.Location = new System.Drawing.Point(611, 266);
            this._bcusInsert.Name = "_bcusInsert";
            this._bcusInsert.Size = new System.Drawing.Size(115, 35);
            this._bcusInsert.TabIndex = 6;
            this._bcusInsert.Text = "INSERT";
            this._bcusInsert.UseVisualStyleBackColor = true;
            this._bcusInsert.Click += new System.EventHandler(this._bcusInsert_Click);
            // 
            // _dataCustomer
            // 
            this._dataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataCustomer.Location = new System.Drawing.Point(27, 307);
            this._dataCustomer.Name = "_dataCustomer";
            this._dataCustomer.Size = new System.Drawing.Size(699, 224);
            this._dataCustomer.TabIndex = 19;
            this._dataCustomer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataCustomer_CellEndEdit);
            // 
            // _tcusPhone
            // 
            this._tcusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tcusPhone.Location = new System.Drawing.Point(133, 180);
            this._tcusPhone.Name = "_tcusPhone";
            this._tcusPhone.Size = new System.Drawing.Size(463, 35);
            this._tcusPhone.TabIndex = 4;
            // 
            // _tcusEmail
            // 
            this._tcusEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tcusEmail.Location = new System.Drawing.Point(133, 139);
            this._tcusEmail.Name = "_tcusEmail";
            this._tcusEmail.Size = new System.Drawing.Size(463, 35);
            this._tcusEmail.TabIndex = 3;
            // 
            // _tcusAddress
            // 
            this._tcusAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tcusAddress.Location = new System.Drawing.Point(133, 98);
            this._tcusAddress.Name = "_tcusAddress";
            this._tcusAddress.Size = new System.Drawing.Size(463, 35);
            this._tcusAddress.TabIndex = 2;
            // 
            // _tcusName
            // 
            this._tcusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tcusName.Location = new System.Drawing.Point(133, 57);
            this._tcusName.Name = "_tcusName";
            this._tcusName.Size = new System.Drawing.Size(463, 35);
            this._tcusName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Create Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "NPWP :";
            // 
            // _tcusNPWP
            // 
            this._tcusNPWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tcusNPWP.Location = new System.Drawing.Point(133, 225);
            this._tcusNPWP.Name = "_tcusNPWP";
            this._tcusNPWP.Size = new System.Drawing.Size(463, 35);
            this._tcusNPWP.TabIndex = 5;
            // 
            // _tcusCompany
            // 
            this._tcusCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tcusCompany.Location = new System.Drawing.Point(133, 266);
            this._tcusCompany.Name = "_tcusCompany";
            this._tcusCompany.Size = new System.Drawing.Size(463, 35);
            this._tcusCompany.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Company :";
            // 
            // _customerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 579);
            this.Controls.Add(this._tcusCompany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._tcusNPWP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._bcusDelete);
            this.Controls.Add(this._bcusInsert);
            this.Controls.Add(this._dataCustomer);
            this.Controls.Add(this._tcusPhone);
            this.Controls.Add(this._tcusEmail);
            this.Controls.Add(this._tcusAddress);
            this.Controls.Add(this._tcusName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_customerList";
            this.Text = "CV. WARNA MURNI - CUSTOMER";
            this.Load += new System.EventHandler(this._customerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bcusDelete;
        private System.Windows.Forms.Button _bcusInsert;
        private System.Windows.Forms.DataGridView _dataCustomer;
        private System.Windows.Forms.TextBox _tcusPhone;
        private System.Windows.Forms.TextBox _tcusEmail;
        private System.Windows.Forms.TextBox _tcusAddress;
        private System.Windows.Forms.TextBox _tcusName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _tcusNPWP;
        private System.Windows.Forms.TextBox _tcusCompany;
        private System.Windows.Forms.Label label7;
    }
}