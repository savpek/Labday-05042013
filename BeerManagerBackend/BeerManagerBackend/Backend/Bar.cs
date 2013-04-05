using System;
using Microsoft.AspNet.SignalR;

namespace BeerManagerBackend
{
    public class Bar : Hub
    {
        public void Send(string message, string fromUser)
        {
            // Call the addMessage method on all clients            
            Clients.All.addMessage(DateTime.Now + " " + fromUser + ":   " + message);
        }
    }
}