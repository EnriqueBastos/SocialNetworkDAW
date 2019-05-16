using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public interface IDeleteUserPhotoBusiness
    {
        void DeletePhotoByPhotoId(int PhotoId);
    }
}
