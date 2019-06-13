using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Business.UserBusiness;
using System.Security.Cryptography;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Domain.Business
{
    public class AddUserBusiness : IAddUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public AddUserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUser(UserDto user)
        {
            var emailRepeated = await _userRepository.GetUser().FirstOrDefaultAsync(u => u.Email == user.Email);

            if (emailRepeated != null)
            {
                return;
            }

            byte[] bytes;
            new RNGCryptoServiceProvider().GetBytes(bytes = new byte[16]);
            var derivedBytes = new Rfc2898DeriveBytes(user.Password, bytes, 10000);
            byte[] hash = derivedBytes.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(bytes, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            User newUser = new User
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Password = savedPasswordHash,
                DateBirthday = user.DateBirthday,
                PhotoProfile = user.PhotoProfile,
                Private = user.Private,
                BackgroundApp = user.BackgroundApp
            };

            

            await _userRepository.AddUser(newUser);
        }


    }
}
