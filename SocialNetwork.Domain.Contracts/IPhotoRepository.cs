

using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Contracts
{
    public interface IPhotoRepository : IRepository
    {
        void AddPhoto(Photo photo);

        void DeletePhoto(Photo photo);

        void EditPhoto(Photo photo);
    }
}
