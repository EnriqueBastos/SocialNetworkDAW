using System;


namespace SocialNetwork.Domain.Dtos
{
    public class PhotoDetailsDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int UserId { get; set; }

        public byte[] ImageBytes { get; set; }

        public string Title { get; set; }

        public DateTime UploadDateTime { get; set; }

        public int Likes { get; set; }

        public int DisLikes { get; set; }
    }
}
