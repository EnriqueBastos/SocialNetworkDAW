using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public class AddMessageChatBusiness : IAddMessageChatBusiness
    {
        private readonly IMessageChatRepository _messageChatRepository;
        public AddMessageChatBusiness(IMessageChatRepository messageChatRepository)
        {
            _messageChatRepository = messageChatRepository;
        }
        public async Task AddChatMessage(MessageChatDto message)
        {
            DateTime dateTime = DateTime.Now;
            await _messageChatRepository.AddMessageChat(new MessageChat
            {
                MessageText = message.MessageText,
                UserId = message.UserId,
                ChatId = message.ChatId,
                MessageDate = dateTime,
                IsSeen = false
            });
        }
    }
}
