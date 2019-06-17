using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Entities
{
    public class LikesPhoto
    {
        public int Id { get; set; }
        public int UserPhotoId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
