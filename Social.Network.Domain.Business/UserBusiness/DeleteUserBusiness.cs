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
            var user = await _getUserBusiness.GetUserDtoByUserId(userId);

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

            await _userRepository.UnitOfWork.Save();
        }
    }
}
