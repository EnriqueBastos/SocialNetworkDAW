﻿

namespace SocialNetwork.Domain.Entities
{
    public class Music
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string UrlVideo { get; set; }

        public User User { get; set; }
    }
}
