using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
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
            var user = _getUserBusiness.GetUserDtoByUserId(userId);

            _userRepository.DeleteUser(new User {
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                DateBirthday = user.DateBirthday,
                PhotoProfile = user.PhotoProfile,
                BackgroundApp = user.BackgroundApp,
                Private = user.Private
            });
        }
    }
}
