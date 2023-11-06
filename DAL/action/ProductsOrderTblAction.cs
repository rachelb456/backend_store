using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.action
{
    public class ProductsOrderTblAction
    {
        static BbGamesshopContext myDb = new BbGamesshopContext();
        public static List<ProductsOrderTbl> GetAllProductsOrder()
        {
            return myDb.ProductsOrderTbls.ToList();

        }
        //הוספת קניה
        public static List<ProductsOrderTbl> AddProductsOrder(ProductsOrderTbl k)
        {
            myDb.ProductsOrderTbls.Add(k);
            myDb.SaveChanges();
            return GetAllProductsOrder();
        }
    }
}
