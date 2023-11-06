using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO;
using DAL.action;
using BLL;
using DAL.Models;
namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoryController : ControllerBase
    {
        [HttpGet("GetAllCategory")]
        public IActionResult GetAllCategory()
        {
            List<CategoryTbl> c = CategoryAction.GetAllCategory();
            return Ok(Converts.convertoDtoCategoryList(c));
        }
        [HttpPut("AddCategory")]
        public IActionResult AddCategory([FromBody] CategoryDto p)
        {
            CategoryTbl newp = Converts.convertToTblCategory(p);
            List<CategoryTbl> ll = CategoryAction.AddCategory(newp);
            return Ok(Converts.convertoDtoCategoryList(ll));

        }


        [HttpDelete("dellCategory/{id}")]
        public IActionResult dellCategory(int id)
        {
            List<CategoryTbl> ll = CategoryAction.dellCategory(id);
            return Ok(Converts.convertoDtoCategoryList(ll));
        }
        [HttpPost("updateCategory/{id}")]
        public IActionResult updateCategory([FromBody] CategoryDto p, int id)
        {
            CategoryTbl categoryTbl = Converts.convertToTblCategory(p);
            return Ok(Converts.convertoDtoCategoryList(CategoryAction.updateCategory(id, categoryTbl)));
        }
    }
}
