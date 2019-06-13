using SocialNetwork.Domain.Business.MessageChatBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.ChatDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.MessageChatCommands
{
    public class ReadMessagesChatCommandHandler : IReadMessagesChatCommandHandler
    {
        IEditMessageChatBusiness _editMessageChatBusiness;

        IMessageChatRepository _messageChatRepository;

        public ReadMessagesChatCommandHandler(IEditMessageChatBusiness editMessageChatBusiness , IMessageChatRepository messageChatRepository)
        {
            _editMessageChatBusiness = editMessageChatBusiness;
            _messageChatRepository = messageChatRepository;
        }

        public async Task Handler(UserChatDto userChatDto)
        {
            await _editMessageChatBusiness.ReadMessageChats(userChatDto);
            await _messageChatRepository.UnitOfWork.Save();
        }
    }
}
