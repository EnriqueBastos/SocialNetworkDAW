
using SocialNetwork.Domain.Business.UserPhotoBusiness;
using SocialNetwork.Domain.Dtos;

using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserPhotoCommands
{
    public class AddUserPhotoCommandHandler : IAddUserPhotoCommandHandler
    {
        private readonly IAddUserPhotoBusiness _addUserPhotoBusiness;

        public AddUserPhotoCommandHandler(IAddUserPhotoBusiness addUserPhotoBusiness)
        {
            _addUserPhotoBusiness = addUserPhotoBusiness;
        }

        public async Task Handler(AddPhotoDto photo)
        {
            await _addUserPhotoBusiness.AddUserPhoto(photo);
        }
    }
}
