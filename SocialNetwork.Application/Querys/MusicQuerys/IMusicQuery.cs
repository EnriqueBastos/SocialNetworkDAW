using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application.MusicQuerys
{
    public interface IMusicQuery
    {
        IList<MusicDto> GetListMusic(int UserId);

        void DeleteMusicByMusicDto (MusicDto music);

        void AddMusic(MusicDto music);
    }
}
