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
using StockModel;

namespace StockApps
{
    public partial class sellingReportFPajak_bForm_RptViewer : Form
    {
        public String ID_Trans;
        public sellingReportFPajak_bForm_RptViewer(String Trans_ID)
        {
            InitializeComponent();
            ID_Trans = Trans_ID;
        }

        private void sellingReportFPajak_bForm_RptViewer_Load(object sender, EventArgs e)
        {
            sellingReportFPajak_cViewer rptFP = new sellingReportFPajak_cViewer();
            identity identityNow = IdentityController.getIdentity();

            customer_transaction transNow = CustomerTransaction.getCustomerTransaction(ID_Trans).First();
            var custNow = transNow.customer;

            string connectionString = "server=119.235.248.242; database=stockapps; uid=eric; pwd=eric;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            dsSellingFakturPenjualan ds = new dsSellingFakturPenjualan(); // .xsd file name
            DataTable dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter;
            string query = "SELECT DISTINCT a.Customer_Transaction_ID,a. Product_ID, u.Product_Name, a.Customer_Transaction_Product_Quantity,u.Product_Packing_Name,u.Product_Packing_Kilogram, a.Customer_Transaction_Product_Price_Dollar, a.Customer_Transaction_Product_Total_Dollar,a.Customer_Transaction_Product_Total_Rupiah FROM stockapps.customer_transaction_product a, stockapps.product u where a.Customer_Transaction_ID = '" + ID_Trans + "' and a.Product_ID = u.Product_ID;";
            try
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
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
            rptFP.SetDataSource(ds);

            /*
            var listProduct = ProductController.getProduct();
            var listTransProd = transNow.customer_transaction_product;

            var transprod = listTransProd
                .Join(listProduct,
                customer_transaction_product => customer_transaction_product.Product_ID,
                product => product.Product_ID,
                (customer_transaction_product, product) => new { customer_transaction_product = customer_transaction_product, product = product })
                .AsEnumerable()
                .Select(join => new
                {
                    Customer_Transaction_ID = join.customer_transaction_product.Customer_Transaction_ID + "",
                    Product_ID = join.customer_transaction_product.Product_ID + "",
                    Product_Name = join.product.Product_Name + "",
                    Customer_Transaction_Product_Quantity = join.customer_transaction_product.Customer_Transaction_Product_Quantity + "",
                    Product_Packing_Name = join.product.Product_Packing_Name + "",
                    Product_Packing_Kilogram = join.product.Product_Packing_Kilogram + "",
                });

            rptFP.SetDataSource(transprod);
             * */
            rptFP.SetParameterValue("identityCompany", identityNow.Identity_Company_Name);
            rptFP.SetParameterValue("identityCity", identityNow.Identity_City);
            rptFP.SetParameterValue("identityName", identityNow.Identity_Name);
            rptFP.SetParameterValue("identityAddress", identityNow.Identity_Address);
            rptFP.SetParameterValue("TransactionDate", transNow.Customer_Transaction_Date.ToString("D", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")));
            rptFP.SetParameterValue("TransactionNoteNumber", transNow.Customer_Transaction_Note_Number);
            rptFP.SetParameterValue("CustomerCompany", custNow.Customer_Company_Name);
            rptFP.SetParameterValue("CustomerAddress", custNow.Customer_Address);
            rptFP.SetParameterValue("CustomerNpwp", custNow.Customer_NPWP);
            _rptSRFakturPajak.ReportSource = rptFP;
        }
    }
}
