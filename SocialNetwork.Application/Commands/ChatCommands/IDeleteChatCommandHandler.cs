using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ChatCommands
{
    public interface IDeleteChatCommandHandler
    {
        Task Handler(ChatDto chatDto);
    }
}