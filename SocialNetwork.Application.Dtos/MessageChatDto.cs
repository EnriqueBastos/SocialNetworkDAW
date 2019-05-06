using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class MessageChatDto
    {
        public string MessageText { get; set; }

        public string UserName { get; set; }

        public int ChatId { get; set; }

        public int UserId { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
