using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.UserDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands
{
    public interface IAddUserCommandHandler
    {
        Task<GetLoginDto> Handler(UserDto user);
    }
}