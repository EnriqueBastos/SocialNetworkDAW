using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class FriendRequestDto
    {
        public int NotificationId { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public byte[] PhotoProfile { get; set; }

        
    }
}
