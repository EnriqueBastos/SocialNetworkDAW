using SocialNetwork.Domain.Entities;

using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IUserPhotoRepository : IRepository
    {
        IQueryable<UserPhoto> GetUserPhoto();

        void DeleteUserPhoto(UserPhoto photo);

        Task AddUserPhoto(UserPhoto photo);



    }
}
