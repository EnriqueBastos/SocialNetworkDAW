using SocialNetwork.Domain.Business.MessageChatRepository;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.ChatDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.MessageChatBusiness
{
    public class EditMessageChatBusiness : IEditMessageChatBusiness
    {
        private readonly IMessageChatRepository _messageChatRepository;

        private readonly IGetMessageChatBusiness _getMessageChatBusiness;
        public EditMessageChatBusiness(IMessageChatRepository messageChatRepository , IGetMessageChatBusiness getMessageChatBusiness)
        {
            _messageChatRepository = messageChatRepository;
            _getMessageChatBusiness = getMessageChatBusiness;
        }

        public async Task ReadMessageChats(UserChatDto userChatDto)
        {
            var messages = await _getMessageChatBusiness.GetListMessagesChatByUserChatDto(userChatDto);
            messages.ToList().ForEach(m =>
           {
               _messageChatRepository.EditMessageChat(m);
           });
        }
    }
}
