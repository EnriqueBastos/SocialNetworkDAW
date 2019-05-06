using SocialNetwork.Domain.Dtos;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public interface IDeleteContactBusiness
    {
        void DeleteContact(ContactDto contactDto);
    }
}