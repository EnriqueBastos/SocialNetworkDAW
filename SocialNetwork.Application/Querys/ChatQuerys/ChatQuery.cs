using SocialNetwork.Domain.Business.ChatBusiness;
using SocialNetwork.Domain.Dtos.ChatDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Querys.ChatQuerys
{
    
    public class ChatQuery : IChatQuery
    {
        private readonly IGetChatBusiness _getChatBusiness;

        public ChatQuery(IGetChatBusiness getChatBusiness)
        {
            _getChatBusiness = getChatBusiness;
        }

        public async Task<IList<ChatDto>> GetListChatDtoByUserId(int userId)
        {
            return await _getChatBusiness.GetChatDtosContactsByUserId(userId);
        }

        public async Task <int> GetFriendIdByUserChatDto(UserChatDto userChatDto)
        {
            return await _getChatBusiness.GetFriendIdByUserChatDto(userChatDto);
        }
    }
}
