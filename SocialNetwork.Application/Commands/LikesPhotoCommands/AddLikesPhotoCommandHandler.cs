using SocialNetwork.Domain.Business.LikesPhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.PhotoDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.LikesPhotoCommands
{
    public class AddLikesPhotoCommandHandler : IAddLikesPhotoCommandHandler
    {
        private readonly IAddLikesPhotoBusiness _addLikesPhotoBusiness;
        private readonly ILikesPhotoRepository _likesPhotoRepository;
        public AddLikesPhotoCommandHandler(IAddLikesPhotoBusiness addLikesPhotoBusiness, ILikesPhotoRepository likesPhotoRepository)
        {
            _addLikesPhotoBusiness = addLikesPhotoBusiness;
            _likesPhotoRepository = likesPhotoRepository;
        }

        public async Task Handler(LikesPhotoDto likesPhotoDto)
        {
            await _addLikesPhotoBusiness.AddLikesPhoto(likesPhotoDto);
            await _likesPhotoRepository.UnitOfWork.Save();
        }
    }
}
