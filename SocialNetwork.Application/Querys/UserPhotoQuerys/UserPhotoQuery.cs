using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Business;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Business.PhotoCommentBusiness;

namespace SocialNetwork.Application
{
    public class PhotosQuery : IUserPhotoQuery
    {
        private readonly IGetListUserPhotosBusiness _getListPhotos;

        private readonly IGetUserPhotoBusiness _getPhoto;

        private readonly IDeleteUserPhotoBusiness _deletePhoto;

        public PhotosQuery(IGetListUserPhotosBusiness getListPhotos, IGetUserPhotoBusiness getPhoto, IDeleteUserPhotoBusiness deletePhoto)
        {
            _getListPhotos = getListPhotos;
            _getPhoto = getPhoto;
            _deletePhoto = deletePhoto;
        }

        public IList<PhotoDetailsDto> GetLastPhotos()
        {
            return _getListPhotos.GetLastPhotos();
        }

        public PhotoDetailsDto GetPhotoByPhotoId(int PhotoId)
        {
            return _getPhoto.GetPhotoDetailsDtoByPhotoId(PhotoId);
        }

        public IList<PhotoDetailsDto> GetListPhotosByUserId(int userId)
        {
            return _getListPhotos.GetListPhotosByUserId(userId);
        }
        


    }
}
