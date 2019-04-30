using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business
{
    public interface IGetUserPhotoBusiness
    {
        PhotoDto GetPhotoDtoByPhotoId(int PhotoId);
        UserPhoto GetUserPhotoById(int PhotoId);
    }
}
