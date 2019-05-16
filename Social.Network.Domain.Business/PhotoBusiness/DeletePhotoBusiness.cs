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

        public void DeletePhoto(GetPhotoDto photoDto)
        {
            _photoRepository.DeletePhoto(new Photo
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
