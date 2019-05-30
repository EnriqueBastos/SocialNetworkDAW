using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public interface IGetUserBusiness
    {
        Task<UserDto> GetUserDtoByUserId(int UserId);
        Task<IList<ProfileDto>> GetListUsers();
        Task<ProfileDetailsDto> GetProfileDetailsDtoByUserId(int userId);

        Task<int> GetUserIdByLoginDto(UserLoginDto loginDto);

        Task<IList<ProfileDto>> GetProfileDtosBySearchContactDto(SearchContactDto searchContactDto);
    }
}
