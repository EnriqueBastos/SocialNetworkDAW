using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Entities;
using System.Linq;

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
