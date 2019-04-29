using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application
{
    public interface IPhotoQuerys
    {
        IList<PhotoDto> GetLastPhotos();
    }
}
