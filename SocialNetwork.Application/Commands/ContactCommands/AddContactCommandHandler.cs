using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactCommands
{
    public class AddContactCommandHandler : IAddContactCommandHandler
    {
        private readonly IContactRepository _contactRepository;

        private readonly IAddContactBusiness _addContactBusiness;

        public AddContactCommandHandler(IContactRepository contactRepository, IAddContactBusiness addContactBusiness)
        {
            _contactRepository = contactRepository;

            _addContactBusiness = addContactBusiness;
        }

        public async Task Handler(ContactDto contactDto)
        {
            _addContactBusiness.AddContact(contactDto);

            await _contactRepository.UnitOfWork.Save();
        }
    }
}
