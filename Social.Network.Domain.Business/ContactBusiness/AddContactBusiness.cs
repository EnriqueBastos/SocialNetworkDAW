using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public class AddContactBusiness : IAddContactBusiness
    {
        private readonly IContactRepository _contactRepository;



        public AddContactBusiness(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task AddContact(ContactDto contactDto)
        {
            await _contactRepository.AddContact(new Contact
            {
                UserId = contactDto.UserId,
                FriendId = contactDto.FriendId
            });

            await _contactRepository.AddContact(new Contact
            {
                UserId = contactDto.FriendId,
                FriendId = contactDto.UserId
            });

            

            
        }
    }
}
