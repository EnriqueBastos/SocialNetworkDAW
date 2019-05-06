using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public interface IAddPhotoBusiness
    {
        void AddPhoto(PhotoDetailsDto photo);
    }
}