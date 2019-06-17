using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos.UserDtos
{
    public class GetLoginDto
    {
        public int UserId { get; set; }
        public string BackgroundApp { get; set; }
    }
}
