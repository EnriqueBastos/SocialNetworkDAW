using SocialNetwork.Domain.Entities;

using System.Linq;


namespace SocialNetwork.Domain.Contracts
{
    public interface IUserPhotoRepository
    {
        IQueryable<UserPhoto> GetUserPhoto();

        void DeleteUserPhoto(UserPhoto photo);
    }
}
