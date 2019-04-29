using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application.MusicQuerys
{
    public interface IMusicQuerys
    {
        IList<MusicDto> GetListMusic(int UserId);
    }
}
