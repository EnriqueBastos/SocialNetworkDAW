using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Dtos.MusicDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.MusicQuerys
{
    public class MusicQuery : IMusicQuery
    {
        private readonly IGetMusicBusiness _getMusicBusiness;
        private readonly IGetUserBusiness _getUserBusiness;


        public MusicQuery(IGetMusicBusiness getMusicBusiness, IGetUserBusiness getUserBusiness)
        {
            _getMusicBusiness = getMusicBusiness;
            _getUserBusiness = getUserBusiness;

            
        }

        public async Task<ListMusicDto> GetListMusicByUserId(int userId)
        {
            var musicDtos =  await _getMusicBusiness.GetListMusicByUserId(userId);
            var userName = await _getUserBusiness.GetUserNameByUserId(userId);

            return new ListMusicDto
            {
                UserName = userName,
                MusicDtos = musicDtos
            };
        }

       
    }
}
