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
            var listCurrency = CurrencyController.getCurrency();
            var query = CustomerTransaction.getCustomerTransaction(CustomerID, From, To);
            var list = query
                    .Join(listCurrency,
                     customer_transaction => customer_transaction.Currency_ID,
                     currency => currency.Currency_ID,
                     (customer_transaction, currency) => new { customer_transaction = customer_transaction, currency = currency })
                    .ToList()
                    .Select(join => new
                    {
                        Customer_Transaction_Note_Number = join.customer_transaction.Customer_Transaction_Note_Number + "",
                        Customer_Transaction_ID = join.customer_transaction.Customer_Transaction_ID + "",
                        Customer_Transaction_Date = join.customer_transaction.Customer_Transaction_Date.ToString("MMMM dd, yyyy") + "",
                        Customer_ID = CustomerController.getCustomer(Convert.ToInt32(join.customer_transaction.Customer_ID)).First().Customer_Name + "",
                        Customer_Transaction_Price = (join.customer_transaction.Currency_ID == 1 ? join.customer_transaction.Customer_Transaction_Total_Dollar.ToString("C2") : join.customer_transaction.Customer_Transaction_Total_Rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"))) + "",
                        Customer_Payment_Deadline_Date = join.customer_transaction.customer_payment.First().Customer_Payment_Deadline_Date.ToString("MMMM dd, yyyy") + "",
                        Payment_Category_Name = join.customer_transaction.customer_payment.First().payment_category.Payment_Category_Name + "",
                        Customer_Payment_Status = (join.customer_transaction.customer_payment.First().Customer_Payment_Status == 1) ? "Wait Payment" : "Finished"
                    })
                    .ToList();
            rptCust.SetDataSource(list);
            rptCust.SetParameterValue("DateFromTo", From.ToString("MMMM dd, yyyy") + " - " + To.ToString("MMMM dd, yyyy"));
            rptCust.SetParameterValue("CustomerName", (CustomerID == -1 ? "All Customer" : CustomerController.getCustomer(CustomerID).First().Customer_Name));
            _rptSelling.ReportSource = rptCust;
        }
    }
}
