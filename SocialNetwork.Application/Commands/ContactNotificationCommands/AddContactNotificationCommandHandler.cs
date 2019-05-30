using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactNotificationCommands
{
    public class AddContactNotificationCommandHandler : IAddContactNotificationCommandHandler
    {
        private readonly IAddContactNotificationBusiness _addContactNotificationBusiness;

        private readonly IContactNotificationRepository _contactNotificationRepository;

        public AddContactNotificationCommandHandler(IAddContactNotificationBusiness addContactNotificationBusiness , IContactNotificationRepository contactNotificationRepository)
        {
            _addContactNotificationBusiness = addContactNotificationBusiness;

            _contactNotificationRepository = contactNotificationRepository;
        }

        public async Task Handler(ContactDto contactDto)
        {
             _addContactNotificationBusiness.AddContactNotification(contactDto);

            await _contactNotificationRepository.UnitOfWork.Save();
        }
    }
}
