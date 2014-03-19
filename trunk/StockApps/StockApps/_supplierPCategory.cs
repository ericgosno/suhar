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
    public partial class _supplierPCategory : Form
    {
        private Dictionary<string, int> dictCategory;
        public _supplierPCategory()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            dictCategory = new Dictionary<string, int>();
            _tspPCListCategory.Items.Clear();
            var listCategory = ProductController.getProductCategory();
            
            foreach (product_category cat in listCategory)
            {
                _tspPCListCategory.Items.Add(cat.Product_Category_Name, cat.Product_Category_ID);
                //_tspPCListCategory.Items.Add(cat.Product_Category_Name);
                //dictCategory.Add(cat.Product_Category_Name, cat.Product_Category_ID);
            }
            //if (_tspPCListCategory.Items.Count > 0) _tspPCListCategory.
        }

        private void _bspPCInsert_Click(object sender, EventArgs e)
        {
            ProductController.insertProductCategory(_tspPCName.Text);
            RefreshForm();
        }

        private void _bspPCDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Warning!, deleting category will also delete products in this category, Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                ProductController.deleteProductCategory(_tspPCListCategory.SelectedItems[0].ImageIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select category first!");
            }
            RefreshForm();
        }

        private void _tspPCListCategory_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                ProductController.updateProductCategory(_tspPCListCategory.Items[e.Item].ImageIndex, e.Label);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select category first!");
            }
            RefreshForm();
        }

    }
}
