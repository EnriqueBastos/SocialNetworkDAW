using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class DeleteUserBusiness : IDeleteUserBusiness
    {
        private readonly IGetUserBusiness _getUserBusiness;

        private readonly IUserRepository _userRepository;

        public DeleteUserBusiness(IGetUserBusiness getUserBusiness)
        {
            _getUserBusiness = getUserBusiness;
        }

        public void DeleteUserByUserId(int userId)
        {
            var user = _getUserBusiness.GetUserByUserId(userId);

            _userRepository.DeleteUser(user);
        }
    }
}
