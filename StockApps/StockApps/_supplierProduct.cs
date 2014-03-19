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
    public partial class _SupplierProduct : Form
    {
        private int supplierId;
        private int productId;
        private Dictionary<string, int> dictPriceType;
        private Dictionary<string, int> dictStockType;
        private Dictionary<string, int> dictCategory;
        private Dictionary<string, int> dictSupplier;

        private void RefreshComboBox()
        {
            dictCategory = new Dictionary<string, int>();
            dictPriceType = new Dictionary<string, int>();
            dictStockType = new Dictionary<string, int>();

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

        public _SupplierProduct()
        {
            InitializeComponent();
            productId = -1;
            supplierId = -1;
            label5.Text = "Insert Product";
            _bspPInsert.Visible = true;
            _bspPUpdate.Visible = false;

            _lspPSupplierName.Visible = false;
            _cbspSupplierList.Visible = true;
            dictSupplier = new Dictionary<string, int>();
            var listSupplier = SupplierController.getSupplier();
            _cbspSupplierList.Items.Clear();
            foreach (supplier sup in listSupplier)
            {
                _cbspSupplierList.Items.Add(sup.Supplier_Name);
                dictSupplier[sup.Supplier_Name] = sup.Supplier_ID;
            }

            RefreshComboBox();
        }

        public _SupplierProduct(supplier supp)
        {
            InitializeComponent();
            productId = -1;
            label5.Text = "Insert Product";
            _bspPInsert.Visible = true;
            _bspPUpdate.Visible = false;

            supplierId = supp.Supplier_ID;
            _lspPSupplierName.Visible = true;
            _cbspSupplierList.Visible = false;
            _lspPSupplierName.Text = supp.Supplier_Name;

            RefreshComboBox();
        }

        public _SupplierProduct(supplier supp, product prod)
        {
            InitializeComponent();
            label5.Text = "Update Product";
            _bspPInsert.Visible = false;
            _bspPUpdate.Visible = true;

            productId = prod.Product_ID;
            supplierId = supp.Supplier_ID;
            _lspPSupplierName.Visible = true;
            _cbspSupplierList.Visible = false;
            _lspPSupplierName.Text = supp.Supplier_Name;

            RefreshComboBox();

            _cbspPPackageName.SelectedItem = prod.Product_Packing_Name;
            _cbspPTypePrice.SelectedItem = prod.currency.Currency_Name;
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

        private void _bspPAddCategory_Click(object sender, EventArgs e)
        {
            _supplierPCategory listCategory = new _supplierPCategory();
            listCategory.Show();
            listCategory.FormClosed += new FormClosedEventHandler(listCategory_FormClosed);
        }

        void listCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            dictCategory = new Dictionary<string, int>();
            var listCategory = ProductController.getProductCategory();
            foreach (product_category pc in listCategory)
            {
                _cbspPCategory.Items.Add(pc.Product_Category_Name);
                dictCategory[pc.Product_Category_Name] = pc.Product_Category_ID;
            }
        }

        private void _cbspSupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                supplierId = dictSupplier[_cbspSupplierList.SelectedItem.ToString()];
            }
            catch (Exception ex)
            {
 
            }
        }

    }
}
