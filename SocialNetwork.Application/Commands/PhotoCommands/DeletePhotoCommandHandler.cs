using SocialNetwork.Domain.Business.PhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;

using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.PhotoCommands
{
    public class DeletePhotoCommandHandler : IDeletePhotoCommandHandler
    {
        private readonly IDeletePhotoBusiness _deleteUserPhotoBusiness;
        private readonly IPhotoRepository _photoRepository;

        public DeletePhotoCommandHandler(IDeletePhotoBusiness deleteUserPhotoBusiness , IPhotoRepository photoRepository)
        {
            _deleteUserPhotoBusiness = deleteUserPhotoBusiness;
            _photoRepository = photoRepository;

        }

        public async Task Handler(PhotoDto photo)
        {
            _deleteUserPhotoBusiness.DeletePhoto(photo);

            await _photoRepository.UnitOfWork.Save();
        }
    }
}
