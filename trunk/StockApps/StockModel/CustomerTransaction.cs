﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class CustomerTransaction
    {
        public static customer_transaction insertCustomerTransaction(DateTime transDate, int customerID, double totalDollar, double totalRupiah, string description, List<customer_transaction_product> transProd, string noteNumber, int currencyId)
        {
            customer_transaction newTrans = new customer_transaction();
            string idnow = null;
            int code = 1;
            while (true)
            {
                string codeStr = code.ToString("D4");
                string customerStr = customerID.ToString("D3");
                string dateStr = transDate.ToString("yyyyMMdd");
                idnow = customerStr + "-" + dateStr + "-" + codeStr;
                var checkID = from f in StockEntity.Entity.customer_transaction
                              where f.Customer_Transaction_ID == idnow
                              select f;
                if (checkID.Count() > 0) code++;
                else break;
            }

            newTrans.Customer_Transaction_ID = idnow;
            newTrans.Customer_ID = customerID;
            newTrans.Customer_Transaction_Date = transDate;
            newTrans.Customer_Transaction_Status = 1;
            newTrans.Customer_Transaction_Description = description;
            decimal dolar = Convert.ToDecimal(totalDollar);
            decimal rupiah = Convert.ToDecimal(totalRupiah);
            newTrans.Customer_Transaction_Dollar = dolar;
            newTrans.Customer_Transaction_Rupiah = rupiah;
            newTrans.Customer_Transaction_PPN_Dollar = 0.1M * dolar;
            newTrans.Customer_Transaction_PPN_Rupiah = 0.1M * rupiah;
            newTrans.Customer_Transaction_Total_Dollar = 1.1M * dolar;
            newTrans.Customer_Transaction_Total_Rupiah = 1.1M * rupiah;
            newTrans.Customer_Transaction_Note_Number = noteNumber;
            newTrans.Currency_ID = currencyId;
            StockEntity.Entity.AddTocustomer_transaction(newTrans);
            StockEntity.Entity.SaveChanges();
            
            foreach (customer_transaction_product prod in transProd)
            {
                prod.customer_transaction = newTrans;
                StockEntity.Entity.AddTocustomer_transaction_product(prod);
                ProductController.changeProductStock(prod.Product_ID, -1 * Convert.ToInt32(prod.Customer_Transaction_Product_Quantity));
            }
            StockEntity.Entity.SaveChanges();
            return newTrans;
        }
    }
}
