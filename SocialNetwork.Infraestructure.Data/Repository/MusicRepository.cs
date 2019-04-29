using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.Infraestructure.Repository
{
    public class MusicRepository : IMusicRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public MusicRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public IQueryable<Music> GetMusic()
        {
            return _socialNetworkContext.Set<Music>();
        }

        
    }
}
