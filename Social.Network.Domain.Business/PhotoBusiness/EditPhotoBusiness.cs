using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public class EditPhotoBusiness : IEditPhotoBusiness
    {
        private readonly IPhotoRepository _photoRepository;

        public EditPhotoBusiness(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public void EditPhoto(GetPhotoDto photoDto)
        {
            _photoRepository.EditPhoto(new Photo
            {
                Id = photoDto.Id,
                Title = photoDto.Title,
                ImageBytes = photoDto.ImageBytes,
                UpdateDateTime = photoDto.UploadDateTime,
                Likes = photoDto.Likes,
                Dislikes = photoDto.DisLikes
            });
        }
    }
}
