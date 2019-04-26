using SocialNetwork.Domain.Entities;
using System;
using System.Linq;

namespace SocialNetwork.Domain.Contracts
{
    public interface IUserRepository
    {
        IQueryable<User> GetUser();
    }
}
