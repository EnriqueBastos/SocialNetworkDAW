using SocialNetwork.Domain.Business.ChatBusiness;
using SocialNetwork.Domain.Business.GroupChatBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands
{
    public class AddGroupChatCommandHandler: IAddGroupChatCommandHandler
    {
        private readonly IAddGroupChatBusiness _addGroupChatBusiness;
        private readonly IGroupChatRepository _groupChatRepository;
        private readonly IAddChatBusiness _addChatBusiness;

        public AddGroupChatCommandHandler(IGroupChatRepository groupChatRepository,
             IAddGroupChatBusiness addGroupChatBusiness,
            IAddChatBusiness addChatBusiness)
        {
            _addGroupChatBusiness = addGroupChatBusiness;
            _groupChatRepository = groupChatRepository;
            _addChatBusiness = addChatBusiness;
        }

        public async Task Handler(CreateChatDto groupChat)
        {
            _addChatBusiness.AddChat(groupChat.ChatName);
            _addGroupChatBusiness.AddGroupChat(new GroupChatDto
            { 
                UserId = groupChat.UserId,
                ChatId = groupChat.ChatId
            });
           

            await _groupChatRepository.UnitOfWork.Save();

        }
    }
}
