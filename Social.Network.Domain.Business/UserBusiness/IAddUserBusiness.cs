using SocialNetwork.Domain.Dtos;


namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IAddUserBusiness
    {
        void AddUser(UserDto user);
    }
}
