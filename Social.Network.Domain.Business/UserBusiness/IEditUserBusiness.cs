using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IEditUserBusiness
    {
        void EditUser(SetUserDto user);
    }
}
