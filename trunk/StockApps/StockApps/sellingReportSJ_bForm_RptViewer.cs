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
    public partial class sellingReportSJ_bForm_RptViewer : Form
    {
        public String ID_Trans;
        public sellingReportSJ_bForm_RptViewer(String Trans_ID)
        {
            InitializeComponent();
            ID_Trans = Trans_ID;
        }

        private void sellingReportSJ_bForm_RptViewer_Load(object sender, EventArgs e)
        {
            sellingReportSJ_cViewer rptSJ = new sellingReportSJ_cViewer();
            identity identityNow = IdentityController.getIdentity();

            customer_transaction transNow = CustomerTransaction.getCustomerTransaction(ID_Trans).First();
            var custNow = transNow.customer;
            
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

            rptSJ.SetDataSource(transprod);
            rptSJ.SetParameterValue("identityCompany", identityNow.Identity_Company_Name);
            rptSJ.SetParameterValue("identityCity", identityNow.Identity_City);
            rptSJ.SetParameterValue("IdentityName", identityNow.Identity_Name);
            rptSJ.SetParameterValue("TransactionDate", transNow.Customer_Transaction_Date.ToString("D", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")));
            rptSJ.SetParameterValue("TransactionNoteNumber", transNow.Customer_Transaction_Note_Number);
            rptSJ.SetParameterValue("CustomerCompany", custNow.Customer_Company_Name);
            rptSJ.SetParameterValue("CustomerAddress", custNow.Customer_Address);
           _rptSRSuratJalan.ReportSource = rptSJ;
        }
    }
}
