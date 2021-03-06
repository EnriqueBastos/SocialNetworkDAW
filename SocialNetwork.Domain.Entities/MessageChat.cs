﻿using System;


namespace SocialNetwork.Domain.Entities
{
    public class MessageChat
    {
        public int Id { get; set; }

        public string MessageText { get; set; }

        public int UserId { get; set; }

        public int ChatId { get; set; }

        public DateTime MessageDate { get; set; }

        public bool IsSeen { get; set; }

        public User User { get; set; }

        
    }
}
