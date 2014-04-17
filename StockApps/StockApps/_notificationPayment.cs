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
    public partial class _notificationPayment : Form
    {
        private customer_payment paymentNow;
        public _notificationPayment()
        {
            InitializeComponent();
        }
        public _notificationPayment(customer_payment payment)
        {
            InitializeComponent();
            customer custNow = CustomerController.getCustomer(payment.Customer_ID).First();

            _lblNotifName.Text = custNow.Customer_Company_Name;
            _lblNotifAmount.Text = (payment.bank.Currency_ID == 1) ? payment.Customer_Payment_Total_Dollar.ToString("C2") : payment.Customer_Payment_Total_Rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lblNotifBank.Text = payment.bank.Bank_Name;
            _lblNotifDate.Text = payment.Customer_Payment_Date.ToString("D");
            _lblNotifDeadline.Text = payment.Customer_Payment_Deadline_Date.ToString("D");
            _lblNotifNPWP.Text = custNow.Customer_NPWP;
            this.paymentNow = payment;
        }

        private void _notificationPayment_Load(object sender, EventArgs e)
        {

        }

        private void _rdNotifDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (_rdNotifDelay.Checked) _cbNotifDelayDate.Enabled = true;
            else _cbNotifDelayDate.Enabled = false;
        }

        private void _bNotifInsert_Click(object sender, EventArgs e)
        {
            if (_rdNotifConfirm.Checked)
            {
                decimal kurs = 0;
                try
                {
                    kurs = Convert.ToDecimal(_tNotifKurs.Text);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Kurs must be decimal!");
                    return;
                }
                // Confirm payment by changing status
                CustomerTransaction.confirmPayment(paymentNow.Customer_Payment_ID);
                // Insert credit to customer debt list
                CustomerController.insertCustomerDebt(paymentNow.Customer_ID, paymentNow.Customer_Payment_Deadline_Date, "CRD", false, (paymentNow.bank.Currency_ID == 1) ? paymentNow.Customer_Payment_Total_Dollar : paymentNow.Customer_Payment_Total_Rupiah, "Pembayaran untuk transaksi " + paymentNow.Customer_Payment_ID,kurs,paymentNow.bank.Currency_ID);
                // Insert to Bank
                string code = (paymentNow.Payment_Category_ID == 1) ? "CSHDBT" : "BGDBT";
                code = code + "-" + paymentNow.Customer_ID.ToString("D3");
                BankController.insertBankTransaction(paymentNow.Bank_ID, paymentNow.Customer_Payment_Deadline_Date, code, true, (paymentNow.bank.Currency_ID == 1) ? paymentNow.Customer_Payment_Total_Dollar : paymentNow.Customer_Payment_Total_Rupiah, "Pembayaran " + paymentNow.payment_category.Payment_Category_Name + " untuk transaksi " + paymentNow.Customer_Payment_ID,kurs);
            }
            if (_rdNotifDelay.Checked)
            {
                CustomerTransaction.delayPayment(paymentNow.Customer_Payment_ID,_cbNotifDelayDate.Value); 
            }
            this.Close();
        }

    }
}
