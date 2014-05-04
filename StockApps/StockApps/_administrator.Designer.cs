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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tadmUser = new System.Windows.Forms.TextBox();
            this._tadmPass = new System.Windows.Forms.TextBox();
            this._badmLogin = new System.Windows.Forms.Button();
            this._lIdentityCompany = new System.Windows.Forms.Label();
            this._lIdentityAddress = new System.Windows.Forms.Label();
            this._lIdentityPhone = new System.Windows.Forms.Label();
            this._lIdentityCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lConnectionStatus = new System.Windows.Forms.Label();
            this._pConnectionStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._tConnectionCheck = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeDatabaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._pConnectionStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD :";
            // 
            // _tadmUser
            // 
            this._tadmUser.Enabled = false;
            this._tadmUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmUser.Location = new System.Drawing.Point(285, 208);
            this._tadmUser.Name = "_tadmUser";
            this._tadmUser.Size = new System.Drawing.Size(215, 35);
            this._tadmUser.TabIndex = 1;
            // 
            // _tadmPass
            // 
            this._tadmPass.Enabled = false;
            this._tadmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmPass.Location = new System.Drawing.Point(285, 243);
            this._tadmPass.Name = "_tadmPass";
            this._tadmPass.PasswordChar = '*';
            this._tadmPass.Size = new System.Drawing.Size(215, 35);
            this._tadmPass.TabIndex = 2;
            // 
            // _badmLogin
            // 
            this._badmLogin.BackColor = System.Drawing.Color.Transparent;
            this._badmLogin.Enabled = false;
            this._badmLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._badmLogin.Location = new System.Drawing.Point(122, 306);
            this._badmLogin.Name = "_badmLogin";
            this._badmLogin.Size = new System.Drawing.Size(404, 37);
            this._badmLogin.TabIndex = 3;
            this._badmLogin.Text = "LOGIN";
            this._badmLogin.UseVisualStyleBackColor = false;
            this._badmLogin.Click += new System.EventHandler(this._badmLogin_Click);
            // 
            // _lIdentityCompany
            // 
            this._lIdentityCompany.AutoSize = true;
            this._lIdentityCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lIdentityCompany.Location = new System.Drawing.Point(237, 361);
            this._lIdentityCompany.Name = "_lIdentityCompany";
            this._lIdentityCompany.Size = new System.Drawing.Size(157, 24);
            this._lIdentityCompany.TabIndex = 4;
            this._lIdentityCompany.Text = "CV. WARNA MURNI";
            this._lIdentityCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lIdentityCompany.UseCompatibleTextRendering = true;
            this._lIdentityCompany.Visible = false;
            // 
            // _lIdentityAddress
            // 
            this._lIdentityAddress.AutoSize = true;
            this._lIdentityAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lIdentityAddress.Location = new System.Drawing.Point(133, 380);
            this._lIdentityAddress.MaximumSize = new System.Drawing.Size(500, 50);
            this._lIdentityAddress.Name = "_lIdentityAddress";
            this._lIdentityAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lIdentityAddress.Size = new System.Drawing.Size(221, 24);
            this._lIdentityAddress.TabIndex = 5;
            this._lIdentityAddress.Text = "Jln. Klampis Harapan 1 no. 1 ";
            this._lIdentityAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lIdentityAddress.UseCompatibleTextRendering = true;
            this._lIdentityAddress.Visible = false;
            // 
            // _lIdentityPhone
            // 
            this._lIdentityPhone.AutoSize = true;
            this._lIdentityPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lIdentityPhone.Location = new System.Drawing.Point(266, 426);
            this._lIdentityPhone.Name = "_lIdentityPhone";
            this._lIdentityPhone.Size = new System.Drawing.Size(112, 20);
            this._lIdentityPhone.TabIndex = 6;
            this._lIdentityPhone.Text = "031 - 5353535";
            this._lIdentityPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lIdentityPhone.Visible = false;
            // 
            // _lIdentityCity
            // 
            this._lIdentityCity.AutoSize = true;
            this._lIdentityCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lIdentityCity.Location = new System.Drawing.Point(263, 404);
            this._lIdentityCity.Name = "_lIdentityCity";
            this._lIdentityCity.Size = new System.Drawing.Size(77, 20);
            this._lIdentityCity.TabIndex = 7;
            this._lIdentityCity.Text = "Surabaya";
            this._lIdentityCity.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(122, 140);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(378, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _lConnectionStatus
            // 
            this._lConnectionStatus.AutoSize = true;
            this._lConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lConnectionStatus.Location = new System.Drawing.Point(47, 457);
            this._lConnectionStatus.Name = "_lConnectionStatus";
            this._lConnectionStatus.Size = new System.Drawing.Size(262, 24);
            this._lConnectionStatus.TabIndex = 11;
            this._lConnectionStatus.Text = "Checking Connection Status...";
            // 
            // _pConnectionStatus
            // 
            this._pConnectionStatus.Image = global::StockApps.Properties.Resources.green_light;
            this._pConnectionStatus.Location = new System.Drawing.Point(9, 451);
            this._pConnectionStatus.Name = "_pConnectionStatus";
            this._pConnectionStatus.Size = new System.Drawing.Size(32, 32);
            this._pConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pConnectionStatus.TabIndex = 10;
            this._pConnectionStatus.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 496);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(623, 24);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StockApps.Properties.Resources.administrator;
            this.pictureBox1.Location = new System.Drawing.Point(253, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 115);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // _tConnectionCheck
            // 
            this._tConnectionCheck.Interval = 3000;
            this._tConnectionCheck.Tick += new System.EventHandler(this._tConnectionCheck_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDatabaseConnectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeDatabaseConnectionToolStripMenuItem
            // 
            this.changeDatabaseConnectionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDatabaseConnectionToolStripMenuItem.Name = "changeDatabaseConnectionToolStripMenuItem";
            this.changeDatabaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(226, 25);
            this.changeDatabaseConnectionToolStripMenuItem.Text = "Change Database Connection";
            this.changeDatabaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.changeDatabaseConnectionToolStripMenuItem_Click);
            // 
            // _administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 516);
            this.Controls.Add(this._lConnectionStatus);
            this.Controls.Add(this._pConnectionStatus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._lIdentityCity);
            this.Controls.Add(this._lIdentityPhone);
            this.Controls.Add(this._lIdentityAddress);
            this.Controls.Add(this._lIdentityCompany);
            this.Controls.Add(this._badmLogin);
            this.Controls.Add(this._tadmPass);
            this.Controls.Add(this._tadmUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. WARNA MURNI - ADMINISTRATOR";
            ((System.ComponentModel.ISupportInitialize)(this._pConnectionStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tadmUser;
        private System.Windows.Forms.TextBox _tadmPass;
        private System.Windows.Forms.Button _badmLogin;
        private System.Windows.Forms.Label _lIdentityCompany;
        private System.Windows.Forms.Label _lIdentityAddress;
        private System.Windows.Forms.Label _lIdentityPhone;
        private System.Windows.Forms.Label _lIdentityCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox _pConnectionStatus;
        private System.Windows.Forms.Label _lConnectionStatus;
        private System.Windows.Forms.Timer _tConnectionCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeDatabaseConnectionToolStripMenuItem;
    }
}