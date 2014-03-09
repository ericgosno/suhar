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
        private Dictionary<string, int> dictProduct;
        private Dictionary<string, int> dictSupplier;
        public _purchasingTrans()
        {
            InitializeComponent();
            dictProduct = new Dictionary<string,int>();
            var listSupplier = SupplierController.getSupplier();
            dictSupplier = new Dictionary<string, int>();
            foreach (supplier supp in listSupplier)
            {
                _cbpurNama.Items.Add(supp.Supplier_Name);
                dictSupplier[supp.Supplier_Name] = supp.Supplier_ID;
            }            
        }


        private void _purchasingTrans_Load(object sender, EventArgs e)
        {

        }

        private void _cbpurNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            dictProduct = new Dictionary<string,int>();
            _dataSupTransaction.Rows.Clear();
            _lpurDollar.Text = "0";
            _lpurRp.Text = "0";
            var listProduct = ProductController.getProductBySupplierID(dictSupplier[_cbpurNama.SelectedItem.ToString()]);
            List<string> listprod = new List<string>();
            foreach (product prod in listProduct)
            {
                listprod.Add(prod.Product_Name);
                dictProduct[prod.Product_Name] = prod.Product_ID;
            }
            (_dataSupTransaction.Columns["Product"] as DataGridViewComboBoxColumn).DataSource = listprod;
        }

        private void RefreshData()
        {
            double totalRupiah = 0;
            double totalDollar = 0;
            for (int i = 0; i < _dataSupTransaction.Rows.Count; i++)
            {
                try
                {
                    int prodId = dictProduct[_dataSupTransaction.Rows[i].Cells["Product"].Value.ToString()];
                    var list = ProductController.getProductByProductID(prodId);
                    if (list.Count() <= 0) return;
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
                    newProduct.Product_ID  = dictProduct[_dataSupTransaction.Rows[i].Cells["Product"].Value.ToString()];
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
            SupplierTransaction.insertSupplierTransaction(_dtTransDate.Value,dictSupplier[_cbpurNama.SelectedItem.ToString()], totalDollar, totalRupiah, _tpurDescription.Text, prod);
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
