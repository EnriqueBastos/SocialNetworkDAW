using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        

        public UserRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public async Task AddUser(User user)
        {
             await _socialNetworkContext.Set<User>().AddAsync(user);
             
        }

        public void DeleteUser(User user)
        {
            _socialNetworkContext.Set<User>().Remove(user);
            
        }

        public void EditUser(User user)
        {
            _socialNetworkContext.Entry(user).State = EntityState.Modified;
        }

        public IQueryable<User> GetUser()
        {
            return _socialNetworkContext.Set<User>();
        }

        public IUnitOfWork UnitOfWork
        {
            get { return _socialNetworkContext; }
        }

    }
}
