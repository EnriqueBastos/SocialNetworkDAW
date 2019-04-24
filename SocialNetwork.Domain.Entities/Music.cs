using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class Music
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string UrlMusic { get; set; }

        public User User { get; set; }
    }
}
