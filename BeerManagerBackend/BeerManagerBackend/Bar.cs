using System.Collections.Generic;
using Microsoft.AspNet.SignalR;

namespace BeerManagerBackend
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Bar : Hub
    {
        private static readonly List<User> UserList = new List<User>();
        public void Send(string message)
        {
            // Call the addMessage method on all clients            
            Clients.All.addMessage(message);
        }

        public User GetUser()
        {
            return new User { Name = "Ville", Age = 27 };
        }

        public void EnterBar(string firstName, string lastName)
        {
            UserList.Add(new User{Name = firstName});
            Clients.All.refreshUserList(UserList);
            
        }
    }
}