using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Linq;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class GetUserBusiness : IGetUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public GetUserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto GetUserDtoByUserId(int UserId)
        {
            return _userRepository
                .GetUser()
                .Select(user => new UserDto
                {
                    Name = user.Name,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    DateBirthday = user.DateBirthday,
                    PhotoProfile = user.PhotoProfile,
                    BackgroundApp = user.BackgroundApp
                }).FirstOrDefault();
        }

        public User GetUserByUserId(int UserId)
        {
            return _userRepository
                .GetUser()
                .FirstOrDefault(user =>
               user.Id == UserId);
        }
    }
}
