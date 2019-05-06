using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactCommands
{
    public interface IDeleteContactCommandHandler
    {
        Task Handler(ContactDto contactDto);
    }
}