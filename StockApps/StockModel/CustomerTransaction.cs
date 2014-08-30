using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class CustomerTransaction
    {
        public static customer_transaction insertCustomerTransaction(DateTime transDate, int customerID, double totalDollar, double totalRupiah, string description, List<customer_transaction_product> transProd, string noteNumber, int currencyId,decimal kurs)
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
            newTrans.Customer_Transaction_Kurs = kurs;
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

        public static customer_payment insertCustomerPayment(customer_transaction transactionNows,int bankId, DateTime deadlineDate,int paymentCategory)
        {
            customer_payment newPayment = new customer_payment();
            newPayment.Customer_Payment_ID = transactionNows.Customer_Transaction_ID;
            newPayment.Bank_ID = bankId;
            newPayment.Currency_ID = transactionNows.Currency_ID;
            newPayment.Customer_ID = transactionNows.Customer_ID;
            newPayment.Payment_Category_ID = paymentCategory;
            newPayment.Customer_Payment_Date = transactionNows.Customer_Transaction_Date;
            newPayment.Customer_Payment_Deadline_Date = deadlineDate;
            newPayment.Customer_Payment_Dollar = transactionNows.Customer_Transaction_Dollar;
            newPayment.Customer_Payment_Kurs = transactionNows.Customer_Transaction_Kurs;
            newPayment.Customer_Payment_PPN_Dollar = transactionNows.Customer_Transaction_PPN_Dollar;
            newPayment.Customer_Payment_PPN_Rupiah = transactionNows.Customer_Transaction_PPN_Rupiah;
            newPayment.Customer_Payment_Rupiah = transactionNows.Customer_Transaction_Rupiah;
            newPayment.Customer_Payment_Total_Dollar = transactionNows.Customer_Transaction_Total_Dollar;
            newPayment.Customer_Payment_Total_Rupiah = transactionNows.Customer_Transaction_Total_Rupiah;
            newPayment.Customer_Payment_Status = 1;
            newPayment.customer_transaction.Add(transactionNows);
            StockEntity.Entity.AddTocustomer_payment(newPayment);
            StockEntity.Entity.SaveChanges();
            return newPayment;
        }

        public static IQueryable<customer_payment> getDeadlinePayment()
        {
            var list = (from f in StockEntity.Entity.customer_payment
                        where f.Customer_Payment_Status == 1 && f.Customer_Payment_Deadline_Date.CompareTo(DateTime.Now) <= 0
                        select f);
            return list;
        }

        public static IQueryable<customer_transaction> getCustomer(int Id)
        {
            var list = (from f in StockEntity.Entity.customer_transaction
                        where f.Customer_ID == Id
                        select f);
            return list;
        }

        public static bool confirmPayment(string paymentID)
        {
            var payment = (from f in StockEntity.Entity.customer_payment
                           where f.Customer_Payment_ID == paymentID
                           select f);
            if (payment.Count() <= 0) return false;
            var paymentNow = payment.First();
            paymentNow.Customer_Payment_Status = 2;
            StockEntity.Entity.SaveChanges();
            return true;
        }
        public static bool delayPayment(string paymentID, DateTime newDeadline)
        {
            var payment = (from f in StockEntity.Entity.customer_payment
                           where f.Customer_Payment_ID == paymentID
                           select f);
            if (payment.Count() <= 0) return false;
            var paymentNow = payment.First();
            paymentNow.Customer_Payment_Deadline_Date = newDeadline;
            StockEntity.Entity.SaveChanges();
            return true; 
        }

        public static IQueryable<customer_transaction> getCustomerTransaction()
        {
            var list = (from f in StockEntity.Entity.customer_transaction
                        select f);
            return list;
        }
        public static IQueryable<customer_transaction> getCustomerTransaction(string TransID)
        {
            return getCustomerTransaction().Where(x => x.Customer_Transaction_ID == TransID); 
        }
        public static IQueryable<customer_transaction> getCustomerTransaction(int CustomerID, DateTime from, DateTime to)
        {
            var list = getCustomerTransaction().Where(x => x.Customer_Transaction_Date.CompareTo(from) >= 0 && x.Customer_Transaction_Date.CompareTo(to) <= 0);
            if (CustomerID != -1)
            {
               list = list.Where(x => x.Customer_ID == CustomerID);
            }
            List<customer_transaction> test = list.ToList();

            return list;
        }
        public static IQueryable<customer_transaction> getCustomerTransaction(int CustomerID)
        {
            var list = getCustomerTransaction().Where(x => x.Customer_ID == CustomerID);
            return list;
        }

        public static IQueryable<customer_transaction_product> getCustomerTransactionProduct()
        {
            var list = (from f in StockEntity.Entity.customer_transaction_product
                       select f);
            return list;
        }
        public static IQueryable<customer_transaction_product> getCustomerTransactionProduct(int ProductID)
        {
            return getCustomerTransactionProduct().Where(x => x.Product_ID == ProductID); 
        }
    }
}
