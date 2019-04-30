using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.PhotoCommentBusiness
{
    public class DeleteUserPhotoBusiness : IDeleteUserPhotoBusiness
    {
        private readonly IUserPhotoRepository _photoRepository;

        private readonly IGetUserPhotoBusiness _getPhoto;

        public DeleteUserPhotoBusiness(IUserPhotoRepository photoRepository, IGetUserPhotoBusiness getPhoto)
        {
            _photoRepository = photoRepository;

            _getPhoto = getPhoto;
        
        }

        public void DeletePhoto(int PhotoId)
        {
            var userPhoto = _getPhoto.GetUserPhotoById(PhotoId);
            _photoRepository.DeleteUserPhoto(userPhoto);
        }

    }
}
