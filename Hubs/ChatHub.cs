using Microsoft.AspNetCore.SignalR;
using WebApplication2.Models;

namespace WebApplication2.Hubs;

public class ChatHub : Hub
{
    private readonly MessageContext _context;

    public ChatHub(MessageContext context)
    {
        _context = context;
    }
    public async Task SendMessage(string user, string message)
    {
        Message m = new Message() {Body = message};
        _context.Messages.Add(m);
        await _context.SaveChangesAsync();
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}