using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Business;
using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Business.UserBusiness;

namespace SocialNetwork.Application
{
    public class UserQuery: IUserQuery
    {
        private readonly IGetProfileBusiness _getProfileBusiness;

        private readonly IGetUserBusiness _getUserBusiness;

        public UserQuery(IGetProfileBusiness getProfileBusiness , IGetUserBusiness getUserBusiness)
        {
            _getProfileBusiness = getProfileBusiness;

            _getUserBusiness = getUserBusiness;

            
        }

        public UserDto GetProfile(int userId)
        {

            return _getProfileBusiness.GetProfileInfo(userId);

        }

        

        
    }
}
