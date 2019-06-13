using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.MessageChatRepository;
using SocialNetwork.Domain.Business.UserBusiness;
using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Dtos.ChatDtos;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public class GetContactBusiness : IGetContactBusiness
    {
        private readonly IContactRepository _contactRepository;

        private readonly IGetUserBusiness _getUserBusiness;

        private readonly IGetContactNotificationBusiness _getContactNotificationBusiness;

        public GetContactBusiness(IContactRepository contactRepository ,
            IGetUserBusiness getUserBusiness,
            IGetContactNotificationBusiness getContactNotificationBusiness
            )
        {
            _contactRepository = contactRepository;
            _getUserBusiness = getUserBusiness;
            _getContactNotificationBusiness = getContactNotificationBusiness;
        }

        public async Task<IList<ProfileDto>> GetAllProfileContactsByUserId(int userId)
        {
            
            
            return await _contactRepository
                    .GetContact()
                    .Select(contact => contact)
                    .Where(contact => contact.FriendId == userId)
                    .Select(contact => new ProfileDto
                    {
                        UserId = contact.UserId,
                        UserName = contact.User.Name,
                        UserLastName = contact.User.LastName,
                        PhotoProfile = contact.User.PhotoProfile,
                        Private = contact.User.Private

                    })
                    .ToListAsync();
        }

        public IList<int> GetListFriendIdByUserId(int userId)
        {
            return _contactRepository
                .GetContact()
                .Where(contact => contact.UserId == userId)
                .Select(contact => contact.FriendId)
                .ToList();
        }

        public IList<Contact> GetContactByUserIdFriendId(int userId, int friendId)
        {
            return _contactRepository
                .GetContact()
                .Select(contact => contact)
                .Where(contact =>
                    (contact.UserId == userId && contact.FriendId == friendId)|| (contact.UserId == friendId && contact.FriendId == userId)
                    ).ToList();
        }

        public async Task <IList<Contact>> GetListContactByUserId(int userId)
        {
            return await _contactRepository
                .GetContact()
                .Where(c => c.FriendId == userId)
                .Include(c => c.User)
                .OrderBy(c => c.User.Name)
                .ToListAsync();
        }
        


        public async Task<IList<ProfileDto>> GetProfileDtosBySearchContactDto(SearchContactDto searchContactDto)
        {
            var listUsers = await  _getUserBusiness.GetListProfileDtosByUserNameUserId(searchContactDto.UserName , searchContactDto.UserId);

            var listFriends = await GetAllProfileContactsByUserId(searchContactDto.UserId);
            

            bool continueFor = true;

            for (int f = 0; f < listUsers.Count; f++)
            {
                if (await _getContactNotificationBusiness.GetBoolContactNotification(searchContactDto.UserId, listUsers[f].UserId))
                {
                    listUsers[f].FriendRequestIsSent = true;
                }
                else
                {
                    listUsers[f].FriendRequestIsSent = false;
                }
                for (int k = 0; k < listFriends.Count && continueFor; k++)
                {
                    if (listUsers[f].UserId == listFriends[k].UserId)
                    {
                        listUsers[f].IsFriend = true;
                        continueFor = false;
                    }
                    else
                    {
                        listUsers[f].IsFriend = false;
                    }
                }
                continueFor = true;
            }

            return listUsers;
        }


        public async Task<int> GetFriendIdByContactIdUserId(int contactId , int userId)
        {
            var contact = await _contactRepository
                .GetContact()
                .FirstOrDefaultAsync(c => 
                           c.UserId == userId && c.Id == contactId ||
                           c.FriendId == userId && c.Id == contactId
                );
            if(contact.UserId == userId)
            {
                return contact.FriendId;
            }
            else
            {
                return contact.UserId;
            }

        }
    }
}
