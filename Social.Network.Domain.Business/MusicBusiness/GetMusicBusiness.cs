using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Domain.Business.MusicBusiness
{
    public class GetMusicBusiness :IGetMusicBusiness
    {
        private readonly IMusicRepository _musicRepository;

        public GetMusicBusiness(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public async Task<IList<MusicDto>> GetListMusicByUserId(int UserId)
        {
            return await _musicRepository
                .GetMusic()
                .OrderByDescending(music => music)
                .Select(music =>
                    new MusicDto
                    {
                        MusicId = music.Id,
                        UserId = music.User.Id,
                        UrlVideo = music.UrlVideo
                    }
                ).Where(music => music.UserId == UserId)
                .ToListAsync();
        }
    }
}
