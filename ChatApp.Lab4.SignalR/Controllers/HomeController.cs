using ChatApp.Lab4.SignalR.Database;
using ChatApp.Lab4.SignalR.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ChatApp.Lab4.SignalR.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private AppDbContext _ctx;

        public HomeController(AppDbContext ctx) => _ctx = ctx;

        public IActionResult Index() => View(_ctx.Chats.ToList());

        [HttpGet("{id}")]
        public IActionResult Chat(int id)
        {
            var chat = _ctx.Chats
            .Include(x => x.Messages)
            .FirstOrDefault(x => x.Id == id);
            return View(chat);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(int chatId, string message)
        {
            var Message = new Message
            {
                ChatId = chatId,
                Test = message,
                Name = User.Identity.Name,
                Timestamp = DateTime.Now
            };
            _ctx.Messages.Add(Message);
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Chat", new { id = chatId });
        }

        [HttpPost]
        public async Task<IActionResult> AddImage(int chatId, string message)
        {
            var path = "~/images/";
            var photoPath = path + message;

            //var Photo = new Photo
            //{
            //    Name = photoPath
            //};
            ////_ctx.Photos.Add(Photo);
            //await _ctx.SaveChangesAsync();
            return RedirectToAction("Chat", new { id = chatId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            var chat = new Chat
            {
                Name = name,
                Type = ChatType.Room
            };
            chat.Users.Add(new ChatUser
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                Role = UserRole.Admin,
            });
            _ctx.Chats.Add(chat);

            await _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet("JoinRoom/{id}")]
        public async Task<IActionResult> JoinRoom(int id)
        {
            // var chatUser = new ChatUser { ChatId = id, UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value, Role = UserRole.Admin,

            // };
            var chatUser = (from c in _ctx.ChatUsers
                            where c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value && c.ChatId == id
                            select c).FirstOrDefault();
            if (chatUser == null)
            {
                chatUser = new ChatUser
                {
                    ChatId = id,
                    UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    Role = UserRole.Admin,
                };
                _ctx.ChatUsers.Add(chatUser);
                await _ctx.SaveChangesAsync();
            }

            // _ctx.ChatUsers.Add(chatUser); await _ctx.SaveChangesAsync();
            return RedirectToAction("Chat", "Home", new { id = id });
        }
    }
}