
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Infraestructure.Repository
{
    public class UserPhotoRepository : IUserPhotoRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public UserPhotoRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public IQueryable<UserPhoto> GetUserPhoto()
        {
            return _socialNetworkContext.Set<UserPhoto>();
        }

        public void DeleteUserPhoto(UserPhoto photo)
        {
             _socialNetworkContext.Set<UserPhoto>().Remove(photo);
            
        }

        public void AddUserPhoto(UserPhoto photo)
        {
            _socialNetworkContext.Set<UserPhoto>().Add(photo);
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _socialNetworkContext;
            }
        }


    }
}
