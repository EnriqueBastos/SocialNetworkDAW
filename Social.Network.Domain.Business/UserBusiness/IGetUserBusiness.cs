using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;


namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IGetUserBusiness
    {
        User GetUserByUserId(int UserId);
        UserDto GetUserDtoByUserId(int UserId);
    }
}
