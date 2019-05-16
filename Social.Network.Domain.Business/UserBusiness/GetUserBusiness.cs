using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class GetUserBusiness : IGetUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public GetUserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

     

        public UserDto GetUserDtoByUserId(int UserId)
        {
            return _userRepository
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

                .FirstOrDefault(userDto=>
                userDto.Id ==UserId
                
                );
        }

        public ProfileDetailsDto GetProfileDetailsDtoByUserId(int userId)
        {
            return _userRepository
                .GetUser()
                .Select(user => new ProfileDetailsDto
                {
                    UserId = user.Id,
                    UserName = user.Name,
                    UserLastName = user.LastName,
                    DateBirthday = user.DateBirthday,
                    PhotoProfile = user.PhotoProfile

                }).FirstOrDefault(profile => profile.UserId == userId);
        }

        public IList<ProfileDto> GetListUsers()
        {
            return _userRepository
                .GetUser()
                .Select(user => new ProfileDto
                {
                    UserId = user.Id,
                    UserName = user.Name,
                    UserLastName = user.LastName,
                    PhotoProfile = user.PhotoProfile,
                    Private = user.Private

                }).ToList();

        }

        public int GetUserIdByLoginDto(UserLoginDto loginDto)
        {
            var userLogin =_userRepository
                            .GetUser()
                            .FirstOrDefault(user =>

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

        
    }
}
