using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.EntityFrameworkCore.Query.Internal;
using DAL.action;
using DAL.Models;


namespace BLL
{
    public class Functions
    {
        
      //  static BbGamesshopContext myDb = new BbGamesshopContext();
       //בדיקה האם קיים במלאי
       public static bool HaveInMelay(ProductWithAmount p)
        {
            BbGamesshopContext myDb = new BbGamesshopContext();
            ProductTbl theProduct=  ProductAction.GetProductById(p.ProductId);
            if(theProduct.AmountInMelay>p.Amount)
            {
                theProduct.AmountInMelay= theProduct.AmountInMelay - p.Amount;
                ProductAction.updateProduct(theProduct.IdProduct, theProduct);
                myDb.SaveChanges();
                return true;
            }
            return false;
            
        }
        public static double isamountInStack(ProductWithAmount[] arrProducts, int idUser)
        {
            BbGamesshopContext myDb = new BbGamesshopContext();
            //יצירת קנייה 
            KniyaTbl kniyaTbl = new KniyaTbl();
            kniyaTbl.DateKniya = DateTime.Today;
            kniyaTbl.IdUser = idUser;
            KniyaAction.AddKniya(kniyaTbl);
             myDb.SaveChanges();
            //שמירת קוד קניה כדי שנוכל להוסיף את המוצרים שבהזמנה
            int idKniya=kniyaTbl.IdKniya;
            double sum = 0;
            //מעבר על המערך
            foreach (ProductWithAmount item in arrProducts)
            {
               //אם יש מהמוצר במלאי
                if(HaveInMelay(item))
                {
                    //יצירת מוצר בהזמנה
                    ProductsOrderTbl productsOrderTbl = new ProductsOrderTbl();
                    ProductTbl theProduct = ProductAction.GetProductById(item.ProductId);
                    //חישוב סכום לצורך הסכום הסופי
                    sum += Convert.ToDouble(theProduct.Cost) *(item.Amount);
                    //עדכון פרטים למוצר בהזמנה
                    productsOrderTbl.Amount = item.Amount;
                    productsOrderTbl.IdKniya = idKniya;
                    productsOrderTbl.IdProduct= theProduct.IdProduct;
                    ProductsOrderTblAction.AddProductsOrder(productsOrderTbl);
                }

            }
            KniyaTbl kniyaTblUpdate = new KniyaTbl();
            kniyaTblUpdate.DateKniya = DateTime.Today;
            kniyaTblUpdate.IdUser = idUser;
            kniyaTblUpdate.SumKniya = sum;
            KniyaAction.UpdateKniya(idKniya, kniyaTblUpdate);
            return sum;
        }
    }
}
