using SocialNetwork.Domain.Dtos.MusicDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.MusicQuerys
{
    public interface IMusicQuery
    {
        Task<ListMusicDto> GetListMusicByUserId(int userId);
    }
}
