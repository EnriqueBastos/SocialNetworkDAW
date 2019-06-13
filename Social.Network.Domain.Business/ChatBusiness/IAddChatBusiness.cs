using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ChatBusiness
{
    public interface IAddChatBusiness
    {
        Task AddChat(int contactUserFriendId, int contactFriendUserId);
    }
}
