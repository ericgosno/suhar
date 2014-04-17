namespace StockApps
{
    partial class _administrator
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
            this._tadmUser = new System.Windows.Forms.TextBox();
            this._tadmPass = new System.Windows.Forms.TextBox();
            this._badmLogin = new System.Windows.Forms.Button();
            this._lIdentityCompany = new System.Windows.Forms.Label();
            this._lIdentityAddress = new System.Windows.Forms.Label();
            this._lIdentityPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(421, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD :";
            // 
            // _tadmUser
            // 
            this._tadmUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmUser.Location = new System.Drawing.Point(277, 156);
            this._tadmUser.Name = "_tadmUser";
            this._tadmUser.Size = new System.Drawing.Size(215, 35);
            this._tadmUser.TabIndex = 1;
            // 
            // _tadmPass
            // 
            this._tadmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmPass.Location = new System.Drawing.Point(277, 205);
            this._tadmPass.Name = "_tadmPass";
            this._tadmPass.PasswordChar = '*';
            this._tadmPass.Size = new System.Drawing.Size(215, 35);
            this._tadmPass.TabIndex = 2;
            // 
            // _badmLogin
            // 
            this._badmLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._badmLogin.Location = new System.Drawing.Point(108, 260);
            this._badmLogin.Name = "_badmLogin";
            this._badmLogin.Size = new System.Drawing.Size(404, 37);
            this._badmLogin.TabIndex = 3;
            this._badmLogin.Text = "LOGIN";
            this._badmLogin.UseVisualStyleBackColor = true;
            this._badmLogin.Click += new System.EventHandler(this._badmLogin_Click);
            // 
            // _lIdentityCompany
            // 
            this._lIdentityCompany.AutoSize = true;
            this._lIdentityCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lIdentityCompany.Location = new System.Drawing.Point(237, 348);
            this._lIdentityCompany.Name = "_lIdentityCompany";
            this._lIdentityCompany.Size = new System.Drawing.Size(156, 20);
            this._lIdentityCompany.TabIndex = 4;
            this._lIdentityCompany.Text = "CV. WARNA MURNI";
            this._lIdentityCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _lIdentityAddress
            // 
            this._lIdentityAddress.AutoSize = true;
            this._lIdentityAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lIdentityAddress.Location = new System.Drawing.Point(212, 368);
            this._lIdentityAddress.MaximumSize = new System.Drawing.Size(250, 50);
            this._lIdentityAddress.Name = "_lIdentityAddress";
            this._lIdentityAddress.Size = new System.Drawing.Size(210, 20);
            this._lIdentityAddress.TabIndex = 5;
            this._lIdentityAddress.Text = "Jln. Klampis Harapan 1 no. 1";
            this._lIdentityAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _lIdentityPhone
            // 
            this._lIdentityPhone.AutoSize = true;
            this._lIdentityPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lIdentityPhone.Location = new System.Drawing.Point(253, 413);
            this._lIdentityPhone.Name = "_lIdentityPhone";
            this._lIdentityPhone.Size = new System.Drawing.Size(112, 20);
            this._lIdentityPhone.TabIndex = 6;
            this._lIdentityPhone.Text = "031 - 5353535";
            this._lIdentityPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this._lIdentityPhone);
            this.Controls.Add(this._lIdentityAddress);
            this.Controls.Add(this._lIdentityCompany);
            this.Controls.Add(this._badmLogin);
            this.Controls.Add(this._tadmPass);
            this.Controls.Add(this._tadmUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - ADMINISTRATOR";
            this.Load += new System.EventHandler(this._administrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tadmUser;
        private System.Windows.Forms.TextBox _tadmPass;
        private System.Windows.Forms.Button _badmLogin;
        private System.Windows.Forms.Label _lIdentityCompany;
        private System.Windows.Forms.Label _lIdentityAddress;
        private System.Windows.Forms.Label _lIdentityPhone;
    }
}