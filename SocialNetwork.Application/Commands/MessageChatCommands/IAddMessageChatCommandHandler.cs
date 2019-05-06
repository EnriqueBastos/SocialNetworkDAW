using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.MessageChatCommands
{
    public interface IAddMessageChatCommandHandler
    {
        Task Handler(MessageChatDto message);
    }
}