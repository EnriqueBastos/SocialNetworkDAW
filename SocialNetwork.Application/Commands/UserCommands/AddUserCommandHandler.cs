using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;

using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands
{
    public class AddUserCommandHandler : IAddUserCommandHandler
    {
        private readonly IAddUserBusiness _addUserBusiness;
        private readonly IUserRepository _userRepository;
        private readonly IGetUserBusiness _getUserBusiness;

        public AddUserCommandHandler(IAddUserBusiness addUserBusiness, IUserRepository userRepository , IGetUserBusiness getUserBusiness)
        {
            _addUserBusiness = addUserBusiness;

            _userRepository = userRepository;

            _getUserBusiness = getUserBusiness;
        }

        public async Task<int> Handler(UserDto user)
        {
            await _addUserBusiness.AddUser(user);

            await _userRepository.UnitOfWork.Save();

            return await _getUserBusiness.GetUserIdByLoginDto(
                new UserLoginDto
                {
                    Email = user.Email,
                    Password = user.Password
                }
            );
        }
    }
}
