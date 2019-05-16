using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Dtos;
namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public interface IGetListUserPhotosBusiness
    {
        IList<GetPhotoDto> GetLastPhotos();

        IList<GetPhotoDto> GetListPhotosByUserId(int userId);
    }
}
