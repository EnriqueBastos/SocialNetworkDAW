using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
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

        public async Task DeletePhotoByPhotoId(int PhotoId)
        {
            var userPhoto = await _getPhoto.GetUserPhotoByPhotoId(PhotoId);
            _photoRepository.DeleteUserPhoto(userPhoto);
        }

    }
}
