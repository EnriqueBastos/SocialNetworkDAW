using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;

namespace SocialNetwork.Application
{
    public interface IUserQuery
    {
        IList<ProfileDto> GetProfileList();

        ProfileDetailsDto GetProfileDetailsDtoByUserId(int userId);

        UserDto GetUserDtoByUserId(int userId);

        int GetUserIdByLoginDto(UserLoginDto loginDto);



    }
}