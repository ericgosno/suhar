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
            foreach (privilege_authorization auth in Session.UserLogin.privilege.privilege_authorization)
            {
                switch (auth.Authorization_ID)
                {
                    case 1:
                        supplierToolStripMenuItem.Visible = true;
                        supplierToolStripMenuItem1.Visible = true;
                        break;
                    case 2:
                        userToolStripMenuItem.Visible = true;
                        customerToolStripMenuItem.Visible = true;
                        break;
                    case 3:
                        purchasingToolStripMenuItem2.Visible = true;
                        purchasingToolStripMenuItem.Visible = true;
                        CheckPurchasingNotification();
                        break;
                    case 4:
                        sellingToolStripMenuItem2.Visible = true;
                        sellingToolStripMenuItem.Visible = true;
                        CheckSellingNotification();
                        break;
                    case 5:
                        productToolStripMenuItem.Visible = true;
                        break;
                    case 6:
                        administratorToolStripMenuItem.Visible = true;
                        break;
                    case 7:
                        historyToolStripMenuItem.Visible = true;
                        break;
                    case 8:
                        cashFlowToolStripMenuItem.Visible = true;
                        break;
                }
            }
        }

        private void CheckPurchasingNotification()
        {
            var list = SupplierTransaction.getDeadlinePayment().ToList();
            foreach (supplier_payment payment in list)
            {
                _notificationPaymentSupplier purchasingNotif = new _notificationPaymentSupplier(payment);
                purchasingNotif.Show(this);
                purchasingNotif.Focus();
            }
        }
        private void CheckSellingNotification()
        {
            var list = CustomerTransaction.getDeadlinePayment().ToList();
            foreach (customer_payment payment in list)
            {
                _notificationPayment sellingNotif = new _notificationPayment(payment);
                sellingNotif.Show(this);
                sellingNotif.Focus();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHistoryR formAdminHistory = new adminHistoryR();
            formAdminHistory.Show(this);
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierPCategory formCategory = new _supplierPCategory();
            formCategory.Show(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierList supplierListForm = new _supplierList();
            supplierListForm.Show(this);
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _customerList customerListForm = new _customerList();
            customerListForm.Show(this);
        }

        private void categoryUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _administratorCategory adminCategory = new _administratorCategory();
            adminCategory.Show(this);
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _administratorList adminList = new _administratorList();
            adminList.Show(this);
        }

        private void transactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _purchasingTrans purTrans = new _purchasingTrans();
            purTrans.Show(this);
        }

        private void transactionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _sellingTrans sellTrans = new _sellingTrans();
            sellTrans.Show(this);
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {

        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bankList bankList = new _bankList();
            bankList.Show(this);
        }

        private void sellingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sellingReport formReportSelling = new sellingReport();
            formReportSelling.Show(this);
        }
        private void insertBankCashTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _insertBankTransaction insertBankTrans = new _insertBankTransaction();
            insertBankTrans.Show(this);
        }

        private void purchasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            purchasingReporting formReportPurchasing = new purchasingReporting();
            formReportPurchasing.Show(this);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _StockList formStockList = new _StockList();
            formStockList.Show(this);
        }

        private void sellingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _sellingTransactionList formSellingreport = new _sellingTransactionList();
            formSellingreport.Show(this);
        }

        private void purchasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _purchasingTransactionList formReportPurchasing = new _purchasingTransactionList();
            formReportPurchasing.Show(this);
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplierReport formReportSupplier = new supplierReport();
            formReportSupplier.Show(this);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerReport formReportCustomer = new customerReport();
            formReportCustomer.Show(this);
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceHistoryReport formReportPrice = new priceHistoryReport();
            formReportPrice.Show(this);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SupplierProduct suppProduct = new _SupplierProduct();
            suppProduct.Show(this);
        }

        private void insertBankCashTransactionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _insertBankTransaction bankTrans = new _insertBankTransaction();
            bankTrans.Show(this);
        }

        private void bankAccountReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankReport bankReport = new BankReport();
            bankReport.Show(this);
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _identityForm createOwner = new _identityForm();
            createOwner.Show(this);
        }

        private void customerDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CustomerDebtReportViewer nextForm = new _CustomerDebtReportViewer();
            nextForm.Show(this);
        }

        private void supplierCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SupplierCreditReportViewer nextForm = new _SupplierCreditReportViewer();
            nextForm.Show(this);
        }
    }
}
