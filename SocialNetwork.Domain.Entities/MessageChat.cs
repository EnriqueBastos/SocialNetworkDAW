using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class MessageChat
    {
        public int Id { get; set; }

        public string MessageText { get; set; }

        public int ChatId { get; set; }

        public int UserId { get; set; }

        public DateTime MessageDate { get; set; }

        public User User { get; set; }

        public Chat Chat { get; set; }

        
    }
}
