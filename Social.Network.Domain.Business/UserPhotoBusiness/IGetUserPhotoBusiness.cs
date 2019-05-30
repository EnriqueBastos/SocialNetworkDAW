using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public interface IGetUserPhotoBusiness
    {
        Task<GetPhotoDto> GetPhotoDetailsDtoByPhotoId(int PhotoId);
        UserPhoto GetUserPhotoByPhotoId(int PhotoId);

        Task<GetUserPhotoInfoDto> GetUserPhotoInfoDtoByPhotoId(int userPhotoId);
    }
}
