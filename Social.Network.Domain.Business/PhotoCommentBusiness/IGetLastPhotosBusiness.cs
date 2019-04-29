using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Dtos;
namespace SocialNetwork.Domain.Business
{
    public interface IGetLastPhotosBusiness
    {
        IList<PhotoDto> GetLastPhotos();
    }
}
