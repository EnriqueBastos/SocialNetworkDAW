using SocialNetwork.Domain.Entities;

using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IUserRepository : IRepository
    {
        IQueryable<User> GetUser();

        Task AddUser(User user);

        void DeleteUser(User user);

        void EditUser(User user);




    }
}
