using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class ProfileDetailsDto
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserLastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool Private { get; set; } 

        public string Description { get; set; }

        public DateTime DateBirthday { get; set; }

        public string BackgroundApp { get; set; }

        public byte[] PhotoProfile { get; set; }

        public IList<FriendRequestDto> FriendRequests { get; set; }
    }
}
