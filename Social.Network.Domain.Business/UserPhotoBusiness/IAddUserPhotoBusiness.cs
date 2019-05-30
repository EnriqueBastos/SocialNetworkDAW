using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserPhotoBusiness
{
    public interface IAddUserPhotoBusiness
    {
        Task AddUserPhoto(AddPhotoDto newPhoto);
    }
}