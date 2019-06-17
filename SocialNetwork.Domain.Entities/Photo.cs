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

        public byte[] ImageBytes { get; set; }

        public DateTime UpdateDateTime { get; set; }
        
    }
}
