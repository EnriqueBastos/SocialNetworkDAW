using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application
{
    public interface IUserQuery
    {
        Task<IList<ProfileDto>> GetProfileList();

        Task<ProfileDetailsDto> GetProfileDetailsDtoByUserId(int userId);

        Task<UserDto> GetUserDtoByUserId(int userId);

        Task<int> GetUserIdByLoginDto(UserLoginDto loginDto);

        Task<IList<ProfileDto>> GetProfileDtosBySearchContactDto(SearchContactDto searchContactDto);



    }
}