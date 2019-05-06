using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;


namespace SocialNetwork.Infraestructure.Repository
{
    public class MessageChatRepository : IMessageChatRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public MessageChatRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public IUnitOfWork UnitOfWork
        {
            get { return _socialNetworkContext; }
        }

        public void AddMessageChat(MessageChat message)
        {
            _socialNetworkContext.Set<MessageChat>().Add(message);
        }

        public IQueryable<MessageChat> GetMessageChat()
        {
            return _socialNetworkContext.Set<MessageChat>();
        }
    }
}
