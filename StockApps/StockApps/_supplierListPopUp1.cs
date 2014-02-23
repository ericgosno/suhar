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
                .Select(join => new {
                    Product_ID = join.join.product.Product_ID,
                    Product_Name = join.join.product.Product_Name,
                    Product_Stock = join.join.product.Product_Stock,
                    Product_Price = join.join.product.Product_Buy_Price,
                    Product_Category_Name = join.product_category.Product_Category_Name,
                });
           _dataDetailSupplier.DataSource = list;
            /* 
            _dataDetailSupplier.Columns["Supplier_Name"].HeaderText = "Name";
            _dataDetailSupplier.Columns["Supplier_Address"].HeaderText = "Address";
            _dataDetailSupplier.Columns["Supplier_Email"].HeaderText = "Email";
            _dataDetailSupplier.Columns["Supplier_Phone"].HeaderText = "Phone";

            _dataDetailSupplier.Columns["Supplier_Status"].Visible = false;
            _dataDetailSupplier.Columns["Supplier_ID"].Visible = false;
            _dataDetailSupplier.Columns["products"].Visible = false;
            _dataDetailSupplier.Columns["supplier_transaction"].Visible = false;
            _dataDetailSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            */
            _dataDetailSupplier.Refresh();
        }

        private void _bspDInsert_Click(object sender, EventArgs e)
        {
            _supplierProduct prodForm = new _supplierProduct(supplierNow);
            prodForm.FormClosed += new FormClosedEventHandler(prodForm_FormClosed);
            prodForm.Show();
        }

        void prodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshForm();
        }
    }
}
