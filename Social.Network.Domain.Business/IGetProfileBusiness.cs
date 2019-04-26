using SocialNetwork.Application.Dtos;

namespace SocialNetwork.Domain.Business
{
    public interface IGetProfileBusiness
    {
        UserDto GetProfileInfo(int id);
    }
}