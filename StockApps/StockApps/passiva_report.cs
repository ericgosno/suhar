using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockModel;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace StockApps
{
    public partial class passiva_report : Form
    {
        _neraca_passiva parent;
        DateTime tahun;
        public passiva_report(DateTime timeYear, _neraca_passiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
        }

        private void passiva_report_Load(object sender, EventArgs e)
        {
            string connectionString = "server=119.235.248.242; database=stockapps; uid=eric; pwd=eric;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            ReportDocument rptDoc = new ReportDocument();
            dsPassivaN ds = new dsPassivaN(); // .xsd file name
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter;
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlDataAdapter adapter2;
            MySqlCommand cmd3 = new MySqlCommand();
            MySqlDataAdapter adapter3;
            MySqlCommand cmd4 = new MySqlCommand();
            MySqlDataAdapter adapter4;
            //string query = "SELECT * from admin_history";
            String akhirTahun = tahun.ToString("yyyy-MM-dd");
            string query = "SELECT nourut,nota,nama,jumlah,tahun_passiva FROM stockapps.neraca_passiva_usaha where DATE(tahun_passiva) = '" + akhirTahun + "'";
            string query2 = "SELECT nourut,nota,nama,jumlah,tahun_passiva FROM stockapps.neraca_passiva_ppjk where DATE(tahun_passiva) = '" + akhirTahun + "'";
            string query3 = "SELECT nourut,keterangan,jumlah,tahun_passiva FROM stockapps.neraca_passiva_pajak where DATE(tahun_passiva) = '" + akhirTahun + "'";
            string query4 = "SELECT nourut,nama,jumlah,tahun_passiva FROM stockapps.neraca_passiva_saham where DATE(tahun_passiva) = '" + akhirTahun + "'";

            try
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                cmd2 = new MySqlCommand(query2, connection);
                adapter2 = new MySqlDataAdapter(cmd2);
                adapter2.Fill(dt2);

                cmd3 = new MySqlCommand(query3, connection);
                adapter3 = new MySqlDataAdapter(cmd3);
                adapter3.Fill(dt3);

                cmd4 = new MySqlCommand(query4, connection);
                adapter4 = new MySqlDataAdapter(cmd4);
                adapter4.Fill(dt4);
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
            ds.Tables[2].Merge(dt3);
            ds.Tables[3].Merge(dt4);
            // Your .rpt file path will be below

            //rptDoc.Load(Application.StartupPath + @"adminReport.rpt");
            rptDoc.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockApps\NeracaPassivaReport.rpt");
            //rptDoc.Load(@"C:\Users\3nc\Documents\Visual Studio 2010\Projects\Suhar\StockApps\StockApps\aReport.rpt");

            //set dataset to the report viewer.

            rptDoc.SetDataSource(ds);
            //rptDoc.SetParameterValue("AnualYear", tahun.ToString("dd-MMMM-yyyy"));
            crystalReportPassiva.ReportSource = rptDoc;
        }
    }
}
