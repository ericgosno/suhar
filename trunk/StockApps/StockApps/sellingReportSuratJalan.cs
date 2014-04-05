using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using StockModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace StockApps
{
    public partial class sellingReportSuratJalan : Form
    {
        public String _NOTAID;
        public String _CUSID;
        public sellingReportSuratJalan(String NotaID, String Cus_ID)
        {
            InitializeComponent();
            _NOTAID = NotaID;
            _CUSID = Cus_ID;
        }

        private void sellingReportSuratJalan_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_NOTAID);
            string connectionString = "server=119.235.248.242; database=stockapps; uid=eric; pwd=eric;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            ReportDocument rptDoc = new ReportDocument();
            dsSellingSJ ds = new dsSellingSJ();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter;
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlDataAdapter adapter2;
            MySqlCommand cmd3 = new MySqlCommand();
            MySqlDataAdapter adapter3;
            //string query = "SELECT * from admin_history";
            string query = "SELECT Customer_ID,Customer_Company_Name,Customer_Address from stockapps.customer where Customer_ID = '" + _CUSID + "'";
            string query2 = "SELECT Customer_Transaction_ID,Customer_ID,Customer_Transaction_Date,Customer_Transaction_note_Number from stockapps.customer_transaction where Customer_Transaction_ID = '" + _NOTAID + "'";
            string query3 = "SELECT DISTINCT a.Customer_Transaction_ID,a. Product_ID, u.Product_Name, a.Customer_Transaction_Product_Quantity,u.Product_Packing_Name,u.Product_Packing_Kilogram FROM stockapps.customer_transaction_product a, stockapps.product u where a.Customer_Transaction_ID = '" + _NOTAID + "'  and a.Product_ID = u.Product_ID;";

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
            // Your .rpt file path will be below

            //rptDoc.Load(Application.StartupPath + @"adminReport.rpt");
            rptDoc.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockApps\sellingReportSuratJalanView.rpt");
            //rptDoc.Load(@"C:\Users\3nc\Documents\Visual Studio 2010\Projects\Suhar\StockApps\StockApps\adminReport.rpt");

            //set dataset to the report viewer.
            rptDoc.SetDataSource(ds);
            _rptSellingSJ.ReportSource = rptDoc;
        }

    }
}
