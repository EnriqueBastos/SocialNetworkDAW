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

        public DateTime DateBirthday { get; set; }

        public byte[] PhotoProfile { get; set; }
    }
}
