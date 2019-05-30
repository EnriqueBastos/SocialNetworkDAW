

using SocialNetwork.Domain.Entities;
using System.Linq;

namespace SocialNetwork.Domain.Contracts
{
    public interface IPhotoRepository : IRepository
    {

        IQueryable<Photo> GetPhoto();

        void AddPhoto(Photo photo);

        void DeletePhoto(Photo photo);

        void EditPhoto(Photo photo);
    }
}
