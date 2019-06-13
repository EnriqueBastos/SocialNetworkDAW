using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Business.UserBusiness
{
    public class EditUserBusiness : IEditUserBusiness
    {
        private readonly IUserRepository _userRepository;
        private readonly IGetUserBusiness _getUserBusiness;

        public EditUserBusiness(IUserRepository userRepository , IGetUserBusiness getUserBusiness)
        {
            _userRepository = userRepository;
            _getUserBusiness = getUserBusiness;
        }

        public async Task EditUser(SetUserDto setUserDto)
        {

            byte[] bytesPhotoProfile = Convert.FromBase64String(setUserDto.PhotoProfile);

            User user = await _getUserBusiness.GetUserByUserId(setUserDto.Id);

            if(setUserDto.Password != user.Password)
            {
                byte[] bytes;
                new RNGCryptoServiceProvider().GetBytes(bytes = new byte[16]);
                var derivedBytes = new Rfc2898DeriveBytes(setUserDto.Password, bytes, 10000);
                byte[] hash = derivedBytes.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(bytes, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                user.Password = Convert.ToBase64String(hashBytes);
            }
            else
            {
                user.Password = setUserDto.Password;
            }

            user.Name = setUserDto.Name;
            user.LastName = setUserDto.LastName;
            user.Email = setUserDto.Email;
            user.DateBirthday = setUserDto.DateBirthday;
            user.PhotoProfile = bytesPhotoProfile;
            user.Private = setUserDto.Private;
            user.Description = setUserDto.Description;

            _userRepository.EditUser(user);
        }
    }
}
