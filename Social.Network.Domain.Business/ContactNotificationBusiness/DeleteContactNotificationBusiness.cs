using SocialNetwork.Domain.Contracts;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactNotificationBusiness
{
    public class DeleteContactNotificationBusiness : IDeleteContactNotificationBusiness
    {
        private readonly IContactNotificationRepository _contactNotificationRepository;

        private readonly IGetContactNotificationBusiness _getContactNotificationBusiness;

        public DeleteContactNotificationBusiness(IContactNotificationRepository contactNotificationRepository , IGetContactNotificationBusiness getContactNotificationBusiness)
        {
            _contactNotificationRepository = contactNotificationRepository;

            _getContactNotificationBusiness = getContactNotificationBusiness;
        }

        public async Task DeleteContactNotification(int contactNotificationId)
        {
            var contactNotification = await _getContactNotificationBusiness.GetContactNotificationById(contactNotificationId);
            
            _contactNotificationRepository.DeleteContactNotification(contactNotification);

            
        }
    }
}
