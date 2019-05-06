using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;

namespace SocialNetwork.Domain.Business
{
    public class GetListUserPhotosBusiness : IGetListUserPhotosBusiness
    {
        public readonly IUserPhotoRepository _photoRepository;

        public GetListUserPhotosBusiness(IUserPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public IList<PhotoDetailsDto> GetLastPhotos()
        {
            return _photoRepository
                .GetUserPhoto()
                .OrderByDescending(photo => photo)
                .Select(photo =>
                new PhotoDetailsDto {
                    UserName = photo.User.Name,
                    ImageBytes = photo.Photo.ImageBytes,
                    Title = photo.Photo.Title,
                    UploadDateTime = photo.Photo.UpdateDateTime

                }).ToList();

        }

        public IList<PhotoDetailsDto> GetListPhotosByUserId(int userId)
        {
            return _photoRepository
                .GetUserPhoto()
                .OrderByDescending(photo => photo)
                .Select(photo =>
                new PhotoDetailsDto {
                    UserName = photo.User.Name,
                    ImageBytes = photo.Photo.ImageBytes,
                    Title = photo.Photo.Title,
                    UploadDateTime = photo.Photo.UpdateDateTime

                })
                .Where(userPhoto => userPhoto.Id == userId)
                .ToList();
        }
    }
}
