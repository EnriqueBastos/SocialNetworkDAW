using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos
{
    public class SearchContactDto
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
    }
}
