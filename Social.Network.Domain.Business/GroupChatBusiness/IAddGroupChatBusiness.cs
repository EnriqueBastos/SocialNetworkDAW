using SocialNetwork.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.Domain.Business.GroupChatBusiness
{
    public interface IAddGroupChatBusiness
    {
        void AddGroupChat(GroupChatDto groupChat);
    }
}
