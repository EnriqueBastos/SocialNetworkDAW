using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class UserPhoto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PhotoId { get; set; }

        public User User { get; set; }
        public Photo Photo { get; set; }
        public ICollection<UserPhotoComment> UserPhotoComments { get; set; }
    }

}
