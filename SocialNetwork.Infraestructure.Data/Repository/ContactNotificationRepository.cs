using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;

namespace SocialNetwork.Infraestructure.Repository
{
    public class ContactNotificationRepository : IContactNotificationRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public ContactNotificationRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public IQueryable<ContactNotification> GetContactNotification()
        {
            return _socialNetworkContext.Set<ContactNotification>();
        }

        public void AddContactNotification(ContactNotification contactNotification)
        {
            _socialNetworkContext.Set<ContactNotification>().Add(contactNotification);
        }

        public void DeleteContactNotification(ContactNotification contactNotification)
        {
            _socialNetworkContext.Set<ContactNotification>().Remove(contactNotification);
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
