
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IDeleteUserBusiness
    {
        Task DeleteUserByUserId(int userId);
    }
}
