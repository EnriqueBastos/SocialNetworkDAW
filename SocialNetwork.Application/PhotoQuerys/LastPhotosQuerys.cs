using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application
{
    public class LastPhotosQuery : IPhotoQuerys
    {
        private readonly IGetLastPhotosBusiness _getLastPhotos;

        public LastPhotosQuery(IGetLastPhotosBusiness getLastPhotos)
        {
            _getLastPhotos = getLastPhotos;
        }

        public IList<PhotoDto> GetLastPhotos()
        {
            return _getLastPhotos.GetLastPhotos();
        }
    }
}
