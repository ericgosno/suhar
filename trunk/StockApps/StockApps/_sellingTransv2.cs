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
    public partial class _sellingTransv2 : Form
    {
        public bool isFinished;
        private customer_transaction transNow;

        public _sellingTransv2(customer_transaction transNow)
        {
            InitializeComponent();
            isFinished = false;
            _lblSellName.Text = transNow.customer.Customer_Company_Name;
            _lblSellNPWP.Text = transNow.customer.Customer_NPWP;
            _lsellKurs.Text = transNow.Customer_Transaction_Kurs.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            if (transNow.Currency_ID == 1)
            {
                _lsellTotal.Text = Convert.ToDecimal(transNow.Customer_Transaction_Dollar).ToString("C2");
                _lsellTax.Text = Convert.ToDecimal(transNow.Customer_Transaction_PPN_Dollar).ToString("C2");
                _lsellTotalTax.Text = Convert.ToDecimal(transNow.Customer_Transaction_Total_Dollar).ToString("C2");
            }
            else
            {
                _lsellTotal.Text = Convert.ToDecimal(transNow.Customer_Transaction_Rupiah).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                _lsellTax.Text = Convert.ToDecimal(transNow.Customer_Transaction_PPN_Rupiah).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                _lsellTotalTax.Text = Convert.ToDecimal(transNow.Customer_Transaction_Total_Rupiah).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")); 
            }
            _cbsellPayWith.DataSource = PaymentController.getPaymentCategory();
            _cbsellPayWith.DisplayMember = "Payment_Category_Name";
            _cbsellPayWith.ValueMember = "Payment_Category_ID";
            this.transNow = transNow;

            _cbsellBank.DataSource = BankController.getBankWithCash();
            _cbsellBank.DisplayMember = "Bank_Name";
            _cbsellBank.ValueMember = "Bank_ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _bcusInsert_Click(object sender, EventArgs e)
        {

        }

        private void _cbsellPayWith_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _bcusInsert_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning! Once Transaction Processed, It can not be Removed/Edited Again, Are you sure to process?", "Warning!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                CustomerTransaction.insertCustomerPayment(transNow, Convert.ToInt32(_cbsellBank.SelectedValue), _dateJatuhTempo.Value, Convert.ToInt32(_cbsellPayWith.SelectedValue));
                CustomerController.insertCustomerDebt(transNow.Customer_ID, transNow.Customer_Transaction_Date, "DBT", true, (transNow.Currency_ID == 1) ? transNow.Customer_Transaction_Total_Dollar : transNow.Customer_Transaction_Total_Rupiah, "Pembayaran dilakukan secara " + _cbsellPayWith.Text + " jatuh tempo pada tanggal " + _dateJatuhTempo.Value.ToString("D", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")), transNow.Customer_Transaction_Kurs, transNow.Currency_ID);
                MessageBox.Show("Transaction Inserted Succesfully");
                isFinished = true;
                this.Close();
            }
        }

        private void _bSellTransFP_Click(object sender, EventArgs e)
        {
            sellingReportFP_bForm_RptViewer nextForm = new sellingReportFP_bForm_RptViewer(transNow.Customer_Transaction_ID);
            nextForm.Show();
        }

        private void _bSellTransSJ_Click(object sender, EventArgs e)
        {
            sellingReportSJ_bForm_RptViewer nextForm = new sellingReportSJ_bForm_RptViewer(transNow.Customer_Transaction_ID);
            nextForm.Show();
        }

        private void _bSellTransFPAJAK_Click(object sender, EventArgs e)
        {
            sellingReportFPajak_bForm_RptViewer nextForm = new sellingReportFPajak_bForm_RptViewer(transNow.Customer_Transaction_ID);
            nextForm.Show();
        }

        private void _sellingTransv2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFinished == false)
            {
                if (MessageBox.Show("Warning! Closing this page means cancel current transaction, are you sure to cancel current transaction?", "Warning!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    CustomerTransaction.CancelCustomerTransaction(transNow.Customer_Transaction_ID);
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
