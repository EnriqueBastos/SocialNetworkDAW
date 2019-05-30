using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Entities
{
    public class ContactNotification
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int FriendId { get; set; }

        public User User { get; set; }
    }
}
