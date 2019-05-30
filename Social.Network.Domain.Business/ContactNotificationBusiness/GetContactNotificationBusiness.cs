using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.ContactNotificationBusiness
{
    public class GetContactNotificationBusiness : IGetContactNotificationBusiness
    {
        private readonly IContactNotificationRepository _contactNotificationRepository;

        

        public GetContactNotificationBusiness(IContactNotificationRepository contactNotificationRepository)
        {
            _contactNotificationRepository = contactNotificationRepository;
        }

        public async Task<IList<FriendRequestDto>> GetFriendRequestDtoContactNotifications (int userId)
        {
            return await _contactNotificationRepository
                .GetContactNotification()
                .Include(notification => notification.User)
                .Where(notification => notification.FriendId == userId)
                .Select(notification => new FriendRequestDto
                {
                    NotificationId = notification.Id,
                    UserId = notification.User.Id,
                    Name = notification.User.Name,
                    LastName = notification.User.LastName,
                    PhotoProfile = notification.User.PhotoProfile

                }
                ).ToListAsync();
        }

        public async Task<ContactNotification> GetContactNotificationById(int id)
        {

            return await _contactNotificationRepository
                .GetContactNotification()
                .Include(x => x.User)
                .FirstOrDefaultAsync(notification => notification.Id == id);

            
        }

        public async Task<bool> GetBoolContactNotification(int userId , int friendId)
        {
            return await _contactNotificationRepository
                .GetContactNotification()
                .AnyAsync(contactNotification =>
                contactNotification.UserId == userId && contactNotification.FriendId == friendId
                );

            
        }
    }
}
