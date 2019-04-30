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

        public AddUserCommandHandler(IAddUserBusiness addUserBusiness, IUserRepository userRepository)
        {
            _addUserBusiness = addUserBusiness;

            _userRepository = userRepository;
        }

        public async Task Handler(UserDto user)
        {
            _addUserBusiness.AddUser(user);

            await _userRepository.UnitOfWork.Save();
        }
    }
}
