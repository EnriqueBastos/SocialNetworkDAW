using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocialNetwork.Application.Dtos;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Infraestructure.Repository;

namespace SocialNetwork.Domain.Business
{
    public class GetProfileBusiness: IGetProfileBusiness
    {
        public readonly IUserRepository _userRepository;
        public GetProfileBusiness(IUserRepository userRepository )
        {
            if(userRepository == null)
            {
                throw new NullReferenceException("No existe UserRepository");
            }
            _userRepository = userRepository;
        }
        public UserDto GetProfileInfo(int id)
        {
            var user = _userRepository.GetUser().FirstOrDefault(x => x.ID == id);
            return new UserDto
            {
                Name = user.Name,
                PhotoProfile = user.PhotoProfile
            };
        }
    }
}
