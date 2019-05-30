using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public interface IAddPhotoBusiness
    {
        Task AddPhoto(AddPhotoDto photoDto);
    }
}