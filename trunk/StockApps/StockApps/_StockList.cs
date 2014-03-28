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
    public partial class _StockList : Form
    {
        public _StockList()
        {
            InitializeComponent();

            var listCategory = ProductController.getProductCategory();
            _cbproSCategory.DataSource = listCategory;
            _cbproSCategory.ValueMember = "Product_Category_ID";
            _cbproSCategory.DisplayMember = "Product_Category_Name";

            var listCurrency = CurrencyController.getCurrency();
            _cbproSTypePrice.DataSource = listCurrency;
            _cbproSTypePrice.ValueMember = "Currency_ID";
            _cbproSTypePrice.DisplayMember = "Currency_Name";

            var listSupplier = SupplierController.getSupplier();
            _cbProSSup.DataSource = listSupplier;
            _cbProSSup.ValueMember = "Supplier_ID";
            _cbProSSup.DisplayMember = "Supplier_Name";
            RefreshForm();
        }

        private void RefreshForm()
        {
            try
            {
                var listProduct = ProductController.getProduct();

                if (_cbProSSup.SelectedIndex >= 0)
                {
                    int idnow = Convert.ToInt32(_cbProSSup.SelectedValue);
                    listProduct = listProduct.Where(a => a.Supplier_ID == idnow);
                }
                if (_txtProSName.Text != "") listProduct = listProduct.Where(a => a.Product_Name.Contains(_txtProSName.Text));
                if (_cbproSCategory.SelectedIndex >= 0)
                {
                    int catId = Convert.ToInt32(_cbproSCategory.SelectedValue);
                    listProduct = listProduct.Where(a => a.Product_Category_ID == catId);
                }

                if (_cbProSValue2.SelectedIndex >= 0 && _tproSStock.Value > 0)
                {
                    if (_cbProSValue2.SelectedIndex == 0)
                    {
                        listProduct = listProduct.Where(a => a.Product_Stock < _tproSStock.Value);
                    }
                    if (_cbProSValue2.SelectedIndex == 1)
                    {
                        listProduct = listProduct.Where(a => a.Product_Stock > _tproSStock.Value);
                    }
                    if (_cbProSValue2.SelectedIndex == 2)
                    {
                        listProduct = listProduct.Where(a => a.Product_Stock == _tproSStock.Value);
                    }
                }

                var listCategory = ProductController.getProductCategory();
                var listCurrency = CurrencyController.getCurrency();
                var list = listProduct
                     .Join(listCurrency,
                     product => product.Currency_ID,
                     currency => currency.Currency_ID,
                     (product, currency) => new { product = product, currency = currency })
                     .Join(listCategory,
                     join => join.product.Product_Category_ID,
                     product_category => product_category.Product_Category_ID,
                     (join, product_category) => new { join = join, product_category = product_category })
                     .AsEnumerable()
                     .Select(join => new
                     {
                         Product_ID = join.join.product.Product_ID + "",
                         Product_Name = join.join.product.Product_Name + "",
                         Product_Stock = join.join.product.Product_Stock + "",
                         Product_Price = join.join.product.Product_Buy_Price + " " + join.join.currency.Currency_Name,
                         Product_Category_Name = join.product_category.Product_Category_Name + "",
                         Product_Package = (join.join.product.Product_Stock / join.join.product.Product_Packing_Kilogram) + " " + join.join.product.Product_Packing_Name
                     }).ToList();

                _dataDetailSupplier.DataSource = list;
                _dataDetailSupplier.Columns["Product_Name"].HeaderText = "Name";
                _dataDetailSupplier.Columns["Product_Stock"].HeaderText = "Stock";
                _dataDetailSupplier.Columns["Product_Price"].HeaderText = "Price";
                _dataDetailSupplier.Columns["Product_Category_Name"].HeaderText = "Category";
                _dataDetailSupplier.Columns["Product_Package"].HeaderText = "Package Avaliable";

                _dataDetailSupplier.Columns["Product_ID"].Visible = false;
                _dataDetailSupplier.Refresh();
            }
            catch (Exception ex) { }
        }

        private void _cbProSSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _cbProSValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _txtProSName_TextChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _tproSPrice_TextChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _cbproSTypePrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _cbProSValue2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _tproSStock_TextChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _cbproSCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _tproSStock_ValueChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _bProSUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow rowNow = null;
                if (_dataDetailSupplier.CurrentCell != null)
                {
                    rowNow = _dataDetailSupplier.SelectedCells[0].OwningRow;
                }
                else if (_dataDetailSupplier.CurrentRow != null)
                {
                    rowNow = _dataDetailSupplier.SelectedRows[0];
                }
                
                int productId = Convert.ToInt32(rowNow.Cells["Product_ID"].Value);
                product prodNow = ProductController.getProductByProductID(productId).First();
                _SupplierProduct suppProd = new _SupplierProduct(prodNow.supplier,prodNow);
                suppProd.Show(this);
                suppProd.FormClosed += new FormClosedEventHandler(prodForm_FormClosed);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Must Select Row First!");
            }

        }

        void prodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshForm();
        }

        private void _bProSPriceHistory_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow rowNow = null;
                if (_dataDetailSupplier.CurrentCell != null)
                {
                    rowNow = _dataDetailSupplier.SelectedCells[0].OwningRow;
                }
                else if (_dataDetailSupplier.CurrentRow != null)
                {
                    rowNow = _dataDetailSupplier.SelectedRows[0];
                }
                int productId = Convert.ToInt32(rowNow.Cells["Product_ID"].Value);
                product prodNow = ProductController.getProductByProductID(productId).First();
                _priceHistory priceHistory = new _priceHistory(prodNow);
                priceHistory.Show(this);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("You Must Select Row First!");
            }
        }

        private void _bProSInsert_Click(object sender, EventArgs e)
        {
            _SupplierProduct suppProd = new _SupplierProduct();
            suppProd.Show(this);
            suppProd.FormClosed += new FormClosedEventHandler(prodForm_FormClosed);
        }

        private void _bProSDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                DataGridViewRow rowNow = null;
                if (_dataDetailSupplier.CurrentCell != null)
                {
                    rowNow = _dataDetailSupplier.SelectedCells[0].OwningRow;
                }
                else if (_dataDetailSupplier.CurrentRow != null)
                {
                    rowNow = _dataDetailSupplier.SelectedRows[0];
                }
                ProductController.deleteProduct(Convert.ToInt32(rowNow.Cells["Product_ID"].Value));
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

   
    }
}
