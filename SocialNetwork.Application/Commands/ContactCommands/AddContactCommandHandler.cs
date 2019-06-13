using SocialNetwork.Domain.Business.ChatBusiness;
using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;
using System.Linq;

namespace SocialNetwork.Application.Commands.ContactCommands
{
    public class AddContactCommandHandler : IAddContactCommandHandler
    {
        private readonly IContactRepository _contactRepository;

        private readonly IAddContactBusiness _addContactBusiness;

        private readonly IDeleteContactNotificationBusiness _deleteContactNotificationBusiness;

        private readonly IAddChatBusiness _addChatBusiness;

        public AddContactCommandHandler(
            IContactRepository contactRepository, 
            IAddContactBusiness addContactBusiness , 
            IDeleteContactNotificationBusiness deleteContactNotificationBusiness,
            IAddChatBusiness addChatBusiness
            )

        {
            _deleteContactNotificationBusiness = deleteContactNotificationBusiness;

            _contactRepository = contactRepository;

            _addContactBusiness = addContactBusiness;

            _addChatBusiness = addChatBusiness;
        }

        public async Task Handler(ContactDto contactDto)
        {
            var idContacts  = await _addContactBusiness.AddContact(contactDto);

            await _addChatBusiness.AddChat(idContacts[0] , idContacts[1]);
            
            await _deleteContactNotificationBusiness.DeleteContactNotification(contactDto.ContactNotificationId);

            await _contactRepository.UnitOfWork.Save();
        }
    }
}
