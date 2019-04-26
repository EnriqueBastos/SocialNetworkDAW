using SocialNetwork.Application.Dtos;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application
{
    public class UserQuery: IUserQuery
    {
        private readonly IGetProfileBusiness _getProfileBusiness;
        public UserQuery(IGetProfileBusiness getProfileBusiness )
        {
            _getProfileBusiness = getProfileBusiness;
        }   
        public UserDto GetProfile(int userId)
        {

            return _getProfileBusiness.GetProfileInfo(userId);
        }
    }
}
