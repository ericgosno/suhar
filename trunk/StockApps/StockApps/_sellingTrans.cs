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
    public partial class _sellingTrans : Form
    {
        private Dictionary<string, int> dictCustomer;
        private Dictionary<string, int> dictCurrency;
        private Dictionary<string, int> dictProduct;
        public _sellingTrans()
        {
            InitializeComponent();
            dictCustomer = new Dictionary<string, int>();
            var customerList = CustomerController.getCustomer();
            foreach (customer cust in customerList)
            {
                _cbsellNama.Items.Add(cust.Customer_Name);
                dictCustomer[cust.Customer_Name] = cust.Customer_ID;
            }
            var productList = ProductController.getProduct();
            List<string> listProd = new List<string>();
            dictProduct = new Dictionary<string, int>();
            foreach (product prod in productList)
            {
                listProd.Add(prod.Product_Name);
                dictProduct[prod.Product_Name] = prod.Product_ID;
            }

            dictCurrency = new Dictionary<string, int>();
            var listCurrency = CurrencyController.getCurrency();
            foreach (currency cur in listCurrency)
            {
                _cbsellKurs.Items.Add(cur.Currency_Name);
                dictCurrency[cur.Currency_Name] = cur.Currency_ID;
            }
            (_dataCusTransaction.Columns["Product"] as DataGridViewComboBoxColumn).DataSource = listProd;
        }

        private void RefreshData()
        {
            double totalRupiah = 0;
            double totalDollar = 0;
            for (int i = 0; i < _dataCusTransaction.Rows.Count; i++)
            {
                try
                {
                    if (_dataCusTransaction.Rows[i].Cells["Product"].Value == null) continue;
                    int prodId = dictProduct[_dataCusTransaction.Rows[i].Cells["Product"].Value.ToString()];
                    var list = ProductController.getProductByProductID(prodId);
                    if (list.Count() <= 0) return;
                    var prodNow = list.First();
                    int quantity = Convert.ToInt32(_dataCusTransaction.Rows[i].Cells["Quantity_Kg"].Value);
                    if (quantity > prodNow.Product_Stock)
                    {
                        _dataCusTransaction.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        _dataCusTransaction.Rows[i].ErrorText = "Insufficient Stock";
                    }
                    else
                    {
                        _dataCusTransaction.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                    _dataCusTransaction.Rows[i].Cells["Stock"].Value = prodNow.Product_Stock.ToString();
                    double priceperkg = Convert.ToDouble(_dataCusTransaction.Rows[i].Cells["Price_Kg"].Value);
                    _dataCusTransaction.Rows[i].Cells["Package_Quantity"].Value = Math.Ceiling(Convert.ToDouble(quantity) / Convert.ToDouble(prodNow.Product_Packing_Kilogram)).ToString() + " " + prodNow.Product_Packing_Name;
                    double dollar;
                    double rupiah;
                    if (dictCurrency[_cbsellKurs.SelectedItem.ToString()] == 1)
                    {
                        dollar = priceperkg * quantity;
                        rupiah = dollar * Convert.ToDouble(_tsellKurs.Text);
                    }
                    else
                    {
                        rupiah = priceperkg * quantity;
                        dollar = rupiah / Convert.ToDouble(_tsellKurs.Text); 
                    }

                    totalRupiah += rupiah;
                    totalDollar += dollar;
                    
                    _dataCusTransaction.Rows[i].Cells["Subtotal_Dollar"].Value = dollar.ToString("C2");
                    _dataCusTransaction.Rows[i].Cells["Subtotal_Rupiah"].Value = rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                }
                catch (Exception ex) { continue; }
            }
            _lsellRp.Text = totalRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lsellDollar.Text = totalDollar.ToString("C2");
            double ppnRupiah = 0.1 * totalRupiah;
            double ppnDollar = 0.1 * totalDollar;
            _lsellPPNRupiah.Text = ppnRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lsellPPNDollar.Text = ppnDollar.ToString("C2");
            double totalWithPPNRupiah = 1.1 * totalRupiah;
            double totalWithPPNDollar = 1.1 * totalDollar;
            _lsellTotalPPNDollar.Text = totalWithPPNDollar.ToString("C2");
            _lsellTotalPPNRupiah.Text = totalWithPPNRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void _sellingTrans_Load(object sender, EventArgs e)
        {

        }

        private void _dataCusTransaction_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData();
        }

        private void _tsellKurs_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void _bsellPay_Click(object sender, EventArgs e)
        {
            double totalDollar = 0;
            double totalRupiah = 0;

            List<customer_transaction_product> prod = new List<customer_transaction_product>();
            for (int i = 0; i < _dataCusTransaction.Rows.Count; i++)
            {
                try
                {
                    customer_transaction_product newProduct = new customer_transaction_product();
                    newProduct.Product_ID = dictProduct[_dataCusTransaction.Rows[i].Cells["Product"].Value.ToString()];
                    var list = ProductController.getProductByProductID(newProduct.Product_ID);
                    if (list.Count() <= 0) continue;
                    var prodNow = list.First();
                    int quantity = Convert.ToInt32(_dataCusTransaction.Rows[i].Cells["Quantity_Kg"].Value);
                    double priceperkg = Convert.ToDouble(_dataCusTransaction.Rows[i].Cells["Price_Kg"].Value);
                    _dataCusTransaction.Rows[i].Cells["Package_Quantity"].Value = Math.Ceiling(Convert.ToDouble(quantity) / Convert.ToDouble(prodNow.Product_Packing_Kilogram)).ToString() + " " + prodNow.Product_Packing_Name;
                    
                    double dollar;
                    double rupiah;
                    if (dictCurrency[_cbsellKurs.SelectedItem.ToString()] == 1)
                    {
                        newProduct.Customer_Transaction_Product_Price_Dollar = Convert.ToDecimal(priceperkg);
                        newProduct.Customer_Transaction_Product_Price_Rupiah = Convert.ToDecimal(priceperkg) * Convert.ToDecimal(_tsellKurs.Text);
                        dollar = priceperkg * quantity;
                        rupiah = dollar * Convert.ToDouble(_tsellKurs.Text);
                    }
                    else
                    {
                        newProduct.Customer_Transaction_Product_Price_Rupiah = Convert.ToDecimal(priceperkg);
                        newProduct.Customer_Transaction_Product_Price_Dollar = Convert.ToDecimal(priceperkg) / Convert.ToDecimal(_tsellKurs.Text);
                        rupiah = priceperkg * quantity;
                        dollar = rupiah / Convert.ToDouble(_tsellKurs.Text);
                    }

                    if (quantity > prodNow.Product_Stock)
                    {
                        MessageBox.Show("Not Sufficient Quantity! Please Fix");
                        return;
                    }
                    
                    
                    newProduct.Customer_Transaction_Product_Total_Dollar = Convert.ToDecimal(dollar);
                    newProduct.Customer_Transaction_Product_Total_Rupiah = Convert.ToDecimal(rupiah);
                    newProduct.Customer_Transaction_Product_Quantity = quantity;
                    
                    totalRupiah += rupiah;
                    totalDollar += dollar;
                    _dataCusTransaction.Rows[i].Cells["Subtotal_Dollar"].Value = dollar.ToString("C2");
                    _dataCusTransaction.Rows[i].Cells["Subtotal_Rupiah"].Value = rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                    prod.Add(newProduct);
                }
                catch (Exception ex) { continue; }
            }
            _lsellRp.Text = totalRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lsellDollar.Text = totalDollar.ToString("C2");
            double ppnRupiah = 0.1 * totalRupiah;
            double ppnDollar = 0.1 * totalDollar;
            _lsellPPNRupiah.Text = ppnRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lsellPPNDollar.Text = ppnDollar.ToString("C2");
            double totalWithPPNRupiah = 1.1 * totalRupiah;
            double totalWithPPNDollar = 1.1 * totalDollar;
            _lsellTotalPPNDollar.Text = totalWithPPNDollar.ToString("C2");
            _lsellTotalPPNRupiah.Text = totalWithPPNRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            CustomerTransaction.insertCustomerTransaction(_dtTransDate.Value, dictCustomer[_cbsellNama.SelectedItem.ToString()], totalDollar, totalRupiah, _tsellDescription.Text, prod, _tsellNoteNum.Text, dictCurrency[_cbsellKurs.SelectedItem.ToString()]);
            this.Close();
        }

        private void _bsellDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _dataCusTransaction.Rows.Remove(_dataCusTransaction.SelectedRows[0]);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _cbsellKurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
