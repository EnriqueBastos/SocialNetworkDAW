using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.PhotoCommentBusiness
{
    public interface IDeleteUserPhotoBusiness
    {
        void DeletePhoto(int PhotoId);
    }
}
