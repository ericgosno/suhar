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
            RefreshReport();
        }

        private void RefreshReport()
        {
            try
            {
                rptBankTransaction rpt = new rptBankTransaction();
                var list = BankController.getBankTransaction(Convert.ToInt32(_cbtransBankName.SelectedValue), _ttransBankFrom.Value, _ttransBankTo.Value).ToList();
                rpt.SetDataSource(list);

                rpt.SetParameterValue("Bank", (_cbtransBankName.SelectedItem as bank).Bank_Name);
                _rptBank.ReportSource = rpt;
            }
            catch (Exception ex) { }
        }

        private void _cbtransBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void _ttransBankFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void _ttransBankTo_ValueChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }
    }
}
