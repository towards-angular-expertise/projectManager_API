using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        [HttpPost]
        [Route("addUser")]
        public IActionResult addUser([FromBody] User user){
            var valid = ModelState;
            return Ok(valid);
        }
    }
}