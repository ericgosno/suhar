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
    public partial class _notificationPaymentSupplier : Form
    {
        private supplier_payment paymentNow;
        public _notificationPaymentSupplier()
        {
            InitializeComponent();
        }

        public _notificationPaymentSupplier(supplier_payment payment)
        {
            InitializeComponent();
            supplier custNow = SupplierController.getSupplier(payment.Supplier_ID).First();

            _lblNotifName.Text = custNow.Supplier_Company_Name;
            _lblNotifAmount.Text = (payment.bank.Currency_ID == 1) ? payment.Supplier_Payment_Total_Dollar.ToString("C2") : payment.Supplier_Payment_Total_Rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lblNotifBank.Text = payment.bank.Bank_Name;
            _lblNotifDate.Text = payment.Supplier_Payment_Date.ToString("D");
            _lblNotifDeadline.Text = payment.Supplier_Payment_Deadline_Date.ToString("D");
            _lblNotifNPWP.Text = custNow.Supplier_NPWP;
            this.paymentNow = payment;
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

                if (kurs <= 0)
                {
                    MessageBox.Show("Kurs must be more than zero!");
                    return;
                }
                // Confirm payment by changing status
                SupplierTransaction.confirmPayment(paymentNow.Supplier_Payment_ID);
                // Insert credit to customer debt list
                SupplierController.insertSupplierCredit(paymentNow.Supplier_ID, paymentNow.Supplier_Payment_Deadline_Date, "CRD", false, (paymentNow.bank.Currency_ID == 1) ? paymentNow.Supplier_Payment_Total_Dollar : paymentNow.Supplier_Payment_Total_Rupiah, "Pembayaran untuk transaksi " + paymentNow.Supplier_Payment_ID, kurs, paymentNow.bank.Currency_ID);
                // Insert to Bank
                string code = (paymentNow.Payment_Category_ID == 1) ? "CSHCRD" : "BGCRD";
                code = code + "-" + paymentNow.Supplier_ID.ToString("D3");
                BankController.insertBankTransaction(paymentNow.Bank_ID, paymentNow.Supplier_Payment_Deadline_Date, code, false, (paymentNow.bank.Currency_ID == 1) ? paymentNow.Supplier_Payment_Total_Dollar : paymentNow.Supplier_Payment_Total_Rupiah, "Pembayaran " + paymentNow.payment_category.Payment_Category_Name + " untuk transaksi " + paymentNow.Supplier_Payment_ID,kurs);
            }
            if (_rdNotifDelay.Checked)
            {
                SupplierTransaction.delayPayment(paymentNow.Supplier_Payment_ID, _cbNotifDelayDate.Value);
            }
            this.Close();
        }

        private void _notificationPaymentSupplier_Load(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(StockApps.Properties.Resources.corner);
            pictureBox1.Image = pic;
            Bitmap pic2 = new Bitmap(StockApps.Properties.Resources.cvusahaSmall);
            pictureBox2.Image = pic2;
        }


    }
}
