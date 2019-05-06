﻿using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Business.ContactBusiness
{
    public class AddContactBusiness : IAddContactBusiness
    {
        private readonly IContactRepository _contactRepository;

        public AddContactBusiness(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void AddContact(ContactDto contactDto)
        {
            _contactRepository.AddContact(new Contact
            {
                UserId = contactDto.UserId,
                FriendId = contactDto.FriendId
            });

            _contactRepository.AddContact(new Contact
            {
                UserId = contactDto.FriendId,
                FriendId = contactDto.UserId
            });
        }
    }
}