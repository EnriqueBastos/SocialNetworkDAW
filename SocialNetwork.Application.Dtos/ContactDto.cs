using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class ContactDto
    {
        public int UserId { get; set; }

        public int FriendId { get; set; }

        public int ContactNotificationId { get; set; }
    }
}
