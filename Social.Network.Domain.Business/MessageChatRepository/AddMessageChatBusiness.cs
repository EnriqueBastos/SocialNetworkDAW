using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public class AddMessageChatBusiness : IAddMessageChatBusiness
    {
        private readonly IMessageChatRepository _messageChatRepository;
        public AddMessageChatBusiness(IMessageChatRepository messageChatRepository)
        {
            _messageChatRepository = messageChatRepository;
        }
        public void AddChatMessage(MessageChatDto message)
        {
            _messageChatRepository.AddMessageChat(new MessageChat
            {
                MessageText = message.MessageText,
                ChatId = message.ChatId,
                UserId = message.UserId,
                MessageDate = message.MessageDate 
            });
        }
    }
}
