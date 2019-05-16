using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public interface IGetUserPhotoBusiness
    {
        GetPhotoDto GetPhotoDetailsDtoByPhotoId(int PhotoId);
        UserPhoto GetUserPhotoByPhotoId(int PhotoId);
    }
}
