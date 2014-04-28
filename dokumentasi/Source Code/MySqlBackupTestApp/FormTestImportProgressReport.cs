using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlBackupTestApp
{
    public partial class FormTestImportProgressReport : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlBackup mb;
        Timer timer1;
        BackgroundWorker bwImport;

        int curBytes;
        int totalBytes;

        public FormTestImportProgressReport()
        {
            InitializeComponent();

            mb = new MySqlBackup();
            mb.ImportProgressChanged += mb_ImportProgressChanged;

            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;

            bwImport = new BackgroundWorker();
            bwImport.DoWork += bwImport_DoWork;
            bwImport.RunWorkerCompleted += bwImport_RunWorkerCompleted;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            if (!Program.SourceFileExists())
                return;

            curBytes = 0;
            totalBytes = 0;

            conn = new MySqlConnection(Program.ConnectionString);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();

            timer1.Start();

            mb.ImportInfo.IntervalForProgressReport = (int)nmImInterval.Value;
            mb.Command = cmd;

            bwImport.RunWorkerAsync();
        }

        void bwImport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                mb.ImportFromFile(Program.TargetFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = totalBytes;
            progressBar1.Value = curBytes;

            lbStatus.Text = progressBar1.Value + " of " + progressBar1.Maximum;
        }

        void mb_ImportProgressChanged(object sender, ImportProgressArgs e)
        {
            totalBytes = (int)e.TotalBytes;
            curBytes = (int)e.CurrentBytes;
        }

        void bwImport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CloseConnection();

            System.Threading.Thread.Sleep(100); // Wait for the timer to do the last progressbar update.

            if (mb.LastError == null)
                MessageBox.Show("Completed.");
            else
                MessageBox.Show("Completed with error(s)." + Environment.NewLine + Environment.NewLine + mb.LastError.ToString());

            timer1.Stop();
        }

        void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }

            if (cmd != null)
                cmd.Dispose();

            if (mb != null)
                mb.StopAllProcess();
        }
    }
}
