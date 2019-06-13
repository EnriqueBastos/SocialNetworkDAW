using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.ChatDtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.MessageChatRepository
{
    public class GetMessageChatBusiness : IGetMessageChatBusiness
    {
        private readonly IMessageChatRepository _messageChatRepository;

        public GetMessageChatBusiness(IMessageChatRepository messageChatRepository)
        {
            _messageChatRepository = messageChatRepository;
        }

        public async Task<int> GetCountIsNotSeen(int userId, int chatId)
        {
            var messagesNotSeen =  await _messageChatRepository
                .GetMessageChat()
                .Where(m => m.UserId != userId && m.ChatId == chatId)
                .Where(m => !m.IsSeen).ToListAsync();

            return messagesNotSeen.Count();
        }
        public async Task<IList<MessageChatDto>> GetListMessagesChatByChatId (int chatId)
        {
            var messages = await _messageChatRepository
                .GetMessageChat()
                .Where(m => m.ChatId == chatId)
                .Include(m => m.User)
                .Select(m => new MessageChatDto
                {
                    ChatId = chatId,
                    MessageText = m.MessageText,
                    UserName = m.User.Name,
                    UserId = m.UserId,
                    MessageDate = m.MessageDate,
                    IsSeen = m.IsSeen
                })
                .ToListAsync();

            return messages;
        }

        public async Task<IList<MessageChat>> GetListMessagesChatByUserChatDto(UserChatDto userChatDto)
        {
            return await _messageChatRepository
                .GetMessageChat()
                .Where(m =>
                    m.UserId != userChatDto.UserId &&
                    m.ChatId == userChatDto.ChatId &&
                    !m.IsSeen
                ).Select(m => new MessageChat
                {
                    Id = m.Id,
                    MessageText = m.MessageText,
                    UserId = m.UserId,
                    ChatId = m.ChatId,
                    MessageDate = m.MessageDate,
                    IsSeen = true
                }
                ).ToListAsync();
        }
        

        
    }
}
