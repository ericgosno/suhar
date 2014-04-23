namespace StockApps
{
    partial class _administratorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dataAdministrator = new System.Windows.Forms.DataGridView();
            this._badmCInsert = new System.Windows.Forms.Button();
            this._tadmCPass = new System.Windows.Forms.TextBox();
            this._tadmCEmail = new System.Windows.Forms.TextBox();
            this._tadmCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._badmCUpdate = new System.Windows.Forms.Button();
            this._badmCDelete = new System.Windows.Forms.Button();
            this._cbadmCCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this._tadmCPassConf = new System.Windows.Forms.TextBox();
            this._badmCReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataAdministrator)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataAdministrator
            // 
            this._dataAdministrator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataAdministrator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataAdministrator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataAdministrator.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataAdministrator.Location = new System.Drawing.Point(29, 277);
            this._dataAdministrator.Name = "_dataAdministrator";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataAdministrator.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dataAdministrator.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dataAdministrator.Size = new System.Drawing.Size(798, 270);
            this._dataAdministrator.TabIndex = 7;
            this._dataAdministrator.SelectionChanged += new System.EventHandler(this._dataAdministrator_SelectionChanged);
            // 
            // _badmCInsert
            // 
            this._badmCInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._badmCInsert.Location = new System.Drawing.Point(662, 182);
            this._badmCInsert.Name = "_badmCInsert";
            this._badmCInsert.Size = new System.Drawing.Size(165, 35);
            this._badmCInsert.TabIndex = 6;
            this._badmCInsert.Text = "INSERT";
            this._badmCInsert.UseVisualStyleBackColor = true;
            this._badmCInsert.Click += new System.EventHandler(this._badmCInsert_Click);
            // 
            // _tadmCPass
            // 
            this._tadmCPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmCPass.Location = new System.Drawing.Point(243, 138);
            this._tadmCPass.Name = "_tadmCPass";
            this._tadmCPass.PasswordChar = '*';
            this._tadmCPass.Size = new System.Drawing.Size(413, 35);
            this._tadmCPass.TabIndex = 3;
            // 
            // _tadmCEmail
            // 
            this._tadmCEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmCEmail.Location = new System.Drawing.Point(243, 99);
            this._tadmCEmail.Name = "_tadmCEmail";
            this._tadmCEmail.Size = new System.Drawing.Size(413, 35);
            this._tadmCEmail.TabIndex = 2;
            // 
            // _tadmCName
            // 
            this._tadmCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmCName.Location = new System.Drawing.Point(243, 59);
            this._tadmCName.Name = "_tadmCName";
            this._tadmCName.Size = new System.Drawing.Size(413, 35);
            this._tadmCName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Create Admin";
            // 
            // _badmCUpdate
            // 
            this._badmCUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._badmCUpdate.Location = new System.Drawing.Point(662, 223);
            this._badmCUpdate.Name = "_badmCUpdate";
            this._badmCUpdate.Size = new System.Drawing.Size(165, 35);
            this._badmCUpdate.TabIndex = 8;
            this._badmCUpdate.Text = "UPDATE";
            this._badmCUpdate.UseVisualStyleBackColor = true;
            this._badmCUpdate.Click += new System.EventHandler(this._badmCUpdate_Click);
            // 
            // _badmCDelete
            // 
            this._badmCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._badmCDelete.Location = new System.Drawing.Point(712, 561);
            this._badmCDelete.Name = "_badmCDelete";
            this._badmCDelete.Size = new System.Drawing.Size(115, 35);
            this._badmCDelete.TabIndex = 9;
            this._badmCDelete.Text = "DELETE";
            this._badmCDelete.UseVisualStyleBackColor = true;
            this._badmCDelete.Click += new System.EventHandler(this._badmCDelete_Click);
            // 
            // _cbadmCCategory
            // 
            this._cbadmCCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cbadmCCategory.FormattingEnabled = true;
            this._cbadmCCategory.Location = new System.Drawing.Point(243, 216);
            this._cbadmCCategory.Name = "_cbadmCCategory";
            this._cbadmCCategory.Size = new System.Drawing.Size(413, 37);
            this._cbadmCCategory.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Category :";
            // 
            // _tadmCPassConf
            // 
            this._tadmCPassConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tadmCPassConf.Location = new System.Drawing.Point(243, 176);
            this._tadmCPassConf.Name = "_tadmCPassConf";
            this._tadmCPassConf.PasswordChar = '*';
            this._tadmCPassConf.Size = new System.Drawing.Size(413, 35);
            this._tadmCPassConf.TabIndex = 4;
            // 
            // _badmCReset
            // 
            this._badmCReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._badmCReset.Location = new System.Drawing.Point(662, 141);
            this._badmCReset.Name = "_badmCReset";
            this._badmCReset.Size = new System.Drawing.Size(165, 35);
            this._badmCReset.TabIndex = 30;
            this._badmCReset.Text = "RESET";
            this._badmCReset.UseVisualStyleBackColor = true;
            this._badmCReset.Click += new System.EventHandler(this._badmCReset_Click);
            // 
            // _administratorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 627);
            this.Controls.Add(this._badmCReset);
            this.Controls.Add(this._tadmCPassConf);
            this.Controls.Add(this._cbadmCCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._badmCUpdate);
            this.Controls.Add(this._badmCDelete);
            this.Controls.Add(this._dataAdministrator);
            this.Controls.Add(this._badmCInsert);
            this.Controls.Add(this._tadmCPass);
            this.Controls.Add(this._tadmCEmail);
            this.Controls.Add(this._tadmCName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "_administratorList";
            this.Text = "CV. WARNA MURNI - ADMINISTRATOR";
            this.Load += new System.EventHandler(this._administratorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataAdministrator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataAdministrator;
        private System.Windows.Forms.Button _badmCInsert;
        private System.Windows.Forms.TextBox _tadmCPass;
        private System.Windows.Forms.TextBox _tadmCEmail;
        private System.Windows.Forms.TextBox _tadmCName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _badmCUpdate;
        private System.Windows.Forms.Button _badmCDelete;
        private System.Windows.Forms.ComboBox _cbadmCCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _tadmCPassConf;
        private System.Windows.Forms.Button _badmCReset;
    }
}