﻿using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;

using System.Linq;
using System.Threading.Tasks;

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

        public void DeleteMusic(Music music)
        {
            _socialNetworkContext.Set<Music>().Remove(music);
        }

        public async Task AddMusic(Music music)
        {
            await _socialNetworkContext.Set<Music>().AddAsync(music);
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _socialNetworkContext;
            }
        }


    }
}
