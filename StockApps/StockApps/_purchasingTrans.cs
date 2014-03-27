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
    public partial class _purchasingTrans : Form
    {
        public _purchasingTrans()
        {
            InitializeComponent();
            var listSupplier = SupplierController.getSupplier();
            _cbpurNama.DataSource = listSupplier;
            _cbpurNama.DisplayMember = "Supplier_Company_Name";
            _cbpurNama.ValueMember = "Supplier_ID";
            _cbpurKurs.DataSource = CurrencyController.getCurrency();
            _cbpurKurs.DisplayMember = "Currency_Name";
            _cbpurKurs.ValueMember = "Currency_ID";
            refreshListProduct();
        }

        private void refreshListProduct()
        {
            try
            {
                _dataSupTransaction.Rows.Clear();
                _lpurDollar.Text = "0";
                _lpurRp.Text = "0";
                var listProduct = ProductController.getProductBySupplierID(Convert.ToInt32((_cbpurNama.SelectedValue)));
                (_dataSupTransaction.Columns["Product"] as DataGridViewComboBoxColumn).DataSource = listProduct;
                (_dataSupTransaction.Columns["Product"] as DataGridViewComboBoxColumn).DisplayMember = "Product_Name";
                (_dataSupTransaction.Columns["Product"] as DataGridViewComboBoxColumn).ValueMember = "Product_ID";
            }
            catch (Exception ex) { }
        }
        private void _purchasingTrans_Load(object sender, EventArgs e)
        {

        }

        private void _cbpurNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshListProduct();
        }

        private void RefreshData()
        {
            double totalRupiah = 0;
            double totalDollar = 0;
            for (int i = 0; i < _dataSupTransaction.Rows.Count; i++)
            {
                try
                {
                    int prodId = Convert.ToInt32((_dataSupTransaction.Rows[i].Cells["Product"] as DataGridViewComboBoxCell).Value);
                    var list = ProductController.getProductByProductID(prodId);
                    if (list.Count() <= 0) 
                        continue;
                    var prodNow = list.First();
                    int quantity = Convert.ToInt32(_dataSupTransaction.Rows[i].Cells["Quantity_Kg"].Value);
                    double priceperkg = Convert.ToDouble(prodNow.Product_Buy_Price);
                    _dataSupTransaction.Rows[i].Cells["Package_Quantity"].Value = Math.Ceiling(Convert.ToDouble(quantity) / Convert.ToDouble(prodNow.Product_Packing_Kilogram)).ToString() + " " + prodNow.Product_Packing_Name;
                    _dataSupTransaction.Rows[i].Cells["Price_Kg"].Value = prodNow.Product_Buy_Price.ToString() + " " + prodNow.currency.Currency_Name;
                    double dollar = 0;
                    double rupiah = 0;
                    if (prodNow.Currency_ID == 1)
                    {
                        dollar = priceperkg * quantity;
                        rupiah = dollar * Convert.ToDouble(_tpurKurs.Text);
                    }
                    else
                    {
                        rupiah = priceperkg * quantity;
                        dollar = rupiah / Convert.ToDouble(_tpurKurs.Text);
                    }

                    totalRupiah += rupiah;
                    totalDollar += dollar;
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Dollar"].Value = dollar.ToString("C2");
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Rupiah"].Value = rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                }
                catch (Exception ex) { continue; }
            }
            _lpurRp.Text = totalRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")); 
            _lpurDollar.Text = totalDollar.ToString("C2");
            _lpurPPNRupiah.Text = (totalRupiah * 0.1).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lpurPPNDollar.Text = (totalDollar * 0.1).ToString("C2");
            _lpurTotalPPNDollar.Text = (totalDollar * 1.1).ToString("C2");
            _lpurTotalPPNRupiah.Text = (totalRupiah * 1.1).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
        }
        private void _dataSupTransaction_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData();
        }

        private void _tpurKurs_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void _bpurPay_Click(object sender, EventArgs e)
        {
            double totalDollar = 0;
            double totalRupiah = 0;

            List<supplier_transaction_product> prod = new List<supplier_transaction_product>();
            for (int i = 0; i < _dataSupTransaction.Rows.Count; i++)
            {
                try
                {
                    supplier_transaction_product newProduct = new supplier_transaction_product();
                    newProduct.Product_ID = Convert.ToInt32((_dataSupTransaction.Rows[i].Cells["Product"] as DataGridViewComboBoxCell).Value);
                    var list = ProductController.getProductByProductID(newProduct.Product_ID);
                    if (list.Count() <= 0) continue;
                    var prodNow = list.First();
                    int quantity = Convert.ToInt32(_dataSupTransaction.Rows[i].Cells["Quantity_Kg"].Value);
                    double priceperkg = Convert.ToDouble(prodNow.Product_Buy_Price);
                    _dataSupTransaction.Rows[i].Cells["Package_Quantity"].Value = Math.Ceiling(Convert.ToDouble(quantity) / Convert.ToDouble(prodNow.Product_Packing_Kilogram)).ToString() + " " + prodNow.Product_Packing_Name;
                    _dataSupTransaction.Rows[i].Cells["Price_Kg"].Value = prodNow.Product_Buy_Price.ToString() + " " + prodNow.currency.Currency_Name;
                    double dollar = 0;
                    double rupiah = 0;
                    if (prodNow.Currency_ID == 1)
                    {
                        dollar = priceperkg * quantity;
                        rupiah = dollar * Convert.ToDouble(_tpurKurs.Text);
                    }
                    else
                    {
                        rupiah = priceperkg * quantity;
                        dollar = rupiah / Convert.ToDouble(_tpurKurs.Text);
                    }
                    newProduct.Supplier_Transaction_Product_Price_Dollar = Convert.ToDecimal(dollar);
                    newProduct.Supplier_Transaction_Product_Price_Rupiah = Convert.ToDecimal(rupiah);
                    newProduct.Supplier_Transaction_Product_Quantity = quantity;
                    totalRupiah += rupiah;
                    totalDollar += dollar;
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Dollar"].Value = dollar.ToString("C2");
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Rupiah"].Value = rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                    prod.Add(newProduct);
                }
                catch (Exception ex) { continue; }
            }
            try
            {
                decimal kurs = Convert.ToDecimal(_tpurKurs.Text);
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("Kurs must be nominal!");
                return;
            }
            supplier_transaction newTrans = SupplierTransaction.insertSupplierTransaction(_dtTransDate.Value,Convert.ToInt32(_cbpurNama.SelectedValue), totalDollar, totalRupiah, _tpurDescription.Text, prod,_tpurNoteNum.Text,_tpurInvoice.Text,Convert.ToInt32(_cbpurKurs.SelectedValue),Convert.ToDecimal(_tpurKurs.Text));
            _purchasingTrans2 nextForm = new _purchasingTrans2(newTrans);
            nextForm.FormClosed += new FormClosedEventHandler(prodForm_FormClosed);
            nextForm.Show();
            this.Hide();
        }
        
        void prodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void _bpurDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _dataSupTransaction.Rows.Remove(_dataSupTransaction.SelectedRows[0]);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }
    }
}
