using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class ProfileDto
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserLastName { get; set; }

        public byte[] PhotoProfile { get; set; }

        public bool Private { get; set; }

        public bool IsFriend { get; set; }

        public bool FriendRequestIsSent { get; set; }

    }
}
