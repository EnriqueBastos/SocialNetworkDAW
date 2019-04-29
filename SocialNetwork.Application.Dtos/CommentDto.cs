using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class CommentDto
    {
        public string UserName { get; set; }
        public string CommentText { get; set; }

        public int PhotoId { get; set; }
    }
}
