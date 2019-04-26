using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class UserPhotoComment
    {
        public int Id { get; set; }
        public int UserPhotoId { get; set; }
        public string CommentText { get; set; }
        public UserPhoto UserPhoto { get; set; }

    }
}
