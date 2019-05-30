using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.MusicBusiness
{
    public interface IGetMusicBusiness
    {
        Task<IList<MusicDto>> GetListMusicByUserId(int UserId);
    }
}
