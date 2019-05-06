using SocialNetwork.Domain.Business.MusicBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.MusicCommands
{
    public class DeleteMusicCommandHandler : IDeleteMusicCommandHandler
    {
        private readonly IDeleteMusicBusiness _deleteMusicBusiness;
        private readonly IMusicRepository _musicRepository;
        public DeleteMusicCommandHandler(IDeleteMusicBusiness deleteMusicBusiness, IMusicRepository musicRepository)
        {
            _deleteMusicBusiness = deleteMusicBusiness;
            _musicRepository = musicRepository;
        }

        public async Task Handler(int musicId)
        {
            _deleteMusicBusiness.DeleteMusicByMusicId(musicId);

            await _musicRepository.UnitOfWork.Save();
        }
    }
}
