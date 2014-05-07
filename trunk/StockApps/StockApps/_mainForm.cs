using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StockModel;

namespace StockApps
{
    public partial class _mainForm : Form
    {
        public _mainForm()
        {
            InitializeComponent();
            // delete history older than 3 months
            HistoryController.RemoveOldHistory(90);

            // authorization
            addProductToolStripMenuItem.Visible = false;
            addCategoryToolStripMenuItem.Visible = false;
            supplierToolStripMenuItem.Visible = false;
            supplierToolStripMenuItem1.Visible = false;
            userToolStripMenuItem.Visible = false;
            customerToolStripMenuItem.Visible = false;
            purchasingToolStripMenuItem2.Visible = false;
            purchasingToolStripMenuItem.Visible = false;
            sellingToolStripMenuItem2.Visible = false;
            sellingToolStripMenuItem.Visible = false;
            productToolStripMenuItem.Visible = false;
            administratorToolStripMenuItem.Visible = false;
            historyToolStripMenuItem.Visible = false;
            cashFlowToolStripMenuItem.Visible = false;
            customerDebtToolStripMenuItem.Visible = false;
            supplierCreditToolStripMenuItem.Visible = false;

            _lIdentityCompany.Text = IdentityController.getIdentity().Identity_Company_Name;
            _lUser.Text = Session.UserLogin.users_username + "(" + Session.UserLogin.privilege.Privilege_name + ")";
            
            _linkAddProduct.Visible = false;
            _linkBackup.Visible = false;
            _linkBank.Visible = false;
            _linkBankTransaction.Visible = false;
            _linkCustomer.Visible = false;
            _linkCustomerDebt.Visible = false;
            _linkHistoryLogin.Visible = false;
            _linkOwner.Visible = false;
            _linkPrivilege.Visible = false;
            _linkProductCategory.Visible = false;
            _linkProductList.Visible = false;
            _linkPurchasing.Visible = false;
            _linkRestore.Visible = false;
            _linkRptBank.Visible = false;
            _linkRptCustomer.Visible = false;
            _linkRptPurchasing.Visible = false;
            _linkRptSupplier.Visible = false;
            _linkRptSelling.Visible = false;
            _linkSelling.Visible = false;
            _linkSupplier.Visible = false;
            _linkSupplierCredit.Visible = false;
            _linkUser.Visible = false;

            foreach (privilege_authorization auth in Session.UserLogin.privilege.privilege_authorization)
            {
                switch (auth.Authorization_ID)
                {
                    case 1:
                        supplierToolStripMenuItem.Visible = true;
                        supplierToolStripMenuItem1.Visible = true;
                        _linkRptSupplier.Visible = true;
                        _linkSupplier.Visible = true;
                        break;
                    case 2:
                        userToolStripMenuItem.Visible = true;
                        customerToolStripMenuItem.Visible = true;
                        _linkCustomer.Visible = true;
                        _linkRptCustomer.Visible = true;
                        break;
                    case 3:
                        purchasingToolStripMenuItem2.Visible = true;
                        purchasingToolStripMenuItem.Visible = true;
                        _linkPurchasing.Visible = true;
                        _linkRptPurchasing.Visible = true;
                        CheckPurchasingNotification();
                        break;
                    case 4:
                        sellingToolStripMenuItem2.Visible = true;
                        sellingToolStripMenuItem.Visible = true;
                        _linkSelling.Visible = true;
                        _linkRptSelling.Visible = true;
                        CheckSellingNotification();
                        break;
                    case 5:
                        productToolStripMenuItem.Visible = true;
                        addCategoryToolStripMenuItem.Visible = true;
                        addProductToolStripMenuItem.Visible = true;
                        _linkProductList.Visible = true;
                        _linkProductCategory.Visible = true;
                        _linkAddProduct.Visible = true;
                        break;
                    case 6:
                        administratorToolStripMenuItem.Visible = true;
                        _linkUser.Visible = true;
                        _linkPrivilege.Visible = true;
                        _linkBackup.Visible = true;
                        _linkRestore.Visible = true;
                        _linkOwner.Visible = true;
                        break;
                    case 7:
                        historyToolStripMenuItem.Visible = true;
                        _linkHistoryLogin.Visible = true;
                        break;
                    case 8:
                        cashFlowToolStripMenuItem.Visible = true;
                        bankAccountReportToolStripMenuItem.Visible = true;
                        customerDebtToolStripMenuItem.Visible = false;
                        supplierCreditToolStripMenuItem.Visible = false;
                        _linkCustomerDebt.Visible = true;
                        _linkSupplierCredit.Visible = true;
                        _linkRptBank.Visible = true;
                        _linkBank.Visible = true;
                        _linkBankTransaction.Visible = true;
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

        // supplier
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierList supplierListForm = new _supplierList();
            supplierListForm.Show(this);
        }

        private void _linkSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _supplierList supplierListForm = new _supplierList();
            supplierListForm.Show(this);
        }

        // Customer 
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _customerList customerListForm = new _customerList();
            customerListForm.Show(this);
        }

