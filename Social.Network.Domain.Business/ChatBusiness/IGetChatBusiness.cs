using SocialNetwork.Domain.Dtos.ChatDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ChatBusiness
{
    public interface IGetChatBusiness
    {
        Task<int> GetChatIdByContactId(int contactId);

        Task<IList<ChatDto>> GetChatDtosContactsByUserId(int userId);

        Task<int> GetFriendIdByUserChatDto(UserChatDto userChatDto);
    }
}