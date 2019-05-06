using SocialNetwork.Data;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Contracts;

namespace SocialNetwork.Infraestructure.Repository
{
    public class ChatRepository : IChatRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public ChatRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public void AddChat(Chat chat)
        {
            _socialNetworkContext.Set<Chat>().Add(chat);
        }

        public void DeleteChat(Chat chat)
        {
            _socialNetworkContext.Set<Chat>().Remove(chat);
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _socialNetworkContext;
            }
        }
    }
}
