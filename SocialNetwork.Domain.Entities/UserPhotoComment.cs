using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Entities
{
    public class UserPhotoComment
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int UserPhotoId { get; set; }

        public string CommentText { get; set; }

        public User User { get; set; }
    }
}
