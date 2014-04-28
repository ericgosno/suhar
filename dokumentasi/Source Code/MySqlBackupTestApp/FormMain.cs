using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySqlBackupTestApp
{
    public partial class FormMain : Form
    {
        List<Form> lstForm = new List<Form>();

        public FormMain()
        {
            InitializeComponent();
            this.Text += MySql.Data.MySqlClient.MySqlBackup.Version;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestSimple));
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();

            for (int i = 0; i < lstForm.Count; i++)
            {
                lstForm[i].WindowState = FormWindowState.Normal;
                lstForm[i].WindowState = FormWindowState.Maximized;
            }

            this.ResumeLayout(true);
        }

        void OpenForm(Type formType)
        {
            this.SuspendLayout();

            bool formOpened = false;

            for (int i = 0; i < lstForm.Count; i++)
            {
                if (lstForm[i].GetType() == formType)
                {
                    lstForm[i].SuspendLayout();
                    lstForm[i].BringToFront();
                    lstForm[i].Activate();
                    lstForm[i].WindowState = FormWindowState.Normal;
                    lstForm[i].WindowState = FormWindowState.Maximized;
                    lstForm[i].ResumeLayout(true);
                    formOpened = true;
                    break;
                }
            }

            if (!formOpened)
            {
                object form = (object)Activator.CreateInstance(formType);
                ((Form)form).WindowState = FormWindowState.Maximized;
                ((Form)form).FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                ((Form)form).TopLevel = false;

                panel1.Controls.Add(((Form)form));
                ((Form)form).Show();

                lstForm.Add(((Form)form));
            }

            this.ResumeLayout(true);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ExportAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (Program.DefaultFolder != "")
                f.InitialDirectory = Program.DefaultFolder;
            f.Filter = "*.sql|*.sql|*.*|*.*";
            f.FileName = "TestDump " + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".sql";
            if (DialogResult.OK == f.ShowDialog())
            {
                textBox_File.Text = f.FileName;
                Program.DefaultFolder = System.IO.Path.GetDirectoryName(textBox_File.Text);
            }
        }

        private void button_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (Program.DefaultFolder != "")
                f.InitialDirectory = Program.DefaultFolder;
            if (DialogResult.OK == f.ShowDialog())
            {
                textBox_File.Text = f.FileName;
                Program.DefaultFolder = System.IO.Path.GetDirectoryName(textBox_File.Text);
            }
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormDumpFileViewer));

            for (int i = 0; i < lstForm.Count; i++)
            {
                if (lstForm[i].GetType() == typeof(FormDumpFileViewer))
                {
                    if (Program.TargetFile == "")
                    { }
                    else 
                    {
                        ((FormDumpFileViewer)lstForm[i]).OpenTargetFile();
                    }
                    break;
                }
            }
        }

        private void textBox_Connection_TextChanged(object sender, EventArgs e)
        {
            Program.ConnectionString = textBox_Connection.Text;
        }

        private void textBox_File_TextChanged(object sender, EventArgs e)
        {
            Program.TargetFile = textBox_File.Text;
        }

        private void webReferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormReference));
        }

        private void compareDumpFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormCompareFile));
        }

        private void databaseInfoViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormDatabaseInfo));
        }

        private void dumpFileViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormDumpFileViewer));
        }

        private void testExportWithProgressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestExportProgresBar));
        }

        private void createSampleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormToolCreateSampleTable));
        }

        private void testExportImportWithOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormExImWithOptions));
        }

        private void testBasicWithDefaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestSimple));
        }

        private void queryBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormQueryBrowser));
        }

        private void testProgressReportImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestImportProgressReport));
        }

        private void testEncryptDecryptDumpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestEncryptDecrypt));
        }

        private void testCustomExportOfTablesAndRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestCustomTablesExport));
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }

        private void testExportImportFromMemoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestExportImportMemory));
        }

        private void testExportImportWithZipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormTestZip));
        }

        private void decryptOldEncryptedDumpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FormDecryptOldDumpFile));
        }

    }
}
