using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application.MusicQuerys
{
    public interface IMusicQuery
    {
        IList<MusicDto> GetListMusicByUserId(int UserId);
    }
}
