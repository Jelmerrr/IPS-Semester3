using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Backend.Controllers
{
    public class AttackController : Controller
    {
        [HttpPost]
        [Route("api/[controller]/sendString/{textInput}")]
        public IActionResult sendString(string textInput)
        {
            string newText = textInput + "!";
            return Ok(newText);
        }
    }
}
