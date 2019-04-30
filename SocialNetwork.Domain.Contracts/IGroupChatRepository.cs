using SocialNetwork.Domain.Entities;
using System.Linq;

namespace SocialNetwork.Domain.Contracts
{
    public interface IGroupChatRepository
    {
        void AddGroupChat(GroupChat groupChat);

        void DeleteGroupChat(GroupChat groupChat);

        IQueryable<GroupChat> GetGroupChat();
    }
}
