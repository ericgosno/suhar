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
        public static supplier insertSupplier(string supplierName, string supplierAddress, string supplierEmail, string supplierPhone,string supplierNPWP)
        {
            supplier newSupplier = new supplier();
            newSupplier.Supplier_Name = supplierName;
            newSupplier.Supplier_Address = supplierAddress;
            newSupplier.Supplier_Email = supplierEmail;
            newSupplier.Supplier_Phone = supplierPhone;
            newSupplier.Supplier_NPWP = supplierNPWP;
            newSupplier.Supplier_Status = 1;
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

        public static supplier editSupplier(int supplierId, string supplierName, string supplierAddress, string supplierEmail, string supplierPhone,string supplierNPWP)
        {
            supplier supplierNows = (from f in StockEntity.Entity.suppliers
                                    where f.Supplier_ID == supplierId
                                    select f).First();

            supplierNows.Supplier_Name = supplierName;
            supplierNows.Supplier_Address = supplierAddress;
            supplierNows.Supplier_Email = supplierEmail;
            supplierNows.Supplier_Phone = supplierPhone;
            supplierNows.Supplier_NPWP = supplierNPWP;
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
    }
}
