using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public class ProductController
    {
        private stockappsEntities entity;
        public ProductController()
        {
            entity = new stockappsEntities();
        }
    }
}
