using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;

namespace SocialNetwork.Application
{
    public interface IUserQuery
    {
        IList<ProfileDto> GetProfileList();

        UserDto GetUserByUserId(int userId);



    }
}