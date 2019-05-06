using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class EditUserBusiness : IEditUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public EditUserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void EditUser(UserDto userDto)
        {
            _userRepository.EditUser(new User {
                Id = userDto.Id,
                Name = userDto.Name,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password,
                DateBirthday = userDto.DateBirthday,
                PhotoProfile = userDto.PhotoProfile,
                BackgroundApp = userDto.BackgroundApp,
                Private = userDto.Private
            });
        }
    }
}
