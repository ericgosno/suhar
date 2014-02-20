using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace StockModel
{
    public static class UserController
    {
        public static user Login(string username, string password)
        {

            var list = from e in StockEntity.Entity.users
                       where e.users_username.Equals(username)
                       select e;
            if (list.Count() < 0) return null;
            user userNow = list.First();
            if (MD5Function.VerifyMd5Hash(password, userNow.users_password)) return userNow;
            else return null;
        }


    }
}
