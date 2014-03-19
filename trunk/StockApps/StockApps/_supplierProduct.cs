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
    public partial class _SupplierProduct : Form
    {
        private int supplierId;
        private int productId;
        private Dictionary<string, int> dictPriceType;
        private Dictionary<string, int> dictStockType;
        private Dictionary<string, int> dictCategory;

        public _SupplierProduct()
        {
            InitializeComponent();
            productId = -1;
        }

        public _SupplierProduct(supplier supp)
        {
            InitializeComponent();
            productId = -1;
            label5.Text = "Insert Product";
            _bspPInsert.Visible = true;
            _bspPUpdate.Visible = false;

            dictCategory = new Dictionary<string, int>();
            dictPriceType = new Dictionary<string, int>();
            dictStockType = new Dictionary<string, int>();

            supplierId = supp.Supplier_ID;
            _lspPSupplierName.Text = supp.Supplier_Name;

            _cbspPPackageName.Items.Add("Sack");
            _cbspPPackageName.Items.Add("Bags");
            _cbspPPackageName.Items.Add("Drum");

            var listCurrency = CurrencyController.getCurrency();
            foreach (currency cur in listCurrency)
            {
                _cbspPTypePrice.Items.Add(cur.Currency_Name);
                dictPriceType[cur.Currency_Name] = cur.Currency_ID;
            }

            var listCategory = ProductController.getProductCategory();
            foreach (product_category pc in listCategory)
            {
                _cbspPCategory.Items.Add(pc.Product_Category_Name);
                dictCategory[pc.Product_Category_Name] = pc.Product_Category_ID;
            }
        }

        public _SupplierProduct(supplier supp, product prod)
        {
            InitializeComponent();
            label5.Text = "Update Product";
            _bspPInsert.Visible = false;
            _bspPUpdate.Visible = true;

            productId = prod.Product_ID;
            dictCategory = new Dictionary<string, int>();
            dictPriceType = new Dictionary<string, int>();
            dictStockType = new Dictionary<string, int>();

            supplierId = supp.Supplier_ID;
            _lspPSupplierName.Text = supp.Supplier_Name;

            _cbspPPackageName.Items.Add("Sack");
            _cbspPPackageName.Items.Add("Bags");
            _cbspPPackageName.Items.Add("Drum");
            _cbspPPackageName.SelectedItem = prod.Product_Packing_Name;

            var listCurrency = CurrencyController.getCurrency();
            foreach (currency cur in listCurrency)
            {
                _cbspPTypePrice.Items.Add(cur.Currency_Name);
                dictPriceType[cur.Currency_Name] = cur.Currency_ID;
            }
            _cbspPTypePrice.SelectedItem = prod.currency.Currency_Name;

            var listCategory = ProductController.getProductCategory();
            foreach (product_category pc in listCategory)
            {
                _cbspPCategory.Items.Add(pc.Product_Category_Name);
                dictCategory[pc.Product_Category_Name] = pc.Product_Category_ID;
            }
            _cbspPCategory.SelectedItem = prod.product_category.Product_Category_Name;

            _tspPName.Text = prod.Product_Name;
            _tspPPackingKilogram.Text = prod.Product_Packing_Kilogram.ToString();
            _tspPPrice.Text = prod.Product_Buy_Price.ToString();
        }

        private void _bspPInsert_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.insertProduct(supplierId, dictCategory[_cbspPCategory.SelectedItem.ToString()], dictPriceType[_cbspPTypePrice.SelectedItem.ToString()], Convert.ToDouble(_tspPPrice.Text), _tspPName.Text,_cbspPPackageName.SelectedItem.ToString(),Convert.ToInt32(_tspPPackingKilogram.Text));
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Invalid Parameter"); }
        }

        private void _bspPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.updateProduct(productId,supplierId, dictCategory[_cbspPCategory.SelectedItem.ToString()], dictPriceType[_cbspPTypePrice.SelectedItem.ToString()], Convert.ToDouble(_tspPPrice.Text), _tspPName.Text, _cbspPPackageName.SelectedItem.ToString(), Convert.ToInt32(_tspPPackingKilogram.Text));
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Invalid Parameter"); }

        }


    }
}