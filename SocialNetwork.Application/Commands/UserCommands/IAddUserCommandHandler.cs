using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands
{
    public interface IAddUserCommandHandler
    {
        Task<int> Handler(UserDto user);
    }
}