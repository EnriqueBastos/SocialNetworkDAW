using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Commands.ContactCommands
{
    public class DeleteContactCommandHandler : IDeleteContactCommandHandler
    {
        private readonly IDeleteContactBusiness _deleteContactBusiness;

        private readonly IContactRepository _contactRepository;

        public DeleteContactCommandHandler(IDeleteContactBusiness deleteContactBusiness, IContactRepository contactRepository)
        {
            _deleteContactBusiness = deleteContactBusiness;
            _contactRepository = contactRepository;
        }

        public async Task Handler(ContactDto contactDto)
        {
            _deleteContactBusiness.DeleteContact(contactDto);

            await _contactRepository.UnitOfWork.Save();
        }
    }
}
