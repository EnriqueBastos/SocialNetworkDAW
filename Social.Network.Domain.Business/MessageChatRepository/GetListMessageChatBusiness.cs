using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public class GetListMessageChatBusiness : IGetListMessageChatBusiness
    {
        private readonly IMessageChatRepository _messageChatRepository;

        public GetListMessageChatBusiness(IMessageChatRepository messageChatRepository)
        {
            _messageChatRepository = messageChatRepository;
        }

        public IList<MessageChatDto> GetListMessageChatByChatId (int chatId)
        {
            return _messageChatRepository
                .GetMessageChat()
                .Select(messageChat => new MessageChatDto
                {
                   UserName = messageChat.User.Name,
                   MessageText = messageChat.MessageText

                }).Where(messageChat =>

                messageChat.ChatId == chatId

                ).ToList();
                
        }
    }
}
