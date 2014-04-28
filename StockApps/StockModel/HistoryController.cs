using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Reflection;

namespace StockModel
{
    public static class HistoryController
    {

        public static void RemoveOldHistory(int limitDay)
        {
            DateTime limit = DateTime.Now.AddDays(-1 * limitDay);
            var list = (from f in StockEntity.Entity.admin_history
                       where f.time_log < limit
                       select f).ToList();

            foreach (admin_history hist in list)
            {
                StockEntity.Entity.DeleteObject(hist);
            }
            StockEntity.Entity.SaveChanges();
        }
    }
}
