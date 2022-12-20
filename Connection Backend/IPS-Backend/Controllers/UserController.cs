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
        [HttpPost]
        [Route("{userName}/{userPass}")]
        public IActionResult CreateUser(string userName, string userPass)
        {
            DAL.UserDAL userDAL = new DAL.UserDAL();
            userDAL.CreateUser(userName, userPass);
            return Ok();
        }

        [HttpGet]
        [Route("{userName}/{userPass}")]
        public IActionResult Login(string userName, string userPass)
        {
            DAL.UserDAL userDAL = new DAL.UserDAL();
            var users = userDAL.GetUsers();
            
            foreach(var item in users)
            {
                if (item.userName == userName && item.userPass == userPass)
                {
                    var result = item;
                    return Ok(result);
                }
            }
            return Ok("Wrong credentials!");
        }

        [HttpPost]
        [Route("attack/{boardState}")]
        public async Task<IActionResult> SendAttackRequest(string boardState)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://localhost:44337/api/Attack/StartAttack/1/2"),
                Method = HttpMethod.Post,
                Content = new StringContent(boardState)
            };
            var response = await client.SendAsync(request);

            return Ok(response);
        }
        }
    }

