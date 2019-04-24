using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class Photo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string PhotoRoute { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
        
    }
}
