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
    public partial class _supplierProduct : Form
    {
        private int supplierId;
        private Dictionary<string, int> dictPriceType;
        private Dictionary<string, int> dictStockType;
        private Dictionary<string, int> dictCategory;

        public _supplierProduct()
        {
            InitializeComponent();
        }

        public _supplierProduct(supplier supp)
        {
            InitializeComponent();
            dictCategory = new Dictionary<string, int>();
            dictPriceType = new Dictionary<string, int>();
            dictStockType = new Dictionary<string, int>();

            supplierId = supp.Supplier_ID;
            _lspPSupplierName.Text = supp.Supplier_Name;

            _cbspPPackageName.Items.Add("Sack");
            _cbspPPackageName.Items.Add("Opo");
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

        private void _bspPInsert_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.insertProduct(supplierId, dictCategory[_cbspPCategory.SelectedItem.ToString()], dictPriceType[_cbspPTypePrice.SelectedItem.ToString()], Convert.ToDouble(_tspPPrice.Text), _tspPName.Text,_cbspPPackageName.SelectedItem.ToString(),Convert.ToInt32(_tspPPackingKilogram.Text));
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Invalid Parameter"); }
        }


    }
}
