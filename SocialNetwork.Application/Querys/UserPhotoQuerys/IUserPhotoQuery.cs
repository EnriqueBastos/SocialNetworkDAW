using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application
{
    public interface IUserPhotoQuery
    {
        IList<GetPhotoDto> GetLastPhotos();

        GetPhotoDto GetPhotoByPhotoId(int PhotoId);

        IList<GetPhotoDto> GetListPhotosByUserId(int userId);

        
    }
}
