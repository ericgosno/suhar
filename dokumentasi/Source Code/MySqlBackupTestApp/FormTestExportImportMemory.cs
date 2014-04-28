using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace MySqlBackupTestApp
{
    public partial class FormTestExportImportMemory : Form
    {
        byte[] _ba = null;

        public FormTestExportImportMemory()
        {
            InitializeComponent();
            ClearMemory();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            try
            {
                UTF8Encoding utf8Encoding = new UTF8Encoding(false);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (TextWriter tw = new StreamWriter(ms, utf8Encoding))
                    {
                        using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    conn.Open();
                                    cmd.Connection = conn;

                                    mb.ExportToTextWriter(tw);
                                    LoadIntoMemory(ms.ToArray());

                                    conn.Close();
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Finished.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ba == null || _ba.Length == 0)
                {
                    MessageBox.Show("No content is loaded into memory, cannot perform Import/Restore task.");
                    return;
                }

                using (MemoryStream ms = new MemoryStream(_ba))
                {
                    using (TextReader tr = new StreamReader(ms))
                    {
                        using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();

                                    mb.ImportFromTextReader(tr);

                                    conn.Close();
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Finished.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void LoadIntoMemory(byte[] ba)
        {
            if (ba == null || ba.Length == 0)
            {
                ClearMemory();
            }
            else
            {
                _ba = ba;
                lbStatus.Text = "Dump file is loaded into memory.";
                lbStatus.ForeColor = Color.DarkGreen;
                btImport.Enabled = true;
            }
        }

        void ClearMemory()
        {
            _ba = null;
            lbStatus.Text = "No dump file loaded in memory.";
            lbStatus.ForeColor = Color.Black;
            btImport.Enabled = false;
        }

        private void btLoadFile_Click(object sender, EventArgs e)
        {
            if (!Program.SourceFileExists())
                return;

            byte[] ba = File.ReadAllBytes(Program.TargetFile);

            LoadIntoMemory(ba);

            MessageBox.Show("Dump file is loaded into memory.");
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearMemory();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ba == null || _ba.Length == 0)
                {
                    MessageBox.Show("No content is loaded into memory, nothing to save.");
                    return;
                }

                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "*.sql|*.sql|*.*|*.*";
                f.FileName = "MemoryDump.sql";
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllBytes(f.FileName, _ba);
                }
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}