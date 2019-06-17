using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class DeleteUserBusiness : IDeleteUserBusiness
    {
        private readonly IGetUserBusiness _getUserBusiness;

        private readonly IUserRepository _userRepository;

        public DeleteUserBusiness(IGetUserBusiness getUserBusiness , IUserRepository userRepository)
        {
            _getUserBusiness = getUserBusiness;

            _userRepository = userRepository;
        }

        public async Task DeleteUserByUserId(int userId)
        {
            var user = await _getUserBusiness.GetUserByUserId(userId);

            _userRepository.DeleteUser(user);
        }
    }
}
