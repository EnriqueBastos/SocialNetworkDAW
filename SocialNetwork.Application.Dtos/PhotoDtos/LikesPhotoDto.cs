using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos.PhotoDtos
{
    public class LikesPhotoDto
    {
        public int UserId { get; set; }
        public int UserPhotoId { get; set; }
        public string UserName { get; set; }
        public byte[] PhotoProfile { get; set; }
    }
}
