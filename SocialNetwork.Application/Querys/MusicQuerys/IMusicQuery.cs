using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application.MusicQuerys
{
    public interface IMusicQuery
    {
        Task<IList<MusicDto>> GetListMusicByUserId(int UserId);
    }
}