        private void _linkCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _customerList customerListForm = new _customerList();
            customerListForm.Show(this);
        }

        /* Product List */
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _StockList formStockList = new _StockList();
            formStockList.Show(this);
        }

        private void _linkProductList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _StockList formStockList = new _StockList();
            formStockList.Show(this);
        }

        /* Add Product */
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SupplierProduct suppProduct = new _SupplierProduct();
            suppProduct.Show(this);
        }

        private void addProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _SupplierProduct suppProduct = new _SupplierProduct();
            suppProduct.Show(this);
        }

        private void _linkAddProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _SupplierProduct suppProduct = new _SupplierProduct();
            suppProduct.Show(this);
        }

        /* Product Category */
        private void addCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _supplierPCategory formCategory = new _supplierPCategory();
            formCategory.Show(this);
        }
        private void _linkProductCategory_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _supplierPCategory formCategory = new _supplierPCategory();
            formCategory.Show(this);
        }

        /* Purchasing Trans */
        private void transactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _purchasingTrans purTrans = new _purchasingTrans();
            purTrans.Show(this);
        }
        private void _linkPurchasing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _purchasingTrans purTrans = new _purchasingTrans();
            purTrans.Show(this);
        }

        /* Selling Trans */
        private void transactionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _sellingTrans sellTrans = new _sellingTrans();
            sellTrans.Show(this);
        }

        private void _linkSelling_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _sellingTrans sellTrans = new _sellingTrans();
            sellTrans.Show(this);
        }

        /* Bank */
        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bankList bankList = new _bankList();
            bankList.Show(this);
        }

        private void _linkBank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _bankList bankList = new _bankList();
            bankList.Show(this);
        }

        /* Bank Transaction */
        private void insertBankCashTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _insertBankTransaction insertBankTrans = new _insertBankTransaction();
            insertBankTrans.Show(this);
        }
        private void insertBankCashTransactionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _insertBankTransaction bankTrans = new _insertBankTransaction();
            bankTrans.Show(this);
        }
        private void _linkBankTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _insertBankTransaction bankTrans = new _insertBankTransaction();
            bankTrans.Show(this);
        }

        /* User */
        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _administratorList adminList = new _administratorList();
            adminList.Show(this);
        }

        private void _linkUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _administratorList adminList = new _administratorList();
            adminList.Show(this);
        }

        /* Privilege */
        private void categoryUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _administratorCategory adminCategory = new _administratorCategory();
            adminCategory.Show(this);
        }
        private void _linkPrivilege_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _administratorCategory adminCategory = new _administratorCategory();
            adminCategory.Show(this);
        }

        /* Owner Info */
        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _identityForm createOwner = new _identityForm();
            createOwner.Show(this);
        }
        private void _linkOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _identityForm createOwner = new _identityForm();
            createOwner.Show(this);
        }

        /* Backup */
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["StockApps.Properties.Settings.stockappsConnectionString"].ToString();
            if (backupDialog.ShowDialog(this) == DialogResult.Cancel) return;
            string file = backupDialog.FileName;
            MessageBox.Show("Backup process has been started, This process can last for several minutes(depend on quantity of data), Please be patient");
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
            MessageBox.Show("Backup database Successfuly!");
        }

        private void _linkBackup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["StockApps.Properties.Settings.stockappsConnectionString"].ToString();
            if (backupDialog.ShowDialog(this) == DialogResult.Cancel) return;

            string file = backupDialog.FileName;
            MessageBox.Show("Backup process has been started, This process can last for several minutes(depend on quantity of data), Please be patient");
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
            MessageBox.Show("Backup database Successfuly!");
        }

        /* Restore */
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["StockApps.Properties.Settings.stockappsConnectionString"].ToString();
            if (restoreDialog.ShowDialog() == DialogResult.Cancel) return;

            string file = restoreDialog.FileName;
            MessageBox.Show("Restore process has been started, This process can last for several minutes(depend on quantity of data), Please be patient");

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }

            MessageBox.Show("Restore database Successfuly!");
        }

        private void _linkRestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["StockApps.Properties.Settings.stockappsConnectionString"].ToString();
            if (restoreDialog.ShowDialog() == DialogResult.Cancel) return;

            string file = restoreDialog.FileName;
            MessageBox.Show("Restore process has been started, This process can last for several minutes(depend on quantity of data), Please be patient");

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }

            MessageBox.Show("Restore database Successfuly!");
        }

        /* Price History */
        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceHistoryReport formReportPrice = new priceHistoryReport();
            formReportPrice.Show(this);
        }

        private void _linkPriceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            priceHistoryReport formReportPrice = new priceHistoryReport();
            formReportPrice.Show(this);
        }

        /* Login History */
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHistoryR formAdminHistory = new adminHistoryR();
            formAdminHistory.Show(this);
        }

        private void _linkHistoryLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminHistoryR formAdminHistory = new adminHistoryR();
            formAdminHistory.Show(this);
        }

        /* Selling Report */
        private void sellingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _sellingTransactionList formSellingreport = new _sellingTransactionList();
            formSellingreport.Show(this);
        }

        private void _linkRptSelling_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _sellingTransactionList formSellingreport = new _sellingTransactionList();
            formSellingreport.Show(this);
        }

        private void sellingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sellingReport formReportSelling = new sellingReport();
            formReportSelling.Show(this);
        }

        /* Purchasing Report */
        private void purchasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            purchasingReporting formReportPurchasing = new purchasingReporting();
            formReportPurchasing.Show(this);
        }
        private void purchasingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _purchasingTransactionList formReportPurchasing = new _purchasingTransactionList();
            formReportPurchasing.Show(this);
        }

        private void _linkRptPurchasing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _purchasingTransactionList formReportPurchasing = new _purchasingTransactionList();
            formReportPurchasing.Show(this);
        }

        /* Customer Report */
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerReport formReportCustomer = new customerReport();
            formReportCustomer.Show(this);
        }
        private void _linkRptCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customerReport formReportCustomer = new customerReport();
            formReportCustomer.Show(this);
        }

        /* Supplier Report */
        private void _linkRptSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supplierReport formReportSupplier = new supplierReport();
            formReportSupplier.Show(this);
        }
        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplierReport formReportSupplier = new supplierReport();
            formReportSupplier.Show(this);
        }

        /* Customer Debt */
        private void customerDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CustomerDebtReportViewer nextForm = new _CustomerDebtReportViewer();
            nextForm.Show(this);
        }
        private void _linkCustomerDebt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _CustomerDebtReportViewer nextForm = new _CustomerDebtReportViewer();
            nextForm.Show(this);
        }


        /* Supplier Credit */
        private void supplierCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SupplierCreditReportViewer nextForm = new _SupplierCreditReportViewer();
            nextForm.Show(this);
        }

        private void _linkSupplierCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _SupplierCreditReportViewer nextForm = new _SupplierCreditReportViewer();
            nextForm.Show(this);
        }

        /* Bank Report */
        private void bankAccountReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BankReport bankReport = new BankReport();
            bankReport.Show(this);
        }
        private void bankAccountReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankReport bankReport = new BankReport();
            bankReport.Show(this);
        }

        private void _linkRptBank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BankReport bankReport = new BankReport();
            bankReport.Show(this);
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {

        }

        private void neracaAktivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _neraca_aktiva NeracaReport = new _neraca_aktiva();
            NeracaReport.Show(this);
        }

        private void neracaPassivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _neraca_passiva NeracaReportP = new _neraca_passiva();
            NeracaReportP.Show(this);
        }

        private void _linkrptAktiva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _neraca_aktiva NeracaReport = new _neraca_aktiva();
            NeracaReport.Show(this);
        }

        private void _linkrptPassiva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _neraca_passiva NeracaReportP = new _neraca_passiva();
            NeracaReportP.Show(this);
        }



    }
}
