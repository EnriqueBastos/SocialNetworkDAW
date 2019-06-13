using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IAddUserBusiness
    {
        Task AddUser(UserDto user);
    }
}
