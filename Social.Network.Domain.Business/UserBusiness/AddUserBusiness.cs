using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Business.UserBusiness;

namespace SocialNetwork.Domain.Business
{
    public class AddUserBusiness : IAddUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public AddUserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserDto user)
        {
            User newUser = new User
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                DateBirthday = user.DateBirthday,
                PhotoProfile = user.PhotoProfile,
                BackgroundApp = user.BackgroundApp
            };

            _userRepository.AddUser(newUser);
            
        }


    }
}
