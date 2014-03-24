using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class BankController
    {
        public static bank insertBank(string bankName, int currencyID)
        {
            bank newBank = new bank();
            newBank.Bank_Name = bankName;
            newBank.Currency_ID = currencyID;
            newBank.Bank_Current_Money = 0;
            newBank.Bank_Status = 1;
            StockEntity.Entity.AddTobanks(newBank);
            StockEntity.Entity.SaveChanges();
            return newBank;
        }
        
        public static bank getCash()
        {
            var list = (from f in StockEntity.Entity.banks
                        where f.Bank_Status == 2
                        select f).First();
            return list;
        }

        public static IQueryable<bank> getBank()
        {
            var list = from e in StockEntity.Entity.banks
                       where e.Bank_Status == 1 
                       select e;
            return list;
        }
        public static IQueryable<bank> getBank(int bankId)
        {
            return getBank().Where(a => a.Bank_ID == bankId);
        }

        public static IQueryable<bank> getBank(string bankName)
        {
            return getBank().Where(a => a.Bank_Name.Contains(bankName));
        }

        public static IQueryable<bank> getBankWithCash()
        {
            var list = from e in StockEntity.Entity.banks
                       where e.Bank_Status == 1 || e.Bank_Status == 2
                       select e;
            return list;
        }

        public static IQueryable<bank> getBankWithCash(int bankId)
        {
            return getBank().Where(a => a.Bank_ID == bankId);
        }

        public static IQueryable<bank> getBankWithCash(string bankName)
        {
            return getBank().Where(a => a.Bank_Name.Contains(bankName));
        }

        public static bank updateBank(int bankId, string bankName, int currencyId)
        {
            var list = from e in StockEntity.Entity.banks
                       where e.Bank_Status >= 1 && e.Bank_ID == bankId
                       select e;
            if (list.Count() <= 0) return null;
            bank bankNow = list.First();
            bankNow.Bank_Name = bankName;
            bankNow.Currency_ID = currencyId;
            StockEntity.Entity.SaveChanges();
            return bankNow;
        }
        public static decimal IncreaseReduceTotalBank(int bankId, decimal change)
        {
            var list = from e in StockEntity.Entity.banks
                       where e.Bank_Status >= 1 && e.Bank_ID == bankId
                       select e;
            if (list.Count() <= 0) return -1;
            bank bankNow = list.First();
            bankNow.Bank_Current_Money += change;
            StockEntity.Entity.SaveChanges();
            return bankNow.Bank_Current_Money;
        }
        public static decimal changeTotalBank(int bankId, decimal totalNow)
        {
            var list = from e in StockEntity.Entity.banks
                       where e.Bank_Status >= 1 && e.Bank_ID == bankId
                       select e;
            if (list.Count() <= 0) return -1;
            bank bankNow = list.First();
            bankNow.Bank_Current_Money = totalNow;
            StockEntity.Entity.SaveChanges();
            return bankNow.Bank_Current_Money; 
        }

        public static void deleteBank(int bankId)
        {
            var list = from e in StockEntity.Entity.banks
                       where e.Bank_ID == bankId
                       select e;
            if (list.Count() <= 0) return;
            bank bankNow = list.First();
            bankNow.Bank_Status = 0;
            StockEntity.Entity.SaveChanges();
        }

        public static bank_transaction insertBankTransaction(int bankID, DateTime bankDate,string bankCode, bool isDebit, decimal money, string description)
        {
            bank_transaction newTrans = new bank_transaction();
            var bankNow = (from f in StockEntity.Entity.banks
                           where f.Bank_ID == bankID
                           select f);
            if (bankNow.Count() <= 0) return null;
            string idnow;
            int code = 1;
            while (true)
            {
                string bankStr = bankID.ToString("D3");
                string dateStr = bankDate.ToString("yyyyMMdd");
                string DebitCode="C";
                if(isDebit)DebitCode = "D";
                string codeStr = code.ToString("D3");

                idnow = bankStr + "-" + dateStr + "-" + bankCode + "-" + DebitCode + "-" + codeStr;
                var checkID = from f in StockEntity.Entity.bank_transaction
                              where f.Bank_Transaction_ID == idnow
                              select f;
                if (checkID.Count() > 0) code++;
                else break;
            }

            newTrans.Bank_Transaction_ID = idnow;
            newTrans.Bank_ID = bankID;
            newTrans.Bank_Transaction_Date = bankDate;
            newTrans.Bank_Transaction_Code = bankCode;
            newTrans.Bank_Transaction_Money = money;
            newTrans.Bank_Transaction_Description = description;
            newTrans.Bank_Transaction_IsLast = 0;

            var afterTrans = (from f in StockEntity.Entity.bank_transaction
                              where f.Bank_ID == bankID && (f.Bank_Transaction_Date.CompareTo(bankDate) > 0 || (f.Bank_Transaction_Date.CompareTo(bankDate) == 0 && f.Bank_Transaction_ID.CompareTo(idnow) > 0))
                              select f).OrderBy(x => x.Bank_Transaction_Date).ThenBy(x => x.Bank_Transaction_ID);

            var beforeTrans = (from f in StockEntity.Entity.bank_transaction
                               where f.Bank_ID == bankID && (f.Bank_Transaction_Date.CompareTo(bankDate) < 0 || (f.Bank_Transaction_Date.CompareTo(bankDate) == 0 && f.Bank_Transaction_ID.CompareTo(idnow) < 0))
                               select f).OrderByDescending(x => x.Bank_Transaction_Date).ThenBy(x => x.Bank_Transaction_ID);
            decimal totalNow = 0;
            if (beforeTrans.Count() > 0)totalNow = beforeTrans.First().Bank_Transaction_Total_Now;
            if (isDebit)
            {
                newTrans.Bank_Transaction_IsDebit = 1;
                totalNow = totalNow + newTrans.Bank_Transaction_Money;
                newTrans.Bank_Transaction_Total_Now = totalNow;
            }
            else
            {
                newTrans.Bank_Transaction_IsDebit = 0;
                totalNow = totalNow - newTrans.Bank_Transaction_Money;
                newTrans.Bank_Transaction_Total_Now = totalNow;
            }


            foreach (bank_transaction bank in afterTrans)
            {
                if (bank.Bank_Transaction_IsDebit == 1)
                {
                    totalNow = totalNow + bank.Bank_Transaction_Money;
                    bank.Bank_Transaction_Total_Now = totalNow;
                }
                else
                {
                    totalNow = totalNow - bank.Bank_Transaction_Money;
                    bank.Bank_Transaction_Total_Now = totalNow; 
                }
            }

            if (afterTrans.Count() <= 0)
            {
                var lastTrans = (from f in StockEntity.Entity.bank_transaction
                                 where f.Bank_ID == bankID && f.Bank_Transaction_IsLast == 1
                                 select f);

                if (lastTrans.Count() > 0)lastTrans.First().Bank_Transaction_IsLast = 0;
                newTrans.Bank_Transaction_IsLast = 1;
            }

            bankNow.First().Bank_Current_Money = totalNow;
            StockEntity.Entity.AddTobank_transaction(newTrans);
            StockEntity.Entity.SaveChanges();
            return newTrans;
        }
    }
}
