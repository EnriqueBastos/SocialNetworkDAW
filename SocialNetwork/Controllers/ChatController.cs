using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SocialNetwork.Application.Commands.MessageChatCommands;
using SocialNetwork.Application.Querys.ChatQuerys;
using SocialNetwork.Application.Querys.ContactQuerys;
using SocialNetwork.Application.Querys.MessageChatQuerys;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.ChatDtos;

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IMessageChatQuery _messageChatQuery;

        private readonly IChatQuery _chatQuery;

        private readonly IAddMessageChatCommandHandler _addMessageChatCommandHandler;

        private readonly IReadMessagesChatCommandHandler _readMessagesChatCommandHandler;

        public ChatController(
            IMessageChatQuery messageChatQuery ,
            IAddMessageChatCommandHandler addMessageChatCommandHandler ,
            IChatQuery chatQuery,
            IReadMessagesChatCommandHandler readMessagesChatCommandHandler
            )
        {
            _messageChatQuery = messageChatQuery;
            _addMessageChatCommandHandler = addMessageChatCommandHandler;
            _chatQuery = chatQuery;
            _readMessagesChatCommandHandler = readMessagesChatCommandHandler;
        }


        // GET: api/Chat/GetListChat/5
        [HttpGet("{userId}", Name = "GetListChat")]
        [ActionName("GetListChat")]
        public async Task<IList<ChatDto>> GetContactChatsByUserId(int userId)
        {
            return await _chatQuery.GetListChatDtoByUserId(userId);
        }

        [HttpGet("{chatId}" , Name ="GetMessagesChat")]
        [ActionName("GetMessagesChat")]

        public async Task<IList<MessageChatDto>> GetListMessagesChatByChatId(int chatId)
        {
            return await _messageChatQuery.GetListMessagesChatByChatId(chatId);
        }

        [HttpPost]
        [ActionName("AddMessageChat")]
        public async Task AddMessageChat([FromBody] MessageChatDto messageChatDto)
        {
            await _addMessageChatCommandHandler.Handler(messageChatDto);
        }

        [HttpPost]
        [ActionName("ReadMessagesChat")]

        public async Task ReadMessagesChat([FromBody] UserChatDto userChatDto)
        {
            await _readMessagesChatCommandHandler.Handler(userChatDto);
        }
        

    }
}
