using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.action
{
    public class CategoryAction
    {
        static BbGamesshopContext myDb = new BbGamesshopContext();
        public static List<CategoryTbl> GetAllCategory()
        {
            return myDb.CategoryTbls.ToList();

        }
        public static List<CategoryTbl> AddCategory(CategoryTbl p)
        {
            myDb.CategoryTbls.Add(p);
            myDb.SaveChanges();
            return GetAllCategory();
        }
        public static List<CategoryTbl> dellCategory(int id)
        {
            CategoryTbl p = myDb.CategoryTbls.FirstOrDefault(n => n.IdCategory == id);
            if (p != null)
            myDb.CategoryTbls.Remove(p);
            myDb.SaveChanges();
            return GetAllCategory();
        }
        public static List<CategoryTbl> updateCategory(int id, CategoryTbl p)
        {
            CategoryTbl pUpdate = myDb.CategoryTbls.FirstOrDefault(n => n.IdCategory == id);
            if (pUpdate != null)
            pUpdate.NameCategory=p.NameCategory;
            myDb.SaveChanges();
            return GetAllCategory();
        }
    }
}
