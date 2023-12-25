using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ChatApp.Lab4.SignalR.Models
{
    public class User : IdentityUser
    {
        public ICollection<ChatUser> Chats { get; set; }
    }
}