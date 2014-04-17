using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class CustomerController
    {
        public static customer insertCustomer(string customerName)
        {
            customer newCustomer = new customer();
            newCustomer.Customer_Name = customerName;
            StockEntity.Entity.AddTocustomers(newCustomer);
            StockEntity.Entity.SaveChanges();
            return newCustomer;
        }
        public static customer insertCustomer(string customerName, string customerAddress, string customerEmail, string customerPhone,string customerNPWP,string customerCompany, string customerCity)
        {
            customer newCustomer = new customer();
            newCustomer.Customer_Name = customerName;
            newCustomer.Customer_Address = customerAddress;
            newCustomer.Customer_Email = customerEmail;
            newCustomer.Customer_Phone = customerPhone;
            newCustomer.Customer_Status = 1;
            newCustomer.Customer_NPWP = customerNPWP;
            newCustomer.Customer_Company_Name = customerCompany;
            newCustomer.Customer_City = customerCity;
            StockEntity.Entity.AddTocustomers(newCustomer);
            StockEntity.Entity.SaveChanges();
            return newCustomer;
        }

        public static IQueryable<customer> getCustomer()
        {
            var list = from e in StockEntity.Entity.customers
                       where e.Customer_Status == 1
                       select e;
            return list;
        }

        public static IQueryable<customer> getCustomer(int customerId)
        {
            return getCustomer().Where(a => a.Customer_ID == customerId);
        }

        public static IQueryable<customer> getCustomer(string customerName)
        {
            return getCustomer().Where(a => a.Customer_Name.Contains(customerName));
        }

        public static IQueryable<customer> getCustomer(int customerId, string customerName)
        {
            return getCustomer().Where(a => a.Customer_Name.Contains(customerName) && a.Customer_ID == customerId);
        }

        public static customer editCustomer(int customerId, string customerName, string customerAddress, string customerEmail, string customerPhone,string customerNPWP,string customerCompany,string customerCity)
        {
            customer customerNows = (from f in StockEntity.Entity.customers
                                    where f.Customer_ID == customerId
                                    select f).First();

            customerNows.Customer_Name = customerName;
            customerNows.Customer_Address = customerAddress;
            customerNows.Customer_Email = customerEmail;
            customerNows.Customer_Phone = customerPhone;
            customerNows.Customer_NPWP = customerNPWP;
            customerNows.Customer_Company_Name = customerCompany;
            customerNows.Customer_City = customerCity;
            StockEntity.Entity.SaveChanges();
            return getCustomer(customerId).First();
        }

        public static void deleteCustomer(int customerId)
        {
            customer customerNows = (from f in StockEntity.Entity.customers
                                     where f.Customer_ID == customerId
                                     select f).First();
            customerNows.Customer_Status = 0;
            StockEntity.Entity.SaveChanges();
        }

        public static IQueryable<customer_debt> getCustomerDebt()
        {
            var list = (from f in StockEntity.Entity.customer_debt
                        select f);
            return list;
        }

        public static IQueryable<customer_debt> getCustomerDebt(int customerID, DateTime from, DateTime to)
        {
            return getCustomerDebt().Where(x => x.Customer_ID == customerID && x.Customer_Debt_Date.CompareTo(from) >= 0 && x.Customer_Debt_Date.CompareTo(to) <= 0);
        }

        public static customer_debt insertCustomerDebt(int customerID, DateTime debtDate, string debtCode, bool isDebit, decimal money, string description,decimal kurs, int currencyID)
        {
            customer_debt newTrans = new customer_debt();
            var customerNow = (from f in StockEntity.Entity.customers
                            where f.Customer_ID == customerID
                           select f);
            if (customerNow.Count() <= 0) return null;
            string idnow;
            int code = 1;
            while (true)
            {
                string bankStr = customerID.ToString("D3");
                string dateStr = debtDate.ToString("yyyyMMdd");
                string DebitCode = "C";
                if (isDebit) DebitCode = "D";
                string codeStr = code.ToString("D3");

                idnow = bankStr + "-" + dateStr + "-" + (debtCode == "" ? "NULL" : debtCode) + "-" + DebitCode + "-" + codeStr;
                var checkID = from f in StockEntity.Entity.customer_debt
                              where f.Customer_Debt_ID == idnow
                              select f;
                if (checkID.Count() > 0) code++;
                else break;
            }

            newTrans.Customer_Debt_ID = idnow;
            newTrans.Customer_ID = customerID;
            newTrans.Customer_Debt_Date = debtDate;
            newTrans.Customer_Debt_Code = debtCode;
            newTrans.Customer_Debt_Kurs = kurs;
            if (currencyID == 1)
            {
                newTrans.Customer_Debt_Money_Dollar = money;
                newTrans.Customer_Debt_Money_Rupiah = money * kurs;
            }
            else
            {
                newTrans.Customer_Debt_Money_Dollar = money / kurs;
                newTrans.Customer_Debt_Money_Rupiah = money; 
            }
            newTrans.Customer_Debt_Description = description;
            newTrans.Customer_Debt_IsLast = 0;

            var afterTrans = (from f in StockEntity.Entity.customer_debt
                              where f.Customer_ID == customerID && (f.Customer_Debt_Date.CompareTo(debtDate) > 0 || (f.Customer_Debt_Date.CompareTo(debtDate) == 0 && f.Customer_Debt_ID.CompareTo(idnow) > 0))
                              select f).OrderBy(x => x.Customer_Debt_Date).ThenBy(x => x.Customer_Debt_ID);

            var beforeTrans = (from f in StockEntity.Entity.customer_debt
                               where f.Customer_ID == customerID && (f.Customer_Debt_Date.CompareTo(debtDate) < 0 || (f.Customer_Debt_Date.CompareTo(debtDate) == 0 && f.Customer_Debt_ID.CompareTo(idnow) < 0))
                               select f).OrderByDescending(x => x.Customer_Debt_Date).ThenBy(x => x.Customer_Debt_ID);
            decimal totalRupiah = 0;
            decimal totalDollar = 0;
            if (beforeTrans.Count() > 0)
            {
                totalRupiah = beforeTrans.First().Customer_Debt_Total_Rupiah;
                totalDollar = beforeTrans.First().Customer_Debt_Total_Dollar;
            }
            if (isDebit)
            {
                newTrans.Customer_Debt_IsDebit = 1;
                totalDollar = totalDollar + newTrans.Customer_Debt_Money_Dollar;
                totalRupiah = totalRupiah + newTrans.Customer_Debt_Money_Rupiah;
                newTrans.Customer_Debt_Total_Dollar = totalDollar;
                newTrans.Customer_Debt_Total_Rupiah = totalRupiah;
            }
            else
            {
                newTrans.Customer_Debt_IsDebit = 0;
                totalDollar = totalDollar - newTrans.Customer_Debt_Money_Dollar;
                totalRupiah = totalRupiah - newTrans.Customer_Debt_Money_Rupiah;
                newTrans.Customer_Debt_Total_Dollar = totalDollar;
                newTrans.Customer_Debt_Total_Rupiah = totalRupiah;
            }


            foreach (customer_debt cust in afterTrans)
            {
                if (cust.Customer_Debt_IsDebit == 1)
                {
                    totalDollar = totalDollar + cust.Customer_Debt_Money_Dollar;
                    totalRupiah = totalRupiah + cust.Customer_Debt_Money_Rupiah;
                    cust.Customer_Debt_Total_Dollar = totalDollar;
                    cust.Customer_Debt_Total_Rupiah = totalRupiah;
                }
                else
                {
                    totalDollar = totalDollar - cust.Customer_Debt_Money_Dollar;
                    totalRupiah = totalRupiah - cust.Customer_Debt_Money_Rupiah;
                    cust.Customer_Debt_Total_Dollar = totalDollar;
                    cust.Customer_Debt_Total_Rupiah = totalRupiah;
                }
            }

            if (afterTrans.Count() <= 0)
            {
                var lastTrans = (from f in StockEntity.Entity.customer_debt
                                 where f.Customer_ID == customerID && f.Customer_Debt_IsLast == 1
                                 select f);

                if (lastTrans.Count() > 0) lastTrans.First().Customer_Debt_IsLast = 0;
                newTrans.Customer_Debt_IsLast = 1;
            }

            customerNow.First().Customer_Debt_Dollar = totalDollar;
            customerNow.First().Customer_Debt_Rupiah = totalRupiah;
            StockEntity.Entity.AddTocustomer_debt(newTrans);
            StockEntity.Entity.SaveChanges();
            return newTrans; 
        }
    }
}
