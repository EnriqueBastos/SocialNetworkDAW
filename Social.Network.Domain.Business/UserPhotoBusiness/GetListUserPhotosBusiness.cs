using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public class GetListUserPhotosBusiness : IGetListUserPhotosBusiness
    {
        public readonly IUserPhotoRepository _photoRepository;

        public GetListUserPhotosBusiness(IUserPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public IList<GetPhotoDto> GetLastPhotos()
        {
            return _photoRepository
                .GetUserPhoto()
                .OrderByDescending(photo => photo)
                .Select(photo =>
                new GetPhotoDto {
                    Id = photo.Id,
                    UserName = photo.User.Name,
                    ImageBytes = photo.Photo.ImageBytes,
                    Title = photo.Photo.Title,
                    UploadDateTime = photo.Photo.UpdateDateTime,
                    Likes = photo.Photo.Likes,
                    DisLikes = photo.Photo.Dislikes

                }).ToList();

        }

        public IList<GetPhotoDto> GetListPhotosByUserId(int userId)
        {
            return _photoRepository
                .GetUserPhoto()
                .OrderByDescending(photo => photo)
                .Select(photo =>
                new GetPhotoDto {
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
