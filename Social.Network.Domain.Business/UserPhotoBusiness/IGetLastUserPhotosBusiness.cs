using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Dtos;
namespace SocialNetwork.Domain.Business
{
    public interface IGetLastUserPhotosBusiness
    {
        IList<PhotoDto> GetLastPhotos();
    }
}
