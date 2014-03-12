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
        private Dictionary<string, int> dictBank;

        public _insertBankTransaction()
        {
            InitializeComponent();
            BankId = -1;
            _cbtransBankName.Visible = true;
            _lbtransBankName.Visible = false;
            dictBank = new Dictionary<string, int>();
            var bankList = BankController.getBank().ToList();
            bankList.Insert(0, BankController.getCash());
            foreach (bank bankNow in bankList)
            {
                _cbtransBankName.Items.Add(bankNow.Bank_Name);
                dictBank[bankNow.Bank_Name] = bankNow.Bank_ID;
            }
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
                else BankId = dictBank[_cbtransBankName.SelectedItem.ToString()];
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
                int BankId = dictBank[_cbtransBankName.SelectedItem.ToString()];
                bank bankNow = BankController.getBankWithCash(BankId).First();
                _lbtransCurrency.Text = bankNow.currency.Currency_Name;
            }
        }
    }
}
