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
    public class CommunicationController : Controller
    {
        [HttpGet]
        [Route("checkCommunication")]
        public async Task<IActionResult> CheckCommunication()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://localhost:44337/checkCommunication"),
                Method = HttpMethod.Get
            };
            var response = await client.SendAsync(request);
            return Ok("test");
        }

        [HttpPost]
        [Route("sendText/{textInput}")]
        public async Task<IActionResult> SendText(string textInput)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://localhost:44337/api/SendData/sendString/" + textInput),
                Method = HttpMethod.Post,
                Content = new StringContent(textInput)
            };
            var response = await client.SendAsync(request);

            return Ok(response);
        }
    }
}
