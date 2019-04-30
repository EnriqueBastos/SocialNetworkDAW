using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.MusicCommands
{
    public class AddMusicCommandHandler : IAddMusicCommandHandler
    {
        private readonly IMusicRepository _musicRepository;
        private readonly IAddMusicBusiness _addMusicBusiness;

        public AddMusicCommandHandler(IMusicRepository musicRepository , IAddMusicBusiness addMusicBusiness)
        {
            _musicRepository = musicRepository;
            _addMusicBusiness = addMusicBusiness;
        }

        public async Task Handler(MusicDto music)
        {
            _addMusicBusiness.AddMusic(music);

            await _musicRepository.UnitOfWork.Save();
        }
    }
}
