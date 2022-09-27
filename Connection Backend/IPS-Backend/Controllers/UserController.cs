using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPS_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("createUser/{userName}/{userPass}")]
        public IActionResult createUser(string userName, string userPass)
        {
            DAL.UserDAL userDAL = new DAL.UserDAL();
            userDAL.CreateUser(userName, userPass);
            return Ok();
        }
    }
}
