using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public interface IAddContactBusiness
    {
        void AddContact(ContactDto contactDto);
    }
}