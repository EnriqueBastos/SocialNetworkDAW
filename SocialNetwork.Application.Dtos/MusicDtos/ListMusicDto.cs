using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Dtos.MusicDtos
{
    public class ListMusicDto
    {
        public string UserName { get; set; }

        public IList<MusicDto> MusicDtos { get; set; }
    }
}
