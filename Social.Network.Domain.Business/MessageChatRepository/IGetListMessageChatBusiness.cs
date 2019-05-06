using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public interface IGetListMessageChatBusiness
    {
        IList<MessageChatDto> GetListMessageChatByChatId(int chatId);
    }
}