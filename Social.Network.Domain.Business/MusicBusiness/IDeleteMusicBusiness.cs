using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.MusicBusiness
{
    public interface IDeleteMusicBusiness
    {
        void DeleteMusicByMusicDto(MusicDto music);
    }
}
