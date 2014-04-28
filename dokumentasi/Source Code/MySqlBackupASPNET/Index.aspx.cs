using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;
using System.IO.Compression;

namespace MySqlBackupASPNET
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btExport_Click(object sender, EventArgs e)
        {
            try
            {
                string output = "";

                using (MemoryStream ms = new MemoryStream())
                {
                    using (TextWriter tw = new StreamWriter(ms, new UTF8Encoding(false)))
                    {
                        using (MySqlConnection conn = new MySqlConnection(txtConnString.Text))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();

                                    mb.ExportToTextWriter(tw);

                                    conn.Close();

                                    output = Encoding.UTF8.GetString(ms.ToArray());
                                }
                            }
                        }
                    }
                }

                if (output.Length > (1024 * 100))
                {
                    lbError.Text = "The length of the output file has exceeded 100KB maximum length limit.<br />Try to use a smaller size of MySQL database sample.";
                    lbError.Visible = true;
                }
                else
                {
                    StoreFile.StoreSqlText(output);
                    Server.Transfer("~/Result.aspx", true);
                }
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;
                lbError.Visible = true;
            }
        }

        protected void btImport(object sender, EventArgs e)
        {
            try
            {
                if (!FileUpload1.HasFile)
                {
                    return;
                }

                byte[] ba = FileUpload1.FileBytes;

                if (FileUpload1.FileName.ToLower().EndsWith(".zip"))
                {
                    MemoryStream ms1 = new MemoryStream(ba);
                    ZipStorer zip = ZipStorer.Open(ms1, FileAccess.Read);
                    List<ZipStorer.ZipFileEntry> dir = zip.ReadCentralDir();
                    MemoryStream ms2 = new MemoryStream();
                    zip.ExtractFile(dir[0], ms2);
                    zip.Close();
                    ba = ms2.ToArray();
                }

                using (MemoryStream ms = new MemoryStream(ba))
                {
                    using (TextReader tr = new StreamReader(ms))
                    {
                        using (MySqlConnection conn = new MySqlConnection(txtConnString.Text))
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

                Response.Write("<script type=\"text/javascript\">alert('Import completed.');</script>");
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;
                lbError.Visible = true;
            }
        }
    }
}