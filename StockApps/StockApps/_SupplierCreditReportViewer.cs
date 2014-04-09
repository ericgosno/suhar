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
    public partial class _SupplierCreditReportViewer : Form
    {
        public _SupplierCreditReportViewer()
        {
            InitializeComponent();
            var supplierList = SupplierController.getSupplier();
            _cbtransCreditName.DataSource = supplierList;
            _cbtransCreditName.DisplayMember = "Supplier_Company_Name";
            _cbtransCreditName.ValueMember = "Supplier_ID";
            _ttransCreditTo.Value = DateTime.Now;
            _ttransCreditFrom.Value = DateTime.Now.AddDays(-30);
        }
        private void RefreshReport()
        {
            try
            {
                rptSupplierCredit rpt = new rptSupplierCredit();
                var list = SupplierController.getSupplierCredit(Convert.ToInt32(_cbtransCreditName.SelectedValue), _ttransCreditFrom.Value, _ttransCreditTo.Value)
                    .OrderByDescending(x => x.Supplier_Credit_Date).ToList();
                if (list.Count() > 0) rpt.SetDataSource(list);

                supplier custNow = _cbtransCreditName.SelectedItem as supplier;
                rpt.SetParameterValue("SupplierName", "Supplier : " + custNow.Supplier_Company_Name);
                rpt.SetParameterValue("DateFromTo", _ttransCreditFrom.Value.ToString("D") + " - " + _ttransCreditTo.Value.ToString("D"));
                _rptCredit.ReportSource = rpt;
            }
            catch (Exception ex) { }
        }

        private void _bCreditView_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }
    }
}
