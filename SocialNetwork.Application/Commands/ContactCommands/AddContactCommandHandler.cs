using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactCommands
{
    public class AddContactCommandHandler : IAddContactCommandHandler
    {
        private readonly IContactRepository _contactRepository;

        private readonly IAddContactBusiness _addContactBusiness;

        private readonly IDeleteContactNotificationBusiness _deleteContactNotificationBusiness;

        public AddContactCommandHandler(IContactRepository contactRepository, IAddContactBusiness addContactBusiness , IDeleteContactNotificationBusiness deleteContactNotificationBusiness)

        {
            _deleteContactNotificationBusiness = deleteContactNotificationBusiness;

            _contactRepository = contactRepository;

            _addContactBusiness = addContactBusiness;
        }

        public async Task Handler(ContactDto contactDto)
        {
            await _addContactBusiness.AddContact(contactDto);

            await _deleteContactNotificationBusiness.DeleteContactNotification(contactDto.ContactNotificationId);

            await _contactRepository.UnitOfWork.Save();
        }
    }
}
