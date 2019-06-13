using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class SetUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateBirthday { get; set; }

        public string PhotoProfile { get; set; }

        public string BackgroundApp { get; set; }

        public bool Private { get; set; }

        public string Description { get; set; }
    }
}
