using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.ChatBusiness
{
    public class AddChatBusiness : IAddChatBusiness
    {
        private readonly IChatRepository _chatRepository;

        public AddChatBusiness(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public void AddChat(string chat)
        {
            _chatRepository.AddChat(new Chat
            {
                ChatName = chat
            });
        }

    }
}
