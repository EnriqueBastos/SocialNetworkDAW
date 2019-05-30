using SocialNetwork.Domain.Dtos;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public interface IAddContactBusiness
    {
        Task AddContact(ContactDto contactDto);
    }
}