using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserCommands
{
    public class EditUserCommandHandler : IEditUserCommandHandler
    {
        private readonly IEditUserBusiness _editUserBusiness;

        private readonly IRepository _repository;
        public EditUserCommandHandler(IEditUserBusiness editUserBusiness , IRepository repository)
        {
            _editUserBusiness = editUserBusiness;
            _repository = repository;
        }

        public async Task Handler(UserDto userDto)
        {
            _editUserBusiness.EditUser(userDto);

            await _repository.UnitOfWork.Save();

        }
    }
}
