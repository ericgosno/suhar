using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class PaymentController
    {
        public static IQueryable<payment_category> getPaymentCategory()
        {
            var list = from f in StockEntity.Entity.payment_category
                       select f;
            return list;
        }

        public static IQueryable<payment_category> getPaymentCategory(int paymentCategoryID)
        {
            return getPaymentCategory().Where(a => a.Payment_Category_ID == paymentCategoryID);
        }
    }
}
