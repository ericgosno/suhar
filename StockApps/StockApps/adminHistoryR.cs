using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace StockApps
{
    public partial class adminHistoryR : Form
    {
        public adminHistoryR()
        {
            InitializeComponent();
        }

        private void adminHistoryR_Load(object sender, EventArgs e)
        {
            string connectionString = "server=119.235.248.242; database=stockapps; uid=eric; pwd=eric;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            ReportDocument rptDoc = new ReportDocument();
            dsAdmin ds = new dsAdmin(); // .xsd file name
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter;
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlDataAdapter adapter2;
            string query = "SELECT * from admin_history";
            string query2 = "SELECT users_id,users_username from users";
            try
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                cmd2 = new MySqlCommand(query2, connection);
                adapter2 = new MySqlDataAdapter(cmd2);
                adapter2.Fill(dt2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            ds.Tables[0].Merge(dt);
            ds.Tables[1].Merge(dt2);

            // Your .rpt file path will be below
            
            //rptDoc.Load(Application.StartupPath + @"adminReport.rpt");
            //rptDoc.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockApps\adminReport.rpt");
            rptDoc.Load(@"C:\Users\3nc\Documents\Visual Studio 2010\Projects\Suhar\StockApps\StockApps\adminReport.rpt");

            //set dataset to the report viewer.
            rptDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptDoc;
        }

    
    }
}
