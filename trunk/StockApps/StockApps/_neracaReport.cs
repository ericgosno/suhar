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
    public partial class _neracaReport : Form
    {
        _neraca_aktiva parent;
        DateTime tahun;
        public _neracaReport(DateTime timeYear, _neraca_aktiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
        }

        private void _neracaReport_Load(object sender, EventArgs e)
        {
            /*
            neraca_aktiva aktiva = NeracaAktiva.getAllAktiva().First();

            try{
                neracaReport rptNeraca = new neracaReport();
                var listProd = NeracaAktiva.getAllProduct();
                var neracaProduk = listProd
                    .AsEnumerable()
                    .Select(neraca_aktiva_all_product => new 
                    {
                        bg = neraca_aktiva_all_product.bg + "",
                        id_allproduct = neraca_aktiva_all_product.id_allproduct + "",
                        nama = neraca_aktiva_all_product.nama + "",
                        jumlah = neraca_aktiva_all_product.jumlah + "",
                    })
                    .ToList();
                rptNeraca.SetDataSource(neracaProduk);
                //rptNeraca.SetParameterValue("tahun", aktiva.tahun_aktiva);
                rptNeraca.SetParameterValue("tahunan", aktiva.tahun_aktiva.Value.ToString("dd MMMM yyyy"));
                crystalReportViewerNeraca.ReportSource = rptNeraca;
            }
         
           
              catch (Exception ex) { MessageBox.Show(ex.Message); }
             * */
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StockApps.Properties.Settings.stockappsConnectionString"].ToString();

            //string connectionString = "server=119.235.248.242; database=stockapps; uid=eric; pwd=eric;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            neracaReport rptDoc = new neracaReport();
            dsNeraca ds = new dsNeraca(); // .xsd file name
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
            string query = "SELECT id_allproduct,nama,bg,jumlah FROM stockapps.neraca_aktiva_allproduct where DATE(tahun_aktiva) = '"+ akhirTahun +"'";
            string query2 = "SELECT id_allkas,nama,dollar,rupiah,tahun_aktiva FROM stockapps.neraca_aktiva_allkas where DATE(tahun_aktiva) = '" + akhirTahun + "'";
            string query3 = "SELECT id_allpiutang,nama,nota,jumlah,tahun_aktiva FROM stockapps.neraca_aktiva_allpiutang where DATE(tahun_aktiva) = '" + akhirTahun + "'";
            string query4 = "SELECT id_allinventaris,nama,jumlah,status,tahun_aktiva FROM stockapps.neraca_aktiva_allinventaris where DATE(tahun_aktiva) = '" + akhirTahun + "'";
           
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
            //rptDoc.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockApps\neracaReport.rpt");
            //rptDoc.Load(@"C:\Users\3nc\Documents\Visual Studio 2010\Projects\Suhar\StockApps\StockApps\aReport.rpt");

            //set dataset to the report viewer.
           
            rptDoc.SetDataSource(ds);
            rptDoc.SetParameterValue("AnualYear", tahun.ToString("dd-MMMM-yyyy"));
            crystalReportViewerNeraca.ReportSource = rptDoc;
        }
    }
}
