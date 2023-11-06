using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.action
{
    public class UserAction
    {
        static BbGamesshopContext myDb = new BbGamesshopContext();
        public static List<UserTbl> GetAllUser()
        {
            return myDb.UserTbls.ToList();

        }
        public static List<UserTbl> AddUser(UserTbl p)
        {
            myDb.UserTbls.Add(p);
            myDb.SaveChanges();
            return GetAllUser();
        }
       
        public static List<UserTbl> updateUser(int id, UserTbl p)
        {
            UserTbl pUpdate = myDb.UserTbls.FirstOrDefault(n => n.IdUser == id);
            if (pUpdate != null) 
            { 
                pUpdate.FirstName = p.FirstName;
                pUpdate.LastName = p.LastName;
                pUpdate.Email = p.Email;
            }
            myDb.SaveChanges();
            return GetAllUser();
        }
        public static UserTbl getUserByIdEmail(int id,string email)
        {
            UserTbl userTbl = myDb.UserTbls.FirstOrDefault(n => n.IdUser == id && n.Email.Equals(email));
            return userTbl;
        }
    }
}
