using System;
using System.Collections.Generic;
using Microsoft.AspNet.SignalR;

namespace BeerManagerBackend
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LoginDate { get; set; }
        public int Age { get; set; }
    }

    public class Bar : Hub
    {
        private static readonly List<User> UserList = new List<User>();
        public void Send(string message, string fromUser)
        {
            // Call the addMessage method on all clients            
            Clients.All.addMessage(message);
        }

        public void EnterBar(string firstName, string lastName)
        {
            UserList.Add(new User{Name = firstName, Surname = lastName, LoginDate = DateTime.Now});
            Clients.All.refreshUserList(UserList);
        }
    }
}