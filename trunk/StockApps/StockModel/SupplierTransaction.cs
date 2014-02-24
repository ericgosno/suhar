﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class SupplierTransaction
    {
        public static supplier_transaction insertSupplierTransaction(DateTime transDate,int supplierId,double totalDollar,double totalRupiah,string description, List<supplier_transaction_product> transProd)
        {
            supplier_transaction newTrans = new supplier_transaction();
            newTrans.Supplier_ID = supplierId;
            newTrans.Supplier_Transaction_Date = transDate;
            newTrans.Supplier_Transaction_Status = 1;
            newTrans.Supplier_Transaction_Description = description;
            newTrans.Supplier_Transaction_Total_Dollar = Convert.ToDecimal(totalDollar);
            newTrans.Supplier_Transaction_Total_Rupiah = Convert.ToDecimal(totalRupiah);
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
    }
}
