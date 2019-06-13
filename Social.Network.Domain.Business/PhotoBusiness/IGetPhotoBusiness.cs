using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public interface IGetPhotoBusiness
    {
        Task<Photo> GetLastPhoto();
    }
}