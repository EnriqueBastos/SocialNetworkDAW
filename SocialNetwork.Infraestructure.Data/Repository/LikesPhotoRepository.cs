using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    public class LikesPhotoRepository : ILikesPhotoRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public LikesPhotoRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }
        public IQueryable<LikesPhoto> GetLikesPhoto()
        {
            return _socialNetworkContext.Set<LikesPhoto>();
        }

        public void DeleteLikesPhoto(LikesPhoto likesPhoto)
        {
            _socialNetworkContext.Set<LikesPhoto>().Remove(likesPhoto);
        }

        public async Task AddLikesPhoto(LikesPhoto likesPhoto)
        {
            await _socialNetworkContext.Set<LikesPhoto>().AddAsync(likesPhoto);
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
