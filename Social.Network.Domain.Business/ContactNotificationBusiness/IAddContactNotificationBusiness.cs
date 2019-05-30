using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.ContactNotificationBusiness
{
    public interface IAddContactNotificationBusiness
    {
        void AddContactNotification(ContactDto contactDto);
    }
}