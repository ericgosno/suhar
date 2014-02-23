using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class CurrencyController
    {
        public static IQueryable<currency> getCurrency()
        {
            var list = from f in StockEntity.Entity.currencies
                       select f;
            return list;
        }

        public static IQueryable<currency> getCurrency(int CurrencyID)
        {
            return getCurrency().Where(a => a.Currency_ID == CurrencyID);
        }
    }
}
