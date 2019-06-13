using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public interface IAddContactBusiness
    {
        Task<IList<int>> AddContact(ContactDto contactDto);
    }
}