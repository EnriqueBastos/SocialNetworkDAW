using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactNotificationCommands
{
    public interface IAddContactNotificationCommandHandler
    {
        Task Handler(ContactDto contactDto);
    }
}