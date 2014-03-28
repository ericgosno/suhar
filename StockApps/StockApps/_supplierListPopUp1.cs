using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockModel;

namespace StockApps
{
    public partial class _supplierListPopUp1 : Form
    {
        private supplier supplierNow;
        public _supplierListPopUp1(supplier supplierNow)
        {
            InitializeComponent();
            this.supplierNow = supplierNow;
            _tspDName.Text = supplierNow.Supplier_Name;
            RefreshForm();
        }
        private void RefreshForm()
        {
            var listProduct = ProductController.getProductBySupplierID(supplierNow.Supplier_ID);
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

        private void _bspDInsert_Click(object sender, EventArgs e)
        {
            _SupplierProduct prodForm = new _SupplierProduct(supplierNow);
            prodForm.FormClosed += new FormClosedEventHandler(prodForm_FormClosed);
            prodForm.Show();
        }

        void prodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshForm();
        }

        private void _bspDDelete_Click(object sender, EventArgs e)
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

        private void _bspDUpdate_Click(object sender, EventArgs e)
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
                var prodnow = ProductController.getProductByProductID(Convert.ToInt32(rowNow.Cells["Product_ID"].Value)).First();
                _SupplierProduct prodForm = new _SupplierProduct(supplierNow,prodnow);
                prodForm.FormClosed += new FormClosedEventHandler(prodForm_FormClosed);
                prodForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _supplierListPopUp1_Load(object sender, EventArgs e)
        {

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

    }
}
