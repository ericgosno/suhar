using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace StockModel
{
    public static class ConnectionController
    {
        public static void ChangeConnectionString(string dbHost, string dbUsername, string dbPassword, string dbDatabase)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["stockappsEntities"].ConnectionString = "metadata=res://*/StockApps.csdl|res://*/StockApps.ssdl|res://*/StockApps.msl;provider=MySql.Data.MySqlClient;provider connection string=\"server=" + dbHost + ";User Id=" + dbUsername + ";password= " + dbPassword + ";database=" + dbDatabase + ";Persist Security Info=True\"";            
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
