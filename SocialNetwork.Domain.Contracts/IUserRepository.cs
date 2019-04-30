using SocialNetwork.Domain.Entities;

using System.Linq;

namespace SocialNetwork.Domain.Contracts
{
    public interface IUserRepository
    {
        IQueryable<User> GetUser();

        void AddUser(User user);

        void DeleteUser(User user);
        
    }
}
