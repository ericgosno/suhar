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
    public partial class _purchasingTransactionList : Form
    {
        public _purchasingTransactionList()
        {
            InitializeComponent();
            var listSupplier = SupplierController.getSupplier();
            _cbPurTransNama.DataSource = listSupplier;
            _cbPurTransNama.ValueMember = "Supplier_ID";
            _cbPurTransNama.DisplayMember = "Supplier_Name";
            _cbPurTransTo.Value = DateTime.Now;
            _cbPurTransFrom.Value = DateTime.Now.AddDays(-30);
            _lShowAll.Checked = true;
            _cbPurTransNama.Enabled = false;
            RefreshQuery();
        }

        private void RefreshQuery()
        {
            try
            {
                int supplierID = -1;
                if (!_lShowAll.Checked)
                    supplierID = Convert.ToInt32(_cbPurTransNama.SelectedValue);
                var query = SupplierTransaction.getSupplierTransaction(supplierID, _cbPurTransFrom.Value, _cbPurTransTo.Value);
                var listCurrency = CurrencyController.getCurrency();
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
                            Supplier_Transaction_Price = (join.supplier_transaction.Currency_ID == 1 ? join.supplier_transaction.Supplier_Transaction_Total_Dollar.ToString("C2") : join.supplier_transaction.Supplier_Transaction_Total_Rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"))) + "",
                            Supplier_Payment_Deadline_Date = join.supplier_transaction.supplier_payment.First().Supplier_Payment_Deadline_Date.ToString("MMMM dd, yyyy") + "",
                            Payment_Category_Name = join.supplier_transaction.supplier_payment.First().payment_category.Payment_Category_Name + "",
                            Supplier_Payment_Status = (join.supplier_transaction.supplier_payment.First().Supplier_Payment_Status == 1) ? "Wait Payment" : "Finished",
                            Supplier_Transaction_Invoice_Number = join.supplier_transaction.Supplier_Transaction_Invoice_Number + ""
                        })
                        .ToList();

                _dataPriceHistory.DataSource = list;
                _dataPriceHistory.Columns["Supplier_Transaction_Date"].HeaderText = "Date";
                _dataPriceHistory.Columns["Supplier_Transaction_Price"].HeaderText = "Price";
                _dataPriceHistory.Columns["Supplier_Transaction_Note_Number"].HeaderText = "Note Number";
                _dataPriceHistory.Columns["Supplier_Transaction_Invoice_Number"].HeaderText = "Invoice Number";
                _dataPriceHistory.Columns["Payment_Category_Name"].HeaderText = "Payment Method";
                _dataPriceHistory.Columns["Supplier_Payment_Deadline_Date"].HeaderText = "Payment Deadline";
                _dataPriceHistory.Columns["Supplier_Payment_Status"].HeaderText = "Status";
                _dataPriceHistory.Columns["Supplier_Transaction_ID"].Visible = false;

                _dataPriceHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex) { }
        }

        private void _lShowAll_CheckedChanged(object sender, EventArgs e)
        {
            _cbPurTransNama.Enabled = !(_lShowAll.Checked);
            RefreshQuery();
        }

        private void _cbPurTransNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _cbPurTransFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _cbPurTransTo_ValueChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _bPurTransPrint_Click(object sender, EventArgs e)
        {
            int supplierID = -1;
            if (!_lShowAll.Checked)
                supplierID = Convert.ToInt32(_cbPurTransNama.SelectedValue);
            _PurchasingReportViewer nextForm = new _PurchasingReportViewer(supplierID, _cbPurTransFrom.Value, _cbPurTransTo.Value);
            nextForm.Show();
        }
    }
}
