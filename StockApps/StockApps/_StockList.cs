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
        private Dictionary<string, int> dictSupplier;
        private Dictionary<string, int> dictCategory;
        private Dictionary<string, int> dictCurrency;

        public _StockList()
        {
            InitializeComponent();
            dictCategory = new Dictionary<string, int>();
            var listCategory = ProductController.getProductCategory();
            _cbproSCategory.Items.Clear();
            foreach (product_category cat in listCategory)
            {
                _cbproSCategory.Items.Add(cat.Product_Category_Name);
                dictCategory[cat.Product_Category_Name] = cat.Product_Category_ID;
            }

            dictCurrency = new Dictionary<string, int>();
            var listCurrency = CurrencyController.getCurrency();
            _cbproSTypePrice.Items.Clear();
            foreach (currency cur in listCurrency)
            {
                _cbproSTypePrice.Items.Add(cur.Currency_Name);
                dictCurrency[cur.Currency_Name] = cur.Currency_ID;
            }

            dictSupplier = new Dictionary<string, int>();
            var listSupplier = SupplierController.getSupplier();
            _cbProSSup.Items.Clear();
            foreach (supplier sup in listSupplier)
            {
                _cbProSSup.Items.Add(sup.Supplier_Name);
                dictSupplier[sup.Supplier_Name] = sup.Supplier_ID;
            }
            RefreshForm();
        }

        private void RefreshForm()
        {
            var listProduct = ProductController.getProduct();
            
            if (_cbProSSup.SelectedIndex >= 0)
            {
                int idnow = dictSupplier[_cbProSSup.SelectedItem.ToString()];
                listProduct = listProduct.Where(a => a.Supplier_ID == idnow);
            }
            if (_txtProSName.Text != "") listProduct = listProduct.Where(a => a.Product_Name.Contains(_txtProSName.Text));
            if (_cbproSCategory.SelectedIndex >= 0)
            {
                int catId = dictCategory[_cbproSCategory.SelectedItem.ToString()];
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

   
    }
}
