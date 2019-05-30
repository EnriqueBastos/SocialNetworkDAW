using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IContactRepository : IRepository
    {
        IQueryable<Contact> GetContact();

        Task AddContact(Contact contact);

        void DeleteContact(Contact contact);
    }
}
