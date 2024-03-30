using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SampleSignalRWebAPI.SignalRHub
{
    public class SampleHub : Hub
    {
        public async Task SendToAll(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        public async Task SendToCaller(string message)
        {
            await Clients.Caller.SendAsync("ReceiveMessage", message);
        }

        public async Task SendToOthers(string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", message);
        }
    }
}
