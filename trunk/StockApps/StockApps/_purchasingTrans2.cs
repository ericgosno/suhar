﻿using System;
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
    public partial class _purchasingTrans2 : Form
    {
        private supplier_transaction transNow;
        public _purchasingTrans2(supplier_transaction transNow)
        {
            InitializeComponent();
            _lblPurName.Text = transNow.supplier.Supplier_Company_Name;
            _lblPurNPWP.Text = transNow.supplier.Supplier_NPWP;
            _lPurKurs.Text = transNow.Supplier_Transaction_Kurs.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            if (transNow.Currency_ID == 1)
            {
                _lPurTotal.Text = Convert.ToDecimal(transNow.Supplier_Transaction_Dollar).ToString("C2");
                _lPurTax.Text = Convert.ToDecimal(transNow.Supplier_Transaction_PPN_Dollar).ToString("C2");
                _lPurTotalTax.Text = Convert.ToDecimal(transNow.Supplier_Transaction_Total_Dollar).ToString("C2");
            }
            else
            {
                _lPurTotal.Text = Convert.ToDecimal(transNow.Supplier_Transaction_Rupiah).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                _lPurTax.Text = Convert.ToDecimal(transNow.Supplier_Transaction_PPN_Rupiah).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                _lPurTotalTax.Text = Convert.ToDecimal(transNow.Supplier_Transaction_Total_Rupiah).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            }
            _cbPurPayWith.DataSource = PaymentController.getPaymentCategory();
            _cbPurPayWith.DisplayMember = "Payment_Category_Name";
            _cbPurPayWith.ValueMember = "Payment_Category_ID";
            this.transNow = transNow;

            _cbPurBank.DataSource = BankController.getBankWithCash();
            _cbPurBank.DisplayMember = "Bank_Name";
            _cbPurBank.ValueMember = "Bank_ID";
        }

        private void _bcusInsert_Click(object sender, EventArgs e)
        {
            SupplierTransaction.insertSupplierPayment(transNow, Convert.ToInt32(_cbPurBank.SelectedValue), _dateJatuhTempo.Value, Convert.ToInt32(_cbPurPayWith.SelectedValue));
            SupplierController.insertSupplierCredit(transNow.Supplier_ID, transNow.Supplier_Transaction_Date, "DBT", true, transNow.Supplier_Transaction_Total_Rupiah, "Pembayaran dilakukan secara " + _cbPurPayWith.Text + " jatuh tempo pada tanggal " + _dateJatuhTempo.Value.ToString("D", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")));
            MessageBox.Show("Transaction Inserted Succesfully");
            this.Close();
        }
    }
}
