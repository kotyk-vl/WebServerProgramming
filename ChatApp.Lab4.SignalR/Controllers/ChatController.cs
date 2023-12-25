using ChatApp.Lab4.SignalR.Database;
using ChatApp.Lab4.SignalR.Hubs;
using ChatApp.Lab4.SignalR.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace ChatApp.Lab4.SignalR.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        private IHubContext<ChatHub> _chat;

        public ChatController(
            IHubContext<ChatHub> chat
        )
        {
            _chat = chat;
        }

        [HttpPost("[action]/{connectionId}/{roomName}")]
        public async Task<IActionResult> JoinRoom(string connectionId, string roomName)
        {
            await _chat.Groups.AddToGroupAsync(connectionId, roomName);
            return Ok();
        }

        [HttpPost("[action]/{connectionId}/{roomName}")]
        public async Task<IActionResult> LeaveRoom(string connectionId, string roomName)
        {
            await _chat.Groups.RemoveFromGroupAsync(connectionId, roomName);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SendMessage(string message, int chatId, string roomName, [FromServices] AppDbContext ctx)
        {
            var Message = new Message
            {
                ChatId = chatId,
                Test = message,
                Name = User.Identity.Name,
                Timestamp = DateTime.Now
            };
            ctx.Messages.Add(Message);
            await ctx.SaveChangesAsync();

            await _chat.Clients.Group(roomName).SendAsync("RecieveMessage", Message);

            return Ok();
        }
    }
}