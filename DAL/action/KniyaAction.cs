using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.action
{
    public class KniyaAction
    {
        static BbGamesshopContext myDb = new BbGamesshopContext();
        public static List<KniyaTbl> GetAllKniya()
        {
            return myDb.KniyaTbls.ToList();

        }
        //הוספת קניה
     
        public static List<KniyaTbl> AddKniya(KniyaTbl k)
        {
            myDb.KniyaTbls.Add(k);
            myDb.SaveChanges();
            return GetAllKniya();
        }
        //עדכון
        public static List<KniyaTbl> UpdateKniya(int idKniya,KniyaTbl k)
        {
            KniyaTbl kniyaTbl=myDb.KniyaTbls.FirstOrDefault(k=>k.IdKniya==idKniya);
            kniyaTbl.SumKniya = k.SumKniya;
            kniyaTbl.DateKniya = k.DateKniya;
            kniyaTbl.IdUser = k.IdUser;
            myDb.SaveChanges();
            return GetAllKniya();
        }
    }
}
