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
    public partial class _PurchasingReportViewer : Form
    {
        public _PurchasingReportViewer(int SupplierID, DateTime From, DateTime To)
        {
            InitializeComponent();
            purchasingSupplierReport rptCust = new purchasingSupplierReport();
            var listCurrency = CurrencyController.getCurrency();
            var query = SupplierTransaction.getSupplierTransaction(SupplierID, From, To);
            var list = query
                    .Join(listCurrency,
                     supplier_transaction => supplier_transaction.Currency_ID,
                     currency => currency.Currency_ID,
                     (supplier_transaction, currency) => new { supplier_transaction = supplier_transaction, currency = currency })
                    .ToList()
                    .Select(join => new
                    {
                        Supplier_Transaction_Note_Number = join.supplier_transaction.Supplier_Transaction_Note_Number + "",
                        Supplier_Transaction_ID = join.supplier_transaction.Supplier_Transaction_ID + "",
                        Supplier_Transaction_Date = join.supplier_transaction.Supplier_Transaction_Date.ToString("MMMM dd, yyyy") + "",
                        Supplier_ID = SupplierController.getSupplier(Convert.ToInt32(join.supplier_transaction.Supplier_ID)).First().Supplier_Name + "",
                        Supplier_Transaction_Price = (join.supplier_transaction.Currency_ID == 1 ? join.supplier_transaction.Supplier_Transaction_Total_Dollar.ToString("C2") : join.supplier_transaction.Supplier_Transaction_Total_Rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"))) + "",
                        Supplier_Payment_Deadline_Date = join.supplier_transaction.supplier_payment.First().Supplier_Payment_Deadline_Date.ToString("MMMM dd, yyyy") + "",
                        Payment_Category_Name = join.supplier_transaction.supplier_payment.First().payment_category.Payment_Category_Name + "",
                        Supplier_Payment_Status = (join.supplier_transaction.supplier_payment.First().Supplier_Payment_Status == 1) ? "Wait Payment" : "Finished"
                    })
                    .ToList();
            rptCust.SetDataSource(list);
            rptCust.SetParameterValue("DateFromTo", From.ToString("MMMM dd, yyyy") + " - " + To.ToString("MMMM dd, yyyy"));
            rptCust.SetParameterValue("SupplierName", (SupplierID == -1 ? "All Supplier" : SupplierController.getSupplier(SupplierID).First().Supplier_Name));
            _rptPurchasing.ReportSource = rptCust;
        }
    }
}
