using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Business;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Business.UserPhotoBusiness;
using System.Threading.Tasks;

namespace SocialNetwork.Application
{
    public class UserPhotosQuery : IUserPhotoQuery
    {
        private readonly IGetListUserPhotosBusiness _getListPhotos;

        private readonly IGetUserPhotoBusiness _getUserPhoto;

        

        public UserPhotosQuery(IGetListUserPhotosBusiness getListPhotos, IGetUserPhotoBusiness getUserPhoto)
        {
            _getListPhotos = getListPhotos;
            _getUserPhoto = getUserPhoto;
            
        }
         public async Task<GetPhotoDto> GetPhotoByPhotoId(int PhotoId)
        {
            return await _getUserPhoto.GetPhotoDetailsDtoByPhotoId(PhotoId);
        }

        public IList<GetPhotoDto> GetLastPhotosContacts(int userId)
        {
            return  _getListPhotos.GetLastPhotosContacts(userId);
        }

        public async Task<IList<GetPhotoDto>> GetLastPhotosUserByUserId(int userId)
        {
            return await _getListPhotos.GetListPhotosByUserId(userId);
        }

        public async Task<GetUserPhotoInfoDto> GetUserPhotoInfoDtoByUserPhotoId(int userPhotoId)
        {
            return await _getUserPhoto.GetUserPhotoInfoDtoByPhotoId(userPhotoId);
        }
    }
}
