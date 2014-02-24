using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class ProductController
    {
        public static IQueryable<product> getProduct()
        {
            var list = from f in StockEntity.Entity.products
                       where f.Product_Status == 1
                       select f;
            return list;
        }

        public static void changeProductStock(int productId, int change)
        {
            product productNow = (from f in StockEntity.Entity.products
                                 where f.Product_ID == productId
                                 select f).First();
            productNow.Product_Stock += change;
            StockEntity.Entity.SaveChanges();
        }

        public static IQueryable<product> getProductByProductID(int productId)
        {
            return getProduct().Where(a => a.Product_ID == productId);
        }

        public static IQueryable<product> getProductBySupplierID(int supplierId)
        {
            return getProduct().Where(a => a.Supplier_ID == supplierId);
        }

        public static product insertProduct(int supplierID, int productCategoryID,int currencyID,double price, string productName,string productPackingName,int productPackingKilogram)
        {
            product newProduct = new product();
            newProduct.Supplier_ID = supplierID;
            newProduct.Product_Category_ID = productCategoryID;
            newProduct.Product_Name = productName;
            newProduct.Product_Stock = 0;
            newProduct.Product_Status = 1;
            newProduct.Currency_ID = currencyID;
            newProduct.Product_Packing_Name = productPackingName;
            newProduct.Product_Packing_Kilogram = productPackingKilogram;
            newProduct.Product_Buy_Price = Convert.ToDecimal(price);
            StockEntity.Entity.AddToproducts(newProduct);
            StockEntity.Entity.SaveChanges();
            return newProduct;
        }

        public static void updateProduct(int productId, int supplierID, int productCategoryID, int currencyID, double price, string productName, string productPackingName, int productPackingKilogram)
        {
            var list = from f in StockEntity.Entity.products
                       where f.Product_ID == productId
                       select f;
            if (list.Count() <= 0) return;
            var productNow = list.First();
            productNow.Supplier_ID = supplierID;
            productNow.Product_Category_ID = productCategoryID;
            productNow.Product_Name = productName;
            productNow.Currency_ID = currencyID;
            productNow.Product_Packing_Name = productPackingName;
            productNow.Product_Packing_Kilogram = productPackingKilogram;
            productNow.Product_Buy_Price = Convert.ToDecimal(price);
            StockEntity.Entity.SaveChanges();
        }

        public static void deleteProduct(int productId)
        {
            var list = from f in StockEntity.Entity.products
                       where f.Product_ID == productId
                       select f;
            if (list.Count() <= 0) return;
            var productNow = list.First();
            productNow.Product_Status = 0;
            StockEntity.Entity.SaveChanges();
        }

        public static product_category insertProductCategory(string name)
        {
            product_category newCategory = new product_category();
            newCategory.Product_Category_Name = name;
            newCategory.Product_Category_Status = 1;
            StockEntity.Entity.AddToproduct_category(newCategory);
            StockEntity.Entity.SaveChanges();
            return newCategory;
        }

        public static IQueryable<product_category> getProductCategory()
        {
            var list = from e in StockEntity.Entity.product_category
                       where e.Product_Category_Status == 1
                       select e;
            return list;
        }

        public static IQueryable<product_category> getProductCategory(int categoryId)
        {
            return getProductCategory().Where(a => a.Product_Category_ID == categoryId);
        }

        public static IQueryable<product_category> getProductCategory(string categoryName)
        {
            return getProductCategory().Where(a => a.Product_Category_Name.Contains(categoryName));
        }

        public static IQueryable<product_category> getProductCategory(int categoryId, string categoryName)
        {
            return getProductCategory().Where(a => a.Product_Category_ID == categoryId && a.Product_Category_Name.Contains(categoryName));
        }

        public static void deleteProductCategory(int categoryId)
        {
            product_category categoryNows = (from f in StockEntity.Entity.product_category
                                     where f.Product_Category_ID == categoryId
                                     select f).First();
            categoryNows.Product_Category_Status = 0;
            StockEntity.Entity.SaveChanges();
        }

        public static void updateProductCategory(int CategoryId, string CategoryName)
        {
            product_category categoryNows = (from f in StockEntity.Entity.product_category
                                             where f.Product_Category_ID == CategoryId
                                             select f).First();
            categoryNows.Product_Category_Name = CategoryName;
            StockEntity.Entity.SaveChanges();
        }
    }
}
