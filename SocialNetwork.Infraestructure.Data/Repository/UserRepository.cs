﻿using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;


namespace SocialNetwork.Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public UserRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public void AddUser(User user)
        {
             _socialNetworkContext.Set<User>().Add(user);
        }

        public IQueryable<User> GetUser()
        {
            return _socialNetworkContext.Set<User>();
        }

    }
}
