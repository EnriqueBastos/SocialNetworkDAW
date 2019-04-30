using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application
{
    public interface IUserPhotoQuery
    {
        IList<PhotoDto> GetLastPhotos();

        PhotoDto GetPhotoByPhotoId(int PhotoId);

        
    }
}
