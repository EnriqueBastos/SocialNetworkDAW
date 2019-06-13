using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IMessageChatRepository : IRepository
    {
        Task AddMessageChat(MessageChat message);

        IQueryable<MessageChat> GetMessageChat();

        void EditMessageChat(MessageChat messageChat);
    }
}
