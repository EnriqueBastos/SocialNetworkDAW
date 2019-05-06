using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ChatCommands
{
    public interface IAddChatCommandHandler
    {
        Task Handler(string chatName);
    }
}