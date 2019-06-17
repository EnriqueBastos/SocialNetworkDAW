using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Contracts;
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

        public async Task Handler(int userId)
        {
            await _deleteUserBusiness.DeleteUserByUserId(userId);
            await _userRepository.UnitOfWork.Save();
        }
    }
}
