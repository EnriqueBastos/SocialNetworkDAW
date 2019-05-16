using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IGetUserBusiness
    {
        UserDto GetUserDtoByUserId(int UserId);
        IList<ProfileDto> GetListUsers();
        ProfileDetailsDto GetProfileDetailsDtoByUserId(int userId);

        int GetUserIdByLoginDto(UserLoginDto loginDto);
    }
}
