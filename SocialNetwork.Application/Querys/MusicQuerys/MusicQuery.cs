using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.MusicQuerys
{
    public class MusicQuery : IMusicQuery
    {
        private readonly IGetMusicBusiness _getMusic;


        public MusicQuery(IGetMusicBusiness getMusic)
        {
            _getMusic = getMusic;

            
        }

        public async Task<IList<MusicDto>> GetListMusicByUserId(int UserId)
        {
            return  await _getMusic.GetListMusicByUserId(UserId);
        }

       
    }
}
