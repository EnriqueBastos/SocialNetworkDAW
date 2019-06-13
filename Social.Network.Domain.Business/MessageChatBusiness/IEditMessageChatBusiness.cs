using SocialNetwork.Domain.Dtos.ChatDtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.MessageChatBusiness
{
    public interface IEditMessageChatBusiness
    {
        Task ReadMessageChats(UserChatDto userChatDto);
    }
}