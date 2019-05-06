using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public interface IGetContactBusiness
    {
        IList<ProfileDto> GetAllProfileContactsByUserId(int userId);

        IList<Contact> GetContactByUserIdFriendId(int userId, int friendId);
    }
}
