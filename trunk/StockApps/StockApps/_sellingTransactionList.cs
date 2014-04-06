﻿using System;
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
    public partial class _sellingTransactionList : Form
    {
        public _sellingTransactionList()
        {
            InitializeComponent();
            var listCustomer = CustomerController.getCustomer();
            _cbSellTransNama.DataSource = listCustomer;
            _cbSellTransNama.ValueMember = "Customer_ID";
            _cbSellTransNama.DisplayMember = "Customer_Name";
            _cbSellTransTo.Value = DateTime.Now;
            _cbSellTransFrom.Value = DateTime.Now.AddDays(-30);
            _lShowAll.Checked = true;
            _cbSellTransNama.Enabled = false;
            RefreshQuery();
        }

        private void RefreshQuery()
        {
            try
            {
                int customerID = -1;
                if (!_lShowAll.Checked) 
                    customerID = Convert.ToInt32(_cbSellTransNama.SelectedValue);
                var query = CustomerTransaction.getCustomerTransaction(customerID, _cbSellTransFrom.Value, _cbSellTransTo.Value);
                var listCurrency = CurrencyController.getCurrency();
                var list = query
                        .Join(listCurrency,
                         customer_transaction => customer_transaction.Currency_ID,
                         currency => currency.Currency_ID,
                         (customer_transaction, currency) => new { customer_transaction = customer_transaction, currency = currency })
                        .AsEnumerable()
                        .Select(join => new
                        {
                            Customer_Transaction_Note_Number = join.customer_transaction.Customer_Transaction_Note_Number + "",
                            Customer_Transaction_ID = join.customer_transaction.Customer_Transaction_ID + "",
                            Customer_Transaction_Date = join.customer_transaction.Customer_Transaction_Date + "",
                            Customer_Transaction_Price = (join.customer_transaction.Currency_ID == 1 ? join.customer_transaction.Customer_Transaction_Total_Dollar.ToString("C2") : join.customer_transaction.Customer_Transaction_Total_Rupiah.ToString("C2",System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"))) + "",
                        })
                        .ToList();

                _dataPriceHistory.DataSource = list;
                _dataPriceHistory.Columns["Customer_Transaction_Date"].HeaderText = "Date";
                _dataPriceHistory.Columns["Customer_Transaction_Price"].HeaderText = "Price";
                _dataPriceHistory.Columns["Customer_Transaction_Note_Number"].HeaderText = "Stock";

                _dataPriceHistory.Columns["Customer_Transaction_ID"].Visible = false;

                //_dataPriceHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex) { }
        }


        private void _lShowAll_CheckedChanged(object sender, EventArgs e)
        {
            _cbSellTransNama.Enabled = !(_lShowAll.Checked);
            RefreshQuery();
        }

        private void _cbSellTransNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _cbSellTransFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _cbSellTransTo_ValueChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _bSellTransSJ_Click(object sender, EventArgs e)
        {
            //try
          //  {
                DataGridViewRow rowNow = null;
                if (_dataPriceHistory.CurrentCell != null)
                {
                    rowNow = _dataPriceHistory.SelectedCells[0].OwningRow;
                }
                else if (_dataPriceHistory.CurrentRow != null)
                {
                    rowNow = _dataPriceHistory.SelectedRows[0];
                }
                string transID = rowNow.Cells["Customer_Transaction_ID"].Value.ToString();
                customer_transaction transNow = CustomerTransaction.getCustomerTransaction(transID).First();
                sellingReportSJ_bForm_RptViewer nextForm = new sellingReportSJ_bForm_RptViewer(transID);
                nextForm.Show();
           // }
            //catch (Exception ex)
           // {
             //   MessageBox.Show("You must select a Row First!");
           // }
        }

        private void _bSellTransPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
