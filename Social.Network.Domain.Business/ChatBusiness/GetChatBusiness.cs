using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Business.MessageChatRepository;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos.ChatDtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ChatBusiness
{
    public class GetChatBusiness : IGetChatBusiness
    {
        private readonly IChatRepository _chatRepository;
        private readonly IGetContactBusiness _getContactBusiness;
        private readonly IGetMessageChatBusiness _getMessageChatBusiness;

        public GetChatBusiness(
            IChatRepository chatRepository ,
            IGetContactBusiness getContactBusiness,
            IGetMessageChatBusiness getMessageChatBusiness
            )
        {
            _chatRepository = chatRepository;
            _getContactBusiness = getContactBusiness;
            _getMessageChatBusiness = getMessageChatBusiness;
        }

        public async Task<int> GetChatIdByContactId(int contactId)
        {
            var chat = await _chatRepository
                .GetChat()
                .Where(x =>
                    x.ContactFriendUserId == contactId || x.ContactUserFriendId == contactId
                ).FirstOrDefaultAsync();

            return chat.Id;
        }

        public async Task<IList<ChatDto>> GetChatDtosContactsByUserId(int userId)
        {
            var contacts = await _getContactBusiness.GetListContactByUserId(userId);

            contacts = contacts.ToList();

            IList<ChatDto> chatDtos = new List<ChatDto>();

            foreach(Contact contact in contacts)
            {
                int chatId = await GetChatIdByContactId(contact.Id);

                int countIsNotSeen = await _getMessageChatBusiness.GetCountIsNotSeen(userId, chatId);

                chatDtos.Add(new ChatDto
                {
                    UserName = contact.User.Name,
                    PhotoProfile = contact.User.PhotoProfile,
                    ChatId = chatId,
                    CountIsNotSeen = countIsNotSeen

                });
            }

            return chatDtos;
            
        }

        public async Task<int> GetFriendIdByUserChatDto(UserChatDto userChatDto)
        {
            var chat =  await _chatRepository
                .GetChat()
                .FirstOrDefaultAsync(x => x.Id == userChatDto.ChatId);
            return await _getContactBusiness.GetFriendIdByContactIdUserId(chat.ContactFriendUserId, userChatDto.UserId);
        }
    }
}
