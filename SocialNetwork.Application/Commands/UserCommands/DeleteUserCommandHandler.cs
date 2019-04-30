using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserCommands
{
    public class DeleteUserCommandHandler : IDeleteUserCommandHandler
    {
        private readonly IUserRepository _userRepository;
        private readonly IDeleteUserBusiness _deleteUserBusiness;

        public DeleteUserCommandHandler(IUserRepository userRepository , IDeleteUserBusiness deleteUserBusiness)
        {
            _userRepository = userRepository;
            _deleteUserBusiness = deleteUserBusiness;
        }

        public async Task Handler(UserDto user)
        {
            _deleteUserBusiness.DeleteUserByUserId(user.Id);
            await _userRepository.UnitOfWork.Save();
        }
    }
}
