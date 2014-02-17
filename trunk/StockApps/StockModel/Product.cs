using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public class Product
    {
        private stockappsEntities entity;
        public Product()
        {
            entity = new stockappsEntities();
        }
    }
}
