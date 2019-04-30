

using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Contracts
{
    public interface IPhotoRepository : IRepository
    {
        void AddPhoto(Photo photo);
    }
}
