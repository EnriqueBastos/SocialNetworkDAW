using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Business.ContactNotificationBusiness;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Dtos.UserDtos;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class GetUserBusiness : IGetUserBusiness
    {
        private readonly IUserRepository _userRepository;

        private readonly IGetContactNotificationBusiness _getContactNotificationBusiness;

        public GetUserBusiness(
            IUserRepository userRepository,
            IGetContactNotificationBusiness getContactNotificationBusiness
            )
        {
            _userRepository = userRepository;

            _getContactNotificationBusiness = getContactNotificationBusiness;

           
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
                    Password = user.Password,
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

        public async Task<GetLoginDto> GetLoginDtoByUserLoginDto(UserLoginDto loginDto)
        {
            var userLogin = await _userRepository
                            .GetUser()
                            .FirstOrDefaultAsync(user =>
                                user.Email == loginDto.Email
                            );
            if(userLogin == null)
            {
                return new GetLoginDto
                {
                    UserId = -1,
                    BackgroundApp = null
                };
            }
            string savedPasswordHash = userLogin.Password;
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(loginDto.Password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            bool ok = true;
            for(int f = 0; f < 20; f++)
            {
                if(hashBytes[f + 16] != hash[f])
                {
                    ok = false;
                }
            }

            if (ok)
            {
                return new GetLoginDto
                {
                    UserId = userLogin.Id,
                    BackgroundApp = userLogin.BackgroundApp
                };
            }
            else
            {
                return new GetLoginDto
                {
                    UserId = -1,
                    BackgroundApp = null
                };
            }
            
                
        }

        public async Task<string> GetUserNameByUserId(int userId)
        {
            var user = await _userRepository
                .GetUser()
                .FirstOrDefaultAsync(x => x.Id == userId);
            return user.Name;
        }

        public async Task<IList<ProfileDto>> GetListProfileDtosByUserNameUserId(string userName, int userId)
        {
            return await _userRepository
                .GetUser()
                .Where(user => user.Name == userName && user.Id != userId)
                .Select(user => new ProfileDto
                {
                    UserId = user.Id,
                    UserName = user.Name,
                    UserLastName = user.LastName,
                    PhotoProfile = user.PhotoProfile,
                    Private = user.Private

                })
                .ToListAsync();
        }

        public async Task<string> GetPasswordByUserId(int userId)
        {
            var user = await _userRepository.GetUser().FirstOrDefaultAsync(u => u.Id == userId);

            return user.Password;
        }

        public async Task<User> GetUserByUserId(int id)
        {
            return await _userRepository.GetUser().FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
