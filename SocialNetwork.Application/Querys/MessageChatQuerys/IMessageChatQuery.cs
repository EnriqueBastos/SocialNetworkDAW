using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Querys.MessageChatQuerys
{
    public interface IMessageChatQuery
    {
        Task<IList<MessageChatDto>> GetListMessagesChatByChatId(int chatId);
    }
}
