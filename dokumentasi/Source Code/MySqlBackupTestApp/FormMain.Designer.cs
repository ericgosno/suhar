namespace MySqlBackupTestApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBox_Connection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testBasicWithDefaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testExportImportWithOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testCustomExportOfTablesAndRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testExportWithProgressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testProgressReportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testEncryptDecryptDumpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testExportImportFromMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testExportImportWithZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.compareDumpFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseInfoViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpFileViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSampleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptOldEncryptedDumpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.button_ExportAs = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Connection
            // 
            this.textBox_Connection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Connection.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Connection.Location = new System.Drawing.Point(118, 8);
            this.textBox_Connection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Connection.Name = "textBox_Connection";
            this.textBox_Connection.Size = new System.Drawing.Size(633, 21);
            this.textBox_Connection.TabIndex = 0;
            this.textBox_Connection.TextChanged += new System.EventHandler(this.textBox_Connection_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 414);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webReferencesToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // webReferencesToolStripMenuItem
            // 
            this.webReferencesToolStripMenuItem.Name = "webReferencesToolStripMenuItem";
            this.webReferencesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.webReferencesToolStripMenuItem.Text = "Web References";
            this.webReferencesToolStripMenuItem.Click += new System.EventHandler(this.webReferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testBasicWithDefaultSettingsToolStripMenuItem,
            this.testExportImportWithOptionsToolStripMenuItem,
            this.testCustomExportOfTablesAndRowsToolStripMenuItem,
            this.testExportWithProgressBarToolStripMenuItem,
            this.testProgressReportImportToolStripMenuItem,
            this.testEncryptDecryptDumpFileToolStripMenuItem,
            this.testExportImportFromMemoryToolStripMenuItem,
            this.testExportImportWithZipToolStripMenuItem,
            this.toolStripSeparator2,
            this.compareDumpFilesToolStripMenuItem,
            this.databaseInfoViewerToolStripMenuItem,
            this.dumpFileViewerToolStripMenuItem,
            this.createSampleDataToolStripMenuItem,
            this.queryBrowserToolStripMenuItem,
            this.decryptOldEncryptedDumpFileToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.testToolStripMenuItem.Text = "Tools";
            // 
            // testBasicWithDefaultSettingsToolStripMenuItem
            // 
            this.testBasicWithDefaultSettingsToolStripMenuItem.Name = "testBasicWithDefaultSettingsToolStripMenuItem";
            this.testBasicWithDefaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testBasicWithDefaultSettingsToolStripMenuItem.Text = "Test - Basic with Default Settings";
            this.testBasicWithDefaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.testBasicWithDefaultSettingsToolStripMenuItem_Click);
            // 
            // testExportImportWithOptionsToolStripMenuItem
            // 
            this.testExportImportWithOptionsToolStripMenuItem.Name = "testExportImportWithOptionsToolStripMenuItem";
            this.testExportImportWithOptionsToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testExportImportWithOptionsToolStripMenuItem.Text = "Test - Export / Import with Options";
            this.testExportImportWithOptionsToolStripMenuItem.Click += new System.EventHandler(this.testExportImportWithOptionsToolStripMenuItem_Click);
            // 
            // testCustomExportOfTablesAndRowsToolStripMenuItem
            // 
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Name = "testCustomExportOfTablesAndRowsToolStripMenuItem";
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Text = "Test - Custom Export of Tables and Rows";
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Click += new System.EventHandler(this.testCustomExportOfTablesAndRowsToolStripMenuItem_Click);
            // 
            // testExportWithProgressBarToolStripMenuItem
            // 
            this.testExportWithProgressBarToolStripMenuItem.Name = "testExportWithProgressBarToolStripMenuItem";
            this.testExportWithProgressBarToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testExportWithProgressBarToolStripMenuItem.Text = "Test - Progress Report - Export";
            this.testExportWithProgressBarToolStripMenuItem.Click += new System.EventHandler(this.testExportWithProgressBarToolStripMenuItem_Click);
            // 
            // testProgressReportImportToolStripMenuItem
            // 
            this.testProgressReportImportToolStripMenuItem.Name = "testProgressReportImportToolStripMenuItem";
            this.testProgressReportImportToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testProgressReportImportToolStripMenuItem.Text = "Test - Progress Report - Import";
            this.testProgressReportImportToolStripMenuItem.Click += new System.EventHandler(this.testProgressReportImportToolStripMenuItem_Click);
            // 
            // testEncryptDecryptDumpFileToolStripMenuItem
            // 
            this.testEncryptDecryptDumpFileToolStripMenuItem.Name = "testEncryptDecryptDumpFileToolStripMenuItem";
            this.testEncryptDecryptDumpFileToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testEncryptDecryptDumpFileToolStripMenuItem.Text = "Test - Encrypt / Decrypt Dump File";
            this.testEncryptDecryptDumpFileToolStripMenuItem.Click += new System.EventHandler(this.testEncryptDecryptDumpFileToolStripMenuItem_Click);
            // 
            // testExportImportFromMemoryToolStripMenuItem
            // 
            this.testExportImportFromMemoryToolStripMenuItem.Name = "testExportImportFromMemoryToolStripMenuItem";
            this.testExportImportFromMemoryToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testExportImportFromMemoryToolStripMenuItem.Text = "Test - Export / Import To/From Memory";
            this.testExportImportFromMemoryToolStripMenuItem.Click += new System.EventHandler(this.testExportImportFromMemoryToolStripMenuItem_Click);
            // 
            // testExportImportWithZipToolStripMenuItem
            // 
            this.testExportImportWithZipToolStripMenuItem.Name = "testExportImportWithZipToolStripMenuItem";
            this.testExportImportWithZipToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.testExportImportWithZipToolStripMenuItem.Text = "Test - Export / Import with Zip";
            this.testExportImportWithZipToolStripMenuItem.Click += new System.EventHandler(this.testExportImportWithZipToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(287, 6);
            // 
            // compareDumpFilesToolStripMenuItem
            // 
            this.compareDumpFilesToolStripMenuItem.Name = "compareDumpFilesToolStripMenuItem";
            this.compareDumpFilesToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.compareDumpFilesToolStripMenuItem.Text = "Compare Dump Files";
            this.compareDumpFilesToolStripMenuItem.Click += new System.EventHandler(this.compareDumpFilesToolStripMenuItem_Click);
            // 
            // databaseInfoViewerToolStripMenuItem
            // 
            this.databaseInfoViewerToolStripMenuItem.Name = "databaseInfoViewerToolStripMenuItem";
            this.databaseInfoViewerToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.databaseInfoViewerToolStripMenuItem.Text = "Database Info Viewer";
            this.databaseInfoViewerToolStripMenuItem.Click += new System.EventHandler(this.databaseInfoViewerToolStripMenuItem_Click);
            // 
            // dumpFileViewerToolStripMenuItem
            // 
            this.dumpFileViewerToolStripMenuItem.Name = "dumpFileViewerToolStripMenuItem";
            this.dumpFileViewerToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.dumpFileViewerToolStripMenuItem.Text = "Dump File Viewer";
            this.dumpFileViewerToolStripMenuItem.Click += new System.EventHandler(this.dumpFileViewerToolStripMenuItem_Click);
            // 
            // createSampleDataToolStripMenuItem
            // 
            this.createSampleDataToolStripMenuItem.Name = "createSampleDataToolStripMenuItem";
            this.createSampleDataToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.createSampleDataToolStripMenuItem.Text = "Create Sample Data";
            this.createSampleDataToolStripMenuItem.Click += new System.EventHandler(this.createSampleDataToolStripMenuItem_Click);
            // 
            // queryBrowserToolStripMenuItem
            // 
            this.queryBrowserToolStripMenuItem.Name = "queryBrowserToolStripMenuItem";
            this.queryBrowserToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.queryBrowserToolStripMenuItem.Text = "Query Browser";
            this.queryBrowserToolStripMenuItem.Click += new System.EventHandler(this.queryBrowserToolStripMenuItem_Click);
            // 
            // decryptOldEncryptedDumpFileToolStripMenuItem
            // 
            this.decryptOldEncryptedDumpFileToolStripMenuItem.Name = "decryptOldEncryptedDumpFileToolStripMenuItem";
            this.decryptOldEncryptedDumpFileToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.decryptOldEncryptedDumpFileToolStripMenuItem.Text = "Decrypt Old Encrypted Dump File";
            this.decryptOldEncryptedDumpFileToolStripMenuItem.Click += new System.EventHandler(this.decryptOldEncryptedDumpFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox_File);
            this.splitContainer1.Panel1.Controls.Add(this.button_ExportAs);
            this.splitContainer1.Panel1.Controls.Add(this.button_View);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button_SelectFile);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Connection);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(764, 498);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 5;
            // 
            // textBox_File
            // 
            this.textBox_File.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_File.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_File.Location = new System.Drawing.Point(182, 45);
            this.textBox_File.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(569, 21);
            this.textBox_File.TabIndex = 4;
            this.textBox_File.TextChanged += new System.EventHandler(this.textBox_File_TextChanged);
            // 
            // button_ExportAs
            // 
            this.button_ExportAs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportAs.Location = new System.Drawing.Point(7, 36);
            this.button_ExportAs.Name = "button_ExportAs";
            this.button_ExportAs.Size = new System.Drawing.Size(48, 38);
            this.button_ExportAs.TabIndex = 3;
            this.button_ExportAs.Text = "Export As";
            this.button_ExportAs.UseVisualStyleBackColor = true;
            this.button_ExportAs.Click += new System.EventHandler(this.button_ExportAs_Click);
            // 
            // button_View
            // 
            this.button_View.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View.Location = new System.Drawing.Point(116, 36);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(59, 38);
            this.button_View.TabIndex = 2;
            this.button_View.Text = "View Content";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectFile.Location = new System.Drawing.Point(61, 36);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(49, 38);
            this.button_SelectFile.TabIndex = 0;
            this.button_SelectFile.Text = "Select File";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 522);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySqlBackup.NET Testing Tools (V1.0.1) for Version ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Connection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem webReferencesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.Button button_ExportAs;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.Button button_SelectFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem compareDumpFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseInfoViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpFileViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem testExportWithProgressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSampleDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testExportImportWithOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testBasicWithDefaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testProgressReportImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testEncryptDecryptDumpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testCustomExportOfTablesAndRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testExportImportFromMemoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testExportImportWithZipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptOldEncryptedDumpFileToolStripMenuItem;
    }
}