using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class EditUserBusiness : IEditUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public EditUserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void EditUser(SetUserDto profileDetailsDto)
        {
            byte[] bytesPhotoProfile = Convert.FromBase64String(profileDetailsDto.PhotoProfile);

            _userRepository.EditUser(new User
            {
                Id = profileDetailsDto.Id,
                Name = profileDetailsDto.Name,
                LastName = profileDetailsDto.LastName,
                Email = profileDetailsDto.Email,
                Password = "123",
                Description = profileDetailsDto.Description,
                DateBirthday = profileDetailsDto.DateBirthday,
                PhotoProfile = bytesPhotoProfile,
                BackgroundApp = profileDetailsDto.BackgroundApp,
                Private = profileDetailsDto.Private
            });
        }
    }
}
