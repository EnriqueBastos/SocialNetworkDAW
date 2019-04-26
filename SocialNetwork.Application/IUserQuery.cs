using SocialNetwork.Application.Dtos;

namespace SocialNetwork.Application
{
    public interface IUserQuery
    {
        UserDto GetProfile(int userId);
    }
}