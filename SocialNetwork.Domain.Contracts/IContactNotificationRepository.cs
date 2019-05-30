using SocialNetwork.Domain.Entities;
using System.Linq;


namespace SocialNetwork.Domain.Contracts
{
    public interface IContactNotificationRepository : IRepository
    {
        IQueryable<ContactNotification> GetContactNotification();

        void AddContactNotification(ContactNotification contactNotification);

        void DeleteContactNotification(ContactNotification contactNotification);
    }
}
