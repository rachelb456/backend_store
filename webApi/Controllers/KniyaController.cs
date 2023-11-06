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
    public class KniyaController : ControllerBase
    {
        //GetAllKniya UpdateKniya AddKniya
        [HttpGet("GetAllKniya")]
        public IActionResult GetAllKniya()
        {
          
            return Ok(Converts.convertoDtoKniyaList(KniyaAction.GetAllKniya()));
        }
        [HttpPut("AddKniya")]
        public IActionResult AddKniya([FromBody] KniyaTbl k)
        {
            return Ok(Converts.convertoDtoKniyaList(KniyaAction.AddKniya(k)));
        }
        [HttpPost("UpdateKniya/{id}")]
        public IActionResult UpdateKniya( [FromBody] KniyaTbl k,int id)
        {
            return Ok(Converts.convertoDtoKniyaList(KniyaAction.UpdateKniya(id,k)));

        }
    }
}
