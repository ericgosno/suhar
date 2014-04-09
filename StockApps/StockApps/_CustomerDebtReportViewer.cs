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
    public partial class _CustomerDebtReportViewer : Form
    {
        public _CustomerDebtReportViewer()
        {
            InitializeComponent();
            var customerList = CustomerController.getCustomer();
            _cbtransDebtName.DataSource = customerList;
            _cbtransDebtName.DisplayMember = "Customer_Company_Name";
            _cbtransDebtName.ValueMember = "Customer_ID";
            _ttransDebtTo.Value = DateTime.Now;
            _ttransDebtFrom.Value = DateTime.Now.AddDays(-30);
        }

        private void RefreshReport()
        {
            try
            {
                rptCustomerDebt rpt = new rptCustomerDebt();
                var list = CustomerController.getCustomerDebt(Convert.ToInt32(_cbtransDebtName.SelectedValue), _ttransDebtFrom.Value, _ttransDebtTo.Value)
                    .OrderByDescending(x => x.Customer_Debt_Date).ToList();
                if (list.Count() > 0) rpt.SetDataSource(list);

                customer custNow = _cbtransDebtName.SelectedItem as customer;
                rpt.SetParameterValue("CustomerName", "Customer : " + custNow.Customer_Company_Name);
                rpt.SetParameterValue("DateFromTo", _ttransDebtFrom.Value.ToString("D") + " - " + _ttransDebtTo.Value.ToString("D"));
                _rptDebt.ReportSource = rpt;
            }
            catch (Exception ex) { }
        }

        private void _bDebtView_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }
    }
}
