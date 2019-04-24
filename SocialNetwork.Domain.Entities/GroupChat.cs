using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class GroupChat

    {
        public int Id { get; set; }

        public int ChatId { get; set; }

        public int UserId { get; set; }

        public Chat Chat { get; set; }

        public User User { get; set; }


    }
}
