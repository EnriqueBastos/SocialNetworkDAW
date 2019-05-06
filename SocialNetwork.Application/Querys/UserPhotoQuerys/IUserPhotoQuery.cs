using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application
{
    public interface IUserPhotoQuery
    {
        IList<PhotoDetailsDto> GetLastPhotos();

        PhotoDetailsDto GetPhotoByPhotoId(int PhotoId);

        IList<PhotoDetailsDto> GetListPhotosByUserId(int userId);

        
    }
}
