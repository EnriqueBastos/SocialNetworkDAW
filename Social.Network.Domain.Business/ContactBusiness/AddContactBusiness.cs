using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.ChatBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public class AddContactBusiness : IAddContactBusiness
    {
        private readonly IContactRepository _contactRepository;

        private readonly IGetContactBusiness _getContactBusiness;

        private readonly IAddChatBusiness _addChatBusiness;



        public AddContactBusiness(
            IContactRepository contactRepository ,
            IGetContactBusiness getContactBusiness,
            IAddChatBusiness addChatBusiness
            )
        {
            _contactRepository = contactRepository;
            _getContactBusiness = getContactBusiness;
            _addChatBusiness = addChatBusiness;
        }

        public async Task<IList<int>> AddContact(ContactDto contactDto)
        {
            IList<int> idContacts = new List<int>();
            Contact contact ;

            await _contactRepository.AddContact(new Contact
            {
                UserId = contactDto.UserId,
                FriendId = contactDto.FriendId
            });

            await _contactRepository.UnitOfWork.Save();

            contact = await _contactRepository.GetContact().LastOrDefaultAsync( );

            idContacts.Add(contact.Id);

            await _contactRepository.AddContact(new Contact
            {
                UserId = contactDto.FriendId,
                FriendId = contactDto.UserId
            });

            await _contactRepository.UnitOfWork.Save();

            contact = await _contactRepository.GetContact().LastOrDefaultAsync();

            idContacts.Add(contact.Id);

            return idContacts;




        }
    }
}
