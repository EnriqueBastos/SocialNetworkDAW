using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IGetUserBusiness
    {
        UserDto GetUserDtoByUserId(int UserId);
        IList<ProfileDto> GetListUsers();
    }
}
