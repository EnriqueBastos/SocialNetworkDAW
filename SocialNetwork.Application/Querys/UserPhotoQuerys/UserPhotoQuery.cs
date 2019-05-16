using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Business;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Business.UserPhotoBusiness;

namespace SocialNetwork.Application
{
    public class PhotosQuery : IUserPhotoQuery
    {
        private readonly IGetListUserPhotosBusiness _getListPhotos;

        private readonly IGetUserPhotoBusiness _getPhoto;

        

        public PhotosQuery(IGetListUserPhotosBusiness getListPhotos, IGetUserPhotoBusiness getPhoto)
        {
            _getListPhotos = getListPhotos;
            _getPhoto = getPhoto;
            
        }

        public IList<GetPhotoDto> GetLastPhotos()
        {
            return _getListPhotos.GetLastPhotos();
        }

        public GetPhotoDto GetPhotoByPhotoId(int PhotoId)
        {
            return _getPhoto.GetPhotoDetailsDtoByPhotoId(PhotoId);
        }

        public IList<GetPhotoDto> GetListPhotosByUserId(int userId)
        {
            return _getListPhotos.GetListPhotosByUserId(userId);
        }
        


    }
}
