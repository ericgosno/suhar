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
    public partial class _priceHistory : Form
    {
        public int productID;
        public _priceHistory(product productNow)
        {
            InitializeComponent();
            _lHistProdName.Text = productNow.Product_Name;
            _lHistSupplier.Text = productNow.supplier.Supplier_Company_Name;
            _lHistEndDate.Value = DateTime.Now;
            _lHistStartDate.Value = DateTime.Now.AddDays(-30);
            _lHistStatus.Checked = false;
            this.productID = productNow.Product_ID;
            RefreshQuery();
        }

        private void RefreshQuery()
        {
            try
            {
                product prodNow = ProductController.getProductByProductID(productID).First();
                
                var query = PriceHistoryController.getPriceHistory(prodNow.Product_ID, !(_lHistStatus.Checked), _lHistStartDate.Value, _lHistEndDate.Value);
                var listCurrency = CurrencyController.getCurrency();

                var list = query
                        .Join(listCurrency,
                         price_history => price_history.Currency_ID,
                         currency => currency.Currency_ID,
                         (price_history, currency) => new { price_history = price_history, currency = currency })
                        .OrderByDescending(join => join.price_history.Price_History_Date)
                        .AsEnumerable()
                        .Select(join => new
                        {
                            Price_History_ID = join.price_history.Price_History_ID + "",
                            Price_History_Date = join.price_history.Price_History_Date + "",
                            Price_History_Price = join.price_history.Price_History_Price  + " "  + join.currency.Currency_Name + "",
                            Price_History_Stock = join.price_history.Price_History_Stock + "",
                            Price_History_Used_Stock = join.price_history.Price_History_Used_Stock + "" ,
                            Price_History_Remaining_Stock = (join.price_history.Price_History_Stock - join.price_history.Price_History_Used_Stock) + ""
                        })
                        .ToList();
                _dataPriceHistory.DataSource = list;
                _dataPriceHistory.Columns["Price_History_Date"].HeaderText = "Date";
                _dataPriceHistory.Columns["Price_History_Price"].HeaderText = "Price";
                _dataPriceHistory.Columns["Price_History_Stock"].HeaderText = "Stock";
                _dataPriceHistory.Columns["Price_History_Used_Stock"].HeaderText = "Used Stock";
                _dataPriceHistory.Columns["Price_History_Remaining_Stock"].HeaderText = "Remaining Stock";
                _dataPriceHistory.Columns["Price_History_ID"].Visible = false;
                //_dataPriceHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex) { }
        }

        private void _lHistStartDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _lHistEndDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void _lHistStatus_CheckedChanged(object sender, EventArgs e)
        {
            RefreshQuery();
        }
    }
}
