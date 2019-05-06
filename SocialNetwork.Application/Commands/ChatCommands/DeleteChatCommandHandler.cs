using SocialNetwork.Domain.Business.ChatBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ChatCommands
{
    public class DeleteChatCommandHandler : IDeleteChatCommandHandler
    {
        private readonly IChatRepository _chatRepository;

        private readonly IDeleteChatBusiness _deleteChatBusiness;
        public DeleteChatCommandHandler(IChatRepository chatRepository , IDeleteChatBusiness deleteChatBusiness)
        {
            _chatRepository = chatRepository;
            _deleteChatBusiness = deleteChatBusiness;

        }

        public async Task Handler(ChatDto chatDto)
        {
            _deleteChatBusiness.DeleteChat(chatDto);

            await _chatRepository.UnitOfWork.Save();
        }
    }
}
