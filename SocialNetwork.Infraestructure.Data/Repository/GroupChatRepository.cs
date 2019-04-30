using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.Infraestructure.Repository
{
    public class GroupChatRepository : IGroupChatRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public GroupChatRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public void AddGroupChat(GroupChat groupChat)
        {
            _socialNetworkContext.Set<GroupChat>().Add(groupChat);
        }

        public void DeleteGroupChat(GroupChat groupChat)
        {
            _socialNetworkContext.Set<GroupChat>().Remove(groupChat);
        }

        public IQueryable<GroupChat> GetGroupChat()
        {
            return _socialNetworkContext.Set<GroupChat>();
        }

        
    }
}
