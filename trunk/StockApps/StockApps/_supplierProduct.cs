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

        private void RefreshComboBox()
        {
            _cbspPPackageName.Items.Add("Sack");
            _cbspPPackageName.Items.Add("Bags");
            _cbspPPackageName.Items.Add("Drum");

            var listCurrency = CurrencyController.getCurrency();
            _cbspPTypePrice.DataSource = listCurrency;
            _cbspPTypePrice.DisplayMember = "Currency_Name";
            _cbspPTypePrice.ValueMember = "Currency_ID";

            var listCategory = ProductController.getProductCategory();
            _cbspPCategory.DataSource = listCategory;
            _cbspPCategory.ValueMember = "Product_Category_ID";
            _cbspPCategory.DisplayMember = "Product_Category_Name";
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

            var listSupplier = SupplierController.getSupplier();
            _cbspSupplierList.DataSource = listSupplier;
            _cbspSupplierList.DisplayMember = "Supplier_Name";
            _cbspSupplierList.ValueMember = "Supplier_ID";

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
            _cbspPTypePrice.SelectedValue = prod.Currency_ID;
            _cbspPCategory.SelectedValue = prod.Product_Category_ID;

            _tspPName.Text = prod.Product_Name;
            _tspPPackingKilogram.Text = prod.Product_Packing_Kilogram.ToString();
            _tspPPrice.Text = prod.Product_Buy_Price.ToString();
        }

        private void _bspPInsert_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.insertProduct(supplierId, Convert.ToInt32(_cbspPCategory.SelectedValue), Convert.ToInt32(_cbspPTypePrice.SelectedValue), Convert.ToDouble(_tspPPrice.Text), _tspPName.Text,_cbspPPackageName.SelectedItem.ToString(),Convert.ToInt32(_tspPPackingKilogram.Text));
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Invalid Parameter"); }
        }

        private void _bspPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.updateProduct(productId, supplierId, Convert.ToInt32(_cbspPCategory.SelectedValue), Convert.ToInt32(_cbspPTypePrice.SelectedValue), Convert.ToDouble(_tspPPrice.Text), _tspPName.Text, _cbspPPackageName.SelectedItem.ToString(), Convert.ToInt32(_tspPPackingKilogram.Text));
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
            var listCategory = ProductController.getProductCategory();
            _cbspPCategory.DataSource = listCategory;
            _cbspPCategory.ValueMember = "Product_Category_ID";
            _cbspPCategory.DisplayMember = "Product_Category_Name";
        }

        private void _cbspSupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                supplierId = Convert.ToInt32(_cbspSupplierList.SelectedValue);
            }
            catch (Exception ex)
            {
 
            }
        }

    }
}
