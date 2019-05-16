using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public interface IEditPhotoBusiness
    {
        void EditPhoto(GetPhotoDto photoDto);
    }
}