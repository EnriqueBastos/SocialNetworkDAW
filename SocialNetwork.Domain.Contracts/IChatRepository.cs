using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IChatRepository : IRepository
    {
        IQueryable<Chat> GetChat();

        Task AddChat(Chat chat);

        void DeleteChat(Chat chat);
    }
}
