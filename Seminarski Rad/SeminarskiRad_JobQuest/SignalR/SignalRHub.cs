using Microsoft.AspNetCore.SignalR;

namespace SeminarskiRad_JobQuest.SignalR
{
    public class SignalRHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Console.WriteLine(Context.ConnectionId);
            return base.OnConnectedAsync();
        }
    }
}
