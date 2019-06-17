using SocialNetwork.Domain.Dtos.PhotoDtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.LikesPhotoBusiness
{
    public interface IGetLikesPhotoBusiness
    {
        Task<IList<LikesPhotoDto>> GetLikesPhotoDtosByUserPhotoId(int userPhotoId);
        Task<LikesPhoto> GetLikesPhotoByLikesPhotoDto(LikesPhotoDto likesPhotoDto);
    }
}