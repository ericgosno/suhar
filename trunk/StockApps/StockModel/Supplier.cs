using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public class Supplier
    {
        private stockappsEntities entity;
        public Supplier()
        {
            entity = new stockappsEntities();
        }

        public supplier insertSupplier(string supplierName)
        {
            supplier newSupplier = new supplier();
            newSupplier.Supplier_Name = supplierName;
            entity.AddTosuppliers(newSupplier);
            entity.SaveChanges();
            return newSupplier;
        }
        public supplier insertSupplier(string supplierName, string supplierAddress, string supplierEmail, string supplierPhone)
        {
            supplier newSupplier = new supplier();
            newSupplier.Supplier_Name = supplierName;
            newSupplier.Supplier_Address = supplierAddress;
            newSupplier.Supplier_Email = supplierEmail;
            newSupplier.Supplier_Phone = supplierPhone;
            entity.AddTosuppliers(newSupplier);
            entity.SaveChanges();
            return newSupplier;
        }

        public IQueryable<supplier> getSupplier()
        {
            var list = from e in entity.suppliers
                       select e;
            return list;
        }

        public IQueryable<supplier> getSupplier(int supplierId)
        {
            return getSupplier().Where(a => a.Supplier_ID == supplierId);
        }

        public IQueryable<supplier> getSupplier(string supplierName)
        {
            return getSupplier().Where(a => a.Supplier_Name.Contains(supplierName));
        }

        public IQueryable<supplier> getSupplier(int supplierId, string supplierName)
        {
            return getSupplier().Where(a => a.Supplier_Name.Contains(supplierName) && a.Supplier_ID == supplierId);
        }

        public supplier editSupplier(int supplierId, string supplierName, string supplierAddress, string supplierEmail, string supplierPhone)
        {
            supplier supplierNows = (from f in entity.suppliers
                                    where f.Supplier_ID == supplierId
                                    select f).First();

            supplierNows.Supplier_Name = supplierName;
            supplierNows.Supplier_Address = supplierAddress;
            supplierNows.Supplier_Email = supplierEmail;
            supplierNows.Supplier_Phone = supplierPhone;
            entity.SaveChanges();

            return getSupplier(supplierId).First();
        }

        public void deleteSupplier(int supplierId)
        {
            supplier supplierNows = (from f in entity.suppliers
                                     where f.Supplier_ID == supplierId
                                     select f).First();
            entity.DeleteObject(supplierNows);
            entity.SaveChanges();
        }
    }
}
