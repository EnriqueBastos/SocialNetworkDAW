using System;
using System.Collections.Generic;
using System.Text;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.GroupChatBusiness
{
    public class AddGroupChatBusiness : IAddGroupChatBusiness
    {
        private readonly IGroupChatRepository _groupChatRepository;

        public AddGroupChatBusiness(IGroupChatRepository groupChatRepository)
        {
            _groupChatRepository = groupChatRepository;
        }
        public void AddGroupChat(GroupChatDto groupChatDto)
        {
            _groupChatRepository.AddGroupChat(new GroupChat {
                UserId = groupChatDto.UserId,
                ChatId = groupChatDto.ChatId
            });


        }
    }
}
