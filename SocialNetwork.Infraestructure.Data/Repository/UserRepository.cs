using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SocialNetwork.Infraestructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly SocialNetworkContext _socialNetworkContext;

        public IQueryable<User> GetUser()
        {
            return _socialNetworkContext.Set<User>();
        }

    }
}
