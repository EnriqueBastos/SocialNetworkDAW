using System;
using System.Linq;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Infraestructure.Repository
{
    public class UserPhotoRepository : IUserPhotoRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public UserPhotoRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public IQueryable<UserPhoto> GetListPhoto()
        {
           return _socialNetworkContext.Set<UserPhoto>();
        }
    }
}
