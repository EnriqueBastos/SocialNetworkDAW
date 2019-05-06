using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactCommands
{
    public interface IAddContactCommandHandler
    {
        Task Handler(ContactDto contactDto);
    }
}