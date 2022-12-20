using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

namespace Server_Backend.Controllers
{
    public class SendDataController : Controller
    {
        public static HubConnection _connection;

        public SendDataController()
        {
            if (_connection == null || _connection.State == HubConnectionState.Disconnected)
            {
                _connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:44337/SendDataHub")
                .Build();
                _connection.StartAsync();
                _connection.On<String>("SendMethod", a =>
                {
                    Console.WriteLine(a);
                });
            }
        }

        [HttpGet]
        [Route("checkCommunication")]
        public IActionResult CheckCommunication()
        {
            System.Diagnostics.Debug.WriteLine('a');
            return Content("{ \"Response\":\"Hello World! test\"}", "application/json");
        }

        [HttpPost]
        [Route("api/[controller]/sendString/{textInput}")]
        public async Task<IActionResult> sendString(string textInput)
        {
            string newText = textInput + "!";
            await _connection.InvokeAsync("SendString", newText);
            return Ok();
        }
    }
}
