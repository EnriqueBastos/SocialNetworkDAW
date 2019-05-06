using System;

namespace SocialNetwork.Domain.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateBirthday { get; set; }

        public byte[] PhotoProfile { get; set; }

        public string BackgroundApp { get; set; }

        public bool Private { get; set; }
    }
}
