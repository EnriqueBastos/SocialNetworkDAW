using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    public class MessageChatRepository : IMessageChatRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public MessageChatRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public async Task AddMessageChat(MessageChat message)
        {
            await _socialNetworkContext.Set<MessageChat>().AddAsync(message);
        }

        public IQueryable<MessageChat> GetMessageChat()
        {
            return _socialNetworkContext.Set<MessageChat>();
        }

        public void EditMessageChat(MessageChat messageChat)
        {
            _socialNetworkContext.Entry(messageChat).State = EntityState.Modified;
        }


        public IUnitOfWork UnitOfWork
        {
            get { return _socialNetworkContext; }
        }
    }
}
