using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;
namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class salController : ControllerBase
    {
        [HttpPost("isamountInStack/{id}")]
        public IActionResult isamountInStack([FromBody] ProductWithAmount[]arr,int id)
        {
            return Ok( Functions.isamountInStack(arr,id));
               
        }
    }
}
