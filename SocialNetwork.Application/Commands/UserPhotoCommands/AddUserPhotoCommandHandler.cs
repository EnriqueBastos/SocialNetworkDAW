
using SocialNetwork.Domain.Business.UserPhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;

using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserPhotoCommands
{
    public class AddUserPhotoCommandHandler : IAddUserPhotoCommandHandler
    {
        private readonly IAddUserPhotoBusiness _addUserPhotoBusiness;

        private readonly IUserPhotoRepository _userPhotoRepository;

        public AddUserPhotoCommandHandler(IAddUserPhotoBusiness addUserPhotoBusiness, IUserPhotoRepository userPhotoRepository)
        {
            _addUserPhotoBusiness = addUserPhotoBusiness;
            _userPhotoRepository = userPhotoRepository;
        }

        public async Task Handler(AddPhotoDto photo)
        {
            await _addUserPhotoBusiness.AddUserPhoto(photo);

            await _userPhotoRepository.UnitOfWork.Save();
        }
    }
}
