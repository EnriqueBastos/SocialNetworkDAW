using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public interface IDeletePhotoBusiness
    {
        void DeletePhoto(PhotoDetailsDto photo);
    }
}