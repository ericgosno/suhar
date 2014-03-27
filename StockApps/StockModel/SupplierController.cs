using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class SupplierController
    {
        public static supplier insertSupplier(string supplierName)
        {
            supplier newSupplier = new supplier();
            newSupplier.Supplier_Name = supplierName;
            StockEntity.Entity.AddTosuppliers(newSupplier);
            StockEntity.Entity.SaveChanges();
            return newSupplier;
        }
        public static supplier insertSupplier(string supplierName, string supplierAddress, string supplierEmail, string supplierPhone,string supplierNPWP, string supplierCompany, int supplierRegional)
        {
            supplier newSupplier = new supplier();
            newSupplier.Supplier_Name = supplierName;
            newSupplier.Supplier_Address = supplierAddress;
            newSupplier.Supplier_Email = supplierEmail;
            newSupplier.Supplier_Phone = supplierPhone;
            newSupplier.Supplier_NPWP = supplierNPWP;
            newSupplier.Supplier_Company_Name = supplierCompany;
            newSupplier.Supplier_Status = 1;
            newSupplier.Supplier_Regional = supplierRegional;
            StockEntity.Entity.AddTosuppliers(newSupplier);
            StockEntity.Entity.SaveChanges();
            return newSupplier;
        }

        public static IQueryable<supplier> getSupplier()
        {
            var list = from e in StockEntity.Entity.suppliers
                       where e.Supplier_Status == 1
                       select e;
            return list;
        }

        public static IQueryable<supplier> getSupplier(int supplierId)
        {
            return getSupplier().Where(a => a.Supplier_ID == supplierId);
        }

        public static IQueryable<supplier> getSupplier(string supplierName)
        {
            return getSupplier().Where(a => a.Supplier_Name.Contains(supplierName));
        }

        public static IQueryable<supplier> getSupplier(int supplierId, string supplierName)
        {
            return getSupplier().Where(a => a.Supplier_Name.Contains(supplierName) && a.Supplier_ID == supplierId);
        }

        public static supplier editSupplier(int supplierId, string supplierName, string supplierAddress, string supplierEmail, string supplierPhone, string supplierNPWP, string supplierCompany, int supplierRegional)
        {
            supplier supplierNows = (from f in StockEntity.Entity.suppliers
                                    where f.Supplier_ID == supplierId
                                    select f).First();

            supplierNows.Supplier_Name = supplierName;
            supplierNows.Supplier_Address = supplierAddress;
            supplierNows.Supplier_Email = supplierEmail;
            supplierNows.Supplier_Phone = supplierPhone;
            supplierNows.Supplier_NPWP = supplierNPWP;
            supplierNows.Supplier_Company_Name = supplierCompany;
            supplierNows.Supplier_Regional = supplierRegional;
            StockEntity.Entity.SaveChanges();

            return getSupplier(supplierId).First();
        }

        public static void deleteSupplier(int supplierId)
        {
            supplier supplierNows = (from f in StockEntity.Entity.suppliers
                                     where f.Supplier_ID == supplierId
                                     select f).First();
            supplierNows.Supplier_Status = 0;
            StockEntity.Entity.SaveChanges();
        }

        public static supplier_credit insertSupplierCredit(int supplierID, DateTime creditDate, string creditCode, bool isDebit, decimal money, string description)
        {
            supplier_credit newTrans = new supplier_credit();
            var supplierNow = (from f in StockEntity.Entity.suppliers
                               where f.Supplier_ID == supplierID
                               select f);
            if (supplierNow.Count() <= 0) return null;
            string idnow;
            int code = 1;
            while (true)
            {
                string bankStr = supplierID.ToString("D3");
                string dateStr = creditDate.ToString("yyyyMMdd");
                string DebitCode = "C";
                if (isDebit) DebitCode = "D";
                string codeStr = code.ToString("D3");

                idnow = bankStr + "-" + dateStr + "-" + (creditCode == "" ? "NULL" : creditCode) + "-" + DebitCode + "-" + codeStr;
                var checkID = from f in StockEntity.Entity.supplier_credit
                              where f.Supplier_Credit_ID == idnow
                              select f;
                if (checkID.Count() > 0) code++;
                else break;
            }

            newTrans.Supplier_Credit_ID = idnow;
            newTrans.Supplier_ID = supplierID;
            newTrans.Supplier_Credit_Date = creditDate;
            newTrans.Supplier_Credit_Code = creditCode;
            newTrans.Supplier_Credit_Money = money;
            newTrans.Supplier_Credit_Description = description;
            newTrans.Supplier_Credit_IsLast = 0;

            var afterTrans = (from f in StockEntity.Entity.supplier_credit
                              where f.Supplier_ID == supplierID && (f.Supplier_Credit_Date.CompareTo(creditDate) > 0 || (f.Supplier_Credit_Date.CompareTo(creditDate) == 0 && f.Supplier_Credit_ID.CompareTo(idnow) > 0))
                              select f).OrderBy(x => x.Supplier_Credit_Date).ThenBy(x => x.Supplier_Credit_ID);

            var beforeTrans = (from f in StockEntity.Entity.supplier_credit
                               where f.Supplier_ID == supplierID && (f.Supplier_Credit_Date.CompareTo(creditDate) < 0 || (f.Supplier_Credit_Date.CompareTo(creditDate) == 0 && f.Supplier_Credit_ID.CompareTo(idnow) < 0))
                               select f).OrderByDescending(x => x.Supplier_Credit_Date).ThenBy(x => x.Supplier_Credit_ID);
            decimal totalNow = 0;
            if (beforeTrans.Count() > 0) totalNow = beforeTrans.First().Supplier_Credit_Total_Now;
            if (isDebit)
            {
                newTrans.Supplier_Credit_IsDebit = 1;
                totalNow = totalNow + newTrans.Supplier_Credit_Money;
                newTrans.Supplier_Credit_Total_Now = totalNow;
            }
            else
            {
                newTrans.Supplier_Credit_IsDebit = 0;
                totalNow = totalNow - newTrans.Supplier_Credit_Money;
                newTrans.Supplier_Credit_Total_Now = totalNow;
            }


            foreach (supplier_credit cust in afterTrans)
            {
                if (cust.Supplier_Credit_IsDebit == 1)
                {
                    totalNow = totalNow + cust.Supplier_Credit_Money;
                    cust.Supplier_Credit_Total_Now = totalNow;
                }
                else
                {
                    totalNow = totalNow - cust.Supplier_Credit_Money;
                    cust.Supplier_Credit_Total_Now = totalNow;
                }
            }

            if (afterTrans.Count() <= 0)
            {
                var lastTrans = (from f in StockEntity.Entity.supplier_credit
                                 where f.Supplier_ID == supplierID && f.Supplier_Credit_IsLast == 1
                                 select f);

                if (lastTrans.Count() > 0) lastTrans.First().Supplier_Credit_IsLast = 0;
                newTrans.Supplier_Credit_IsLast = 1;
            }

            supplierNow.First().Supplier_Credit = totalNow;
            StockEntity.Entity.AddTosupplier_credit(newTrans);
            StockEntity.Entity.SaveChanges();
            return newTrans;
        }
    }
}
