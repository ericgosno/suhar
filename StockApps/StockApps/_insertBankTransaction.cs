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
    public partial class _insertBankTransaction : Form
    {
        private int BankId;

        public _insertBankTransaction()
        {
            InitializeComponent();
            
            _cbtransBankName.Visible = true;
            _lbtransBankName.Visible = false;
            var bankList = BankController.getBankWithCash();
            _cbtransBankName.DataSource = bankList;
            _cbtransBankName.DisplayMember = "Bank_Name";
            _cbtransBankName.ValueMember = "Bank_ID";
            BankId = Convert.ToInt32(_cbtransBankName.SelectedValue);
            _lbtransCurrency.Text = "";
        }

        public _insertBankTransaction(bank bankNow)
        {
            InitializeComponent();
            this.BankId = bankNow.Bank_ID;
            _lbtransBankName.Text = bankNow.Bank_Name;
            _lbtransCurrency.Text = bankNow.currency.Currency_Name;
            _cbtransBankName.Visible = false;
            _lbtransBankName.Visible = true;
        }

        private void _bbtransInsert_Click(object sender, EventArgs e)
        {
            decimal nominal = 0;
            try
            {
                nominal = Convert.ToDecimal(_tbtransMoney.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nominal must be a decimal number!");
                return;
            }
            if (_cbtransDebitCredit.SelectedIndex == -1)
            {
                MessageBox.Show("You must select debit/credit!");
                return;
            }
            if (BankId == -1)
            {
                if (_cbtransBankName.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select bank first!");
                    return;
                }
                else BankId = Convert.ToInt32(_cbtransBankName.SelectedValue);
            }
            bank_transaction newTrans = BankController.insertBankTransaction(BankId, _cbtransDate.Value, _tbtransCode.Text, (_cbtransDebitCredit.SelectedIndex == 0), nominal, _tbtransDescription.Text);
            if (newTrans != null)
            {
                MessageBox.Show("Create Transaction Successfully!");
            }
            this.Close();
        }

        private void _cbtransBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cbtransBankName.SelectedIndex == -1)
            {
                int BankId = Convert.ToInt32(_cbtransBankName.SelectedValue);
                bank bankNow = BankController.getBankWithCash(BankId).First();
                _lbtransCurrency.Text = bankNow.currency.Currency_Name;
            }
        }
    }
}
