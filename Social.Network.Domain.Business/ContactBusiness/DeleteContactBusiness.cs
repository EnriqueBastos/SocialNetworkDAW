using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Linq;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public class DeleteContactBusiness : IDeleteContactBusiness
    {
        private readonly IContactRepository _contactRepository;

        private readonly IGetContactBusiness _getContactBusiness;

        public DeleteContactBusiness(IContactRepository contactRepository, IGetContactBusiness getContactBusiness)
        {
            _contactRepository = contactRepository;

            _getContactBusiness = getContactBusiness;
        }

        public void DeleteContact(ContactDto contactDto)
        {

            var contact = _getContactBusiness.GetContactByUserIdFriendId(contactDto.UserId, contactDto.FriendId);

            contact.ToList().ForEach(friendship =>

                _contactRepository.DeleteContact(friendship)
            );

        }
    }
}
