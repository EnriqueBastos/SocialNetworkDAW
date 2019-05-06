using SocialNetwork.Domain.Entities;
using System.Linq;


namespace SocialNetwork.Domain.Contracts
{
    public interface IContactRepository : IRepository
    {
        IQueryable<Contact> GetContact();

        void AddContact(Contact contact);

        void DeleteContact(Contact contact);
    }
}
