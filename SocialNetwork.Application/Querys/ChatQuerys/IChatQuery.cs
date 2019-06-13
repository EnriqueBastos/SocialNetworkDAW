using SocialNetwork.Domain.Dtos.ChatDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Querys.ChatQuerys
{
    public interface IChatQuery
    {
        Task<IList<ChatDto>> GetListChatDtoByUserId(int userId);
        Task<int> GetFriendIdByUserChatDto(UserChatDto userChatDto);
    }
}