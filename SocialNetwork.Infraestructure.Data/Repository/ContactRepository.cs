using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public ContactRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public IQueryable<Contact> GetContact()
        {
            return _socialNetworkContext.Set<Contact>();
        }
        public async Task<IList<Contact>> GetContactAsync()

        {
            return await _socialNetworkContext.Set<Contact>().Include(x => x.User).ToListAsync();

        }

        public void AddContact(Contact contact)
        {
            _socialNetworkContext.Set<Contact>().Add(contact);
        }

        public void DeleteContact(Contact contact)
        {
            _socialNetworkContext.Set<Contact>().Remove(contact);
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
