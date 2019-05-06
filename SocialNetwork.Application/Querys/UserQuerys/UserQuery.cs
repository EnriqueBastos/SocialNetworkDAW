using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using SocialNetwork.Domain.Business.UserBusiness;

namespace SocialNetwork.Application
{
    public class UserQuery: IUserQuery
    {
        

        private readonly IGetUserBusiness _getUserBusiness;



        public UserQuery( IGetUserBusiness getUserBusiness)
        {
           
            _getUserBusiness = getUserBusiness;

        }

        public UserDto GetUserByUserId(int userId)
        {
            return _getUserBusiness.GetUserDtoByUserId(userId);
        }

        public IList<ProfileDto> GetProfileList()
        {

            return _getUserBusiness.GetListUsers();

        }

        

        
    }
}
