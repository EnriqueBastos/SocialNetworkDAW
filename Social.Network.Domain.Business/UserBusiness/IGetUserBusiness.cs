using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.UserDtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IGetUserBusiness
    {
        Task<UserDto> GetUserDtoByUserId(int UserId);
        Task<IList<ProfileDto>> GetListUsers();
        Task<ProfileDetailsDto> GetProfileDetailsDtoByUserId(int userId);
        Task<GetLoginDto> GetLoginDtoByUserLoginDto(UserLoginDto loginDto);
        Task<IList<ProfileDto>> GetListProfileDtosByUserNameUserId(string userName, int userId);
        Task<string> GetUserNameByUserId(int userId);
        Task<string> GetPasswordByUserId(int userId);
        Task<User> GetUserByUserId(int id);
    }
}
