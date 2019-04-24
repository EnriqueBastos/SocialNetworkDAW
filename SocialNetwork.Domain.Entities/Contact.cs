﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int FriendId { get; set; }

        public User User { get; set; }

    }
}
