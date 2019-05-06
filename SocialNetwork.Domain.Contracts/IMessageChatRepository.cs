using SocialNetwork.Domain.Entities;
using System.Linq;


namespace SocialNetwork.Domain.Contracts
{
    public interface IMessageChatRepository : IRepository
    {
        void AddMessageChat(MessageChat message);
        IQueryable<MessageChat> GetMessageChat();
    }
}
