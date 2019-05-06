using SocialNetwork.Domain.Business.ChatBusiness;
using SocialNetwork.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ChatCommands
{
    public class AddChatComandHandler : IAddChatCommandHandler
    {
        private readonly IAddChatBusiness _addChatBusiness;

        private readonly IChatRepository _chatRepository;

        public AddChatComandHandler(IAddChatBusiness addChatBusiness, IChatRepository chatRepository)
        {
            _addChatBusiness = addChatBusiness;

            _chatRepository = chatRepository;
        }

        public async Task Handler(string chatName)
        {
            _addChatBusiness.AddChat(chatName);

            await _chatRepository.UnitOfWork.Save();
        }

    }
}
