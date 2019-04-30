
using System.Linq;
using SocialNetwork.Domain.Entities;


namespace SocialNetwork.Domain.Contracts
{
    public interface IUserPhotoCommentRepository
    {
        IQueryable<UserPhotoComment> GetUserPhotoComment();

        void AddUserPhotoComment(UserPhotoComment comment);

        void DeleteUserPhotoComment(UserPhotoComment comment);
    }
}
