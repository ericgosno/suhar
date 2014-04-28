using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Compression;
using System.IO;
using System.Text;

namespace MySqlBackupASPNET
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (PreviousPage == null)
                {
                    Response.Redirect("http://mysqlbackup.somee.com/", true);
                    Session.Clear();
                    Session.Abandon();
                    return;
                }

                string dumpcontent = Server.HtmlEncode(StoreFile.GetSqlText());
                PlaceHolder1.Controls.Add(new LiteralControl(dumpcontent));
            }
        }

        protected void btDownload_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AppendHeader("content-disposition", "attachment; filename=MyZip.zip");
            Response.ContentType = "application/zip";
            Response.BinaryWrite(StoreFile.GetZipFile());
            Response.End();
        }
    }
}