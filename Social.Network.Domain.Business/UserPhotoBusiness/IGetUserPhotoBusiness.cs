using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business
{
    public interface IGetUserPhotoBusiness
    {
        PhotoDetailsDto GetPhotoDetailsDtoByPhotoId(int PhotoId);
        UserPhoto GetUserPhotoByPhotoId(int PhotoId);
    }
}
