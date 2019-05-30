using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserCommands
{
    public interface IEditUserCommandHandler
    {
        Task Handler(SetUserDto userDto);
    }
}