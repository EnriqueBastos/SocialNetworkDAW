using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;

using System.Linq;

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

        public void AddMusic(Music music)
        {
            _socialNetworkContext.Set<Music>().Add(music);
        }


    }
}
