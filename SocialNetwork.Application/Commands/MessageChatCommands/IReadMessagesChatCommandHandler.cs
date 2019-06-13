using SocialNetwork.Domain.Dtos.ChatDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.MessageChatCommands
{
    public interface IReadMessagesChatCommandHandler
    {
        Task Handler(UserChatDto userChatDto);
    }
}