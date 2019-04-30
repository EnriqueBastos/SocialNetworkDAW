using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands
{
    public interface IAddGroupChatCommandHandler
    {
        Task Handler(CreateChatDto groupChat);
    }
}