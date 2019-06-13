using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Infraestructure.Repository
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly SocialNetworkContext _socialNetworkContext;

        public PhotoRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public async Task AddPhoto(Photo photo)
        {
            await _socialNetworkContext.Set<Photo>().AddAsync(photo);
        }

        public IQueryable<Photo> GetPhoto()
        {
            return _socialNetworkContext.Set<Photo>();
        }

        public void DeletePhoto(Photo photo)
        {
            _socialNetworkContext.Set<Photo>().Remove(photo);

        }

        public void EditPhoto(Photo photo)
        {
            _socialNetworkContext.Entry(photo).State = EntityState.Modified;
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
