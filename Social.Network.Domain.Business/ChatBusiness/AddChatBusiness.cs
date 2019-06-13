using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ChatBusiness
{
    public class AddChatBusiness : IAddChatBusiness
    {
        private readonly IChatRepository _chatRepository;

        public AddChatBusiness(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task AddChat (int contactUserFriendId ,  int contactFriendUserId)
        {
            await _chatRepository.AddChat(new Chat
            {
                ContactFriendUserId = contactFriendUserId,
                ContactUserFriendId = contactUserFriendId
            });
        }
    }
}
