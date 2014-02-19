using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public sealed class StockEntity
    {
        private static readonly StockEntity instance = new StockEntity();
        public static stockappsEntities Entity = new stockappsEntities();
        private StockEntity() { }

        public static StockEntity Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
