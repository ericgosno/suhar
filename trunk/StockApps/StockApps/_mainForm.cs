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
            adminHistoryR formAdminHistory = new adminHistoryR();
            formAdminHistory.Show();
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

        private void _mainForm_Load(object sender, EventArgs e)
        {

        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bankList bankList = new _bankList();
            bankList.Show();
        }

        private void sellingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sellingReport formReportSelling = new sellingReport();
            formReportSelling.Show();
        }
        private void insertBankCashTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _insertBankTransaction insertBankTrans = new _insertBankTransaction();
            insertBankTrans.Show();
        }

        private void purchasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            purchasingReporting formReportPurchasing = new purchasingReporting();
            formReportPurchasing.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _StockList formStockList = new _StockList();
            formStockList.Show();
        }

        private void sellingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sellingReport formReportSelling = new sellingReport();
            formReportSelling.Show();
        }

        private void purchasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            purchasingReporting formReportPurchasing = new purchasingReporting();
            formReportPurchasing.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplierReport formReportSupplier = new supplierReport();
            formReportSupplier.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerReport formReportCustomer = new customerReport();
            formReportCustomer.Show();
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceHistoryReport formReportPrice = new priceHistoryReport();
            formReportPrice.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SupplierProduct suppProduct = new _SupplierProduct();
            suppProduct.Show();
        }
    }
}
