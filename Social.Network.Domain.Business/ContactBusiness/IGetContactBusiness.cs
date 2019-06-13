using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.ChatDtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public interface IGetContactBusiness
    {
        Task<IList<ProfileDto>> GetAllProfileContactsByUserId(int userId);

        IList<Contact> GetContactByUserIdFriendId(int userId, int friendId);

        IList<int> GetListFriendIdByUserId(int userId);

        Task<IList<ProfileDto>> GetProfileDtosBySearchContactDto(SearchContactDto searchContactDto);
        

        Task<IList<Contact>> GetListContactByUserId(int userId);
        Task<int> GetFriendIdByContactIdUserId(int contactId, int userId);
    }
}
