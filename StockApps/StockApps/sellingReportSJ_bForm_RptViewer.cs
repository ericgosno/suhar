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
    public partial class sellingReportSJ_bForm_RptViewer : Form
    {
        public String ID_Trans;
        public String ID_Cus;
        public sellingReportSJ_bForm_RptViewer(String Trans_ID, String Cus_ID)
        {
            InitializeComponent();
            ID_Trans = Trans_ID;
            ID_Cus = Cus_ID;
        }

        private void sellingReportSJ_bForm_RptViewer_Load(object sender, EventArgs e)
        {
            string connectionString = "server=119.235.248.242; database=stockapps; uid=eric; pwd=eric;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            ReportDocument rptDoc = new ReportDocument();
            dsSellingSuratJalan ds = new dsSellingSuratJalan(); // .xsd file name
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
            string query = "SELECT Customer_ID, Customer_Company_Name, Customer_Address FROM stockapps.customer where Customer_ID = " + ID_Cus;
            string query2 = "SELECT Customer_Transaction_ID, Customer_ID, Customer_Transaction_Date, Customer_Transaction_Note_Number FROM stockapps.customer_transaction where Customer_Transaction_ID = '" + ID_Trans + "'";
            string query3 = "SELECT DISTINCT a.Customer_Transaction_ID,a. Product_ID, u.Product_Name, a.Customer_Transaction_Product_Quantity,u.Product_Packing_Name,u.Product_Packing_Kilogram FROM stockapps.customer_transaction_product a, stockapps.product u where a.Customer_Transaction_ID = '" + ID_Trans + "' and a.Product_ID = u.Product_ID;";
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
            rptDoc.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockApps\sellingReportSJ_cViewer.rpt");
            //rptDoc.Load(@"C:\Users\3nc\Documents\Visual Studio 2010\Projects\Suhar\StockApps\StockApps\adminReport.rpt");

            //set dataset to the report viewer.
            rptDoc.SetDataSource(ds);
           _rptSRSuratJalan.ReportSource = rptDoc;
        }
    }
}
