using SocialNetwork.Domain.Business.GroupChatBusiness;
using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Application.GroupChatQuerys
{
    public class GroupChatQuery : IGroupChatQuery
    {
        private readonly IAddGroupChatBusiness _addGroupChat;

        public GroupChatQuery(IAddGroupChatBusiness addGroupChat)
        {
            _addGroupChat = addGroupChat;
        }


        //public GroupChatDto GetGroupChat(int groupChatId)
        //{
        //    _addGroupChat.AddGroupChat(groupChat);
        //}
    }
}
