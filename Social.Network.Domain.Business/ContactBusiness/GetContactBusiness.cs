﻿using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public class GetContactBusiness : IGetContactBusiness
    {
        private readonly IContactRepository _contactRepository;

        public GetContactBusiness(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IList<ProfileDto> GetAllProfileContactsByUserId(int userId)
        {
            var contactList = _contactRepository
                .GetContact()
                .Select(contact => contact)
                .Where(contact =>
                contact.FriendId == userId 
                ).ToList();

            return contactList.Select(contact => new ProfileDto
            {
                UserId = contact.UserId,
                UserName = contact.User.Name,
                UserLastName = contact.User.LastName,
                PhotoProfile = contact.User.PhotoProfile,
                Private = contact.User.Private

            }).ToList();
 
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
    }
}
