using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class IdentityController
    {
        public static identity getIdentity()
        {
            identity identityNow = (from f in StockEntity.Entity.identities
                               where f.Identity_ID == 1
                               select f).First();
            return identityNow;
        }

        public static identity updateIdentity(string name, string companyName, string address, string phone, string fax, string city,string npwp, string postalCode)
        {
            identity identityNow = (from f in StockEntity.Entity.identities
                                    where f.Identity_ID == 1
                                    select f).First();
            identityNow.Identity_Name = name;
            identityNow.Identity_Company_Name = companyName;
            identityNow.Identity_Phone = phone;
            identityNow.Identity_Fax = fax;
            identityNow.Identity_Address = address;
            identityNow.Identity_City = city;
            identityNow.Identity_NPWP = npwp;
            identityNow.Identity_Postal_Code = postalCode;
            StockEntity.Entity.SaveChanges();
            return identityNow;
        }
    }
}
