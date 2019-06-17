using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.UserCommands
{
    public interface IDeleteUserCommandHandler
    {
        Task Handler(int userId);

    }
}