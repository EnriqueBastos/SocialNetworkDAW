using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Application.Querys.ContactQuerys
{
    public interface IContactQuery
    {
        Task<IList<ProfileDto>> GetListContactProfileByUserId(int userId);
        Task<IList<ProfileDto>> SearchContactBySearchContactDto(SearchContactDto searchContactDto);
    }
}
