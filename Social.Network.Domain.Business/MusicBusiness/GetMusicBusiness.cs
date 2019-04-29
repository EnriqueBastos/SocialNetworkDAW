using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SocialNetwork.Domain.Business.MusicBusiness
{
    public class GetMusicBusiness :IGetMusicBusiness
    {
        private readonly IMusicRepository _musicRepository;

        public GetMusicBusiness(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public IList<MusicDto> GetListMusic(int UserId)
        {
            return _musicRepository
                .GetMusic()
                .OrderByDescending(music => music)
                .Select(music =>
                    new MusicDto
                    {
                        UserId = music.User.Id,
                        UrlVideo = music.UrlVideo
                    }
                ).Where(music => music.UserId == UserId)
                .ToList();
        }
    }
}
