using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class AddPhotoDto
    {


        public int UserId { get; set; }

        public string ImageBytes { get; set; }

        public string Title { get; set; }

        public DateTime UploadDateTime { get; set; }

        public int Likes { get; set; }

        public int DisLikes { get; set; }
    }
}
