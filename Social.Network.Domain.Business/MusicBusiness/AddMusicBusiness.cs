
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.MusicBusiness
{
    public class AddMusicBusiness : IAddMusicBusiness

    {
        private readonly IMusicRepository _musicRepository;

        public AddMusicBusiness(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }
        public void AddMusic(MusicDto music)
        {
            _musicRepository.AddMusic(new Music
            {
                UserId = music.UserId,
                UrlVideo = music.UrlVideo
            });
        }
    }
}
