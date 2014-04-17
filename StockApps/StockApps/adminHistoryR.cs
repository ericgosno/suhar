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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using StockModel;

namespace StockApps
{
    public partial class adminHistoryR : Form
    {
        public adminHistoryR()
        {
            InitializeComponent();
            _tHistoryTo.Value = DateTime.Now;
            _tHistoryFrom.Value = DateTime.Now.AddDays(-30);
             RefreshReport();
        }

        private void adminHistoryR_Load(object sender, EventArgs e)
        {
           
        }

        private void RefreshReport()
        {
            adminReport rpt = new adminReport();
            var listHistory = UserController.getHistoryUser(_tHistoryFrom.Value,_tHistoryTo.Value);
            var listUser = UserController.getUser();
            var list = listHistory
                .Join(listUser,
                admin_history => admin_history.users_id,
                user => user.users_id,
                (admin_history, user) => new { admin_history = admin_history, user = user })
                .OrderByDescending(x => x.admin_history.time_log.Value)
                .AsEnumerable()
                .Select(join => new
                    {
                        users_id = join.user.users_id + "",
                        users_username = join.user.users_username + "",
                        log_type = join.admin_history.log_type + "",
                        time_log = join.admin_history.time_log.Value + ""
                    }).ToList();
            identity ident = IdentityController.getIdentity();
            rpt.SetDataSource(list);
            rpt.SetParameterValue("IdentityCompanyName", ident.Identity_Company_Name);
            rpt.SetParameterValue("IdentityAddress", ident.Identity_Address + "\n" + ident.Identity_City);
            rpt.SetParameterValue("IdentityPhone", "Telp : " + ident.Identity_Phone);
            _rptHistory.ReportSource = rpt; 
        }


        private void _bHistoryView_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }
    
    }
}
