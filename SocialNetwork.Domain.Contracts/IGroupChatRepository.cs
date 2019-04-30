using SocialNetwork.Domain.Entities;
using System.Linq;


namespace SocialNetwork.Domain.Contracts
{
    public interface IGroupChatRepository : IRepository
    {
        void AddGroupChat(GroupChat groupChat);

        void DeleteGroupChat(GroupChat groupChat);

        IQueryable<GroupChat> GetGroupChat();

    }
}
