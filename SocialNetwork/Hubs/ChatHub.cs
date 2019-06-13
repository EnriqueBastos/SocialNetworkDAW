using Microsoft.AspNetCore.SignalR;
using SocialNetwork.Application;
using SocialNetwork.Application.Commands.MessageChatCommands;
using SocialNetwork.Application.Querys.ChatQuerys;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.ChatDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IAddMessageChatCommandHandler _addMessageChatCommandHandler;
        private readonly IUserQuery _userQuery;
        private readonly IReadMessagesChatCommandHandler _editMessageChatCommandHandler;
        private readonly IChatQuery _chatQuery;

        public ChatHub(
            IAddMessageChatCommandHandler addMessageChatCommandHandler ,
            IUserQuery userQuery,
            IReadMessagesChatCommandHandler editMessageChatCommandHandler,
            IChatQuery chatQuery
            )
        {
            _addMessageChatCommandHandler = addMessageChatCommandHandler;
            _userQuery = userQuery;
            _editMessageChatCommandHandler = editMessageChatCommandHandler;
            _chatQuery = chatQuery;
        }
        public async Task SendMessage(MessageChatDto messageChatDto)
        {
            await _addMessageChatCommandHandler.Handler(messageChatDto);

            UserDto userDto = await _userQuery.GetUserDtoByUserId(messageChatDto.UserId);

            string chatString = "ChatId" + messageChatDto.ChatId;

            await Clients.All.SendAsync(chatString, new MessageChatDto
            {
                UserId = messageChatDto.UserId,
                UserName = userDto.Name,
                MessageText = messageChatDto.MessageText,
                ChatId = messageChatDto.ChatId,
                IsSeen = false

            });
        }

        public async Task SendMessageNotification(UserChatDto userChatDto)
        {
            int FriendId = await _chatQuery.GetFriendIdByUserChatDto(userChatDto);

            string userString = "UserId" + FriendId;

            await Clients.All.SendAsync(userString, userChatDto.ChatId);
        }

        
    }
}
