using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;


namespace SocialNetwork.Infraestructure.Repository
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public PhotoRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public void AddPhoto(Photo photo)
        {
            _socialNetworkContext.Set<Photo>().Add(photo);
        }

        public void DeletePhoto(Photo photo)
        {
            _socialNetworkContext.Set<Photo>().Remove(photo);

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
