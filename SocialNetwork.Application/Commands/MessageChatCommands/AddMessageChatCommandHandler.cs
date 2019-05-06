using SocialNetwork.Domain.Business.MessageChatRepository;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.MessageChatCommands
{
    public class AddMessageChatCommandHandler : IAddMessageChatCommandHandler
    {
        private readonly IMessageChatRepository _messageChatRepository;
        private readonly IAddMessageChatBusiness _addMessageChatBusiness;

        public AddMessageChatCommandHandler(IMessageChatRepository messageChatRepository, IAddMessageChatBusiness addMessageChatBusiness)
        {
            _messageChatRepository = messageChatRepository;
            _addMessageChatBusiness = addMessageChatBusiness;
        }

        public async Task Handler(MessageChatDto message)
        {
            _addMessageChatBusiness.AddChatMessage(message);
            await _messageChatRepository.UnitOfWork.Save();

        }
    }
}
