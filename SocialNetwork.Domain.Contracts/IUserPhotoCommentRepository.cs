
using System.Linq;
using SocialNetwork.Domain.Entities;


namespace SocialNetwork.Domain.Contracts
{
    public interface IUserPhotoCommentRepository : IRepository
    {
        IQueryable<UserPhotoComment> GetUserPhotoComment();

        void AddUserPhotoComment(UserPhotoComment comment);

        void DeleteUserPhotoComment(UserPhotoComment comment);
    }
}
