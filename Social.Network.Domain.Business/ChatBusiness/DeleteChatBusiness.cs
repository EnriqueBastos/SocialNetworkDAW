using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.ChatBusiness
{
    public class DeleteChatBusiness : IDeleteChatBusiness
    {
        private readonly IChatRepository _chatRepository;
        public DeleteChatBusiness(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public void DeleteChat(ChatDto chatDto)
        {
            _chatRepository.DeleteChat(new Chat {
                Id = chatDto.Id,
                ChatName = chatDto.ChatName
            });
        }
    }
}
