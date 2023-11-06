using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO;
using DAL.action;
using BLL;
using DAL.Models;
using System.Collections.Generic;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            return Ok(Converts.convertoDtoProductList(ProductAction.GetAllProducts()));
        }
        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(Converts.convertoDtoProduct(ProductAction.GetProductById(id)));
        }
        //dellProductAddProduct
        [HttpPut("AddProduct")]
        public IActionResult AddProduct([FromBody] productDto p)
        {
            ProductTbl newp = Converts.convertToTblProduct(p);
            List<ProductTbl> ll = ProductAction.AddProduct(newp);
            return Ok(Converts.convertoDtoProductList(ll));
        }
        [HttpDelete("dellProduct/{id}")]
        public IActionResult dellProduct(int id)
        {
            List<ProductTbl> ll = ProductAction.dellProduct(id);
            return Ok(Converts.convertoDtoProductList(ll));
        }
        [HttpPost("updateProduct/{id}")]
        public IActionResult updateProduct([FromBody] productDto p, int id)
        {
            ProductTbl productTbl = Converts.convertToTblProduct(p);
            return Ok(Converts.convertoDtoProductList(ProductAction.updateProduct(id, productTbl)));
        }
    }
}
