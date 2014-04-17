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
    public partial class BankReport : Form
    {
        public BankReport()
        {
            InitializeComponent();
            var bankList = BankController.getBankWithCash();
            _cbtransBankName.DataSource = bankList;
            _cbtransBankName.DisplayMember = "Bank_Name";
            _cbtransBankName.ValueMember = "Bank_ID";
            _ttransBankTo.Value = DateTime.Now;
            _ttransBankFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void RefreshReport()
        {
            try
            {
                bank bankNow = _cbtransBankName.SelectedItem as bank;
                var list = BankController.getBankTransaction(Convert.ToInt32(_cbtransBankName.SelectedValue), _ttransBankFrom.Value, _ttransBankTo.Value)
                    .OrderByDescending(x => x.Bank_Transaction_Date)
                    .ToList();

                if (bankNow.Currency_ID == 2)
                {
                    rptBankTransaction rpt = new rptBankTransaction();
                    if (list.Count() > 0) rpt.SetDataSource(list);
                    string bankTitle = bankNow.Bank_Name + " Account Report";
                    rpt.SetParameterValue("Bank", bankTitle);
                    rpt.SetParameterValue("DateFromTo", _ttransBankFrom.Value.ToString("D") + " - " + _ttransBankTo.Value.ToString("D"));
                    _rptBank.ReportSource = rpt;
                }
                else
                {
                    rptBankTransactionDollar rpt = new rptBankTransactionDollar();
                    if (list.Count() > 0) rpt.SetDataSource(list);
                    string bankTitle = bankNow.Bank_Name + " Account Report";
                    rpt.SetParameterValue("Bank", bankTitle);
                    rpt.SetParameterValue("DateFromTo", _ttransBankFrom.Value.ToString("D") + " - " + _ttransBankTo.Value.ToString("D"));
                    _rptBank.ReportSource = rpt; 
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void _cbtransBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void _ttransBankFrom_ValueChanged(object sender, EventArgs e)
        {
        }

        private void _ttransBankTo_ValueChanged(object sender, EventArgs e)
        {
        }

        private void _bbankView_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }
    }
}
