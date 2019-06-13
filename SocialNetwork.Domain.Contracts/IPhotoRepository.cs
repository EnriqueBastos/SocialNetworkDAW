

using SocialNetwork.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Contracts
{
    public interface IPhotoRepository : IRepository
    {

        IQueryable<Photo> GetPhoto();

        Task AddPhoto(Photo photo);

        void DeletePhoto(Photo photo);

        void EditPhoto(Photo photo);
    }
}
