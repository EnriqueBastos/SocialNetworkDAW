using SocialNetwork.Domain.Dtos.PhotoDtos;
using System;
using System.Collections.Generic;

namespace SocialNetwork.Domain.Dtos
{
    public class GetPhotoDto
    {
        public int UserPhotoId { get; set; }

        public string UserName { get; set; }

        public int UserId { get; set; }

        public byte[] ImageBytes { get; set; }

        public string Title { get; set; }

        public DateTime UploadDateTime { get; set; }

        public IList<LikesPhotoDto> LikesPhotoDtos { get; set; }

        
    }
}
