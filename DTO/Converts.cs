using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DTO
{
    public class Converts
    {
        //product
        //המרה מסוג טבלה ל dto
        public static productDto convertoDtoProduct(ProductTbl p)
        {
            productDto obj = new productDto();
            obj.IdProductDto = p.IdProduct;
            obj.NameProductDto = p.NameProduct;
            obj.AmountInMelayDto = p.AmountInMelay;
            obj.IdCategoryDto = p.IdCategory;
            obj.CostDto = (double)p.Cost;
            obj.ImgDto = p.Img;
           // obj.categoryName = p.IdCategoryNavigation.NameCategory;
            return obj;
        }
        //המרה מDTO 

        public static ProductTbl convertToTblProduct(productDto p)
        {
            ProductTbl obj = new ProductTbl();
            obj.IdProduct = p.IdProductDto;
            obj.NameProduct = p.NameProductDto;
            obj.AmountInMelay = p.AmountInMelayDto;
            obj.Img = p.ImgDto;
            obj.Cost = p.CostDto;
            obj.IdCategory = p.IdCategoryDto;
            return obj;
        }
        //פונקציה הממירה מרשימה DTO
        public static List<productDto> convertoDtoProductList(List<ProductTbl> p)
        {
            List<productDto> obj = new List<productDto>();
            foreach (ProductTbl item in p)
            {
                obj.Add(convertoDtoProduct(item));
            }
            return obj;
        }
        public static List<ProductTbl> convertToTblProductList(List<productDto> p)
        {
            List<ProductTbl> productTbls = new List<ProductTbl>();
            foreach (productDto item in p)
            {
                productTbls.Add(convertToTblProduct(item));
            }
            return productTbls;
        }
        //Category
        public static CategoryDto convertoDtoCategory(CategoryTbl p)
        {
            CategoryDto obj = new CategoryDto();
            obj.IdCategoryDto = p.IdCategory;
            obj.NameCategoryDto = p.NameCategory;
            return obj;
        }
        //המרה מDTO 

        public static CategoryTbl convertToTblCategory(CategoryDto p)
        {
            CategoryTbl obj = new CategoryTbl();
            obj.IdCategory = p.IdCategoryDto;
            obj.NameCategory = p.NameCategoryDto;
            return obj;
        }
        //פונקציה הממירה מרשימה DTO
        public static List<CategoryDto> convertoDtoCategoryList(List<CategoryTbl> p)
        {
            List<CategoryDto> obj = new List<CategoryDto>();
            foreach (CategoryTbl item in p)
            {
                obj.Add(convertoDtoCategory(item));
            }
            return obj;
        }
        public static List<CategoryTbl> convertToTblCategoryList(List<CategoryDto> p)
        {
            List<CategoryTbl> productTbls = new List<CategoryTbl>();
            foreach (CategoryDto item in p)
            {
                productTbls.Add(convertToTblCategory(item));
            }
            return productTbls;
        }
        //User
        public static UserDto convertoDtoUser(UserTbl p)
        {
            UserDto obj = new UserDto();
            obj.IdUserDto=p.IdUser;
            obj.FirstNameDto=p.FirstName;
            obj.LastNameDto=p.LastName;
            obj.EmailDto=p.Email;
            return obj;
        }
        //המרה מDTO 

        public static UserTbl convertToTblUser(UserDto p)
        {
            UserTbl obj = new UserTbl();
            obj.IdUser = p.IdUserDto;
            obj.LastName = p.LastNameDto;
            obj.FirstName = p.FirstNameDto;
            obj.Email = p.EmailDto;
            return obj;
        }
        //פונקציה הממירה מרשימה DTO
        public static List<UserDto> convertoDtoUserList(List<UserTbl> p)
        {
            List<UserDto> obj = new List<UserDto>();
            foreach (UserTbl item in p)
            {
                obj.Add(convertoDtoUser(item));
            }
            return obj;
        }
        public static List<UserTbl> convertToTblUserList(List<UserDto> p)
        {
            List<UserTbl> productTbls = new List<UserTbl>();
            foreach (UserDto item in p)
            {
                productTbls.Add(convertToTblUser(item));
            }
            return productTbls;
        }

        public static UserTbl convertToTblUser(KniyaDto newkniya)
        {
            throw new NotImplementedException();
        }
        //Kniya
        public static KniyaDto convertoDtoKniya(KniyaTbl p)
        {
            KniyaDto obj = new KniyaDto();
            obj.IdKniyaDto = p.IdKniya;
            obj.SumKniyaDto=p.SumKniya;
            obj.DateKniyaDto = p.DateKniya;
            obj.IdUserDto = p.IdUser;
            
            return obj;
        }
        //המרה מDTO 

        public static KniyaTbl convertToTblKniya(KniyaDto p)
        {
            KniyaTbl obj = new KniyaTbl();
            obj.IdKniya=p.IdKniyaDto;
            obj.SumKniya = p.SumKniyaDto;
            obj.DateKniya = p.DateKniyaDto;
            obj.IdUser = p.IdUserDto;
            return obj;
        }
        //פונקציה הממירה מרשימה DTO
        public static List<KniyaDto> convertoDtoKniyaList(List<KniyaTbl> p)
        {
            List<KniyaDto> obj = new List<KniyaDto>();
            foreach (KniyaTbl item in p)
            {
                obj.Add(convertoDtoKniya(item));
            }
            return obj;
        }
        public static List<KniyaTbl> convertToTblKniyaList(List<KniyaDto> p)
        {
            List<KniyaTbl> productTbls = new List<KniyaTbl>();
            foreach (KniyaDto item in p)
            {
                productTbls.Add(convertToTblKniya(item));
            }
            return productTbls;
        }

        //ProductsOrder

        //המרה מסוג טבלה ל dto
        public static ProductsOrderDto convertoDtoProductsOrder(ProductsOrderTbl p)
        {

     ProductsOrderDto obj = new ProductsOrderDto();
            obj.IdProductsOrderDto = p.IdProductsOrder;
            obj.IdProductDto = p.IdProduct;
            obj.IdKniyaDto=p.IdKniya;
            obj.AmountDto = p.Amount;
            return obj;
        }
        //המרה מDTO 

        public static ProductsOrderTbl convertToTblProductsOrder(ProductsOrderDto p)
        {
            ProductsOrderTbl obj = new ProductsOrderTbl();
            obj.IdProductsOrder=p.IdProductsOrderDto;
            obj.IdProduct=p.IdProductDto;
            obj.IdKniya = p.IdKniyaDto;
            obj.Amount=p.AmountDto;
            return obj;
        }
        //פונקציה הממירה מרשימה DTO
        public static List<ProductsOrderDto> convertoDtoProductsOrdertList(List<ProductsOrderTbl> p)
        {
            List<ProductsOrderDto> obj = new List<ProductsOrderDto>();
            foreach (ProductsOrderTbl item in p)
            {
                obj.Add(convertoDtoProductsOrder(item));
            }
            return obj;
        }
        public static List<ProductsOrderTbl> convertToTblProductsOrderList(List<ProductsOrderDto> p)
        {
            List<ProductsOrderTbl> productTbls = new List<ProductsOrderTbl>();
            foreach (ProductsOrderDto item in p)
            {
                productTbls.Add(convertToTblProductsOrder(item));
            }
            return productTbls;
        }


    }
}
