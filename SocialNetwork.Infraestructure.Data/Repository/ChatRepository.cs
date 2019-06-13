using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    public class ChatRepository : IChatRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;



        public ChatRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public async Task AddChat(Chat chat)
        {
            await _socialNetworkContext.Set<Chat>().AddAsync(chat);

        }

        public void DeleteChat(Chat chat)
        {
            _socialNetworkContext.Set<Chat>().Remove(chat);

        }

        public void EditChat(Chat chat)
        {
            _socialNetworkContext.Entry(chat).State = EntityState.Modified;
        }

        public IQueryable<Chat> GetChat()
        {
            return _socialNetworkContext.Set<Chat>();
        }

        public IUnitOfWork UnitOfWork
        {
            get { return _socialNetworkContext; }
        }
    }
}
