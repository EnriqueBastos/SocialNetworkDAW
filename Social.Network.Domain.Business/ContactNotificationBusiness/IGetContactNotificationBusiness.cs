using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactNotificationBusiness
{
    public interface IGetContactNotificationBusiness
    {

        Task<IList<FriendRequestDto>> GetFriendRequestDtoContactNotifications(int userId);

        Task<ContactNotification> GetContactNotificationById(int id);

        Task<bool> GetBoolContactNotification(int userId, int friendId);
    }
}