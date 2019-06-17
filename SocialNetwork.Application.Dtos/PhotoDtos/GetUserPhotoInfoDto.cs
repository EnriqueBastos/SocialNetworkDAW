using SocialNetwork.Domain.Dtos.PhotoDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class GetUserPhotoInfoDto
    {
        public int UserPhotoId { get; set; }

        public string UserName { get; set; }

        public int UserId { get; set; }

        public int PhotoId { get; set; }

        public byte[] ImageBytes { get; set; }

        public string Title { get; set; }

        public DateTime UploadDateTime { get; set; }

        public IList<LikesPhotoDto> LikesPhotoDtos { get; set; }

        public IList<CommentDto> Comments{ get; set;}
    }
}
