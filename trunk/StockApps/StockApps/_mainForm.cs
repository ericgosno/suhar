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
    public partial class _mainForm : Form
    {
        public _mainForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierPCategory formCategory = new _supplierPCategory();
            formCategory.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierList supplierListForm = new _supplierList();
            supplierListForm.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _customerList customerListForm = new _customerList();
            customerListForm.Show();
        }

        private void categoryUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _administratorCategory adminCategory = new _administratorCategory();
            adminCategory.Show();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _administratorList adminList = new _administratorList();
            adminList.Show();
        }

        private void transactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _purchasingTrans purTrans = new _purchasingTrans();
            purTrans.Show();
        }

        private void transactionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _sellingTrans sellTrans = new _sellingTrans();
            sellTrans.Show();
        }
    }
}
