using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Business.MessageChatRepository;
using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Querys.MessageChatQuerys
{
    public class MessageChatQuery : IMessageChatQuery
    {
        private readonly IGetMessageChatBusiness _getMessageChatBusiness;

        public MessageChatQuery(IGetMessageChatBusiness getMessageChatBusiness)
        {
            _getMessageChatBusiness = getMessageChatBusiness;
        }

        public async Task<IList<MessageChatDto>> GetListMessagesChatByChatId(int chatId)
        {
            return await _getMessageChatBusiness.GetListMessagesChatByChatId(chatId); 
        }
    }
}
