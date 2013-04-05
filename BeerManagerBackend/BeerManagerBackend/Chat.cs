using Microsoft.AspNet.SignalR;

namespace BeerManagerBackend
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Chat : Hub
    {
        public void Send(string message)
        {
            // Call the addMessage method on all clients            
            Clients.All.addMessage(message);
        }

        public User GetUser()
        {
            return new User { Name = "Ville", Age = 27 };
        }
    }
}