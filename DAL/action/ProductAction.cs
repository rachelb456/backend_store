using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.action
{
    public class ProductAction
    {
       static BbGamesshopContext myDb = new BbGamesshopContext();
        public static List<ProductTbl> GetAllProducts()
        { 
            
            return myDb.ProductTbls.ToList();

        }
        public static ProductTbl GetProductById(int id)
        {
            ProductTbl p = myDb.ProductTbls.Include(x => x.IdCategoryNavigation).FirstOrDefault(n => n.IdProduct == id);
            return p;
        }

        public static List<ProductTbl> AddProduct(ProductTbl p)
        {
            myDb.ProductTbls.Add(p);
            myDb.SaveChanges();
            return GetAllProducts();
        }
        public static List<ProductTbl> dellProduct(int id)
        {
            ProductTbl p = myDb.ProductTbls.FirstOrDefault(n => n.IdProduct == id);
            myDb.ProductTbls.Remove(p);
            myDb.SaveChanges();
            return GetAllProducts();
        }
        public static List<ProductTbl> updateProduct(int id, ProductTbl p)
        {
            ProductTbl pUpdate = myDb.ProductTbls.FirstOrDefault(n => n.IdProduct == id);
            pUpdate.NameProduct = p.NameProduct;
            pUpdate.AmountInMelay = p.AmountInMelay;
            pUpdate.Cost = p.Cost;
            pUpdate.IdCategory = p.IdCategory;
            pUpdate.Img = p.Img;
            myDb.SaveChanges();
            return GetAllProducts();
        }
        //IDno=id

    }
}
