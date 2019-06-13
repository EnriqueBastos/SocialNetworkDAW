using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IContactNotificationRepository : IRepository
    {
        IQueryable<ContactNotification> GetContactNotification();

        Task AddContactNotification(ContactNotification contactNotification);

        void DeleteContactNotification(ContactNotification contactNotification);
    }
}
