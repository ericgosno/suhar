using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using StockModel;
namespace StockApps
{
    public partial class _history : Form
    {
        public _history()
        {
            InitializeComponent();
        }

        private void _history_Load(object sender, EventArgs e)
        {
            
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockModel\cr1.rpt");
            report.SetDatabaseLogon("eric", "eric", "119.235.248.242", "stockapps");

            //report.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockApps\CrystalReport1.rpt");

            /*
            report.SetDataSource(from f in StockModel.StockEntity.Entity.users
                                 select new { f.users_username });*/
            
            crystalReportViewer1.ReportSource = report;
        }
    }
}
