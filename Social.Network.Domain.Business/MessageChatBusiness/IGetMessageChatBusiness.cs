using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.ChatDtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public interface IGetMessageChatBusiness
    {
        Task<IList<MessageChatDto>> GetListMessagesChatByChatId(int chatId);

        Task<int> GetCountIsNotSeen(int userId, int chatId);

        Task<IList<MessageChat>> GetListMessagesChatByUserChatDto(UserChatDto userChatDto);



    }
}