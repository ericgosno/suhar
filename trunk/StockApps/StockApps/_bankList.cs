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
        private int selectedId;
        public _bankList()
        {
            InitializeComponent();
            selectedId = -1;
            var listCurrency = CurrencyController.getCurrency();
            _cbankCurrency.DataSource = listCurrency;
            _cbankCurrency.DisplayMember = "Currency_Name";
            _cbankCurrency.ValueMember = "Currency_ID";
            RefreshForm();
        }

        private void RefreshForm()
        {
            _bbankInsert.Text = "INSERT";
            _tbankName.Text = "";
            _cbankCurrency.SelectedIndex = -1;
            selectedId = -1;
            var listBank = BankController.getBankWithCash();
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
                     Bank_Current_Money = (join.currency.Currency_ID == 1 ? join.bank.Bank_Current_Money.ToString("C2") : join.bank.Bank_Current_Money.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"))) +"",
                     Currency_ID = join.currency.Currency_ID+"",
                     Currency_Name = join.currency.Currency_Name+""
                 }).ToList();

            _dataBank.DataSource = list;
            _dataBank.Columns["Bank_Name"].HeaderText = "Name";
            _dataBank.Columns["Bank_Current_Money"].HeaderText = "Current Balance";
            _dataBank.Columns["Currency_Name"].HeaderText = "Currency";

            _dataBank.Columns["Bank_ID"].Visible = false;
            _dataBank.Columns["Currency_ID"].Visible = false;


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                dataGridView1.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            }
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
                BankController.insertBank(_tbankName.Text, Convert.ToInt32(_cbankCurrency.SelectedValue.ToString()));
            }
            else
            {
                BankController.updateBank(selectedId, _tbankName.Text, Convert.ToInt32(_cbankCurrency.SelectedValue.ToString()));
            }
            RefreshForm();
        }

        private void _dataBank_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rowNow = null;
                if (_dataBank.CurrentCell != null)
                {
                    rowNow = _dataBank.SelectedCells[0].OwningRow;
                }
                else if (_dataBank.CurrentRow != null)
                {
                    rowNow = _dataBank.SelectedRows[0];
                }
                var bankNow = BankController.getBankWithCash(Convert.ToInt32(rowNow.Cells["Bank_ID"].Value)).First();
                selectedId = bankNow.Bank_ID;
                _tbankName.Text = bankNow.Bank_Name;
                _cbankCurrency.SelectedValue = bankNow.currency.Currency_ID;
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
                DataGridViewRow rowNow = null;
                if (_dataBank.CurrentCell != null)
                {
                    rowNow = _dataBank.SelectedCells[0].OwningRow;
                }
                else if (_dataBank.CurrentRow != null)
                {
                    rowNow = _dataBank.SelectedRows[0];
                }
                int bankID = Convert.ToInt32(rowNow.Cells["Bank_ID"].Value);
                if (BankController.getBankTransaction(bankID).Count() > 0)
                {
                    MessageBox.Show("Can't delete this bank, Only bank with no transaction can be deleted!");
                    return;
                }
                BankController.deleteBank(bankID);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _bankList_Load(object sender, EventArgs e)
        {

        }

    
    }
}
