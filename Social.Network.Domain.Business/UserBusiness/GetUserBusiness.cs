using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.ContactBusiness;
using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class GetUserBusiness : IGetUserBusiness
    {
        private readonly IUserRepository _userRepository;

        private readonly IGetContactNotificationBusiness _getContactNotificationBusiness;

        private readonly IGetContactBusiness _getContactBusiness;

        public GetUserBusiness(
            IUserRepository userRepository,
            IGetContactNotificationBusiness getContactNotificationBusiness,
            IGetContactBusiness getContactBusiness
            )
        {
            _userRepository = userRepository;

            _getContactNotificationBusiness = getContactNotificationBusiness;

            _getContactBusiness = getContactBusiness;
        }

        
     

        public async Task<UserDto> GetUserDtoByUserId(int UserId)
        {
            return await _userRepository
                .GetUser()
                .Select(user =>new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    DateBirthday = user.DateBirthday,
                    PhotoProfile = user.PhotoProfile,
                    BackgroundApp = user.BackgroundApp,
                    Private = user.Private
                })
                .FirstOrDefaultAsync(userDto=>
                userDto.Id ==UserId
                
                );
        }

        public async Task<ProfileDetailsDto> GetProfileDetailsDtoByUserId(int userId)
        {
            var contactNotifications = await _getContactNotificationBusiness.GetFriendRequestDtoContactNotifications(userId);

            return await _userRepository
                .GetUser()
                .Select(user => new ProfileDetailsDto
                {
                    UserId = user.Id,
                    UserName = user.Name,
                    UserLastName = user.LastName,
                    DateBirthday = user.DateBirthday,
                    PhotoProfile = user.PhotoProfile,
                    BackgroundApp = user.BackgroundApp,
                    FriendRequests = contactNotifications,
                    Description = user.Description,
                    Email = user.Email,
                    Private = user.Private
                    

                }).FirstOrDefaultAsync(profile => profile.UserId == userId);
        }

        public async Task<IList<ProfileDto>> GetListUsers()
        {
            return  await _userRepository
                .GetUser()
                .Select(user => new ProfileDto
                {
                    UserId = user.Id,
                    UserName = user.Name,
                    UserLastName = user.LastName,
                    PhotoProfile = user.PhotoProfile,
                    Private = user.Private

                }).ToListAsync();

        }

        public async Task<int> GetUserIdByLoginDto(UserLoginDto loginDto)
        {
            var userLogin = await _userRepository
                            .GetUser()
                            .FirstOrDefaultAsync(user =>

                            user.Email == loginDto.Email && user.Password == loginDto.Password

                            );
            if(userLogin != null)
            {
                return userLogin.Id;
            }
            else
            {
                return -1;
            }
            
                
        }

        public async Task<IList<ProfileDto>> GetProfileDtosBySearchContactDto(SearchContactDto searchContactDto)
        {
            var listContacts = await _userRepository
                .GetUser()
                .Where(user => user.Name == searchContactDto.UserName)
                .Select(user => new ProfileDto
                {
                    UserId = user.Id,
                    UserName = user.Name,
                    UserLastName = user.LastName,
                    PhotoProfile = user.PhotoProfile,
                    Private = user.Private

                })
                .ToListAsync();

            var listFriends =   await _getContactBusiness.GetAllProfileContactsByUserId(searchContactDto.UserId);

            


            bool continueFor = true;

            for(int f = 0; f < listContacts.Count; f++)
            {
                if (await _getContactNotificationBusiness.GetBoolContactNotification(searchContactDto.UserId , listContacts[f].UserId))
                {
                    listContacts[f].FriendRequestIsSent = true;
                }
                else
                {
                    listContacts[f].FriendRequestIsSent = false;
                }
                for (int k = 0; k < listFriends.Count && continueFor; k++)
                {
                    if(listContacts[f].UserId == listFriends[k].UserId)
                    {
                        listContacts[f].IsFriend = true;
                        continueFor = false;
                    }
                    else
                    {
                        listContacts[f].IsFriend = false;
                    }
                }
                continueFor = true;
            }

            return listContacts;
        }

        
    }
}
