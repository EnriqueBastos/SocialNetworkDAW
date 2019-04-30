using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application.MusicQuerys
{
    public class MusicQuery : IMusicQuery
    {
        private readonly IGetMusicBusiness _getMusic;

        private readonly IDeleteMusicBusiness _deleteMusic;

        private readonly IAddMusicBusiness _addMusic;

        public MusicQuery(IGetMusicBusiness getMusic 
            , IDeleteMusicBusiness delteMusic
            ,IAddMusicBusiness addMusic)
        {
            _getMusic = getMusic;

            _deleteMusic = delteMusic;

            _addMusic = addMusic;
        }

        public void DeleteMusicByMusicDto (MusicDto music)
        {
            _deleteMusic.DeleteMusicByMusicDto(music);
        }

        public IList<MusicDto> GetListMusic(int UserId)
        {
            return _getMusic.GetListMusic(UserId);
        }

        public void AddMusic(MusicDto music)
        {
            _addMusic.AddMusic(music);
        }
    }
}
