using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockModel;

namespace StockApps
{
    public partial class _sellingReportViewer : Form
    {
        public _sellingReportViewer(int CustomerID,DateTime From, DateTime To)
        {
            InitializeComponent();
            sellingReportCustomer rptCust = new sellingReportCustomer();
            var transNow = CustomerTransaction.getCustomerTransaction(CustomerID, From, To).ToList();
            rptCust.SetDataSource(transNow);
            rptCust.SetParameterValue("DateFromTo", From.ToString("MMMM dd, yyyy") + " - " + To.ToString("MMMM dd, yyyy"));
            rptCust.SetParameterValue("CustomerName", (CustomerID == -1 ? "All Customer" : CustomerController.getCustomer(CustomerID).First().Customer_Name));
            _rptSelling.ReportSource = rptCust;
        }
    }
}
