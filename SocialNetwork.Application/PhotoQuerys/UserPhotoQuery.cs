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
        private readonly IGetLastUserPhotosBusiness _getLastPhotos;

        private readonly IGetUserPhotoBusiness _getPhoto;

        private readonly IDeleteUserPhotoBusiness _deletePhoto;

        public PhotosQuery(IGetLastUserPhotosBusiness getLastPhotos, IGetUserPhotoBusiness getPhoto, IDeleteUserPhotoBusiness deletePhoto)
        {
            _getLastPhotos = getLastPhotos;
            _getPhoto = getPhoto;
            _deletePhoto = deletePhoto;
        }

        public IList<PhotoDto> GetLastPhotos()
        {
            return _getLastPhotos.GetLastPhotos();
        }

        public PhotoDto GetPhotoByPhotoId(int PhotoId)
        {
            return _getPhoto.GetPhotoDtoByPhotoId(PhotoId);
        }

        public void DeletePhoto(int PhotoId)
        {
            _deletePhoto.DeletePhoto(PhotoId);
        }
    }
}
