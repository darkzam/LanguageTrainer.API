
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace LanguageTrainer.Hubs
{
    public class StreamHub : Hub
    {

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }

}
