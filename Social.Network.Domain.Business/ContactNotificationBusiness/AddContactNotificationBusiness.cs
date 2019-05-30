using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.ContactNotificationBusiness
{
    public class AddContactNotificationBusiness : IAddContactNotificationBusiness

    {
        private readonly IContactNotificationRepository _contactNotificationRepository;

        public AddContactNotificationBusiness(IContactNotificationRepository contactNotificationRepository)
        {
            _contactNotificationRepository = contactNotificationRepository;
        }

        public void AddContactNotification (ContactDto contactDto)
        {
            _contactNotificationRepository.AddContactNotification(new ContactNotification
            {
                UserId = contactDto.UserId,
                FriendId = contactDto.FriendId
            });
        }
    }
}
