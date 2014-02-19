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
        public static customer insertCustomer(string customerName, string customerAddress, string customerEmail, string customerPhone)
        {
            customer newCustomer = new customer();
            newCustomer.Customer_Name = customerName;
            newCustomer.Customer_Address = customerAddress;
            newCustomer.Customer_Email = customerEmail;
            newCustomer.Customer_Phone = customerPhone;
            newCustomer.Customer_Status = 1;
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

        public static customer editCustomer(int customerId, string customerName, string customerAddress, string customerEmail, string customerPhone)
        {
            customer customerNows = (from f in StockEntity.Entity.customers
                                    where f.Customer_ID == customerId
                                    select f).First();

            customerNows.Customer_Name = customerName;
            customerNows.Customer_Address = customerAddress;
            customerNows.Customer_Email = customerEmail;
            customerNows.Customer_Phone = customerPhone;
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
    }
}
