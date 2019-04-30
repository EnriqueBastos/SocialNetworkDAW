using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public class DeletePhotoBusiness : IDeletePhotoBusiness
    {
        private readonly IPhotoRepository _photoRepository;

        public DeletePhotoBusiness(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public void DeletePhoto(PhotoDto photo)
        {
            _photoRepository.DeletePhoto(new Photo
            {
                Id = photo.Id,
                Title = photo.Title,
                ImageBytes = photo.ImageBytes,
                UpdateDateTime = photo.UploadDateTime,
                Likes = photo.Likes,
                Dislikes = photo.DisLikes
            });
        }
    }
}
