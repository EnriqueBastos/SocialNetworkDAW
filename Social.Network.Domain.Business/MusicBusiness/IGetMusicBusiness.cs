using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;


namespace SocialNetwork.Domain.Business.MusicBusiness
{
    public interface IGetMusicBusiness
    {
         IList<MusicDto> GetListMusicByUserId(int UserId);
    }
}
