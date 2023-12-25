using System;

namespace ChatApp.Lab4.SignalR.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Test { get; set; }

        public DateTime Timestamp { get; set; }

        public int ChatId { get; set; }
        public Chat chat { get; set; }
    }
}