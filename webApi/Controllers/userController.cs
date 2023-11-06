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
    public class userController : ControllerBase
    {
        [HttpGet("GetAllUser")]
        public IActionResult GetAllUser()
        {
            List<UserTbl> c = UserAction.GetAllUser();
            return Ok(Converts.convertoDtoUserList(c));
        }
        [HttpPut("AddUser")]
        public IActionResult AddUser([FromBody] UserDto p)
        {
            //UserTbl newp = Converts.convertToTblUser(p);
            //List<UserTbl> ll = UserAction.AddUser(newp);
            //return Ok(Converts.convertoDtoUserList(ll));

            UserTbl userTbl=Converts.convertToTblUser(p);
            List<UserTbl> c = UserAction.AddUser(userTbl);
            return Ok(Converts.convertoDtoUserList(c));
        }

        [HttpPost("updateUser/{id}")]
        public IActionResult updateUser([FromBody] UserDto p, int id)
        {
            UserTbl userTbl = Converts.convertToTblUser(p);
            return Ok(Converts.convertoDtoUserList(UserAction.updateUser(id, userTbl)));
        }
        [HttpGet("getUserByIdEmail/{id}/{email}")]
        public IActionResult getUserByIdEmail(int id,string email)
        {
            return Ok(Converts.convertoDtoUser(UserAction.getUserByIdEmail(id, email)));
        }
    }
}
