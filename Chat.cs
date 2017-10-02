using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace razorapp
{
    public class Chat : Hub {
        public async Task Send(string message) {
            await Clients.All.InvokeAsync("Send", message);
        }
    }
}