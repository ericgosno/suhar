using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Reflection;

namespace StockModel
{
    public static class UserController
    {

        public static IQueryable<admin_history> getHistoryUser()
        {
            var list = from f in StockEntity.Entity.admin_history
                       select f;
            return list;
        }
        public static IQueryable<admin_history> getHistoryUser(DateTime From, DateTime To)
        {
            return getHistoryUser().Where(x => x.time_log.Value.CompareTo(From) >= 0 && x.time_log.Value.CompareTo(To) <= 0);
        }
        public static void insertHistoryLogIn(int userID, int typeLog){
            admin_history newadminhistory = new admin_history();
            newadminhistory.admin_history_id = userID + "-" + typeLog + "-" + DateTime.Now.Ticks;
            newadminhistory.users_id = userID;
            newadminhistory.log_type = typeLog;
            newadminhistory.time_log = DateTime.Now;
            StockEntity.Entity.AddToadmin_history(newadminhistory);
            StockEntity.Entity.SaveChanges();
        }

        public static void insertHistoryLogOut(int userID, int typeLog)
        {
            admin_history newadminhistory = new admin_history();
            newadminhistory.admin_history_id = userID + "-" + typeLog + "-" + DateTime.Now.Ticks;
            newadminhistory.users_id = userID;
            newadminhistory.log_type = typeLog;
            newadminhistory.time_log = DateTime.Now;
            StockEntity.Entity.AddToadmin_history(newadminhistory);
            StockEntity.Entity.SaveChanges();
        }

        public static user Login(string username, string password)
        {

            var list = from e in StockEntity.Entity.users
                       where e.users_username.Equals(username)
                       select e;
            if (list.Count() < 0) return null;
            user userNow = list.First();

            if (MD5Function.VerifyMd5Hash(password, userNow.users_password))
            {
                insertHistoryLogIn(userNow.users_id, 0);
                return userNow;
            }
            else return null;
        }

        public static IQueryable<user> getUser()
        {
            var list = from f in StockEntity.Entity.users
                       where f.users_status == 1
                       select f;
            return list;
        }

        public static IQueryable<user> getUser(int usersId)
        {
            return getUser().Where(a => a.users_id == usersId);
        }

        public static user insertUser(string username, string password, int categoryId, string email)
        {
            user newUser = new user();
            newUser.users_username = username;
            newUser.users_password = MD5Function.GetMd5Hash(password);
            newUser.users_status = 1;
            newUser.Privilege_ID = categoryId;
            newUser.users_email = email;
            StockEntity.Entity.AddTousers(newUser);
            StockEntity.Entity.SaveChanges();
            return newUser;
        }

        public static void updateUser(int userId, string userUsername, string userPassword, string userEmail, int idCategory)
        {
            var list = from f in StockEntity.Entity.users
                       where f.users_status == 1 && f.users_id == userId
                       select f;
            if (list.Count() <= 0) return;
            var userNow = list.First();
            userNow.users_username = userUsername;
            if (userPassword != "")
            {
                userNow.users_password = MD5Function.GetMd5Hash(userPassword);
            }
            userNow.users_status = 1;
            userNow.Privilege_ID = idCategory;
            userNow.users_email = userEmail;
            StockEntity.Entity.SaveChanges();
        }

        public static void deleteUser(int userId)
        {
            var list = from f in StockEntity.Entity.users
                       join g in StockEntity.Entity.privileges on f.Privilege_ID equals g.Privilege_ID
                       where f.users_status == 1 && f.users_id == userId
                       select f;
            if (list.Count() <= 0) return;
            StockEntity.Entity.DeleteObject(list.First());
            StockEntity.Entity.SaveChanges();
        }

        public static IQueryable<privilege_authorization> getPrivilegeAuthorization()
        {
            var list = from f in StockEntity.Entity.privilege_authorization
                       select f;
            return list; 
        }

        public static IQueryable<privilege_authorization> getPrivilegeAuthorization(int privilegeId)
        {
            return getPrivilegeAuthorization().Where(a => a.Privilege_ID == privilegeId);
        }

        public static IQueryable<privilege> getPrivilege()
        {
            var list = from f in StockEntity.Entity.privileges
                       select f;
            return list;
        }

        public static IQueryable<privilege> getPrivilege(int privilegeId)
        {
            return getPrivilege().Where(a => a.Privilege_ID == privilegeId);
        }

        public static void insertPrivilege(string privilegeName, List<int> listPrivilege)
        {
            privilege newPrivilege = new privilege();
            newPrivilege.Privilege_name = privilegeName;
            StockEntity.Entity.AddToprivileges(newPrivilege);
            StockEntity.Entity.SaveChanges();
            for (int i = 0; i < listPrivilege.Count; i++)
            {
                privilege_authorization newPrivAuthorization = new privilege_authorization();
                newPrivAuthorization.Authorization_ID = listPrivilege[i];
                newPrivAuthorization.privilege = newPrivilege;
                newPrivAuthorization.Privilege_Authorization_Status = 1;
                StockEntity.Entity.AddToprivilege_authorization(newPrivAuthorization);
                StockEntity.Entity.SaveChanges();
            }
            return;
        }

        public static void updatePrivilege(int privilegeId, string privilegeName, List<int> listPrivilege)
        {
            var list = from f in StockEntity.Entity.privileges
                       where f.Privilege_ID == privilegeId
                       select f;
            if (list.Count() <= 0) return;
            var privNow = list.First();
            privNow.Privilege_name = privilegeName;
            listPrivilege.Sort();
            foreach (privilege_authorization privAuth in privNow.privilege_authorization.ToList())
            {
                if (listPrivilege.BinarySearch(privAuth.Authorization_ID) >= 0)
                {
                    listPrivilege.Remove(privAuth.Authorization_ID);
                }
                else
                {
                    StockEntity.Entity.DeleteObject(privAuth);
                }
            }
            for (int i = 0; i < listPrivilege.Count; i++)
            {
                privilege_authorization newPrivAuth = new privilege_authorization();
                newPrivAuth.Privilege_ID = privilegeId;
                newPrivAuth.Authorization_ID = listPrivilege[i];
                newPrivAuth.Privilege_Authorization_Status = 1;
                StockEntity.Entity.AddToprivilege_authorization(newPrivAuth);
            }
            StockEntity.Entity.SaveChanges();
        }

        public static void deletePrivilege(int privilegeId)
        {
            var list = from f in StockEntity.Entity.privileges
                       where f.Privilege_ID == privilegeId
                       select f;
            if (list.Count() > 0)
            {
                var removedPrivilage = list.First();
                foreach(privilege_authorization auth in removedPrivilage.privilege_authorization.ToList())
                {
                    StockEntity.Entity.privilege_authorization.DeleteObject(auth);
                }
                StockEntity.Entity.privileges.DeleteObject(removedPrivilage);
                StockEntity.Entity.SaveChanges();
            }
        }
    }
}
