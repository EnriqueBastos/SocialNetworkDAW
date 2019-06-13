using SocialNetwork.Domain.Business.PhotoBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public class AddUserPhotoBusiness : IAddUserPhotoBusiness
    {
        private readonly IUserPhotoRepository _userPhotoRepository;

        private readonly IAddPhotoBusiness _addPhotoBusiness;

        private readonly IGetPhotoBusiness _getPhotoBusiness;

        public AddUserPhotoBusiness(IUserPhotoRepository userPhotoRepository, IAddPhotoBusiness addPhotoBusiness, IGetPhotoBusiness getPhotoBusiness)
        {
            _userPhotoRepository = userPhotoRepository;
            _addPhotoBusiness = addPhotoBusiness;
            _getPhotoBusiness = getPhotoBusiness;
        }

        public async Task AddUserPhoto(AddPhotoDto newPhoto)
        {
            await _addPhotoBusiness.AddPhoto(newPhoto);

            await _userPhotoRepository.UnitOfWork.Save();

            var photo = await _getPhotoBusiness.GetLastPhoto();

            await _userPhotoRepository.AddUserPhoto(new UserPhoto
            {
                PhotoId = photo.Id,
                UserId = newPhoto.UserId
            });

            
        }
    }
}
