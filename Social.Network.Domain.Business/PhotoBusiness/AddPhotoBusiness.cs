using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public class AddPhotoBusiness : IAddPhotoBusiness
    {
        private readonly IPhotoRepository _photoRepository;

        public AddPhotoBusiness(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public void AddPhoto(PhotoDetailsDto photoDto)
        {
            _photoRepository.AddPhoto(new Photo
            {
                Title = photoDto.Title,
                ImageBytes = photoDto.ImageBytes,
                UpdateDateTime = photoDto.UploadDateTime,
                Likes = 0,
                Dislikes = 0
            });
        }
    }
}
