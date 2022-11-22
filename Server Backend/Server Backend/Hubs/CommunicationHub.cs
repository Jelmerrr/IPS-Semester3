using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Backend.Hubs
{
    public class CommunicationHub : Hub
    {
        public async Task SendString(string textInput)
        {
            await Clients.All.SendAsync("SendMethod", textInput);
        }
    }
}
