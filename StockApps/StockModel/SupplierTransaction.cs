using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class SupplierTransaction
    {
        public static supplier_transaction insertSupplierTransaction(DateTime transDate, int supplierId, double totalDollar, double totalRupiah, string description, List<supplier_transaction_product> transProd, string noteNumber,string invoice, int currencyId, decimal kurs)
        {
            supplier_transaction newTrans = new supplier_transaction();
            string idnow = null;
            int code = 1;
            while (true)
            {
                string codeStr = code.ToString("D4");
                string supplierStr = supplierId.ToString("D3");
                string dateStr = transDate.ToString("yyyyMMdd");
                idnow = supplierStr + "-" + dateStr + "-" + codeStr;
                var checkID = from f in StockEntity.Entity.supplier_transaction
                              where f.Supplier_Transaction_ID == idnow
                              select f;
                if (checkID.Count() > 0) code++;
                else break;
            }

            newTrans.Supplier_Transaction_ID = idnow;
            newTrans.Supplier_ID = supplierId;
            newTrans.Supplier_Transaction_Date = transDate;
            newTrans.Supplier_Transaction_Status = 1;
            newTrans.Supplier_Transaction_Description = description;
            decimal dolar = Convert.ToDecimal(totalDollar);
            decimal rupiah = Convert.ToDecimal(totalRupiah);
            newTrans.Supplier_Transaction_Dollar = dolar;
            newTrans.Supplier_Transaction_Rupiah = rupiah;
            newTrans.Supplier_Transaction_PPN_Dollar = 0.1M * dolar;
            newTrans.Supplier_Transaction_PPN_Rupiah = 0.1M * rupiah;
            newTrans.Supplier_Transaction_Total_Dollar = 1.1M * dolar;
            newTrans.Supplier_Transaction_Total_Rupiah = 1.1M * rupiah;
            newTrans.Supplier_Transaction_Note_Number = noteNumber;
            newTrans.Supplier_Transaction_Invoice_Number = invoice;
            newTrans.Currency_ID = currencyId;
            newTrans.Supplier_Transaction_Kurs = kurs;
            StockEntity.Entity.AddTosupplier_transaction(newTrans);
            StockEntity.Entity.SaveChanges();
            
            foreach (supplier_transaction_product prod in transProd)
            {
                prod.supplier_transaction = newTrans;
                StockEntity.Entity.AddTosupplier_transaction_product(prod);
                ProductController.changeProductStock(prod.Product_ID, prod.Supplier_Transaction_Product_Quantity);
            }
            StockEntity.Entity.SaveChanges();
            return newTrans;
        }

        public static supplier_payment insertSupplierPayment(supplier_transaction transactionNows, int bankId, DateTime deadlineDate, int paymentCategory)
        {
            supplier_payment newPayment = new supplier_payment();
            newPayment.Supplier_Payment_ID = transactionNows.Supplier_Transaction_ID;
            newPayment.Bank_ID = bankId;
            newPayment.Currency_ID = transactionNows.Currency_ID;
            newPayment.Supplier_ID = transactionNows.Supplier_ID;
            newPayment.Payment_Category_ID = paymentCategory;
            newPayment.Supplier_Payment_Date = transactionNows.Supplier_Transaction_Date;
            newPayment.Supplier_Payment_Deadline_Date = deadlineDate;
            newPayment.Supplier_Payment_Dollar = transactionNows.Supplier_Transaction_Dollar;
            newPayment.Supplier_Payment_Kurs = transactionNows.Supplier_Transaction_Kurs;
            newPayment.Supplier_Payment_PPN_Dollar = transactionNows.Supplier_Transaction_PPN_Dollar;
            newPayment.Supplier_Payment_PPN_Rupiah = transactionNows.Supplier_Transaction_PPN_Rupiah;
            newPayment.Supplier_Payment_Rupiah = transactionNows.Supplier_Transaction_Rupiah;
            newPayment.Supplier_Payment_Total_Dollar = transactionNows.Supplier_Transaction_Total_Dollar;
            newPayment.Supplier_Payment_Total_Rupiah = transactionNows.Supplier_Transaction_Total_Rupiah;
            newPayment.Supplier_Payment_Status = 1;
            newPayment.supplier_transaction.Add(transactionNows);
            StockEntity.Entity.AddTosupplier_payment(newPayment);
            StockEntity.Entity.SaveChanges();
            return newPayment;
        }

        public static IQueryable<supplier_payment> getDeadlinePayment()
        {
            var list = (from f in StockEntity.Entity.supplier_payment
                        where f.Supplier_Payment_Status == 1 && f.Supplier_Payment_Deadline_Date.CompareTo(DateTime.Now) <= 0
                        select f);
            return list;
        }

        public static bool confirmPayment(string paymentID)
        {
            var payment = (from f in StockEntity.Entity.supplier_payment
                           where f.Supplier_Payment_ID == paymentID
                           select f);
            if (payment.Count() <= 0) return false;
            var paymentNow = payment.First();
            paymentNow.Supplier_Payment_Status = 2;
            StockEntity.Entity.SaveChanges();
            return true;
        }
        public static bool delayPayment(string paymentID, DateTime newDeadline)
        {
            var payment = (from f in StockEntity.Entity.supplier_payment
                           where f.Supplier_Payment_ID == paymentID
                           select f);
            if (payment.Count() <= 0) return false;
            var paymentNow = payment.First();
            paymentNow.Supplier_Payment_Deadline_Date = newDeadline;
            StockEntity.Entity.SaveChanges();
            return true;
        }

        public static void CancelSupplierTransaction(string TransactionID)
        {
            /* Revert Transaction */
            supplier_transaction TransNow = getSupplierTransaction(TransactionID).First();
            foreach (supplier_transaction_product prod in TransNow.supplier_transaction_product.ToList())
            {
                ProductController.changeProductStock(prod.Product_ID, -1 * Convert.ToInt32(prod.Supplier_Transaction_Product_Quantity));
                StockEntity.Entity.DeleteObject(prod);
            }
            StockEntity.Entity.DeleteObject(TransNow);
            StockEntity.Entity.SaveChanges();
        }
        public static void FixSupplierTransaction()
        {
            List<supplier_transaction> list = (from f in StockEntity.Entity.supplier_transaction
                                               where f.supplier_payment.Count() == 0
                                               select f).ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                string id = list[i].Supplier_Transaction_ID;
                IQueryable<supplier_payment> payment = (from f in StockEntity.Entity.supplier_payment
                                                        where f.Supplier_Payment_ID == id
                                                        select f);
                if (payment.Count() > 0)
                {
                    list[i].supplier_payment.Add(payment.First());
                }
                else
                {
                    /* Revert Transaction */
                    foreach (supplier_transaction_product prod in list[i].supplier_transaction_product.ToList())
                    {
                        ProductController.changeProductStock(prod.Product_ID, -1 * Convert.ToInt32(prod.Supplier_Transaction_Product_Quantity));
                        StockEntity.Entity.DeleteObject(prod);
                    }
                    StockEntity.Entity.DeleteObject(list[i]);
                }
            }
            StockEntity.Entity.SaveChanges();
        }

        public static IQueryable<supplier_transaction> getSupplierTransaction()
        {
            var list = (from f in StockEntity.Entity.supplier_transaction
                        select f);
            return list;
        }
        public static IQueryable<supplier_transaction> getSupplierTransaction(string TransID)
        {
            return getSupplierTransaction().Where(x => x.Supplier_Transaction_ID == TransID);
        }
        public static IQueryable<supplier_transaction> getSupplierTransaction(int SupplierID, DateTime from, DateTime to)
        {
            var list = getSupplierTransaction().Where(x => x.Supplier_Transaction_Date.CompareTo(from) >= 0 && x.Supplier_Transaction_Date.CompareTo(to) <= 0);
            if (SupplierID != -1) list = list.Where(x => x.Supplier_ID == SupplierID);
            return list;
        }
        public static IQueryable<supplier_transaction> getSupplierTransaction(int SupplierID)
        {
            var list = getSupplierTransaction().Where(x => x.Supplier_ID == SupplierID);
            return list;
        }
        public static IQueryable<supplier_transaction_product> getSupplierTransactionProduct()
        {
            var list = (from f in StockEntity.Entity.supplier_transaction_product
                        select f);
            return list;
        }
        public static IQueryable<supplier_transaction_product> getSupplierTransactionProduct(int ProductID)
        {
            return getSupplierTransactionProduct().Where(x => x.Product_ID == ProductID);
        }
    }
}
