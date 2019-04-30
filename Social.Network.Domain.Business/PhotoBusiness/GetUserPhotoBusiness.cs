using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Linq;
namespace SocialNetwork.Domain.Business.PhotoCommentBusiness
{
    public class GetUserPhotoBusiness : IGetUserPhotoBusiness
    {
        private readonly IUserPhotoRepository _userPhotoRepository;

        public GetUserPhotoBusiness(IUserPhotoRepository userPhotoRepository)
        {
            _userPhotoRepository = userPhotoRepository;
        }

        public PhotoDto GetPhotoDtoByPhotoId(int PhotoId)
        {
             return _userPhotoRepository
                .GetUserPhoto()
                .Select(photo => new PhotoDto
                {
                    UserName = photo.User.Name,
                    ImageBytes = photo.Photo.ImageBytes,
                    Title = photo.Photo.Title,
                    UploadDateTime = photo.Photo.UpdateDateTime
                }).FirstOrDefault(photo =>
                photo.Id == PhotoId
               );
            
        }

        public UserPhoto GetUserPhotoById(int PhotoId)
        {
            return _userPhotoRepository
                .GetUserPhoto().FirstOrDefault(photo =>
                photo.Id == PhotoId
               );
        }
    }
}
