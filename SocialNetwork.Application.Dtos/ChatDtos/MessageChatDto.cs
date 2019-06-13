using System;

namespace SocialNetwork.Domain.Dtos
{
    public class MessageChatDto
    {
        public string MessageText { get; set; }

        public string UserName { get; set; }

        public int UserId { get; set; }

        public int ChatId { get; set; }

        public bool IsSeen { get; set; }

        public DateTime MessageDate { get; set; }

        
    }
}
