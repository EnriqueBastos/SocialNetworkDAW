using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application.Dtos
{
    class PhotoDto
    {
        public string UserName { get; set; }

        public byte[] ImageBytes { get; set; }

        public string Title { get; set; }
    }
}
