
using System.Collections.Generic;

namespace SocialNetwork.Domain.Entities
{
    public class Chat
    {
        public int Id { get; set; }

        public int ContactUserFriendId { get; set; }

        public int ContactFriendUserId { get; set; }

        public ICollection<MessageChat> MessageChats {get; set;}
    }
}
