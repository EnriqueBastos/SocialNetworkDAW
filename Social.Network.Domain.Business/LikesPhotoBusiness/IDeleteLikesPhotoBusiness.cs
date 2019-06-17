using SocialNetwork.Domain.Dtos.PhotoDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.LikesPhotoBusiness
{
    public interface IDeleteLikesPhotoBusiness
    {
        Task DeleteLikesPhotoByLikesPhotoDto(LikesPhotoDto likesPhotoDto);
    }
}