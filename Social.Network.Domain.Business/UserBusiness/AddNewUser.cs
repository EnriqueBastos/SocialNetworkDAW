using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Contracts;
using System;


namespace SocialNetwork.Domain.Business
{
    public class AddNewUser
    {
        private readonly IUserRepository _userRepository;

        public AddNewUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(string name,string email, string password,DateTime dateBirthday, byte[] photoProfile, string backgroundApp)
        {
            var newUser = new UserDto
            {
                Name = name,
                Email = email,
                Password = password,
                DateBirthday = dateBirthday,
                PhotoProfile = photoProfile,
                BackgroundApp = backgroundApp
            };
            //_userRepository.AddUser(newUser);
        }


    }
}
