using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public interface IDeleteUserPhotoBusiness
    {
        Task DeletePhotoByPhotoId(int PhotoId);
    }
}
