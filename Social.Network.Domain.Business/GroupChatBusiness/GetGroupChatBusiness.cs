using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Linq;

namespace SocialNetwork.Domain.Business.GroupChatBusiness
{
    public class GetGroupChatBusiness
    {
        private readonly IGroupChatRepository _groupChatRepository;

        public GetGroupChatBusiness(IGroupChatRepository groupChatRepository)
        {
            _groupChatRepository = groupChatRepository;
        }

        public CreateChatDto GetGroupChat(int GroupChatId)
        {
            return _groupChatRepository
                .GetGroupChat()
                .Select(groupChat => new CreateChatDto
                {
                    UserId = groupChat.UserId,
                    ChatName = groupChat.Chat.ChatName

                }).FirstOrDefault(groupChat => groupChat.ChatId == GroupChatId);
        }
    }
}
