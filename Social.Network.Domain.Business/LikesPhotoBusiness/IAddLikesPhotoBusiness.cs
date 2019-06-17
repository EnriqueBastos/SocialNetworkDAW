using SocialNetwork.Domain.Dtos.PhotoDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.LikesPhotoBusiness
{
    public interface IAddLikesPhotoBusiness
    {
        Task AddLikesPhoto(LikesPhotoDto likesPhotoDto);
    }
}