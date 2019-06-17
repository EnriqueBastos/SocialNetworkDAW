using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using SocialNetwork.Domain.Business.UserBusiness;
using System.Threading.Tasks;
using SocialNetwork.Domain.Dtos.UserDtos;

namespace SocialNetwork.Application
{
    public class UserQuery: IUserQuery
    {
        

        private readonly IGetUserBusiness _getUserBusiness;



        public UserQuery( IGetUserBusiness getUserBusiness)
        {
           
            _getUserBusiness = getUserBusiness;

        }

        public async Task<UserDto> GetUserDtoByUserId(int userId)
        {
            return await _getUserBusiness.GetUserDtoByUserId(userId);
        }

        public async Task<IList<ProfileDto>> GetProfileList()
        {

            return await _getUserBusiness.GetListUsers();

        }

        public async Task<GetLoginDto> GetLoginDtoByUserLoginDto(UserLoginDto loginDto)
        {
            return await _getUserBusiness.GetLoginDtoByUserLoginDto(loginDto);
        }

        public async Task<ProfileDetailsDto> GetProfileDetailsDtoByUserId(int userId)
        {
            return await _getUserBusiness.GetProfileDetailsDtoByUserId(userId);
        }

        
    }
}
