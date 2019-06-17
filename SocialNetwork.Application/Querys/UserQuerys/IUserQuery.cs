using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.UserDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application
{
    public interface IUserQuery
    {
        Task<IList<ProfileDto>> GetProfileList();

        Task<ProfileDetailsDto> GetProfileDetailsDtoByUserId(int userId);

        Task<UserDto> GetUserDtoByUserId(int userId);

        Task<GetLoginDto> GetLoginDtoByUserLoginDto(UserLoginDto loginDto);
        



    }
}