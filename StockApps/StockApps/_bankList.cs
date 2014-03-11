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
    public partial class _bankList : Form
    {
        private Dictionary<string, int> dictCurrency;
        private int selectedId;
        public _bankList()
        {
            InitializeComponent();
            selectedId = -1;
            dictCurrency = new Dictionary<string, int>();
            var listCurrency = CurrencyController.getCurrency();
            foreach (currency cur in listCurrency)
            {
                _cbankCurrency.Items.Add(cur.Currency_Name);
                dictCurrency[cur.Currency_Name] = cur.Currency_ID;
            }
            RefreshForm();
        }

        private void RefreshForm()
        {
            _bbankInsert.Text = "INSERT";
            _tbankName.Text = "";
            _cbankCurrency.SelectedIndex = -1;
            selectedId = -1;
            var listBank = BankController.getBank();
            var listCurrency = CurrencyController.getCurrency();
            var list = listBank
                .Join(listCurrency,
                 bank => bank.Currency_ID,
                 currency => currency.Currency_ID,
                 (bank, currency) => new { bank = bank, currency = currency })
                .AsEnumerable()
                .Select(join => new
                 {
                     Bank_ID = join.bank.Bank_ID + "",
                     Bank_Name = join.bank.Bank_Name + "",
                     Bank_Current_Money = join.bank.Bank_Current_Money+"",
                     Currency_ID = join.currency.Currency_ID+"",
                     Currency_Name = join.currency.Currency_Name+""
                 }).ToList();

            _dataBank.DataSource = list;
            _dataBank.Columns["Bank_Name"].HeaderText = "Name";
            _dataBank.Columns["Bank_Current_Money"].HeaderText = "Current Balance";
            _dataBank.Columns["Currency_Name"].HeaderText = "Currency";

            _dataBank.Columns["Bank_ID"].Visible = false;
            _dataBank.Columns["Currency_ID"].Visible = false;
            _dataBank.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataBank.Refresh();
        }

        private void _bbankInsert_Click(object sender, EventArgs e)
        {
            if (_tbankName.Text == "")
            {
                MessageBox.Show("Name must be filled!");
                return;
            }

            if (_cbankCurrency.SelectedIndex == -1)
            {
                MessageBox.Show("Currency must be selected");
                return;
            }
            if (selectedId == -1)
            {
                BankController.insertBank(_tbankName.Text, dictCurrency[_cbankCurrency.SelectedItem.ToString()]);
            }
            else
            {
                BankController.updateBank(selectedId,_tbankName.Text, dictCurrency[_cbankCurrency.SelectedItem.ToString()]);
            }
            RefreshForm();
        }

        private void _dataBank_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var bankNow = BankController.getBank(Convert.ToInt32(_dataBank.SelectedRows[0].Cells["Bank_ID"].Value)).First();
                selectedId = bankNow.Bank_ID;
                _tbankName.Text = bankNow.Bank_Name;
                _cbankCurrency.SelectedItem = bankNow.currency.Currency_Name;
                _bbankInsert.Text = "UPDATE";
            }
            catch (Exception ex)
            {
                selectedId = -1;
                _bbankInsert.Text = "INSERT";
            }
        }

        private void _bbankReset_Click(object sender, EventArgs e)
        {
            _bbankInsert.Text = "INSERT";
            _tbankName.Text = "";
            _cbankCurrency.SelectedIndex = -1;
            selectedId = -1;
        }

        private void _bbankDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BankController.deleteBank(Convert.ToInt32(_dataBank.SelectedRows[0].Cells["Bank_ID"].Value));
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

    
    }
}
