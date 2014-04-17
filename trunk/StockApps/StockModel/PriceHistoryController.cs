using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class PriceHistoryController
    {
        public static void insertPriceHistory(int productID,decimal price, DateTime datePrice, int amount, int currencyId)
        {
            //check last history for this product
            var histNow = (from f in StockEntity.Entity.price_history
                           where f.Product_ID == productID && f.Price_History_IsLast == 1
                           select f);
            // there isn't a history yet then create one
            if (histNow.Count() <= 0 || Math.Abs(histNow.First().Price_History_Price - price) > 0.01M)
            {
                price_history ph = new price_history();

                string idnow = null;
                int code = 1;
                while (true)
                {
                    string codeStr = code.ToString("D4");
                    string productStr = productID.ToString("D3");
                    string dateStr = datePrice.ToString("yyyyMMdd");
                    idnow = productStr + "-" + dateStr + "-" + codeStr;
                    var checkID = from f in StockEntity.Entity.price_history
                                  where f.Price_History_ID == idnow
                                  select f;
                    if (checkID.Count() > 0) code++;
                    else break;
                }
                foreach(price_history ph1 in histNow)
                {
                    ph1.Price_History_IsLast = 0;
                }
                ph.Price_History_Date = datePrice;
                ph.Price_History_ID = idnow;
                ph.Price_History_IsLast = 1;
                ph.Price_History_Price = price;
                ph.Price_History_Stock = amount;
                ph.Price_History_Used_Stock = 0;
                ph.Price_History_Status = 1;
                ph.Product_ID = productID;
                ph.Currency_ID = currencyId;
                StockEntity.Entity.AddToprice_history(ph);
            }
            else
            {
                price_history historyNow = histNow.First();
                historyNow.Price_History_Stock += amount;
                if (historyNow.Price_History_Stock > historyNow.Price_History_Used_Stock) historyNow.Price_History_Status = 1;
            }
            StockEntity.Entity.SaveChanges();
        }

        public static void reduceAmountHistory(int productID, int amount)
        {
            var histNow = (from f in StockEntity.Entity.price_history
                           where f.Product_ID == productID && f.Price_History_Status == 1
                           orderby f.Price_History_Date ascending
                           select f).ToList();
            int amountNow = amount;
            foreach (price_history ph in histNow)
            {
                int newUsed = Math.Min(ph.Price_History_Stock, ph.Price_History_Used_Stock + amountNow);
                int diff = newUsed - ph.Price_History_Used_Stock;
                amountNow -= diff;
                ph.Price_History_Used_Stock = newUsed;
                if (ph.Price_History_Stock == ph.Price_History_Used_Stock) ph.Price_History_Status = 2;
                if (amountNow == 0) break;
            }
            StockEntity.Entity.SaveChanges();
        }

        public static IQueryable<price_history> getPriceHistory(int productID,bool showAll, DateTime fromDate, DateTime toDate)
        {
            var list = (from f in StockEntity.Entity.price_history
                        where f.Product_ID == productID && f.Price_History_Date.CompareTo(fromDate) >= 0 && f.Price_History_Date.CompareTo(toDate) <= 0
                        select f);
            if (showAll == false) list = list.Where(x => x.Price_History_Status == 1);
            list = list.OrderByDescending(x => x.Price_History_Date);
            return list;
        }
    }
}
