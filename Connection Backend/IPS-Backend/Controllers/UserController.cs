using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("checkCommunication")]
        public IActionResult CheckCommunication()
        {
            return Content("{ \"Response\":\"Hello World!\"}", "application/json");
        }
            
        [HttpPost]
        [Route("createUser/{userName}/{userPass}")]
        public IActionResult CreateUser(string userName, string userPass)
        {
            DAL.UserDAL userDAL = new DAL.UserDAL();
            userDAL.CreateUser(userName, userPass);
            return Ok();
        }
        [HttpPost]
        [Route("sendText/{textInput}")]
        public async Task<IActionResult> SendText(string textInput)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://localhost:44379/api/SendData/sendString/"+textInput),
                Method = HttpMethod.Post,
                Content = new StringContent(textInput)
            };
            var response = await client.SendAsync(request);
            
            return Ok(response);
        }
    }
}
